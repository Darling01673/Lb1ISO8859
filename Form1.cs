using System;
using System.Reflection;

namespace coding
{
    public partial class Form1 : Form
    {
        Dictionary<char, byte> iso8859_51 = new Dictionary<char, byte>
        {
            {'�', 0xB0}, {'�', 0xB1}, {'�', 0xB2}, {'�', 0xB3}, {'�', 0xB4},
            {'�', 0xB5}, {'�', 0xB6}, {'�', 0xB7}, {'�', 0xB8}, {'�', 0xB9},
            {'�', 0xBA}, {'�', 0xBB}, {'�', 0xBC}, {'�', 0xBD}, {'�', 0xBE},
            {'�', 0xBF}, {'�', 0xC0}, {'�', 0xC1}, {'�', 0xC2}, {'�', 0xC3},
            {'�', 0xC4}, {'�', 0xC5}, {'�', 0xC6}, {'�', 0xC7}, {'�', 0xC8},
            {'�', 0xC9}, {'�', 0xCA}, {'�', 0xCB}, {'�', 0xCC}, {'�', 0xCD},
            {'�', 0xCE}, {'�', 0xCF}, {'�', 0xD0}, {'�', 0xD1}, {'�', 0xD2},
            {'�', 0xD3}, {'�', 0xD4}, {'�', 0xD5}, {'�', 0xD6}, {'�', 0xD7},
            {'�', 0xD8}, {'�', 0xD9}, {'�', 0xDA}, {'�', 0xDB}, {'�', 0xDC},
            {'�', 0xDD}, {'�', 0xDE}, {'�', 0xDF}, {'�', 0xE0}, {'�', 0xE1},
            {'�', 0xE2}, {'�', 0xE3}, {'�', 0xE4}, {'�', 0xE5}, {'�', 0xE6},
            {'�', 0xE7}, {'�', 0xE8}, {'�', 0xE9}, {'�', 0xEA}, {'�', 0xEB},
            {'�', 0xEC}, {'�', 0xED}, {'�', 0xEE}, {'�', 0xEF}, {' ', 0xFF}
        };
        Dictionary<string, char> iso8859_52 = new Dictionary<string, char>
            {
                { "B0", '�' }, { "B1", '�' }, { "B2", '�' }, { "B3", '�' }, { "B4", '�' },
                { "B5", '�' }, { "B6", '�' }, { "B7", '�' }, { "B8", '�' }, { "B9", '�' },
                { "BA", '�' }, { "BB", '�' }, { "BC", '�' }, { "BD", '�' }, { "BE", '�' },
                { "BF", '�' }, { "C0", '�' }, { "C1", '�' }, { "C2", '�' }, { "C3", '�' },
                { "C4", '�' }, { "C5", '�' }, { "C6", '�' }, { "C7", '�' }, { "C8", '�' },
                { "C9", '�' }, { "CA", '�' }, { "CB", '�' }, { "CC", '�' }, { "CD", '�' },
                { "CE", '�' }, { "CF", '�' }, { "D0", '�' }, { "D1", '�' }, { "D2", '�' },
                { "D3", '�' }, { "D4", '�' }, { "D5", '�' }, { "D6", '�' }, { "D7", '�' },
                { "D8", '�' }, { "D9", '�' }, { "DA", '�' }, { "DB", '�' }, { "DC", '�' },
                { "DD", '�' }, { "DE", '�' }, { "DF", '�' }, { "E0", '�' }, { "E1", '�' },
                { "E2", '�' }, { "E3", '�' }, { "E4", '�' }, { "E5", '�' }, { "E6", '�' },
                { "E7", '�' }, { "E8", '�' }, { "E9", '�' }, { "EA", '�' }, { "EB", '�' },
                { "EC", '�' }, { "ED", '�' }, { "EE", '�' }, { "EF", '�' }, {"FF", ' '}
             };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int count = 0;
            while (count < textBox1.Text.Length)
            {
                if (iso8859_51.ContainsKey(textBox1.Text[count]))
                {
                    textBox2.Text += iso8859_51[textBox1.Text[count]].ToString("X2") + " ";

                }
                count++;
            }
            count = 0;
            textBox2.Text += Environment.NewLine;
            while (count < textBox1.Text.Length)
            {
                if (iso8859_51.ContainsKey(textBox1.Text[count]))
                {

                    textBox2.Text += Convert.ToString(iso8859_51[textBox1.Text[count]], 2).PadLeft(8, '0') + " ";
                }
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
            string[] str = textBox1.Text.Split(new[] { ' ' });

            foreach (string bit in str)
            {
                if (iso8859_52.ContainsKey(bit))
                {
                    textBox2.Text += iso8859_52[bit];
                }
              
            }
        }
    }
}
