using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject1
{
    public partial class binaryConvert : Form
    {
        public binaryConvert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double result = 0;
            for(int i = 0; i< textBox1.Text.Length; i++)
            {
               // if (i == 0 && textBox1.Text.ElementAt(textBox1.Text.Length - 1 - i).Equals("1"))
                //{
                //    result += 1; }
                if (textBox1.Text.ElementAt(textBox1.Text.Length - 1 - i) == '1')
                {
                    result += Math.Pow(2, i);
                }
            }

            textBox2.Text = Convert.ToString((int) result);
           /* int numb;
            int two = 1;
            int result = 0;
            char[] chars;
            if (textBox1.Text.Length > 0 && Int32.TryParse(textBox1.Text, out numb)) {

                int digits = textBox1.Text.Length;
                for (int i = 1; i < digits; i++) {
                    two *= 2;
                }
                chars = textBox1.Text.ToCharArray();

                for (int j = 0; j < chars.Length; j++) {
                    switch (chars[j]) {
                        case '0': {
                                //do nothing
                                break;
                            }
                        case '1': {
                                result += 1 * two;
                                break;
                            }
                        default: {
                                break;
                            }
                    }
                    two /= 2;
                } //END OF FOR LOOP

                textBox2.Text = result.ToString();
            }//END OF IF
            */


        }
    }
}
