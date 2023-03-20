using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StevenEmployeeWageSystem
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public List<StevenRegular> listOfRegular = new List<StevenRegular>();
        public List<StevenTemporary> listOfTemporary = new List<StevenTemporary>();

        private void inputEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputEmployee formInputEmployee = new FormInputEmployee();
            formInputEmployee.Owner = this;
            formInputEmployee.ShowDialog();
        }

        private void displayEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayEmployee formDisplayEmployee = new FormDisplayEmployee();
            formDisplayEmployee.Owner = this;
            formDisplayEmployee.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
