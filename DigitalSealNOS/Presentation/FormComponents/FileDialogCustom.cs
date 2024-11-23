using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.Presentation.FormComponents
{
    public static class FileDialogCustom 
    {
        public static string GetFilePath()
        {
            FileDialog openFileDialog = new OpenFileDialog(); // Change the type to OpenFileDialog
            openFileDialog.ShowDialog();
            return openFileDialog.FileName; // Change Title to FileName to get the file path
        }
    }
}
