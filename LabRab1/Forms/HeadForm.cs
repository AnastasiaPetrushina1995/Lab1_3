using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }
        
        private void buttonHours_Click(object sender, EventArgs e)
        {
            HoursForm hoursForm = new HoursForm();
            hoursForm.Show();
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            MonthForm monthForm = new MonthForm();
            monthForm.Show();
        }

        private void buttonParall_Click(object sender, EventArgs e)
        {
            RateForm rateForm = new RateForm();
            rateForm.Show();
        }
    }
}
