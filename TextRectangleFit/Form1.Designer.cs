namespace TextRectangleFit
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
            this.BT_Generate = new System.Windows.Forms.Button();
            this.PB_Pic = new System.Windows.Forms.PictureBox();
            this.RTB_Text = new System.Windows.Forms.RichTextBox();
            this.NUD_Padding = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_MaxRows = new System.Windows.Forms.Label();
            this.CB_Double = new System.Windows.Forms.CheckBox();
            this.CB_LineBreak = new System.Windows.Forms.CheckBox();
            this.BT_UseInputFromRTB = new System.Windows.Forms.Button();
            this.LB_Rect = new System.Windows.Forms.Label();
            this.CB_DeleteLargeWords = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Padding)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Generate
            // 
            this.BT_Generate.Location = new System.Drawing.Point(12, 12);
            this.BT_Generate.Name = "BT_Generate";
            this.BT_Generate.Size = new System.Drawing.Size(97, 29);
            this.BT_Generate.TabIndex = 0;
            this.BT_Generate.Text = "Generate";
            this.BT_Generate.UseVisualStyleBackColor = true;
            this.BT_Generate.Click += new System.EventHandler(this.BT_Generate_Click);
            // 
            // PB_Pic
            // 
            this.PB_Pic.Image = global::TextRectangleFit.Properties.Resources._5xlQJRVbfoo___Copy;
            this.PB_Pic.Location = new System.Drawing.Point(0, 0);
            this.PB_Pic.Name = "PB_Pic";
            this.PB_Pic.Size = new System.Drawing.Size(600, 793);
            this.PB_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Pic.TabIndex = 1;
            this.PB_Pic.TabStop = false;
            this.PB_Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Pic_Paint);
            // 
            // RTB_Text
            // 
            this.RTB_Text.Location = new System.Drawing.Point(58, 684);
            this.RTB_Text.Name = "RTB_Text";
            this.RTB_Text.Size = new System.Drawing.Size(489, 96);
            this.RTB_Text.TabIndex = 2;
            this.RTB_Text.Text = "";
            // 
            // NUD_Padding
            // 
            this.NUD_Padding.Location = new System.Drawing.Point(67, 47);
            this.NUD_Padding.Name = "NUD_Padding";
            this.NUD_Padding.Size = new System.Drawing.Size(42, 20);
            this.NUD_Padding.TabIndex = 3;
            this.NUD_Padding.ValueChanged += new System.EventHandler(this.NUD_Padding_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Padding:";
            // 
            // LB_MaxRows
            // 
            this.LB_MaxRows.AutoSize = true;
            this.LB_MaxRows.Location = new System.Drawing.Point(12, 76);
            this.LB_MaxRows.Name = "LB_MaxRows";
            this.LB_MaxRows.Size = new System.Drawing.Size(51, 13);
            this.LB_MaxRows.TabIndex = 4;
            this.LB_MaxRows.Text = "max rows";
            // 
            // CB_Double
            // 
            this.CB_Double.AutoSize = true;
            this.CB_Double.Location = new System.Drawing.Point(115, 19);
            this.CB_Double.Name = "CB_Double";
            this.CB_Double.Size = new System.Drawing.Size(37, 17);
            this.CB_Double.TabIndex = 5;
            this.CB_Double.Text = "x2";
            this.CB_Double.UseVisualStyleBackColor = true;
            // 
            // CB_LineBreak
            // 
            this.CB_LineBreak.AutoSize = true;
            this.CB_LineBreak.Checked = true;
            this.CB_LineBreak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_LineBreak.Location = new System.Drawing.Point(158, 19);
            this.CB_LineBreak.Name = "CB_LineBreak";
            this.CB_LineBreak.Size = new System.Drawing.Size(76, 17);
            this.CB_LineBreak.TabIndex = 5;
            this.CB_LineBreak.Text = "Line break";
            this.CB_LineBreak.UseVisualStyleBackColor = true;
            // 
            // BT_UseInputFromRTB
            // 
            this.BT_UseInputFromRTB.Location = new System.Drawing.Point(58, 649);
            this.BT_UseInputFromRTB.Name = "BT_UseInputFromRTB";
            this.BT_UseInputFromRTB.Size = new System.Drawing.Size(97, 29);
            this.BT_UseInputFromRTB.TabIndex = 0;
            this.BT_UseInputFromRTB.Text = "Use as input";
            this.BT_UseInputFromRTB.UseVisualStyleBackColor = true;
            this.BT_UseInputFromRTB.Click += new System.EventHandler(this.BT_UseInputFromRTB_Click);
            // 
            // LB_Rect
            // 
            this.LB_Rect.AutoSize = true;
            this.LB_Rect.Location = new System.Drawing.Point(12, 98);
            this.LB_Rect.Name = "LB_Rect";
            this.LB_Rect.Size = new System.Drawing.Size(47, 13);
            this.LB_Rect.TabIndex = 4;
            this.LB_Rect.Text = "msg rect";
            // 
            // CB_DeleteLargeWords
            // 
            this.CB_DeleteLargeWords.AutoSize = true;
            this.CB_DeleteLargeWords.Location = new System.Drawing.Point(158, 42);
            this.CB_DeleteLargeWords.Name = "CB_DeleteLargeWords";
            this.CB_DeleteLargeWords.Size = new System.Drawing.Size(210, 17);
            this.CB_DeleteLargeWords.TabIndex = 5;
            this.CB_DeleteLargeWords.Text = "Delete large words (line break required)";
            this.CB_DeleteLargeWords.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 792);
            this.Controls.Add(this.CB_DeleteLargeWords);
            this.Controls.Add(this.CB_LineBreak);
            this.Controls.Add(this.CB_Double);
            this.Controls.Add(this.LB_Rect);
            this.Controls.Add(this.LB_MaxRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_Padding);
            this.Controls.Add(this.RTB_Text);
            this.Controls.Add(this.BT_UseInputFromRTB);
            this.Controls.Add(this.BT_Generate);
            this.Controls.Add(this.PB_Pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "TextRectangleFit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Padding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Generate;
        private System.Windows.Forms.PictureBox PB_Pic;
        private System.Windows.Forms.RichTextBox RTB_Text;
        private System.Windows.Forms.NumericUpDown NUD_Padding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_MaxRows;
        private System.Windows.Forms.CheckBox CB_Double;
        private System.Windows.Forms.CheckBox CB_LineBreak;
        private System.Windows.Forms.Button BT_UseInputFromRTB;
        private System.Windows.Forms.Label LB_Rect;
        private System.Windows.Forms.CheckBox CB_DeleteLargeWords;
    }
}

