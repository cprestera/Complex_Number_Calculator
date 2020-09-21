//*****************************************************************
// Name: Cameron Prestera
// CS-3260 Section 001
// Assignment: Lab04
// Date: 9/20/2020

// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will 
// receive a zero this project if I am found in violation of this policy
//******************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        ComplexData complexData1;
        ComplexData complexData2;
        ComplexData complexAnswer;
        ComplexArithmetic complexArithmetic;

        public Form1()
        {
            InitializeComponent();
            complexData1 = new ComplexData();
            complexData2 = new ComplexData();
            complexAnswer = new ComplexData();
            complexArithmetic = new ComplexArithmetic();
        }


        private void onClick(object sender, EventArgs e)
        {
            try
            {
                double realNum1 = Convert.ToDouble(realNum1TxtBox.Text.Trim());
                double realNum2 = Convert.ToDouble(realNum2TxtBox.Text.Trim());
                double imagNum1 = Convert.ToDouble(imagNum1TxtBox.Text.Trim());
                double imagNum2 = Convert.ToDouble(imagNum2TxtBox.Text.Trim());
                complexData1.setRealNumber(realNum1);
                complexData2.setRealNumber(realNum2);
                complexData1.setImagNumber(imagNum1);
                complexData2.setImagNumber(imagNum2);
            }
            catch(Exception)
            {
                MessageBox.Show("Error: Bad number input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((sender as Button).Text == "Add")
            {
                complexArithmetic.add(complexData1, complexData2, complexAnswer);
                updateView();
            } else if ((sender as Button).Text == "Subtract")
            {
                complexArithmetic.sub(complexData1, complexData2, complexAnswer);
                updateView();
            } else if ((sender as Button).Text == "Multiply")
            {
                complexArithmetic.mult(complexData1, complexData2, complexAnswer);
                updateView();
            } else if ((sender as Button).Text == "Divide")
            {
                complexArithmetic.div(complexData1, complexData2, complexAnswer);
                updateView();
            }

        }

        private void updateView()
        {
            realNumAnsTxtBox.Text = complexAnswer.getRealNumber().ToString("#.##");
            imagNumAnsTxtBox.Text = complexAnswer.getImagNumber().ToString("#.##");
           
        }
    }
}
