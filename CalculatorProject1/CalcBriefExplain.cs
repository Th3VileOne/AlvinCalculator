﻿using System;
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
    public partial class CalcBriefExplain : Form
    {
        public CalcBriefExplain()
        {
            InitializeComponent();
            richTextBox1.Text = "This calculator does your simple calculator function along with the memory functions.";
        }
    }
}
