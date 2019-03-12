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
            try
            {

            Binary b = new Binary(TxtBinary.Text);
            TxtDecimal.Text = b.convert_Dicimal().ToString();
            TxtOctal.Text = b.convert_octal().ToString();
            TxtHexa.Text = b.convert_Hexadecimal();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void BTN2_Click(object sender, EventArgs e)
        {
            Deciimal d = new Deciimal(TxtDecimal.Text);
            TxtBinary.Text = d.convert_binary();
            TxtOctal.Text = d.convert_Octal();
            TxtHexa.Text = d.convert_Hexa();
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            Octal o = new Octal(TxtOctal.Text);
            TxtDecimal.Text = o.convert_decimal().ToString();
            TxtBinary.Text = o.convert_binary();
            TxtHexa.Text = o.convert_Hexadecimal();
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            hexadecimal h = new hexadecimal(TxtHexa.Text);
            TxtDecimal.Text = h.convert_decimal().ToString();
            TxtBinary.Text = h.convert_binary();
            TxtOctal.Text = h.convert_Octal();
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
                if (s[i] != '0')
                {
                    if (s[i].Equals('1'))
                        continue;

                    else{
                        //MessageBox.Show("this number is refused");
                        //f = false;
                        //break;
                        throw new Exception("this number is refused");
                    }
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
                total = 0;
                for (int j = 0; j < 3; ++j)
                {
                    int y = binary[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                z += total.ToString();
                w = w - 3;
            }
            char[] reversed = z.Reverse().ToArray();
            z = "";
            for (int i = 0; i < reversed.Length; i++) z += reversed[i];
            return z;
        }

        public string convert_Hexadecimal()
        {
            int x;
            string z = "";
            x = binary.Length % 4;
            if (x != 0)
            {
                string leadingZeros = "";
                for (int i = 0; i < 4 - x; i++) leadingZeros += "0";
                binary = leadingZeros + binary;
            }
            x = binary.Length / 4;
            double total = 0;
            int w = binary.Length;
            for (int i = 0; i < x; ++i)
            {
                total = 0;
                for (int j = 0; j < 4; ++j)
                {
                    int y = binary[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                if (total > 9)
                {
                    z += (char)(total+55);
                }
                else z += total.ToString();
                w = w - 4;
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
                /*else
                {
                    MessageBox.Show("this number is refused");
                    f = false;
                    break;
                }*/
            }
            if (f)
                octal = s;
        }
        public string convert_binary()
        {
            //bytl3 ma2lob
            int Reminder;
            string oct = " ";

            for (int i = 0; i < octal.Length; ++i)
            {
                int num = octal[i];
                int a = 0;

                while (a != 3)
                {
                    Reminder = num % 2;
                    num = num / 2;
                    oct += Reminder;
                    a++;
                }

                oct += " ";

            }
            char[] reversed = oct.Reverse().ToArray();
            oct = "";
            for (int j = 0; j < reversed.Length; j++) oct += reversed[j];
            return oct;
        }
        public string convert_Hexadecimal()
        {
            octal = convert_binary();
            int x;
            string z = "";
            x = octal.Length % 4;
            if (x != 0)
            {
                string leadingZeros = "";
                for (int i = 0; i < 4 - x; i++) leadingZeros += "0";
                octal = leadingZeros + octal;
            }
            x = octal.Length / 4;
            double total = 0;
            int w = octal.Length;
            for (int i = 0; i < x; ++i)
            {
                total = 0;
                for (int j = 0; j < 4; ++j)
                {
                    int y = octal[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                if (total > 9)
                {

                    if (total == 10)
                    {
                        total = 'A';
                        total.ToString();
                    }
                    else if (total == 11)
                    {
                        total.ToString();
                        total = 'B';
                    }
                    else if (total == 12)
                        total = 'C';
                    else if (total == 13)
                        total = 'D';
                    else if (total == 14)
                        total = 'E';
                    else if (total == 15)
                        total = 'F';

                }
                z += total.ToString();
                w = w - 4;
            }
            char[] reversed = z.Reverse().ToArray();
            z = "";
            for (int i = 0; i < reversed.Length; i++) z += reversed[i];
            return z;

        }
        public double convert_decimal()
        {

            double total = 0;
            for (int i = 0; i < octal.Length; ++i)
            {
                int x = octal[octal.Length - (i + 1)] - '0';
                total += x * Math.Pow(8, i);
            }
            return total;
        }

    }
    class hexadecimal
    {
        private string hexa;
        public hexadecimal(String s)
        {
            bool f = true;
            char[] chararray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int i = 0;
            foreach (char c in chararray)
            {
                if (s.Contains(c))
                {
                    continue;
                }
                /*else
                {
                    MessageBox.Show("this number is refused");
                    f = false;
                    break;
                }*/
            }
            if (f)
                hexa = s;
        }
        public double convert_decimal()
        {
            int x;
            double total = 0;
            for (int i = 0; i < hexa.Length; ++i)
            {

                if (hexa[hexa.Length - (i + 1)].Equals('A')) x = 10;

                else if (hexa[hexa.Length - (i + 1)].Equals('B')) x = 11;
                else if (hexa[hexa.Length - (i + 1)].Equals('C')) x = 12;
                else if (hexa[hexa.Length - (i + 1)].Equals('D')) x = 13;
                else if (hexa[hexa.Length - (i + 1)].Equals('E')) x = 14;
                else if (hexa[hexa.Length - (i + 1)].Equals('F')) x = 15;
                else
                {
                    x = hexa[hexa.Length - (i + 1)] - '0';
                    total += x * Math.Pow(16, i);
                }
            }
            return total;
        }

        public string convert_binary()
        {
            int Reminder;
            string hex = " ";

            for (int i = 0; i < hexa.Length; ++i)
            {
                int num = hexa[i];
                int a = 0;

                while (a != 4)
                {
                    Reminder = num % 2;
                    num = num / 2;
                    hex += Reminder;
                    a++;
                }

                hex += " ";

            }
            char[] reversed = hex.Reverse().ToArray();
            hex = "";
            for (int j = 0; j < reversed.Length; j++) hex += reversed[j];
            return hex;
        }
        public string convert_Octal()
        {
            hexa = convert_binary();
            int x;
            string z = "";
            x = hexa.Length % 3;
            if (x != 0)
            {
                string leadingZeros = "";
                for (int i = 0; i < 3 - x; i++) leadingZeros += "0";
                hexa = leadingZeros + hexa;
            }
            x = hexa.Length / 3;
            double total = 0;
            int w = hexa.Length;
            for (int i = 0; i < x; ++i)
            {
                total = 0;
                for (int j = 0; j < 3; ++j)
                {
                    int y = hexa[w - (j + 1)] - '0';
                    total += y * Math.Pow(2, j);
                }
                z += total.ToString();
                w = w - 3;
            }
            char[] reversed = z.Reverse().ToArray();
            z = "";
            for (int i = 0; i < reversed.Length; i++) z += reversed[i];
            return z;

        }
    }

    class Deciimal
    {
        private string deciimal;
        public Deciimal(String s)
        {
            deciimal = s;
        }
        public string convert_binary()
        {
            int Reminder;
            string bin = " ";
            int num = int.Parse(deciimal);

            while (num != 0)
            {
                Reminder = num % 2;
                num = num / 2;
                bin += Reminder;
            }
            char[] reversed = bin.Reverse().ToArray();
            bin = "";
            for (int i = 0; i < reversed.Length; i++) bin += reversed[i];
            return bin;

        }
        public string convert_Octal()
        {
            int Reminder;
            string bin = " ";
            int num = int.Parse(deciimal);

            while (num != 0)
            {
                Reminder = num % 8;
                num = num / 8;
                bin += Reminder;
            }
            char[] reversed = bin.Reverse().ToArray();
            bin = "";
            for (int i = 0; i < reversed.Length; i++) bin += reversed[i];
            return bin;

        }

        public string convert_Hexa()
        {
            int Reminder;
            string bin = " ";
            int num = int.Parse(deciimal);

            while (num != 0)
            {
                Reminder = num % 16;
                num = num / 16;
                bin += Reminder;
            }
            char[] reversed = bin.Reverse().ToArray();
            bin = "";
            for (int i = 0; i < reversed.Length; i++) bin += reversed[i];
            return bin;

        }
    }
}


