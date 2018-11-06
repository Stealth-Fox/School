using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxMinFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            decimal[] numberList = new decimal[10];
            decimal temp = 0;
            decimal max = 0;
            decimal min = 0;
            orderBox.Text = "";

            numberList[0] = numBox1.Value;
            numberList[1] = numBox2.Value;
            numberList[2] = numBox3.Value;
            numberList[3] = numBox4.Value;
            numberList[4] = numBox5.Value;
            numberList[5] = numBox6.Value;
            numberList[6] = numBox7.Value;
            numberList[7] = numBox8.Value;
            numberList[8] = numBox9.Value;
            numberList[9] = numBox10.Value;

            min = numberList[0];

            for (int i=0; i<10; i++)
            {
                temp = numberList[i];
                if (temp > max) { max = temp; }
                if (temp < min) { min = temp; }
            }

            maxBox.Text = max.ToString();
            minBox.Text = min.ToString();

            Array.Sort(numberList);

            for (int i = 0; i < 10; i++)
            {
                orderBox.Text = orderBox.Text + " " + numberList[i].ToString() + " /";
            }
        }
    }
}
