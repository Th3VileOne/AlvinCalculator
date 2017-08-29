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
    public partial class Form1 : Form
    {
        double total = 0;
         String[] stringToCalculate = new String[30];
        double[] dubs = new double[2]; //doubles
        String[] ops = new String[2]; //integers
        Boolean hasOps = false;
        double k = 0;
        double mValue = 0;
        
        public Boolean equals_ck = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 2;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 3;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 4;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 5;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 6;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 7;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 8;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox1.Text += 9;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();    
            richTextBox1.Text += 0;

        }
        private void reset() {
            if(equals_ck == true)
            {
                richTextBox2.Clear();
                Array.Clear(dubs, 0, dubs.Length);
                Array.Clear(ops, 0, ops.Length);
                Array.Clear(stringToCalculate, 0, stringToCalculate.Length);

                equals_ck = false;
            }
        }
        private int check_numba() {
            int indexer = -1;
            if (richTextBox2.Find("1") != -1)
            {
                indexer = richTextBox2.Find("1");
            }
            else if (richTextBox2.Find("2") != -1)
            {
                indexer = richTextBox2.Find("2");
            }
            else if (richTextBox2.Find("3") != -1)
            {
                indexer = richTextBox2.Find("3");
            }
            else if (richTextBox2.Find("4") != -1)
            {
                indexer = richTextBox2.Find("4");
            }
            else if (richTextBox2.Find("5") != -1)
            {
                indexer = richTextBox2.Find("5");
            }
            else if (richTextBox2.Find("6") != -1)
            {
                indexer = richTextBox2.Find("6");
            }
            else if (richTextBox2.Find("7") != -1)
            {
                indexer = richTextBox2.Find("7");
            }
            else if (richTextBox2.Find("8") != -1)
            {
                indexer = richTextBox2.Find("8");
            }
            else if (richTextBox2.Find("9") != -1)
            {
                indexer = richTextBox2.Find("9");
            }
            else if (richTextBox2.Find("0") != -1)
            {
                indexer = richTextBox2.Find("0");
            }
            else {
            }


            return indexer;
        } // find number in richtextBox2

        private int check_operator()
        {
            equals_ck = false;
            int test = -1;
            if (richTextBox2.Find("-") != -1)
            {
                test = richTextBox2.Find("-");
            }
            else if (richTextBox2.Find("+") != -1)
            {
                test = richTextBox2.Find("+");
            }
            else if (richTextBox2.Find("*") != -1)
            {
                test = richTextBox2.Find("*");
            }
            else if (richTextBox2.Find("/") != -1)
            {
                test = richTextBox2.Find("/");
            }
            else if (richTextBox2.Find("^") != -1)
            {
                test = richTextBox2.Find("^");
            }
            else if (richTextBox2.Find("mod") != -1) {
                test = richTextBox2.Find("mod");
            }
            else
            {
            }
            return test;
        } // find operator in richtextBox2

        private void yPower_Click(object sender, EventArgs e)
        {
            int co = check_operator();
            String a = richTextBox2.Text;
            if (co > 0 && co != a.Length - 1)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + " ^ ";
            }
            else if (co > 0)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + "^" + a.Substring(co + 1, a.Length - 1);
            }
            else
            {
                richTextBox2.Text += richTextBox1.Text;
                richTextBox2.Text += " ^ ";
                richTextBox1.Clear();
            }
        }//POWER SIGN
        private void modBtn_Click(object sender, EventArgs e) // MOD SIGN
        {
            int co = check_operator();
            String a = richTextBox2.Text;
            if (co > 0 && co != a.Length - 1)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + " mod ";
            }
            else if (co > 0)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + "mod" + a.Substring(co + 1, a.Length - 1);
            }
            else
            {
                richTextBox2.Text += richTextBox1.Text;
                richTextBox2.Text += " mod ";
                richTextBox1.Clear();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int co = check_operator();
            String a = richTextBox2.Text;
            if (co > 0 && co != a.Length-1)
            {
                richTextBox2.Text = a.Substring(0,co-1)+ " + " ;
            }
            else if (co > 0)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + "+" + a.Substring(co + 1, a.Length - 1);
            }
            else
            {
                richTextBox2.Text += richTextBox1.Text;
                richTextBox2.Text += " + ";
                richTextBox1.Clear();
            }
        }//PLUS SIGN

        private void button12_Click(object sender, EventArgs e)
        {
            int co = check_operator();
            String a = richTextBox2.Text;
            if (co > 0 && co != a.Length - 1)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + " - ";
            }
            else if (co > 0)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + "-" + a.Substring(co + 1, a.Length - 1);
            }
            else
            {
                richTextBox2.Text += richTextBox1.Text;
                richTextBox2.Text += " - ";
                richTextBox1.Clear();
            }
        }//MINUS SIGN

        private void button13_Click(object sender, EventArgs e)
        {
            int co = check_operator();
            String a = richTextBox2.Text;
            if (co > 0 && co != a.Length - 1)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + " * ";
            }
            else if (co > 0)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + "*" + a.Substring(co + 1, a.Length - 1);
            }
            else
            {
                richTextBox2.Text += richTextBox1.Text;
                richTextBox2.Text += " * ";
                richTextBox1.Clear();
            }
        }//MULTIPLY SIGN

        private void button14_Click(object sender, EventArgs e)
        {
            int co = check_operator();
            String a = richTextBox2.Text;
            if (co > 0 && co != a.Length - 1)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + " / ";
            }
            else if (co > 0)
            {
                richTextBox2.Text = a.Substring(0, co - 1) + "/" + a.Substring(co + 1, a.Length - 1);
            }
            else
            {
                richTextBox2.Text += richTextBox1.Text;
                richTextBox2.Text += " / ";
                richTextBox1.Clear();
            }
        }//DIVIDE SIGN

        // "=" sign vvvvv
        private void button15_Click(object sender, EventArgs e)
        {
            reset();
            richTextBox2.Text += richTextBox1.Text;
            richTextBox1.Clear();

            if (check_operator() == -1)
            {

            }
            else {
                char[] separatingChars = { ' ' };
                double num;
                int t = 0; //counter for dubs array
                int y = 0; //counter for ops array 
                stringToCalculate = richTextBox2.Text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
                //richTextBox1.Text += stringToCalculate[2];
                // vvv Try to Convert possibles to Int//
                for (int i = 0; i < stringToCalculate.Length; i++)
                {
                    if (Double.TryParse(stringToCalculate[i], out num))
                    {
                        dubs[t] = Convert.ToDouble(stringToCalculate[i]);
                        t++;
                    }
                    else
                    {
                        ops[y] = stringToCalculate[i];
                        y++;
                    }
                }

                //richTextBox1.Text += ops[0];
                int t1 = 0;
                int y1 = 0;
                double k = 0;
                k = Calculate(ops[y1], dubs[t1], dubs[t1 + 1]);
                richTextBox2.Text = k.ToString();
                richTextBox1.Clear();
                equals_ck = true;
            }

           
            
        }//EQUAL SIGN

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public double Calculate(String x, double a, double b) {
                double k = 0;
                switch (x) {
                    case ("+"): {
                            k = a + b;
                            break;
                        }
                    case ("-"):
                        {
                            k = a - b;
                            break;
                        }
                    case ("*"):
                        {
                            k = a * b;
                            break;
                        }
                    case ("/"):
                        {
                            k = a / b;
                            break;
                        }
                    case ("^"): {
                        k = a;
                        for (int i = 1; i < b; i++) {
                            k = k * a; 
                        }
                        break;
                    }
                case ("mod"): {
                        k = a % b;
                        break;
                    }
                    default: {
                            break;
                        }
                }
                return k;
            }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0) {
                richTextBox1.Text += "0.";
            }else if (richTextBox1.Find(".") == -1) {
                richTextBox1.Text += ".";
            }
        }

        private void secondPower_Click(object sender, EventArgs e)
        {
            String rtb1 = richTextBox1.Text;
            String rtb2 = richTextBox2.Text;
            double num;
            if (richTextBox1.Text.Length > 0 && Double.TryParse(rtb1, out num))
            {
                double p = Convert.ToDouble(rtb1);
                richTextBox2.Text = (p * p).ToString();
                richTextBox1.Clear();
            }
            else if (richTextBox2.Text.Length > 0 && Double.TryParse(rtb2, out num))
            {
                double p = Convert.ToDouble(rtb2);
                richTextBox2.Text = (p * p).ToString();
            }
            else {

            }
        }

        private void thirdPower_Click(object sender, EventArgs e)
        {
            String rtb1 = richTextBox1.Text;
            String rtb2 = richTextBox2.Text;
            double num;
            if (richTextBox1.Text.Length > 0 && Double.TryParse(rtb1, out num))
            {
                double p = Convert.ToDouble(rtb1);
                richTextBox2.Text = (p * p * p).ToString();
                richTextBox1.Clear();
            }
            else if (richTextBox2.Text.Length > 0 && Double.TryParse(rtb2, out num))
            {
                double p = Convert.ToDouble(rtb2);
                richTextBox2.Text = (p * p * p).ToString();
            }
            else
            {

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void tenPowered_Click(object sender, EventArgs e)
        {
            String rtb1 = richTextBox1.Text;
            String rtb2 = richTextBox2.Text;
            double k = 10;
            double j;
            double num;
           
            if (richTextBox1.Text.Length > 0 && Double.TryParse(rtb1, out num)) {
                j = Convert.ToDouble(rtb1);
                for (int i = 1; i < j; i++) {
                    k = k * 10;
                }
                richTextBox2.Text = k.ToString();
                richTextBox1.Clear();
            } else if (richTextBox2.Find(" + ") == -1 &&
               richTextBox2.Find(" - ") == -1 &&
               richTextBox2.Find(" * ") == -1 &&
               richTextBox2.Find(" / ") == -1 &&
               richTextBox2.Find(" ^ ") == -1)
            {

                j = Convert.ToDouble(rtb2);
                for (int i = 1; i < j; i++)
                {
                    k = k * 10;
                }
                richTextBox2.Text = k.ToString();
                richTextBox1.Clear();
            }

        }

        private void clearEntire_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            memoryTxtBox.Clear();
            reset();
        }

        private void mcBtn_Click(object sender, EventArgs e)
        {
            memoryTxtBox.Clear();
            mValue = 0;
        }

        private void mPlus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                if (check_operator() == -1)
                {
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    mValue += convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox1.Clear();
                }
                else
                {
                    richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.Text.Length - 3);
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    mValue += convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox1.Clear();
                }

            }
            else if (richTextBox2.Text.Length > 0) {
                if (check_operator() == -1)
                {
                    double convert = Convert.ToDouble(richTextBox2.Text);
                    mValue += convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox1.Clear();
                }
                else if (richTextBox2.Text.Length >= 3 && check_operator() == -1)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox2.Text.Length - 3);
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    mValue += convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox2.Clear();
                }
            }
            
        }

        private void mMinus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                if (check_operator() == -1)
                {
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    mValue -= convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox1.Clear();
                }
                else
                {
                    richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox2.Text.Length - 3);
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    mValue -= convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox1.Clear();
                }

            }
            else if (richTextBox2.Text.Length > 0)
            {
                if (check_operator() == -1)
                {
                    double convert = Convert.ToDouble(richTextBox2.Text);
                    mValue -= convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox1.Clear();
                }
                else if (richTextBox2.Text.Length >= 3 && check_operator() == -1)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox2.Text.Length - 3);
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    mValue -= convert;
                    memoryTxtBox.Text = mValue.ToString();
                    richTextBox2.Clear();
                }
            }
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                if (check_operator() == -1)
                {
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    richTextBox2.Text = Math.Exp(convert).ToString();
                    richTextBox1.Clear();
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 3);
                    double convert = Convert.ToDouble(richTextBox1.Text);
                    richTextBox2.Text = Math.Exp(convert).ToString();
                    richTextBox1.Clear();
                }

            }
            else if (richTextBox2.MaxLength > 0) {
                if (richTextBox2.Text.Length > 0) {
                    double convert = Convert.ToDouble(richTextBox2.Text);
                    richTextBox2.Text = Math.Exp(convert).ToString();
                    richTextBox1.Clear();
                }
                else
                {
                    richTextBox2.Text = richTextBox2.Text.Substring(0, richTextBox1.Text.Length - 3);
                    double convert = Convert.ToDouble(richTextBox2.Text);
                    richTextBox2.Text = Math.Exp(convert).ToString();
                    richTextBox1.Clear();
                }

            }
        }

     
    }


}
