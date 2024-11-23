namespace DigitalSealNOS
{
    partial class Form1
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
            btnGenerateKeys = new Button();
            btnEncryptFile = new Button();
            btnDecryptFile = new Button();
            btnSignFile = new Button();
            btnCalculateMessageSummary = new Button();
            btnCheckFileSignature = new Button();
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
            btnEncryptFile.Location = new Point(12, 70);
            btnEncryptFile.Name = "btnEncryptFile";
            btnEncryptFile.Size = new Size(234, 23);
            btnEncryptFile.TabIndex = 0;
            btnEncryptFile.Text = "Kriptiraj datoteku";
            btnEncryptFile.UseVisualStyleBackColor = true;
            btnEncryptFile.Click += btnEncryptFile_Click;
            // 
            // btnDecryptFile
            // 
            btnDecryptFile.Location = new Point(12, 113);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculateMessageSummary);
            Controls.Add(btnCheckFileSignature);
            Controls.Add(btnSignFile);
            Controls.Add(btnDecryptFile);
            Controls.Add(btnEncryptFile);
            Controls.Add(btnGenerateKeys);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerateKeys;
        private Button btnEncryptFile;
        private Button btnDecryptFile;
        private Button btnSignFile;
        private Button btnCalculateMessageSummary;
        private Button btnCheckFileSignature;
    }
}
