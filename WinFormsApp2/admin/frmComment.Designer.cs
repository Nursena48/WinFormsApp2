namespace WinFormsApp2.admin
{
    partial class frmComment
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.Label();
            this.ntnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(132, 57);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(418, 27);
            this.txtBookName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 27);
            this.textBox1.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.AutoSize = true;
            this.txtMemberName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMemberName.Location = new System.Drawing.Point(42, 106);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(64, 20);
            this.txtMemberName.TabIndex = 4;
            this.txtMemberName.Text = "Üye Adı:";
            // 
            // txtPoint
            // 
            this.txtPoint.AutoSize = true;
            this.txtPoint.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPoint.Location = new System.Drawing.Point(42, 153);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(44, 20);
            this.txtPoint.TabIndex = 6;
            this.txtPoint.Text = "Puan:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(132, 151);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(166, 151);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(298, 151);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(38, 24);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "5";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(210, 151);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(38, 24);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "3";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(254, 151);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(38, 24);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "4";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(460, 151);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(38, 24);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "9";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(416, 151);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(38, 24);
            this.radioButton7.TabIndex = 15;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "8";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(504, 151);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(46, 24);
            this.radioButton8.TabIndex = 14;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "10";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(372, 151);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(38, 24);
            this.radioButton9.TabIndex = 13;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "7";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(338, 151);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(38, 24);
            this.radioButton10.TabIndex = 12;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "6";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(132, 193);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(418, 184);
            this.txtExplanation.TabIndex = 18;
            // 
            // txtComment
            // 
            this.txtComment.AutoSize = true;
            this.txtComment.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtComment.Location = new System.Drawing.Point(41, 193);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(54, 20);
            this.txtComment.TabIndex = 17;
            this.txtComment.Text = "Yorum:";
            // 
            // ntnSend
            // 
            this.ntnSend.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ntnSend.Location = new System.Drawing.Point(282, 383);
            this.ntnSend.Name = "ntnSend";
            this.ntnSend.Size = new System.Drawing.Size(128, 31);
            this.ntnSend.TabIndex = 19;
            this.ntnSend.Text = "Gönder";
            this.ntnSend.UseVisualStyleBackColor = true;
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.ntnSend);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Name = "frmComment";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBookName;
        private Label label1;
        private TextBox textBox1;
        private Label txtMemberName;
        private Label txtPoint;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private TextBox txtExplanation;
        private Label txtComment;
        private Button ntnSend;
    }
}