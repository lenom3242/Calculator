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
           
        }


        private void Result_Function(int choice)
        {
            try
            {
                string first_n_t = FirstNumber.Text;
                string second_n_t = SecondNumber.Text;

                double first_n = Convert.ToDouble(first_n_t);
               if (second_n_t == "") { second_n_t = "0"; }
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
                    case 5:
                        {
                            Result.Text = Convert.ToString(Math.Sin(first_n));
                            break;
                        }
                    case 6:
                        {
                            Result.Text = Convert.ToString(Math.Cos(first_n));
                            break;
                        }
                    case 7:
                        {
                            Result.Text = Convert.ToString(Math.Sqrt(first_n));
                            break;
                        }
                    case 8:
                        {
                            Result.Text = Convert.ToString(Math.Pow(first_n, second_n));
                            break;
                        }
                    case 9:
                        {
                            Result.Text = Convert.ToString((first_n / second_n) * 100) + "%";
                            break;
                        }
                };
            }
            catch (FormatException) {
                MessageBox.Show("В полях должны быть цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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
                SecondWasErased = true;
            }
        }

        private void Sin_button_Click(object sender, EventArgs e)
        {
            Result_Function(5);
        }

        private void Cos_button_Click(object sender, EventArgs e)
        {
            Result_Function(6);
        }

        private void Sqrt_button_Click(object sender, EventArgs e)
        {
            //SecondNumber.Text = "0";
            Result_Function(7);
        }

        private void Sqr_button_Click(object sender, EventArgs e)
        {
            Result_Function(8);
        }



        private void Percent_button_Click(object sender, EventArgs e)
        {
            Result_Function(9);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
