namespace BulkRen
{
    partial class Form1
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
            this.FillBox = new System.Windows.Forms.TextBox();
            this.FillBtn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.DuplicateBox = new System.Windows.Forms.TextBox();
            this.DupLabel = new System.Windows.Forms.Label();
            this.ReferenceBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.RichTextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FillBox
            // 
            this.FillBox.Location = new System.Drawing.Point(172, 27);
            this.FillBox.Name = "FillBox";
            this.FillBox.Size = new System.Drawing.Size(41, 20);
            this.FillBox.TabIndex = 20;
            // 
            // FillBtn
            // 
            this.FillBtn.BackColor = System.Drawing.Color.Aqua;
            this.FillBtn.Location = new System.Drawing.Point(128, 27);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(34, 20);
            this.FillBtn.TabIndex = 19;
            this.FillBtn.Text = "Ins";
            this.FillBtn.UseVisualStyleBackColor = false;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(161, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(13, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = ">";
            // 
            // UndoBtn
            // 
            this.UndoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UndoBtn.Location = new System.Drawing.Point(230, 27);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(41, 20);
            this.UndoBtn.TabIndex = 18;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = false;
            this.UndoBtn.Visible = false;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBTN.Location = new System.Drawing.Point(80, 27);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(34, 20);
            this.DeleteBTN.TabIndex = 17;
            this.DeleteBTN.Text = "Del";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // DuplicateBox
            // 
            this.DuplicateBox.BackColor = System.Drawing.SystemColors.Window;
            this.DuplicateBox.Enabled = false;
            this.DuplicateBox.Location = new System.Drawing.Point(628, 27);
            this.DuplicateBox.Name = "DuplicateBox";
            this.DuplicateBox.Size = new System.Drawing.Size(54, 20);
            this.DuplicateBox.TabIndex = 16;
            this.DuplicateBox.Text = "0";
            this.DuplicateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DupLabel
            // 
            this.DupLabel.AutoSize = true;
            this.DupLabel.Location = new System.Drawing.Point(565, 31);
            this.DupLabel.Name = "DupLabel";
            this.DupLabel.Size = new System.Drawing.Size(57, 13);
            this.DupLabel.TabIndex = 15;
            this.DupLabel.Text = "Duplicates";
            // 
            // ReferenceBox
            // 
            this.ReferenceBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceBox.Location = new System.Drawing.Point(2, 50);
            this.ReferenceBox.Name = "ReferenceBox";
            this.ReferenceBox.Size = new System.Drawing.Size(680, 26);
            this.ReferenceBox.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(2, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Reference file";
            // 
            // FileBox
            // 
            this.FileBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FileBox.DetectUrls = false;
            this.FileBox.Enabled = false;
            this.FileBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileBox.Location = new System.Drawing.Point(2, 82);
            this.FileBox.Name = "FileBox";
            this.FileBox.ReadOnly = true;
            this.FileBox.Size = new System.Drawing.Size(680, 377);
            this.FileBox.TabIndex = 12;
            this.FileBox.Text = "";
            this.FileBox.WordWrap = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem2,
            this.SpecialToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(683, 24);
            this.MenuStrip1.TabIndex = 11;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ToolStripMenuItem5,
            this.ExitToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItem1.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(117, 22);
            this.ToolStripMenuItem5.Text = "Rename";
            this.ToolStripMenuItem5.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFilterToolStripMenuItem});
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(39, 20);
            this.ToolStripMenuItem3.Text = "Edit";
            // 
            // FileFilterToolStripMenuItem
            // 
            this.FileFilterToolStripMenuItem.Name = "FileFilterToolStripMenuItem";
            this.FileFilterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FileFilterToolStripMenuItem.Text = "File filter";
            this.FileFilterToolStripMenuItem.Click += new System.EventHandler(this.FileFilterToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowResultToolStripMenuItem});
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem2.Text = "View";
            // 
            // ShowResultToolStripMenuItem
            // 
            this.ShowResultToolStripMenuItem.Name = "ShowResultToolStripMenuItem";
            this.ShowResultToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ShowResultToolStripMenuItem.Text = "Show result";
            this.ShowResultToolStripMenuItem.Click += new System.EventHandler(this.ShowResultToolStripMenuItem_Click);
            // 
            // SpecialToolStripMenuItem
            // 
            this.SpecialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateBatchToolStripMenuItem});
            this.SpecialToolStripMenuItem.Name = "SpecialToolStripMenuItem";
            this.SpecialToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.SpecialToolStripMenuItem.Text = "Special";
            // 
            // CreateBatchToolStripMenuItem
            // 
            this.CreateBatchToolStripMenuItem.Name = "CreateBatchToolStripMenuItem";
            this.CreateBatchToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.CreateBatchToolStripMenuItem.Text = "Create Batch";
            this.CreateBatchToolStripMenuItem.Click += new System.EventHandler(this.CreateBatchToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem4,
            this.FilterToolStripMenuItem,
            this.BatchToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(119, 22);
            this.ToolStripMenuItem4.Text = "Example";
            // 
            // FilterToolStripMenuItem
            // 
            this.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem";
            this.FilterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FilterToolStripMenuItem.Text = "Filter";
            // 
            // BatchToolStripMenuItem
            // 
            this.BatchToolStripMenuItem.Name = "BatchToolStripMenuItem";
            this.BatchToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.BatchToolStripMenuItem.Text = "Batch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 463);
            this.Controls.Add(this.FillBox);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.UndoBtn);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.DuplicateBox);
            this.Controls.Add(this.DupLabel);
            this.Controls.Add(this.ReferenceBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Bulk rename";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox FillBox;
        internal System.Windows.Forms.Button FillBtn;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button UndoBtn;
        internal System.Windows.Forms.Button DeleteBTN;
        internal System.Windows.Forms.TextBox DuplicateBox;
        internal System.Windows.Forms.Label DupLabel;
        internal System.Windows.Forms.TextBox ReferenceBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RichTextBox FileBox;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem FileFilterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem ShowResultToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SpecialToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CreateBatchToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem FilterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BatchToolStripMenuItem;
    }
}

