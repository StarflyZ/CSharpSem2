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
    public partial class FormInputEmployee : Form
    {
        public FormInputEmployee()
        {
            InitializeComponent();
        }
        FormMenu formMenu;
        private void FormInputEmployee_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string employeeId = textBoxId.Text;
            string employeeName = textBoxName.Text;
            int basicSalary = int.Parse(textBoxBasicSalary.Text);
            listBoxInfo.Items.Clear();
            if (radioButtonRegular.Checked)
            {
                int numOfChild = (int)numericUpDownNumberOfChildren.Value;
                StevenRegular dataRegular = new StevenRegular(employeeId, employeeName, basicSalary, numOfChild);
                formMenu.listOfRegular.Add(dataRegular);
                listBoxInfo.Items.AddRange(dataRegular.Display().Split('\n'));

            }
            else
            {
                DateTime startingWorkDate = dateTimePickerStartDate.Value;
                DateTime endWorkDate = dateTimePickerEndDate.Value;
                StevenTemporary dataTemp = new StevenTemporary(employeeId, employeeName, basicSalary,
                    startingWorkDate, endWorkDate);
                formMenu.listOfTemporary.Add(dataTemp);
                listBoxInfo.Items.AddRange(dataTemp.Display().Split('\n'));
            }
            textBoxId.Text = textBoxName.Text = textBoxBasicSalary.Text = "";
            textBoxId.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
