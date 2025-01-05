namespace HashingAndEncryption
{
    partial class HashingAndEncryption
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
            label1 = new Label();
            txtInput = new TextBox();
            groupBox1 = new GroupBox();
            btnHashitNow = new Button();
            rbtnSHA256 = new RadioButton();
            rbtnMD5 = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBoxKey = new TextBox();
            rbtnSmart = new RadioButton();
            rbERMTAES = new RadioButton();
            rbtnRijManaged = new RadioButton();
            rbtnAES = new RadioButton();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            groupBox3 = new GroupBox();
            btnBaseDecode = new Button();
            btnBase64Encode = new Button();
            label3 = new Label();
            txtOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Text here :";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(180, 9);
            txtInput.MaxLength = 1000000;
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(914, 267);
            txtInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHashitNow);
            groupBox1.Controls.Add(rbtnSHA256);
            groupBox1.Controls.Add(rbtnMD5);
            groupBox1.Location = new Point(180, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 181);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hash Types";
            // 
            // btnHashitNow
            // 
            btnHashitNow.Location = new Point(66, 77);
            btnHashitNow.Name = "btnHashitNow";
            btnHashitNow.Size = new Size(138, 34);
            btnHashitNow.TabIndex = 2;
            btnHashitNow.Text = "Hash it Now";
            btnHashitNow.UseVisualStyleBackColor = true;
            // 
            // rbtnSHA256
            // 
            rbtnSHA256.AutoSize = true;
            rbtnSHA256.Location = new Point(150, 30);
            rbtnSHA256.Name = "rbtnSHA256";
            rbtnSHA256.Size = new Size(107, 29);
            rbtnSHA256.TabIndex = 1;
            rbtnSHA256.Text = "SHA 256";
            rbtnSHA256.UseVisualStyleBackColor = true;
            // 
            // rbtnMD5
            // 
            rbtnMD5.AutoSize = true;
            rbtnMD5.Checked = true;
            rbtnMD5.Location = new Point(3, 27);
            rbtnMD5.Name = "rbtnMD5";
            rbtnMD5.Size = new Size(118, 29);
            rbtnMD5.TabIndex = 0;
            rbtnMD5.TabStop = true;
            rbtnMD5.Text = "MD5 hash";
            rbtnMD5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxKey);
            groupBox2.Controls.Add(rbtnSmart);
            groupBox2.Controls.Add(rbERMTAES);
            groupBox2.Controls.Add(rbtnRijManaged);
            groupBox2.Controls.Add(rbtnAES);
            groupBox2.Controls.Add(btnDecrypt);
            groupBox2.Controls.Add(btnEncrypt);
            groupBox2.Location = new Point(496, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 181);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encryption Types";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 51);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 6;
            label2.Text = "Encryption PassPhrase";
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(151, 90);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(256, 31);
            textBoxKey.TabIndex = 4;
            // 
            // rbtnSmart
            // 
            rbtnSmart.AutoSize = true;
            rbtnSmart.Checked = true;
            rbtnSmart.Location = new Point(0, 108);
            rbtnSmart.Name = "rbtnSmart";
            rbtnSmart.Size = new Size(130, 29);
            rbtnSmart.TabIndex = 5;
            rbtnSmart.TabStop = true;
            rbtnSmart.Text = "SMART AES";
            rbtnSmart.UseVisualStyleBackColor = true;
            // 
            // rbERMTAES
            // 
            rbERMTAES.AutoSize = true;
            rbERMTAES.Location = new Point(0, 80);
            rbERMTAES.Name = "rbERMTAES";
            rbERMTAES.Size = new Size(118, 29);
            rbERMTAES.TabIndex = 4;
            rbERMTAES.TabStop = true;
            rbERMTAES.Text = "ERMT AES";
            rbERMTAES.UseVisualStyleBackColor = true;
            // 
            // rbtnRijManaged
            // 
            rbtnRijManaged.AutoSize = true;
            rbtnRijManaged.Location = new Point(0, 51);
            rbtnRijManaged.Name = "rbtnRijManaged";
            rbtnRijManaged.Size = new Size(89, 29);
            rbtnRijManaged.TabIndex = 3;
            rbtnRijManaged.TabStop = true;
            rbtnRijManaged.Text = "Rijdael";
            rbtnRijManaged.UseVisualStyleBackColor = true;
            // 
            // rbtnAES
            // 
            rbtnAES.AutoSize = true;
            rbtnAES.Location = new Point(0, 27);
            rbtnAES.Name = "rbtnAES";
            rbtnAES.Size = new Size(68, 29);
            rbtnAES.TabIndex = 2;
            rbtnAES.TabStop = true;
            rbtnAES.Text = "AES";
            rbtnAES.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(279, 143);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(112, 32);
            btnDecrypt.TabIndex = 1;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(23, 143);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(112, 32);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBaseDecode);
            groupBox3.Controls.Add(btnBase64Encode);
            groupBox3.Location = new Point(915, 297);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(179, 181);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Base-64 Encoding";
            // 
            // btnBaseDecode
            // 
            btnBaseDecode.Location = new Point(6, 87);
            btnBaseDecode.Name = "btnBaseDecode";
            btnBaseDecode.Size = new Size(167, 34);
            btnBaseDecode.TabIndex = 1;
            btnBaseDecode.Text = "Base-64 Decode";
            btnBaseDecode.UseVisualStyleBackColor = true;
            // 
            // btnBase64Encode
            // 
            btnBase64Encode.Location = new Point(3, 27);
            btnBase64Encode.Name = "btnBase64Encode";
            btnBase64Encode.Size = new Size(170, 34);
            btnBase64Encode.TabIndex = 0;
            btnBase64Encode.Text = "Base-64  Encode";
            btnBase64Encode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 491);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "OutPut :";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(170, 491);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(924, 160);
            txtOutput.TabIndex = 2;
            // 
            // HashingAndEncryption
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 663);
            Controls.Add(txtOutput);
            Controls.Add(label3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "HashingAndEncryption";
            Text = "HashingAndEncryption";
            Load += HashingAndEncryption_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private GroupBox groupBox1;
        private RadioButton rbtnSHA256;
        private RadioButton rbtnMD5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnHashitNow;
        private RadioButton rbtnSmart;
        private RadioButton rbERMTAES;
        private RadioButton rbtnRijManaged;
        private RadioButton rbtnAES;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private TextBox textBoxKey;
        private Button btnBaseDecode;
        private Button btnBase64Encode;
        private Label label2;
        private Label label3;
        private TextBox txtOutput;
    }
}