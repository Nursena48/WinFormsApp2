namespace WinFormsApp2.admin
{
    partial class frmCategory
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
            this.txtCategoryName = new System.Windows.Forms.Label();
            this.ntnSave = new System.Windows.Forms.Button();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.txtDesciription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(130, 67);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(125, 27);
            this.txtBookName.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.AutoSize = true;
            this.txtCategoryName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCategoryName.Location = new System.Drawing.Point(28, 70);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(96, 20);
            this.txtCategoryName.TabIndex = 2;
            this.txtCategoryName.Text = "Kategori Adı:";
            this.txtCategoryName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ntnSave
            // 
            this.ntnSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ntnSave.Location = new System.Drawing.Point(127, 259);
            this.ntnSave.Name = "ntnSave";
            this.ntnSave.Size = new System.Drawing.Size(128, 31);
            this.ntnSave.TabIndex = 17;
            this.ntnSave.Text = "Kaydet";
            this.ntnSave.UseVisualStyleBackColor = true;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(130, 121);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(125, 120);
            this.txtExplanation.TabIndex = 16;
            // 
            // txtDesciription
            // 
            this.txtDesciription.AutoSize = true;
            this.txtDesciription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDesciription.Location = new System.Drawing.Point(39, 121);
            this.txtDesciription.Name = "txtDesciription";
            this.txtDesciription.Size = new System.Drawing.Size(73, 20);
            this.txtDesciription.TabIndex = 15;
            this.txtDesciription.Text = "Açıklama:";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 387);
            this.Controls.Add(this.ntnSave);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.txtDesciription);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBookName;
        private Label txtCategoryName;
        private Button ntnSave;
        private TextBox txtExplanation;
        private Label txtDesciription;
    }
}