using DigitalSealNOS.BusinessLogic;
using DigitalSealNOS.Presentation.FormComponents;

namespace DigitalSealNOS
{
    public partial class Form1 : Form
    {
        private GenerateKeys generateKeys;
        private EncryptDecryptFiles encryptDecryptFiles;
        private MessageCalculator messageCalculator;
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
            if(string.IsNullOrEmpty(inputFilePath)&&string.IsNullOrEmpty(outputFilePath))
                encryptDecryptFiles.EncryptFile(inputFilePath, outputFilePath);
        }

        

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi enkriptiranu datoteku koju želiš dekriptirati");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku u koju želiš spremiti dekriptirani sadržaj");
            if (string.IsNullOrEmpty(inputFilePath) && string.IsNullOrEmpty(outputFilePath))
                encryptDecryptFiles.DecryptFile(inputFilePath, outputFilePath);
        }

        private void btnCalculateMessageSummary_Click(object sender, EventArgs e)
        {
            string inputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku koju želiš izračunati");
            string outputFilePath = FileDialogCustom.GetFilePath("Odaberi datoteku u koju želiš spremiti izračunatu vrijednost");
            if (string.IsNullOrEmpty(inputFilePath) && string.IsNullOrEmpty(outputFilePath))
                messageCalculator.CalculateMessageSummary(inputFilePath, outputFilePath);
        }

        private void btnSignFile_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckFileSignature_Click(object sender, EventArgs e)
        {

        }

        
    }
}
