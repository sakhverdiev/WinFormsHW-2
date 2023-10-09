using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW_2
{
    public partial class Form1 : Form
    {
        private char _op;
        private bool _isClearScreen;
        private int _firstNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num0Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "0";
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "1";
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "2";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "3";
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "4";
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "5";
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "6";
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "7";
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "8";
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            if (_isClearScreen)
            {
                screenLabel.Text = "";
                _isClearScreen = false;
            }

            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "9";
        }

        private void L_BracketsButton_Click(object sender, EventArgs e)
        {
        }

        private void R_BracketsButton_Click(object sender, EventArgs e)
        {
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _op = '+';
            _isClearScreen = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int secondNumber = Convert.ToInt32(screenLabel.Text);
            int result;

            switch (_op)
            {
                case '+':
                    result = _firstNumber + secondNumber;
                    break;
                case '-':
                    result = _firstNumber - secondNumber;
                    break;
                case '\u00d7':
                    result = _firstNumber * secondNumber;
                    break;
                case '\u00f7':
                    result = _firstNumber / secondNumber;
                    break;
                default:
                    result = _firstNumber;
                    break;
            }

            screenLabel.Text = Convert.ToString(result);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            _op = '-';
            _isClearScreen = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _op = '\u00d7';
            _isClearScreen = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            _op = '\u00f7';
            _isClearScreen = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }
    }
}