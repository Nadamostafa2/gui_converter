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
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Binary b = new Binary(TxtBinary.Text);
            TxtDecimal.Text = b.convert_Dicimal().ToString();
            TxtOctal.Text = b.convert_octal().ToString();

        }
    }
    class Binary
    {
        private string binary;
        public Binary(String s)
        {
            bool f = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 0)
                {
                    if (s[i].Equals(1))
                        continue;

                    /*else{
                        MessageBox.Show("this number is refused");
                        f = false;
                        break;
                    }*/
                }
            }
            if (f)
                binary = s;

        }
        public double convert_octal()
        {
            int x;
            string z = " ";
            x = binary.Length % 3;
            if (x != 0)
            {
                x = binary.Length + (3 - x);
                x /= 3;
            }
            else
                x = binary.Length / 3;
            double total = 0;
            int w = binary.Length;
            for (int i = 0; i < x; ++i)
            {
                total = 0; // m4 bt5lih ykml loop lkbira
                for (int j = 0; j < 3; ++j)
                {
                    int y = binary[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                z += total.ToString();
                w = w - 3; // m4 bt5lih y4t3"l
            }
            double.Parse(total);
            return total;
        }
        public double convert_Hexadecimal()
        {
            int x;
            string z = " ";
            x = binary.Length % 4;
            if (x != 0)
            {
                x = binary.Length + (4 - x);
                x /= 4;
            }
            else
                x = binary.Length / 4;
            double total = 0;
            int w = binary.Length;
            for (int i = 0; i < x; ++i)
            {
                total = 0; // m4 bt5lih ykml loop lkbira
                for (int j = 0; j < 4; ++j)
                {
                    int y = binary[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                z += total.ToString();
                w = w - 4; // m4 bt5lih y4t3"l
            }
            double.Parse(total);
            return total;
        }
        public double convert_Dicimal()
        {
            double total = 0;
            for (int i = 0; i < binary.Length; ++i)
            {
                int x = binary[binary.Length - (i + 1)] - '0';
                total += x * Math.Pow(2, i);
            }
            return total;
        }
    }

    class Octal
    {
        private string octal;
        public Octal(String s)
        {
            bool f = true;
            char[] chararray = { '0', '1', '2', '3', '4', '5', '6', '7' };
            int i = 0;
            foreach (char c in chararray)
            {
                if (s.Contains(c))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("this number is refused");
                    f = false;
                    break;
                }
            }
            if (f)
                octal = s;
        }
        public double convert_binary()
        {
        }
        /*public double convert_Hexadecimal()
        {
            int x;
            string z = " ";
            x = octal.Length % 4;
            if (x != 0)
            {
                x = octal.Length + (4 - x);
                x /= 4;
            }
            else
                x = octal.Length / 4;
            double total = 0;
            int w = octal.Length;
            for (int i = 0; i < x; ++i)
            {
                total = 0; // m4 bt5lih ykml loop lkbira
                for (int j = 0; j < 4; ++j)
                {
                    int y = octal[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                z += total.ToString();
                w = w - 4; // m4 bt5lih y4t3"l
            }
            double.Parse(total);
            return total;
        }*/
        public double convert_decimal()
        {

            double total = 0;
            for (int i = 0; i < octal.Length; ++i)
            {
                int x = binary[binary.Length - (i + 1)] - '0';
                total += x * Math.Pow(8, i);
            }
            return total;
            
        }


    }

    class Decimal
    {
        string deciimal;
        Decimal(string s)
        {
            deciimal = s;
        }
        public double convert_binary()
        {
            int num = int.Parse(deciimal);
            int x = num % 2;
            while (x != 0)
            {
                num = num / 2;
                x = num % 2;
            }
        }
    }

}