﻿////////////////////////////////////////////////////////////////////////////////
// The MIT License (MIT)
//
// Copyright (c) 2016 Tim Stair
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PdfConstruct.DataObjects;
using PdfConstruct.Merge;
using PdfConstruct.Properties;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf.Advanced;
using Support.IO;
using Support.UI;

namespace PdfConstruct
{
    public partial class PdfConstructForm : AbstractDirtyForm
    {
        private Thread m_zExportThread;

        private const string ALL_FILES_FILTER = "All files (*.*)|*.*";
        private const string INI_FILE = "PdfConstruct.ini";
        private PDFMerge zPdfMerge = new PDFMerge();

        private enum ItemSubIndex
        {
            Front = 0,
            Back = 1,
            Count = 2
        }

        public PdfConstructForm()
        {
            InitializeComponent();
            m_sFileOpenFilter = "PDFConstruct files (*.pc)|*.pc|All files (*.*)|*.*";
            zPdfMerge.SetupPanel(panelPdfMerge);
            m_sBaseTitle = "PDFConstruct " + Application.ProductVersion;
        }

        #region Form Events

        private void PdfConstructForm_Load(object sender, EventArgs e)
        {
            ConfigureControlState(false);
            InitNew();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(txtOutputPath.Text))
                {
                    MessageBox.Show("Please specify an output path.");
                    return;
                }
                zPdfMerge.SetupPDFMerge(txtOutputPath.Text);
                return;
            }

            if (m_zExportThread != null)
            {
                m_zExportThread.Abort();
                ConfigureControlState(false);
                m_zExportThread = null;
                return;
            }

            if (File.Exists(txtOutputPath.Text))
            {
                try
                {
                    File.Delete(txtOutputPath.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to delete PDF before export: {0} Is the file open in another application?".FormatString(txtOutputPath.Text));
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtOutputPath.Text))
            {
                MessageBox.Show("Please specify an output path.");
                return;
            }

            ConfigureControlState(true);
            var listFiles = GetFilesList();

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = listFiles.Count;

            var zParam = new ParameterizedThreadStart(ExportThread);
            m_zExportThread = new Thread(zParam);
            m_zExportThread.Start(listFiles);
        }

        private void addEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrayFiles = GetImageFiles(true);
            if (arrayFiles == null || arrayFiles.Length == 0)
            {
                return;
            }
            var nTargetIndex = listViewCards.Items.Count;

            foreach (var sFile in arrayFiles)
            {
                AddCardRow(sFile, string.Empty, 1, nTargetIndex);
                nTargetIndex++;
            }
            MarkDirty();
        }


        private void insertNewEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrayFiles = GetImageFiles(true);
            if (arrayFiles == null || arrayFiles.Length == 0)
            {
                return;
            }
            var nTargetIndex = listViewCards.SelectedIndices.Count == 0 ? listViewCards.Items.Count : listViewCards.SelectedIndices[0];

            foreach (var sFile in arrayFiles)
            {
                AddCardRow(sFile, string.Empty, 1, nTargetIndex);
                nTargetIndex++;
            }
            MarkDirty();
        }

        private void selectCardFacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrayFiles = GetImageFiles(false);
            if (arrayFiles == null || arrayFiles.Length == 0)
            {
                return;
            }
            var eIndex = sender == selectCardBacksToolStripMenuItem ? ItemSubIndex.Back : ItemSubIndex.Front;
            SetSelectedItemsValue(listViewCards.SelectedItems, arrayFiles[0], eIndex);
        }

        private void setCardCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zQuery = new QueryPanelDialog("Set Card Count", 400, false);
            const string CARD_COUNT = "CARD_COUNT";
            zQuery.AddNumericBox("Count", 1, 0, int.MaxValue, 1, 0, CARD_COUNT);

            if (DialogResult.OK == zQuery.ShowDialog(this))
            {
                SetSelectedItemsValue(listViewCards.SelectedItems, zQuery.GetDecimal(CARD_COUNT).ToString(), ItemSubIndex.Count);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = ALL_FILES_FILTER
            };
            if (DialogResult.OK == sfd.ShowDialog(this))
            {
                txtOutputPath.Text = sfd.FileName;
                MarkDirty();
            }
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (listViewCards.SelectedItems.Count > 0)
            {
                listViewCards.Items.Remove(listViewCards.SelectedItems[0]);
            }
        }

        private void clearCardFacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSelectedItemsValue(listViewCards.SelectedItems, string.Empty, sender == clearCardFrontsToolStripMenuItem ? ItemSubIndex.Front : ItemSubIndex.Back);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitOpen();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitSave(false);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitSave(true);
        }

        private void listViewCards_Resize(object sender, EventArgs e)
        {
            ListViewAssist.ResizeColumnHeaders(listViewCards);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            ListViewAssist.MoveListViewItems(listViewCards, 1);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            ListViewAssist.MoveListViewItems(listViewCards, -1);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewCards_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        btnMoveUp_Click(sender, e);
                        e.Handled = true; // block the up action
                        break;
                    case Keys.Down:
                        btnMoveDown_Click(sender, e);
                        e.Handled = true; // block the down action
                        break;
                }
            }
        }

        private void PdfConstructForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveOnClose(e);
        }

        private void PdfConstructForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PdfConstructForm_DragDrop(object sender, DragEventArgs e)
        {
            var arrayFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var nTargetIndex = listViewCards.Items.Count;

            foreach (var sFile in arrayFiles)
            {
                AddCardRow(sFile, string.Empty, 1, nTargetIndex);
                nTargetIndex++;
            }
            MarkDirty();
        }

        #endregion

        #region Export Thread

        private void ExportThread(object zParam)
        {
            var zDocument = new PdfDocument();
            zDocument.Options.ColorMode = PdfColorMode.Undefined;
            //zDocument.Options.NoCompression = true;

            var listFiles = (List<string>)zParam;
            Func<string> funcGetOutputPath = () => txtOutputPath.Text;

            var sOutputPth = txtOutputPath.InvokeFunc(funcGetOutputPath);

            foreach(var sFile in listFiles)
            {
                if (!File.Exists(sFile))
                {
                    MessageBox.Show("File does not exist: {0}".FormatString(sFile));
                    ConfigureControlState(false);
                    m_zExportThread = null;
                    return;
                }

                Image zImgSrc;
                try
                {
                    zImgSrc = Image.FromFile(sFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image file: {0}\n\nIs this a valid image file?\n\nError: {1}".FormatString(sFile, ex.Message));
                    return;
                }

                // wipe out any transparency on the images
                var zImgDestination = new Bitmap(zImgSrc.Width, zImgSrc.Height, PixelFormat.Format24bppRgb);
                zImgDestination.SetResolution(zImgSrc.HorizontalResolution, zImgSrc.VerticalResolution);

                var zImageGfx = Graphics.FromImage(zImgDestination);
                zImageGfx.Clear(Color.White);
                zImageGfx.DrawImage(zImgSrc, 0, 0);

                var zPage = zDocument.AddPage(new PdfPage()
                {
                    Width = XUnit.FromInch((double)zImgSrc.Width / (double)zImgSrc.HorizontalResolution),
                    Height = XUnit.FromInch((double)zImgSrc.Height / (double)zImgSrc.VerticalResolution)
                });
                var zGfx = XGraphics.FromPdfPage(zPage);
                using (var zMem = new MemoryStream())
                {
                    zImgDestination.Save(zMem, ImageFormat.Bmp);
                    // just for testing
                    //zImgDestination.Save("C:\\temp.bmp", ImageFormat.Bmp);
                    var zXImage = XImage.FromStream(zMem);
                    zGfx.DrawImage(zXImage, new XPoint());
                    zXImage.Dispose();
                }
                zImgDestination.Dispose();
                zImgSrc.Dispose();
                progressBar.InvokeAction(() => progressBar.Value++);
            }
            zDocument.Save(sOutputPth);
            ConfigureControlState(false);
            m_zExportThread = null;
        }

        #endregion


        #region Support Methods

        private void ConfigureControlState(bool bExporting)
        {
            progressBar.InvokeAction(() => progressBar.Visible = bExporting);
            btnExportPdf.InvokeAction(() => btnExportPdf.Text = bExporting ? "Cancel" : "Export PDF");
            groupBoxSetup.InvokeAction(() => groupBoxSetup.Enabled = !bExporting);
        }

        private List<string> GetFilesList()
        {
            var listFiles = new List<string>(listViewCards.Items.Count);
            for (var nX = 0; nX < listViewCards.Items.Count; nX++)
            {
                var lvItem = listViewCards.Items[nX];
                var sCardFace = lvItem.SubItems[(int)ItemSubIndex.Front].Text;
                var sCardBack = lvItem.SubItems[(int)ItemSubIndex.Back].Text;
                int nCardCount;
                if (!int.TryParse(lvItem.SubItems[(int) ItemSubIndex.Count].Text, out nCardCount))
                {
                    nCardCount = 0;
                }

                var listCardFaces = new List<string>();
                if (!string.IsNullOrWhiteSpace(sCardFace))
                {
                    listCardFaces.Add(sCardFace);
                }
                if (!string.IsNullOrWhiteSpace(sCardBack))
                {
                    listCardFaces.Add(sCardBack);
                }
                if (checkBoxBacksFirst.Checked && 1 < listCardFaces.Count)
                {
                    listCardFaces.Insert(0, listCardFaces[1]);
                    listCardFaces.RemoveAt(2);
                }

                for (var nCount = 0; nCount < nCardCount; nCount++)
                {
                    listFiles.AddRange(listCardFaces);
                }
            }
            return listFiles;
        }

        private void AddCardRow(string sFront, string sBack, int nCount, int nTargetIndex)
        {
            var lvItem = new ListViewItem(new string[] { sFront, sBack, nCount.ToString()});
            listViewCards.Items.Insert(nTargetIndex, lvItem);
        }

        private void SetSelectedItemsValue(ListView.SelectedListViewItemCollection listItems, string sValue, ItemSubIndex eIndex)
        {
            for (var nIdx = 0; nIdx < listItems.Count; nIdx++)
            {
                listItems[nIdx].SubItems[(int)eIndex].Text = sValue;
            }
            MarkDirty();
        }

        private string[] GetImageFiles(bool bMultiSelect)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = ALL_FILES_FILTER,
                CheckFileExists = true,
                Multiselect = bMultiSelect
            };
            return DialogResult.OK == ofd.ShowDialog(this) ? ofd.FileNames : null;
        }

#endregion

#region AbstractDirtyForm

        protected override bool OpenFormData(string sFileName)
        {
            var zConstruct = new Construct();
            if (SerializationUtils.DeserializeFromXmlFile(sFileName, Encoding.UTF8, ref zConstruct))
            {
                listViewCards.Items.Clear();
                txtOutputPath.Text = zConstruct.OutputPath;
                var nTargetIndex = 0;
                zConstruct.CardEntries.ForEach(e =>
                {
                    AddCardRow(e.Front, e.Back, e.Count, nTargetIndex);
                    nTargetIndex++;
                });
                MarkClean();
                return true;
            }
            return false;
        }

        protected override bool SaveFormData(string sFileName)
        {
            var zConstruct = new Construct()
            {
                OutputPath = txtOutputPath.Text,
                CardEntries = new List<CardEntry>(listViewCards.Items.Count)
            };
            for (var nX = 0; nX < listViewCards.Items.Count; nX++)
            {
                var lvItem = listViewCards.Items[nX];
                zConstruct.CardEntries.Add(new CardEntry()
                {
                    Front = lvItem.SubItems[(int) ItemSubIndex.Front].Text,
                    Back = lvItem.SubItems[(int) ItemSubIndex.Back].Text,
                    Count = int.Parse(lvItem.SubItems[(int) ItemSubIndex.Count].Text)
                });
            }
            return SerializationUtils.SerializeToXmlFile(sFileName, zConstruct, Encoding.UTF8);
        }

        #endregion

    }
}
