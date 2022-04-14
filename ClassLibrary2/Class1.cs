using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Somme
    {
        public String ErrorMessage1 { get; set; }
        public String ErrorMessage2 { get; set; }
        public string sommeValue(string valeur1,string valeur2)
        {
            int valeur1 = 0;
            bool success = int.TryParse(txtval1.Text, out int valeur1);
            bool succ = int.TryParse(txtval2.Text, out int valeur2);
            if (success && succ)
            {
                ErrorMessage1="converted ";
            }
            else { ErrorMessage2="erreur"; }

            int btn = valeur1 + valeur2;
            res.Text = btn.ToString();
            return "(valeu1+valeur2).ToString()";
        }
    }
}
