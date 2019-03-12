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
        public string convert_octal()
        {
            int x;
            string z = "";
            x = binary.Length % 3;
            if (x != 0)
            {
                string leadingZeros = "";
                for (int i = 0; i < 3 - x; i++) leadingZeros += "0";
                binary = leadingZeros + binary;
            }
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
                z += total.ToString(); // lw est5dmt += bygib error
                w = w - 3; // m4 bt5lih y4t3"l
            }

            char[] reversed = z.Reverse().ToArray();
            z = "";
            for (int i = 0; i < reversed.Length; i++) z += reversed[i];
            return z;
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
}
