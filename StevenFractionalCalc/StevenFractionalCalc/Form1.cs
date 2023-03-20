using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StevenFractionalCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //StevenFracNumcs result = fract1.Multiply(fract2);
                StevenFracNumcs result = fract1 * fract2;
                listBoxInfo.Items.Add(num1 + "/" + denom1 + " * " + num2 + "/" + denom2+" = "
                    +result.Numerator+"/"+result.Denominator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //StevenFracNumcs result = fract1.Div(fract2);
                StevenFracNumcs result = fract1 / fract2;
                listBoxInfo.Items.Add(num1 + "/" + denom1 + " / " + num2 + "/" + denom2 + " = "
                    + result.Numerator + "/" + result.Denominator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //StevenFracNumcs result = fract1.Add(fract2);
                StevenFracNumcs result = fract1 + fract2;
                listBoxInfo.Items.Add(num1 + "/" + denom1 + " + " + num2 + "/" + denom2 + " = "
                    + result.Numerator + "/" + result.Denominator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSubstraction_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //StevenFracNumcs result = fract1.Subs(fract2);
                StevenFracNumcs result = fract1 - fract2;
                listBoxInfo.Items.Add(num1 + "/" + denom1 + " - " + num2 + "/" + denom2 + " = "
                    + result.Numerator + "/" + result.Denominator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            textBoxFract1Num.Text = textBoxFract1Denom.Text = textBoxFract2Num.Text =
                textBoxFract2Denom.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //bool equal = fract1.IsEqual(fract2);
                if (fract1 == fract2)
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " == " + num2 + "/" + denom2);
                }
                else
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " != " + num2 + "/" + denom2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGreater_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //bool equal = fract1.IsEqual(fract2);
                if (fract1 > fract2)
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " > " + num2 + "/" + denom2);
                }
                else
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " <= " + num2 + "/" + denom2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //bool equal = fract1.IsEqual(fract2);
                if (fract1 < fract2)
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " < " + num2 + "/" + denom2);
                }
                else
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " >= " + num2 + "/" + denom2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGreaterEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //bool equal = fract1.IsEqual(fract2);
                if (fract1 >= fract2)
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " >= " + num2 + "/" + denom2);
                }
                else
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " < " + num2 + "/" + denom2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLowerEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //bool equal = fract1.IsEqual(fract2);
                if (fract1 <= fract2)
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " <= " + num2 + "/" + denom2);
                }
                else
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " > " + num2 + "/" + denom2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNotEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxFract1Num.Text);
                int denom1 = int.Parse(textBoxFract1Denom.Text);
                int num2 = int.Parse(textBoxFract2Num.Text);
                int denom2 = int.Parse(textBoxFract2Denom.Text);
                StevenFracNumcs fract1 = new StevenFracNumcs(num1, denom1);
                StevenFracNumcs fract2 = new StevenFracNumcs(num2, denom2);
                //bool equal = fract1.IsEqual(fract2);
                if (fract1 != fract2)
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " != " + num2 + "/" + denom2);
                }
                else
                {
                    listBoxInfo.Items.Add(num1 + "/" + denom1 + " == " + num2 + "/" + denom2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StevenFracNumcs fract = new StevenFracNumcs();
            StevenFracNumcs result = new StevenFracNumcs();           
            result = -fract;

            MessageBox.Show(result.ToString());
        }
    }
}
