namespace WinFormsApp2.admin
{
    partial class frmBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ntnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(145, 42);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(125, 27);
            this.txtBookName.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(145, 87);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(125, 27);
            this.txtAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(78, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazarı:";
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(145, 126);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(125, 27);
            this.txtPageNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // txtPrize
            // 
            this.txtPrize.Location = new System.Drawing.Point(145, 172);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(125, 27);
            this.txtPrize.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(86, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(146, 215);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(125, 27);
            this.txtPublisher.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(64, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yayınevi:";
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(145, 259);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(125, 27);
            this.txtPublicationYear.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(53, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Basım Yılı:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(145, 309);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(125, 120);
            this.txtExplanation.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(56, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Açıklama:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ntnSave
            // 
            this.ntnSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ntnSave.Location = new System.Drawing.Point(144, 444);
            this.ntnSave.Name = "ntnSave";
            this.ntnSave.Size = new System.Drawing.Size(128, 31);
            this.ntnSave.TabIndex = 14;
            this.ntnSave.Text = "Kaydet";
            this.ntnSave.UseVisualStyleBackColor = true;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 519);
            this.Controls.Add(this.ntnSave);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPublicationYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Name = "frmBook";
            this.Text = "frmBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtPageNumber;
        private Label label3;
        private TextBox txtPrize;
        private Label label4;
        private TextBox txtPublisher;
        private Label label5;
        private TextBox txtPublicationYear;
        private Label label6;
        private TextBox txtExplanation;
        private Label label7;
        private Button ntnSave;
    }
}