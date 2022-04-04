using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        bool FirstWasErased = false;
        bool SecondWasErased = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            FirstNumber.Text = "123...";
            SecondNumber.Text = "456...";
        }


        private void Result_Function(int choice)
        {
            try
            {
                string first_n_t = FirstNumber.Text;
                string second_n_t = SecondNumber.Text;

                double first_n = Convert.ToDouble(first_n_t);
                double second_n = Convert.ToDouble(second_n_t);
                switch (choice)
                {
                    case 1:
                        {
                            Result.Text = Convert.ToString(first_n + second_n);
                            break;
                        }
                    case 2:
                        {
                            Result.Text = Convert.ToString(first_n - second_n);
                            break;
                        }
                    case 3:
                        {
                            Result.Text = Convert.ToString(first_n * second_n);
                            break;
                        }
                    case 4:
                        {
                            if (second_n == 0)
                            {
                                MessageBox.Show("На ноль делить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            Result.Text = Convert.ToString(first_n / second_n);
                            break;
                        }
                };
            }
            catch (FormatException) {
                MessageBox.Show("В полях должны быть цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
            
        }
        private void Plus_button_Click(object sender, EventArgs e)
        {
            Result_Function(1);
        }

        private void Button_clear(object sender, EventArgs e)
        {
            FirstNumber.Text = "";
            SecondNumber.Text = "";
            Result.Text = "";
        }

        private void Minus_button_Click(object sender, EventArgs e)
        {
            Result_Function(2);
        }

        private void Mul_button_Click(object sender, EventArgs e)
        {
            Result_Function(3);
        }

        private void Div_button_Click(object sender, EventArgs e)
        {
            Result_Function(4);
        }

        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNumber_Click(object sender, EventArgs e)
        {
            if (FirstWasErased == false)
            {
                FirstNumber.Text = "";
                FirstWasErased = true;
            }
        }

        private void SecondNumber_Click(object sender, EventArgs e)
        {
            if (SecondWasErased == false)
            {
                SecondNumber.Text = "";
                SecondWasErased = false;
            }
        }
    }
}
