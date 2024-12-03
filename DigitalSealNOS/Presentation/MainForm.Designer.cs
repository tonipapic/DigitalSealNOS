namespace DigitalSealNOS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnGenerateKeys = new Button();
            btnEncryptFile = new Button();
            btnDecryptFile = new Button();
            btnSignFile = new Button();
            btnCalculateMessageSummary = new Button();
            btnCheckFileSignature = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            radBtnSymmetric = new RadioButton();
            radBtnAsymmetric = new RadioButton();
            SuspendLayout();
            // 
            // btnGenerateKeys
            // 
            btnGenerateKeys.Location = new Point(12, 12);
            btnGenerateKeys.Name = "btnGenerateKeys";
            btnGenerateKeys.Size = new Size(234, 23);
            btnGenerateKeys.TabIndex = 0;
            btnGenerateKeys.Text = "Generiraj ključeve";
            btnGenerateKeys.UseVisualStyleBackColor = true;
            btnGenerateKeys.Click += btnGenerateKeys_Click;
            // 
            // btnEncryptFile
            // 
            btnEncryptFile.Location = new Point(12, 86);
            btnEncryptFile.Name = "btnEncryptFile";
            btnEncryptFile.Size = new Size(234, 23);
            btnEncryptFile.TabIndex = 0;
            btnEncryptFile.Text = "Kriptiraj datoteku";
            btnEncryptFile.UseVisualStyleBackColor = true;
            btnEncryptFile.Click += btnEncryptFile_Click;
            // 
            // btnDecryptFile
            // 
            btnDecryptFile.Location = new Point(12, 129);
            btnDecryptFile.Name = "btnDecryptFile";
            btnDecryptFile.Size = new Size(234, 23);
            btnDecryptFile.TabIndex = 0;
            btnDecryptFile.Text = "Dekriptiraj datoteku";
            btnDecryptFile.UseVisualStyleBackColor = true;
            btnDecryptFile.Click += btnDecryptFile_Click;
            // 
            // btnSignFile
            // 
            btnSignFile.Location = new Point(12, 266);
            btnSignFile.Name = "btnSignFile";
            btnSignFile.Size = new Size(234, 23);
            btnSignFile.TabIndex = 0;
            btnSignFile.Text = "Potpiši datoteku";
            btnSignFile.UseVisualStyleBackColor = true;
            btnSignFile.Click += btnSignFile_Click;
            // 
            // btnCalculateMessageSummary
            // 
            btnCalculateMessageSummary.Location = new Point(12, 190);
            btnCalculateMessageSummary.Name = "btnCalculateMessageSummary";
            btnCalculateMessageSummary.Size = new Size(234, 23);
            btnCalculateMessageSummary.TabIndex = 0;
            btnCalculateMessageSummary.Text = "Izračunaj sažetak poruke";
            btnCalculateMessageSummary.UseVisualStyleBackColor = true;
            btnCalculateMessageSummary.Click += btnCalculateMessageSummary_Click;
            // 
            // btnCheckFileSignature
            // 
            btnCheckFileSignature.Location = new Point(12, 310);
            btnCheckFileSignature.Name = "btnCheckFileSignature";
            btnCheckFileSignature.Size = new Size(234, 23);
            btnCheckFileSignature.TabIndex = 0;
            btnCheckFileSignature.Text = "Provjeri potpis";
            btnCheckFileSignature.UseVisualStyleBackColor = true;
            btnCheckFileSignature.Click += btnCheckFileSignature_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // radBtnSymmetric
            // 
            radBtnSymmetric.AutoSize = true;
            radBtnSymmetric.Checked = true;
            radBtnSymmetric.Location = new Point(16, 56);
            radBtnSymmetric.Name = "radBtnSymmetric";
            radBtnSymmetric.Size = new Size(191, 19);
            radBtnSymmetric.TabIndex = 1;
            radBtnSymmetric.TabStop = true;
            radBtnSymmetric.Text = "Simetrična enkripcija/dekripcija";
            radBtnSymmetric.UseVisualStyleBackColor = true;
            // 
            // radBtnAsymmetric
            // 
            radBtnAsymmetric.AutoSize = true;
            radBtnAsymmetric.Location = new Point(213, 56);
            radBtnAsymmetric.Name = "radBtnAsymmetric";
            radBtnAsymmetric.Size = new Size(198, 19);
            radBtnAsymmetric.TabIndex = 1;
            radBtnAsymmetric.TabStop = true;
            radBtnAsymmetric.Text = "Asimetrična enkripcija/dekripcija";
            radBtnAsymmetric.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radBtnAsymmetric);
            Controls.Add(radBtnSymmetric);
            Controls.Add(btnCalculateMessageSummary);
            Controls.Add(btnCheckFileSignature);
            Controls.Add(btnSignFile);
            Controls.Add(btnDecryptFile);
            Controls.Add(btnEncryptFile);
            Controls.Add(btnGenerateKeys);
            Name = "MainForm";
            Text = "Digital Seal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateKeys;
        private Button btnEncryptFile;
        private Button btnDecryptFile;
        private Button btnSignFile;
        private Button btnCalculateMessageSummary;
        private Button btnCheckFileSignature;
        private System.Windows.Forms.Timer timer1;
        private RadioButton radBtnSymmetric;
        private RadioButton radBtnAsymmetric;
    }
}
