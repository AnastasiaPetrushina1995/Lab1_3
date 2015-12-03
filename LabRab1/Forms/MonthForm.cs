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
    public partial class MonthForm : Form
    {
        public MonthForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            if ((textBoxSM.Text == "") || (textBoxWD.Text == "") || (textBoxND.Text == ""))
            {
                MessageBox.Show("Введенные данные не корректны!", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            int SalaryMounth,WorkedDay,NeededDay;
            double S = 0;
            if ((int.TryParse(textBoxSM.Text, out SalaryMounth))
                && (int.TryParse(textBoxWD.Text, out WorkedDay))
                && (int.TryParse(textBoxND.Text, out NeededDay)))
            {
               // if ((SalaryMounth > 0) && (WorkedDay > 0) && (NeededDay > 0))
               // {
                    try
                    {
                        Month month = new Month(SalaryMounth, NeededDay, WorkedDay);
                        S = month.Calculate();
                        textBoxS.AppendText(S.ToString());
                    }
                    catch (MoneyExeption error)
                    {
                        MessageBox.Show("Данные введены некорректно,должны быть больше 0");
                    } 
               // }
              /*  else
                {
                    MessageBox.Show("Введенные данные не корректны!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            else
            {
                MessageBox.Show("Введенные данные не корректны!", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
