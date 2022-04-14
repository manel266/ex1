using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class valider : Form
    {
        public valider()
        {
            InitializeComponent();
            



        }

        private void vlr_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Somme instance = new Somme();
            res.Text = instance.sommeValue(txtval1.Text, txtval2.Text);
            if(instance.ErrorMessage1 !=null)
            {
                MessageBox.Show(instance.ErrorMessage1);
            }
                if(instance.ErrorMessage2 !=null)
            {
                MessageBox.Show(instance.errorMessage2);
            }
            //String valeur1 = txtval1.Text;
            //String valeur2 = txtval2.Text;
            //int valider = int.Parse(valeur1) + int.Parse(valeur2);
            //res.Text = valider.ToString();
            //res.Text=(int.Parse(txtval1.Text)+int.Parse(txtval2.Text)).ToString();

           

        }
    }
}
