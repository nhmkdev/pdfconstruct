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
            this.listViewCards = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripFaces = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericDPI = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFaces.SuspendLayout();
            this.groupBoxSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDPI)).BeginInit();
            this.menuStrip.SuspendLayout();
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
            this.listViewCards.Location = new System.Drawing.Point(6, 71);
            this.listViewCards.Name = "listViewCards";
            this.listViewCards.Size = new System.Drawing.Size(862, 413);
            this.listViewCards.TabIndex = 0;
            this.listViewCards.UseCompatibleStateImageBehavior = false;
            this.listViewCards.View = System.Windows.Forms.View.Details;
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
            this.contextMenuStripFaces.Size = new System.Drawing.Size(174, 176);
            // 
            // addEntriesToolStripMenuItem
            // 
            this.addEntriesToolStripMenuItem.Name = "addEntriesToolStripMenuItem";
            this.addEntriesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addEntriesToolStripMenuItem.Text = "Add New Entries...";
            this.addEntriesToolStripMenuItem.Click += new System.EventHandler(this.addEntriesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // selectCardFrontsToolStripMenuItem
            // 
            this.selectCardFrontsToolStripMenuItem.Name = "selectCardFrontsToolStripMenuItem";
            this.selectCardFrontsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectCardFrontsToolStripMenuItem.Text = "Set Card Front(s)...";
            this.selectCardFrontsToolStripMenuItem.Click += new System.EventHandler(this.selectCardFacesToolStripMenuItem_Click);
            // 
            // selectCardBacksToolStripMenuItem
            // 
            this.selectCardBacksToolStripMenuItem.Name = "selectCardBacksToolStripMenuItem";
            this.selectCardBacksToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectCardBacksToolStripMenuItem.Text = "Set Card Back(s)...";
            this.selectCardBacksToolStripMenuItem.Click += new System.EventHandler(this.selectCardFacesToolStripMenuItem_Click);
            // 
            // setCardCountsToolStripMenuItem
            // 
            this.setCardCountsToolStripMenuItem.Name = "setCardCountsToolStripMenuItem";
            this.setCardCountsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setCardCountsToolStripMenuItem.Text = "Set Card Count(s)...";
            this.setCardCountsToolStripMenuItem.Click += new System.EventHandler(this.setCardCountsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // clearCardFrontsToolStripMenuItem
            // 
            this.clearCardFrontsToolStripMenuItem.Name = "clearCardFrontsToolStripMenuItem";
            this.clearCardFrontsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearCardFrontsToolStripMenuItem.Text = "Clear Card Front(s)";
            this.clearCardFrontsToolStripMenuItem.Click += new System.EventHandler(this.clearCardFacesToolStripMenuItem_Click);
            // 
            // clearCardBacksToolStripMenuItem
            // 
            this.clearCardBacksToolStripMenuItem.Name = "clearCardBacksToolStripMenuItem";
            this.clearCardBacksToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearCardBacksToolStripMenuItem.Text = "Clear Card Back(s)";
            this.clearCardBacksToolStripMenuItem.Click += new System.EventHandler(this.clearCardFacesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 6);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row(s)...";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowsToolStripMenuItem_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.Location = new System.Drawing.Point(811, 523);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(75, 20);
            this.btnExportPdf.TabIndex = 1;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(80, 19);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(754, 20);
            this.txtOutputPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(840, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
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
            this.progressBar.Location = new System.Drawing.Point(12, 523);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(793, 20);
            this.progressBar.TabIndex = 5;
            // 
            // groupBoxSetup
            // 
            this.groupBoxSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetup.Controls.Add(this.label2);
            this.groupBoxSetup.Controls.Add(this.numericDPI);
            this.groupBoxSetup.Controls.Add(this.listViewCards);
            this.groupBoxSetup.Controls.Add(this.btnBrowse);
            this.groupBoxSetup.Controls.Add(this.label1);
            this.groupBoxSetup.Controls.Add(this.txtOutputPath);
            this.groupBoxSetup.Location = new System.Drawing.Point(12, 27);
            this.groupBoxSetup.Name = "groupBoxSetup";
            this.groupBoxSetup.Size = new System.Drawing.Size(874, 490);
            this.groupBoxSetup.TabIndex = 6;
            this.groupBoxSetup.TabStop = false;
            this.groupBoxSetup.Text = "Setup";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DPI:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericDPI
            // 
            this.numericDPI.Location = new System.Drawing.Point(80, 45);
            this.numericDPI.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericDPI.Minimum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericDPI.Name = "numericDPI";
            this.numericDPI.Size = new System.Drawing.Size(79, 20);
            this.numericDPI.TabIndex = 5;
            this.numericDPI.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericDPI.ValueChanged += new System.EventHandler(this.numericDPI_ValueChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(898, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // PdfConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 555);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxSetup);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExportPdf);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "PdfConstructForm";
            this.Text = "PdfConstruct";
            this.Load += new System.EventHandler(this.PdfConstructForm_Load);
            this.contextMenuStripFaces.ResumeLayout(false);
            this.groupBoxSetup.ResumeLayout(false);
            this.groupBoxSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDPI)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCards;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDPI;
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
    }
}

