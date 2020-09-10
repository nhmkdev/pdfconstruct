////////////////////////////////////////////////////////////////////////////////
// The MIT License (MIT)
//
// Copyright (c) 2020 Tim Stair
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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Support.UI;

namespace PdfConstruct.Merge
{
    public class PDFMerge
    {
        private QueryPanel zQuery;
        const string FILE_ONE = "1";
        const string FILE_TWO = "2";
        const string OPEN_RESULT = "OPEN";

        private const string PDF_FILTER_STRING = "PDF files (*.pdf)|*.pdf";

        public void SetupPanel(Panel zPanel)
        {
            zQuery = new QueryPanel(zPanel, 80, false);
            zQuery.AddLabel("The first page will be taken from File 1", 20);
            SetupDragDropFile(zQuery.AddFileBrowseBox("File 1", string.Empty, PDF_FILTER_STRING, FILE_ONE));
            SetupDragDropFile(zQuery.AddFileBrowseBox("File 2", string.Empty, PDF_FILTER_STRING, FILE_TWO));
            zQuery.AddCheckBox("Open Result", false, OPEN_RESULT);
            zQuery.FinalizeControls();
        }

        private void SetupDragDropFile(TextBox textBox)
        {
            textBox.AllowDrop = true;
            textBox.DragEnter += (sender, e) =>
            {
                e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                    ? DragDropEffects.Link
                    : DragDropEffects.None;
            };
            textBox.DragDrop += (sender, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    var arrayFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                    if(arrayFiles.Length > 0) ((TextBox) sender).Text = arrayFiles[0];
                }
            };
        }

        public void SetupPDFMerge(string sFileOut)
        {
            var sFile1 = zQuery.GetString(FILE_ONE);
            var sFile2 = zQuery.GetString(FILE_TWO);

            if (!File.Exists(sFile1) || !File.Exists(sFile2))
            {
                MessageBox.Show("Input Files Must Exist", "Please select existing files to merge.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(sFileOut))
            {
                MessageBox.Show("Output Files Must Be Specified", "Please specify an output file.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                MergePDFs(sFile1, sFile2, sFileOut);
                MessageBox.Show("Export Complete", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "PDF Merge Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (zQuery.GetBool(OPEN_RESULT))
            {
                Process.Start(sFileOut);
            }
        }

        static void MergePDFs(string sFile1, string sFile2, string sOutFile)
        {
            var zDoc1 = PdfReader.Open(sFile1, PdfDocumentOpenMode.Import);
            var zDoc2 = PdfReader.Open(sFile2, PdfDocumentOpenMode.Import);
            var zDocOutput = new PdfDocument();
            var nDocIdx = 0;
            while (nDocIdx < zDoc1.PageCount && nDocIdx < zDoc2.PageCount)
            {
                zDocOutput.AddPage(zDoc1.Pages[nDocIdx]);
                zDocOutput.AddPage(zDoc2.Pages[nDocIdx]);
                nDocIdx++;
            }

            // swap in doc2 as doc1 (if needed) and flush the rest of the pages
            if (nDocIdx >= zDoc1.PageCount)
            {
                zDoc1 = zDoc2;
            }
            while (nDocIdx < zDoc1.PageCount)
            {
                zDocOutput.AddPage(zDoc1.Pages[nDocIdx]);
                nDocIdx++;
            }
            zDocOutput.Save(sOutFile);
        }
    }
}
