using DigitalSealNOS.BusinessLogic;
using DigitalSealNOS.Presentation.FormComponents;

namespace DigitalSealNOS
{
    public partial class Form1 : Form
    {
        private GenerateKeys generateKeys;
        private EncryptDecryptFiles encryptDecryptFiles;
        public Form1()
        {
            InitializeComponent();
            InitClassObjects();
        }

        private void InitClassObjects()
        {
            generateKeys = new();
            encryptDecryptFiles = new();
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
            string inputFilePath = FileDialogCustom.GetFilePath();
            string outputFilePath = FileDialogCustom.GetFilePath();

            encryptDecryptFiles.EncryptFile(inputFilePath, outputFilePath);
        }

        

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateMessageSummary_Click(object sender, EventArgs e)
        {

        }

        private void btnSignFile_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckFileSignature_Click(object sender, EventArgs e)
        {

        }

        
    }
}
