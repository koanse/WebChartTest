using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebChartTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebChart.Chart cc = new WebChart.ChartControl();
            this.Controls.Add(cc);
        }
    }
}