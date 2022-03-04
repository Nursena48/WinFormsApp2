namespace WinFormsApp2.admin
{
    partial class frmAuthor
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
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.frmAuthorName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.frmSurname = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.frmDesciription = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(114, 40);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(222, 27);
            this.txtMemberName.TabIndex = 7;
            // 
            // frmAuthorName
            // 
            this.frmAuthorName.AutoSize = true;
            this.frmAuthorName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.frmAuthorName.Location = new System.Drawing.Point(40, 43);
            this.frmAuthorName.Name = "frmAuthorName";
            this.frmAuthorName.Size = new System.Drawing.Size(74, 20);
            this.frmAuthorName.TabIndex = 6;
            this.frmAuthorName.Text = "Yazar Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 9;
            // 
            // frmSurname
            // 
            this.frmSurname.AutoSize = true;
            this.frmSurname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.frmSurname.Location = new System.Drawing.Point(57, 92);
            this.frmSurname.Name = "frmSurname";
            this.frmSurname.Size = new System.Drawing.Size(57, 20);
            this.frmSurname.TabIndex = 8;
            this.frmSurname.Text = "Soyadı:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 148);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 191);
            this.textBox3.TabIndex = 13;
            // 
            // frmDesciription
            // 
            this.frmDesciription.AutoSize = true;
            this.frmDesciription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.frmDesciription.Location = new System.Drawing.Point(41, 151);
            this.frmDesciription.Name = "frmDesciription";
            this.frmDesciription.Size = new System.Drawing.Size(73, 20);
            this.frmDesciription.TabIndex = 12;
            this.frmDesciription.Text = "Açıklama:";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(161, 359);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(139, 33);
            this.txtSave.TabIndex = 21;
            this.txtSave.Text = "Kaydet";
            this.txtSave.UseVisualStyleBackColor = true;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.frmDesciription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.frmSurname);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.frmAuthorName);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMemberName;
        private Label frmAuthorName;
        private TextBox textBox1;
        private Label frmSurname;
        private TextBox textBox3;
        private Label frmDesciription;
        private Button txtSave;
    }
}