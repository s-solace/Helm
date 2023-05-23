using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helm
{
    public static class FormHelper
    {
        public static T GetOpenForm<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T desiredForm)
                {
                    return desiredForm;
                }
            }

            return null;
        }
    }
}
