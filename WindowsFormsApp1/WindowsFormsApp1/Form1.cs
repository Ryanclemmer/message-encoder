using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string f = textBox2.Text;
            string result = new string(f.Select(r => (char)(r + 2)).ToArray());
            char[] array = result.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char let = array[i];
                 if (let == ' ')
                    array[i] = '3';
                else if (let == 'a')
                    array[i] = 'e';
                else if (let == 'b')
                    array[i] = 'q';
                else if (let == 'c')
                    array[i] = 'i';
                else if (let == 'd')
                    array[i] = 'p';
                else if (let == 'e')
                    array[i] = 'y';
                else if (let == 'f')
                    array[i] = 'a';
                else if (let == 'g')
                    array[i] = 'v';
                else if (let == 'h')
                    array[i] = 'r';
                else if (let == 'i')
                    array[i] = 'f';
                else if (let == 'j')
                    array[i] = '1';
                else if (let == 'k')
                    array[i] = '9';
                else if (let == 'l')
                    array[i] = 'u';
                else if (let == 'm')
                    array[i] = '@';
                else if (let == 'o')
                    array[i] = '}';
                else if (let == 'p')
                    array[i] = '/';
                else if (let == 'q')
                    array[i] = 'o';
                else if (let == 'r')
                    array[i] = '*';
                else if (let == 's')
                    array[i] = 't';
                else if (let == 't')
                    array[i] = '+';
                else if (let == 'u')
                    array[i] = ':';
                else if (let == 'v')
                    array[i] = '?';
                else if (let == 'w')
                    array[i] = 'z';
                else if (let == 'x')
                    array[i] = '(';
                else if (let == 'y')
                    array[i] = '6';
                else if (let == 'z')
                    array[i] = '#';

            }
            string result1 = new string(array);
            textBox2.Text = result1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            char[] array = textBox3.Text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char let = array[i];
                if (let == '3')
                    array[i] = ' ';
                else if (let == 'e')
                    array[i] = 'a';
                else if (let == 'q')
                    array[i] = 'b';
                else if (let == 'i')
                    array[i] = 'c';
                else if (let == 'p')
                    array[i] = 'd';
                else if (let == 'y')
                    array[i] = 'e';
                else if (let == 'a')
                    array[i] = 'f';
                else if (let == 'v')
                    array[i] = 'g';
                else if (let == 'r')
                    array[i] = 'h';
                else if (let == 'f')
                    array[i] = 'i';
                else if (let == '1')
                    array[i] = 'j';
                else if (let == '9')
                    array[i] = 'k';
                else if (let == 'u')
                    array[i] = 'l';
                else if (let == '@')
                    array[i] = 'm';
                else if (let == '}')
                    array[i] = 'o';
                else if (let == '/')
                    array[i] = 'p';
                else if (let == 'o')
                    array[i] = 'q';
                else if (let == '*')
                    array[i] = 'r';
                else if (let == 't')
                    array[i] = 's';
                else if (let == '+')
                    array[i] = 't';
                else if (let == ':')
                    array[i] = 'u';
                else if (let == '?')
                    array[i] = 'v';
                else if (let == 'z')
                    array[i] = 'w';
                else if (let == '(')
                    array[i] = 'x';
                else if (let == '6')
                    array[i] = 'y';
                else if (let == '#')
                    array[i] = 'z';

            }
            string result1 = new string(array);
            string f = result1;
            string result = new string(f.Select(r => (char)(r - 2)).ToArray());
            textBox3.Text = result;
        }
    }
}
