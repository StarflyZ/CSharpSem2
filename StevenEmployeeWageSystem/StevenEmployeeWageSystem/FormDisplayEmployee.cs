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
    public partial class FormDisplayEmployee : Form
    {
        public FormDisplayEmployee()
        {
            InitializeComponent();
        }
        FormMenu formMenu;

        private void FormDisplayEmployee_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
        }
        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("====Data Employee Regular====");
            foreach(StevenRegular dataRegular in formMenu.listOfRegular)
            {
                listBoxInfo.Items.AddRange(dataRegular.Display().Split('\n'));
            }
            listBoxInfo.Items.Add("====Data Employee Temporary====");
            foreach (StevenTemporary dataTemp in formMenu.listOfTemporary)
            {
                listBoxInfo.Items.AddRange(dataTemp.Display().Split('\n'));
            }
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("====Data Employee Regular====");
            foreach(StevenRegular dataRegular in formMenu.listOfRegular)
            {
                listBoxInfo.Items.AddRange(dataRegular.Display().Split('\n'));
            }
        }

        private void radioButtonTemporary_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("====Data Employee Temporary====");
            foreach(StevenTemporary dataTemp in formMenu.listOfTemporary)
            {
                listBoxInfo.Items.AddRange(dataTemp.Display().Split('\n'));
            }
        }
    }
}
