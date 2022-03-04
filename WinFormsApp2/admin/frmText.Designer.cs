namespace WinFormsApp2.admin
{
    partial class frmText
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
            this.btKareHesaplama = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTekmiciftmi = new System.Windows.Forms.Button();
            this.btnBasamak = new System.Windows.Forms.Button();
            this.btnBakteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btKareHesaplama
            // 
            this.btKareHesaplama.Location = new System.Drawing.Point(147, 183);
            this.btKareHesaplama.Name = "btKareHesaplama";
            this.btKareHesaplama.Size = new System.Drawing.Size(97, 36);
            this.btKareHesaplama.TabIndex = 0;
            this.btKareHesaplama.Text = "button1";
            this.btKareHesaplama.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 38);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // btnTekmiciftmi
            // 
            this.btnTekmiciftmi.Location = new System.Drawing.Point(147, 225);
            this.btnTekmiciftmi.Name = "btnTekmiciftmi";
            this.btnTekmiciftmi.Size = new System.Drawing.Size(97, 36);
            this.btnTekmiciftmi.TabIndex = 5;
            this.btnTekmiciftmi.Text = "button2";
            this.btnTekmiciftmi.UseVisualStyleBackColor = true;
            this.btnTekmiciftmi.Click += new System.EventHandler(this.btnTekmiciftmi_Click);
            // 
            // btnBasamak
            // 
            this.btnBasamak.Location = new System.Drawing.Point(147, 267);
            this.btnBasamak.Name = "btnBasamak";
            this.btnBasamak.Size = new System.Drawing.Size(97, 36);
            this.btnBasamak.TabIndex = 6;
            this.btnBasamak.Text = "button3";
            this.btnBasamak.UseVisualStyleBackColor = true;
            this.btnBasamak.Click += new System.EventHandler(this.btnBasamak_Click);
            // 
            // btnBakteri
            // 
            this.btnBakteri.Location = new System.Drawing.Point(147, 309);
            this.btnBakteri.Name = "btnBakteri";
            this.btnBakteri.Size = new System.Drawing.Size(97, 36);
            this.btnBakteri.TabIndex = 7;
            this.btnBakteri.Text = "button4";
            this.btnBakteri.UseVisualStyleBackColor = true;
            this.btnBakteri.Click += new System.EventHandler(this.btnBakteri_Click);
            // 
            // frmText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.btnBakteri);
            this.Controls.Add(this.btnBasamak);
            this.Controls.Add(this.btnTekmiciftmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btKareHesaplama);
            this.Name = "frmText";
            this.Text = "frmText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btKareHesaplama;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTekmiciftmi;
        private Button btnBasamak;
        private Button btnBakteri;
    }
}