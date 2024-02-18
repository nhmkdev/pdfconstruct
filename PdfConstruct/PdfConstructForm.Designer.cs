////////////////////////////////////////////////////////////////////////////////
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

using Support.UI;

namespace PdfConstruct
{
    partial class PdfConstructForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewCards = new Support.UI.ListViewDoubleBuffered();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripFaces = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectCardFrontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCardBacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCardCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearCardFrontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCardBacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxSetup = new System.Windows.Forms.GroupBox();
            this.checkBoxBacksFirst = new System.Windows.Forms.CheckBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelPdfMerge = new System.Windows.Forms.Panel();
            this.contextMenuStripFaces.SuspendLayout();
            this.groupBoxSetup.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCards
            // 
            this.listViewCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCards.ContextMenuStrip = this.contextMenuStripFaces;
            this.listViewCards.FullRowSelect = true;
            this.listViewCards.GridLines = true;
            this.listViewCards.HideSelection = false;
            this.listViewCards.Location = new System.Drawing.Point(6, 45);
            this.listViewCards.Name = "listViewCards";
            this.listViewCards.Size = new System.Drawing.Size(1191, 520);
            this.listViewCards.TabIndex = 0;
            this.listViewCards.UseCompatibleStateImageBehavior = false;
            this.listViewCards.View = System.Windows.Forms.View.Details;
            this.listViewCards.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewCards_KeyDown);
            this.listViewCards.Resize += new System.EventHandler(this.listViewCards_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Card Front";
            this.columnHeader1.Width = 376;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Card Back";
            this.columnHeader2.Width = 413;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Count";
            // 
            // contextMenuStripFaces
            // 
            this.contextMenuStripFaces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntriesToolStripMenuItem,
            this.insertNewEntriesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectCardFrontsToolStripMenuItem,
            this.selectCardBacksToolStripMenuItem,
            this.setCardCountsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clearCardFrontsToolStripMenuItem,
            this.clearCardBacksToolStripMenuItem,
            this.toolStripMenuItem5,
            this.deleteRowToolStripMenuItem});
            this.contextMenuStripFaces.Name = "contextMenuStripFaces";
            this.contextMenuStripFaces.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripFaces.Size = new System.Drawing.Size(178, 198);
            // 
            // addEntriesToolStripMenuItem
            // 
            this.addEntriesToolStripMenuItem.Name = "addEntriesToolStripMenuItem";
            this.addEntriesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addEntriesToolStripMenuItem.Text = "Add New Entries...";
            this.addEntriesToolStripMenuItem.Click += new System.EventHandler(this.addEntriesToolStripMenuItem_Click);
            // 
            // insertNewEntriesToolStripMenuItem
            // 
            this.insertNewEntriesToolStripMenuItem.Name = "insertNewEntriesToolStripMenuItem";
            this.insertNewEntriesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.insertNewEntriesToolStripMenuItem.Text = "Insert New Entries...";
            this.insertNewEntriesToolStripMenuItem.Click += new System.EventHandler(this.insertNewEntriesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // selectCardFrontsToolStripMenuItem
            // 
            this.selectCardFrontsToolStripMenuItem.Name = "selectCardFrontsToolStripMenuItem";
            this.selectCardFrontsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.selectCardFrontsToolStripMenuItem.Text = "Set Card Front(s)...";
            this.selectCardFrontsToolStripMenuItem.Click += new System.EventHandler(this.selectCardFacesToolStripMenuItem_Click);
            // 
            // selectCardBacksToolStripMenuItem
            // 
            this.selectCardBacksToolStripMenuItem.Name = "selectCardBacksToolStripMenuItem";
            this.selectCardBacksToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.selectCardBacksToolStripMenuItem.Text = "Set Card Back(s)...";
            this.selectCardBacksToolStripMenuItem.Click += new System.EventHandler(this.selectCardFacesToolStripMenuItem_Click);
            // 
            // setCardCountsToolStripMenuItem
            // 
            this.setCardCountsToolStripMenuItem.Name = "setCardCountsToolStripMenuItem";
            this.setCardCountsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setCardCountsToolStripMenuItem.Text = "Set Card Count(s)...";
            this.setCardCountsToolStripMenuItem.Click += new System.EventHandler(this.setCardCountsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 6);
            // 
            // clearCardFrontsToolStripMenuItem
            // 
            this.clearCardFrontsToolStripMenuItem.Name = "clearCardFrontsToolStripMenuItem";
            this.clearCardFrontsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearCardFrontsToolStripMenuItem.Text = "Clear Card Front(s)";
            this.clearCardFrontsToolStripMenuItem.Click += new System.EventHandler(this.clearCardFacesToolStripMenuItem_Click);
            // 
            // clearCardBacksToolStripMenuItem
            // 
            this.clearCardBacksToolStripMenuItem.Name = "clearCardBacksToolStripMenuItem";
            this.clearCardBacksToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearCardBacksToolStripMenuItem.Text = "Clear Card Back(s)";
            this.clearCardBacksToolStripMenuItem.Click += new System.EventHandler(this.clearCardFacesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(174, 6);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row(s)...";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowsToolStripMenuItem_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.Location = new System.Drawing.Point(1138, 668);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(75, 20);
            this.btnExportPdf.TabIndex = 1;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(92, 643);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(1083, 20);
            this.txtOutputPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(1185, 642);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(12, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 668);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1120, 20);
            this.progressBar.TabIndex = 5;
            // 
            // groupBoxSetup
            // 
            this.groupBoxSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetup.Controls.Add(this.listViewCards);
            this.groupBoxSetup.Controls.Add(this.checkBoxBacksFirst);
            this.groupBoxSetup.Controls.Add(this.btnMoveUp);
            this.groupBoxSetup.Controls.Add(this.btnMoveDown);
            this.groupBoxSetup.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSetup.Name = "groupBoxSetup";
            this.groupBoxSetup.Size = new System.Drawing.Size(1203, 571);
            this.groupBoxSetup.TabIndex = 6;
            this.groupBoxSetup.TabStop = false;
            this.groupBoxSetup.Text = "Setup";
            // 
            // checkBoxBacksFirst
            // 
            this.checkBoxBacksFirst.AutoSize = true;
            this.checkBoxBacksFirst.Location = new System.Drawing.Point(6, 19);
            this.checkBoxBacksFirst.Name = "checkBoxBacksFirst";
            this.checkBoxBacksFirst.Size = new System.Drawing.Size(111, 17);
            this.checkBoxBacksFirst.TabIndex = 9;
            this.checkBoxBacksFirst.Text = "Export Backs First";
            this.checkBoxBacksFirst.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(1021, 19);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(84, 20);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Location = new System.Drawing.Point(1113, 19);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(84, 20);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1225, 609);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxSetup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1217, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelPdfMerge);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1217, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF Interleave/Merge Util";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelPdfMerge
            // 
            this.panelPdfMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPdfMerge.Location = new System.Drawing.Point(3, 3);
            this.panelPdfMerge.Name = "panelPdfMerge";
            this.panelPdfMerge.Size = new System.Drawing.Size(1211, 577);
            this.panelPdfMerge.TabIndex = 0;
            // 
            // PdfConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnExportPdf);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "PdfConstructForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PdfConstructForm_FormClosing);
            this.Load += new System.EventHandler(this.PdfConstructForm_Load);
            this.contextMenuStripFaces.ResumeLayout(false);
            this.groupBoxSetup.ResumeLayout(false);
            this.groupBoxSetup.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFaces;
        private System.Windows.Forms.ToolStripMenuItem selectCardFrontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCardBacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCardBacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCardFrontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxSetup;
        private System.Windows.Forms.ToolStripMenuItem addEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCardCountsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.ToolStripMenuItem insertNewEntriesToolStripMenuItem;
        private ListViewDoubleBuffered listViewCards;
        private System.Windows.Forms.CheckBox checkBoxBacksFirst;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelPdfMerge;
    }
}

