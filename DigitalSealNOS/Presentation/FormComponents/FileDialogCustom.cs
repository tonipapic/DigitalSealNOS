using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.Presentation.FormComponents
{
    public static class FileDialogCustom 
    {
        public static string GetFilePath(string title=null)
        {
            FileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = title??"Odaberi datoteku";
            openFileDialog.ShowDialog();
            return openFileDialog.FileName; // Change Title to FileName to get the file path
        }
    }
}
