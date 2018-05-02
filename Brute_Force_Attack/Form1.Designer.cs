namespace Brute_Force_Attack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeknika = new System.Windows.Forms.ComboBox();
            this.lblTeknika = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCiphertextError = new System.Windows.Forms.Label();
            this.lblKeyError = new System.Windows.Forms.Label();
            this.lblPlaintextError = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pnlFrequency = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.LblCiphertext = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 104);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(483, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "For Caesar Cipher";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 103);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(244, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Brute Force Attack";
            // 
            // cmbTeknika
            // 
            this.cmbTeknika.FormattingEnabled = true;
            this.cmbTeknika.Items.AddRange(new object[] {
            "Ciphertext only",
            "Known plaintext",
            "Frequency analysis"});
            this.cmbTeknika.Location = new System.Drawing.Point(217, 183);
            this.cmbTeknika.Name = "cmbTeknika";
            this.cmbTeknika.Size = new System.Drawing.Size(135, 21);
            this.cmbTeknika.TabIndex = 0;
            this.cmbTeknika.SelectedIndexChanged += new System.EventHandler(this.cmbTeknika_SelectedIndexChanged);
            // 
            // lblTeknika
            // 
            this.lblTeknika.AutoSize = true;
            this.lblTeknika.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTeknika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeknika.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTeknika.Location = new System.Drawing.Point(23, 183);
            this.lblTeknika.Name = "lblTeknika";
            this.lblTeknika.Size = new System.Drawing.Size(177, 18);
            this.lblTeknika.TabIndex = 2;
            this.lblTeknika.Text = "Zgjedhni teknikën e sulmit";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblCiphertextError);
            this.panel3.Controls.Add(this.lblKeyError);
            this.panel3.Controls.Add(this.lblPlaintextError);
            this.panel3.Controls.Add(this.txtResult);
            this.panel3.Controls.Add(this.pnlFrequency);
            this.panel3.Controls.Add(this.btnEncrypt);
            this.panel3.Controls.Add(this.btnDecrypt);
            this.panel3.Controls.Add(this.txtCiphertext);
            this.panel3.Controls.Add(this.txtKey);
            this.panel3.Controls.Add(this.txtPlaintext);
            this.panel3.Controls.Add(this.LblCiphertext);
            this.panel3.Controls.Add(this.lblKey);
            this.panel3.Controls.Add(this.lblPlaintext);
            this.panel3.Location = new System.Drawing.Point(391, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 310);
            this.panel3.TabIndex = 5;
            // 
            // lblCiphertextError
            // 
            this.lblCiphertextError.AutoSize = true;
            this.lblCiphertextError.Location = new System.Drawing.Point(274, 113);
            this.lblCiphertextError.Name = "lblCiphertextError";
            this.lblCiphertextError.Size = new System.Drawing.Size(0, 13);
            this.lblCiphertextError.TabIndex = 12;
            // 
            // lblKeyError
            // 
            this.lblKeyError.AutoSize = true;
            this.lblKeyError.Location = new System.Drawing.Point(274, 74);
            this.lblKeyError.Name = "lblKeyError";
            this.lblKeyError.Size = new System.Drawing.Size(0, 13);
            this.lblKeyError.TabIndex = 11;
            // 
            // lblPlaintextError
            // 
            this.lblPlaintextError.AutoSize = true;
            this.lblPlaintextError.Location = new System.Drawing.Point(274, 34);
            this.lblPlaintextError.Name = "lblPlaintextError";
            this.lblPlaintextError.Size = new System.Drawing.Size(0, 13);
            this.lblPlaintextError.TabIndex = 6;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(244, 142);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(181, 123);
            this.txtResult.TabIndex = 10;
            // 
            // pnlFrequency
            // 
            this.pnlFrequency.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFrequency.Controls.Add(this.pictureBox2);
            this.pnlFrequency.Location = new System.Drawing.Point(20, 142);
            this.pnlFrequency.Name = "pnlFrequency";
            this.pnlFrequency.Size = new System.Drawing.Size(218, 161);
            this.pnlFrequency.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 149);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.Image")));
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(255, 271);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(74, 32);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.Image")));
            this.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.Location = new System.Drawing.Point(335, 271);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(76, 32);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(107, 90);
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(318, 20);
            this.txtCiphertext.TabIndex = 5;
            this.txtCiphertext.TextChanged += new System.EventHandler(this.txtCiphertext_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(107, 51);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(318, 20);
            this.txtKey.TabIndex = 4;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(107, 11);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(318, 20);
            this.txtPlaintext.TabIndex = 3;
            this.txtPlaintext.TextChanged += new System.EventHandler(this.txtPlaintext_TextChanged);
            // 
            // LblCiphertext
            // 
            this.LblCiphertext.AutoSize = true;
            this.LblCiphertext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblCiphertext.Location = new System.Drawing.Point(17, 97);
            this.LblCiphertext.Name = "LblCiphertext";
            this.LblCiphertext.Size = new System.Drawing.Size(57, 13);
            this.LblCiphertext.TabIndex = 2;
            this.LblCiphertext.Text = "Cipher text";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKey.Location = new System.Drawing.Point(17, 54);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(84, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key (Shift value)";
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPlaintext.Location = new System.Drawing.Point(17, 14);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(50, 13);
            this.lblPlaintext.TabIndex = 0;
            this.lblPlaintext.Text = "Plain text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbTeknika);
            this.Controls.Add(this.lblTeknika);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Brute Force Attack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFrequency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTeknika;
        private System.Windows.Forms.Label lblTeknika;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label LblCiphertext;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Panel pnlFrequency;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCiphertextError;
        private System.Windows.Forms.Label lblKeyError;
        private System.Windows.Forms.Label lblPlaintextError;
    }
}

