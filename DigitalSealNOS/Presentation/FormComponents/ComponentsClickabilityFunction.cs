using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.Presentation.FormComponents
{
    public class ComponentsClickabilityFunction
    {
        private Form Form = new Form();
        public ComponentsClickabilityFunction(Form form)
        {
            Form = form;
        }
       
        public void ManageFormButtonsEnablebility(bool enabled)
        {
            Form.Controls.OfType<Button>().ToList().ForEach(button => {
                if(!button.Name.ToLower().Contains("generate"))
                    button.Enabled = enabled;
            });
        }
    }
}
