using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    public partial class RateForm : Form
    {
        public RateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            if ((textBoxSY.Text == "") || (textBoxWM.Text == ""))
            {
                MessageBox.Show("Введенные данные не корректны!", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int SY, WM;
            double S;
            if ((int.TryParse(textBoxSY.Text, out SY))
                && (int.TryParse(textBoxWM.Text, out WM)))
               // && ((SY > 0) && (WM > 0)))
            {
                try
                {
                    Rate rate = new Rate(SY, WM);
                    S = rate.Calculate();
                    textBoxS.AppendText(S.ToString());
                }
                catch ( MoneyExeption error)
                {
                    MessageBox.Show("Данные введены некорректно,должны быть больше 0");
                } 
            }
           /* else
            {
                MessageBox.Show("Введенные данные не корректны!", " error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
