namespace BulkRen
{
    partial class View
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
            this.ViewBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ViewBox
            // 
            this.ViewBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBox.Location = new System.Drawing.Point(1, 1);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Size = new System.Drawing.Size(941, 489);
            this.ViewBox.TabIndex = 1;
            this.ViewBox.Text = "";
            this.ViewBox.WordWrap = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 489);
            this.Controls.Add(this.ViewBox);
            this.Name = "View";
            this.Text = "View";
            this.Resize += new System.EventHandler(this.View_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox ViewBox;
    }
}