using DigitalSealNOS.BusinessLogic;
using DigitalSealNOS.Presentation.FormComponents;

namespace DigitalSealNOS
{
    public partial class Form1 : Form
    {
        private GenerateKeys generateKeys;
        private EncryptDecryptFiles encryptDecryptFiles;
        private MessageCalculator messageCalculator;
        private FileSignature fileSignature;
        private ComponentsClickabilityFunction componentsClickabilityFunction;

        public Form1()
        {
            InitializeComponent();
            InitClassObjects();
        }

        private void InitClassObjects()
        {
            generateKeys = new();
            encryptDecryptFiles = new();
            messageCalculator = new();
            fileSignature = new();
            componentsClickabilityFunction = new(this);
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                generateKeys.GenerateAndStoreKeys();
                MessageBox.Show("Ključevi uspješno generirani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku koju želiš enkriptirati");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku u koju želiš spremiti enkriptirani sadržaj");
            if (!string.IsNullOrEmpty(inputFilePath) && !string.IsNullOrEmpty(outputFilePath))
            { 
                if(radBtnSymmetric.Checked)
                    encryptDecryptFiles.EncryptFile(inputFilePath, outputFilePath);
                if (radBtnAsymmetric.Checked)
                    encryptDecryptFiles.EncryptFileAsymmetric(inputFilePath, outputFilePath);
            }
        }



        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi enkriptiranu datoteku koju želiš dekriptirati");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku u koju želiš spremiti dekriptirani sadržaj");
            if (!string.IsNullOrEmpty(inputFilePath) && !string.IsNullOrEmpty(outputFilePath))
            {
                if (radBtnSymmetric.Checked)
                {
                    encryptDecryptFiles.DecryptFile(inputFilePath, outputFilePath);
                }
                if (radBtnAsymmetric.Checked)
                {
                    encryptDecryptFiles.DecryptFileAsymmetric(inputFilePath, outputFilePath);
                }
            }
        }

        private void btnCalculateMessageSummary_Click(object sender, EventArgs e)
        {

            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku koju želiš izračunati");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku u koju želiš spremiti izračunatu vrijednost");
            if (!string.IsNullOrEmpty(inputFilePath) && !string.IsNullOrEmpty(outputFilePath))
                messageCalculator.CalculateMessageSummary(inputFilePath, outputFilePath);
        }

        private void btnSignFile_Click(object sender, EventArgs e)
        {
            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku koju želiš potpisat");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku u koju želiš spremiti potpis");
            if (!string.IsNullOrEmpty(inputFilePath) && !string.IsNullOrEmpty(outputFilePath))
                fileSignature.SignFile(inputFilePath, outputFilePath);
        }

        private void btnCheckFileSignature_Click(object sender, EventArgs e)
        {
            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi potpisanu datoteku");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi potpis");
            if (!string.IsNullOrEmpty(inputFilePath) && !string.IsNullOrEmpty(outputFilePath))
            {
                if (fileSignature.VerifyFileSignature(inputFilePath, outputFilePath))
                    MessageBox.Show("Potpis je validan");
                else
                    MessageBox.Show("Potpis nije validan");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            componentsClickabilityFunction.ManageFormButtonsEnablebility(enabled: generateKeys.DoKeysExist());

        }

      
    }
}
