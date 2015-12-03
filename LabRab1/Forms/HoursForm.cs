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
    public partial class HoursForm : Form
    {
        public HoursForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            if ((textBoxSH.Text == "") || (textBoxWH.Text == ""))
            {
                MessageBox.Show("Введенные данные не корректны!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int SH, WH;
            double S = 0;
            if ((int.TryParse(textBoxSH.Text, out SH)) 
                && (int.TryParse(textBoxWH.Text, out WH)))
            {
              //  if ((SH > 0) && (WH > 0))

                    try
                {
                    Hours hours = new Hours(SH, WH);
                    S = hours.Calculate();
                    textBoxS.AppendText(S.ToString());
                }
                    catch ( MoneyExeption error)
                        {
                            MessageBox.Show("Данные введены некорректно,должны быть больше 0");
                        } 
              /*   else
                {
                    MessageBox.Show("Значения полей должны быть больше нуля.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } */
            } 
        }

        public int SH { get; set; }

        public int WH { get; set; }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
