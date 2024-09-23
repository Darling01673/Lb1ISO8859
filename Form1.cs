using System;
using System.Reflection;

namespace coding
{
    public partial class Form1 : Form
    {
        Dictionary<char, byte> iso8859_51 = new Dictionary<char, byte>
        {
            {'À', 0xB0}, {'Á', 0xB1}, {'Â', 0xB2}, {'Ã', 0xB3}, {'Ä', 0xB4},
            {'Å', 0xB5}, {'Æ', 0xB6}, {'Ç', 0xB7}, {'È', 0xB8}, {'É', 0xB9},
            {'Ê', 0xBA}, {'Ë', 0xBB}, {'Ì', 0xBC}, {'Í', 0xBD}, {'Î', 0xBE},
            {'Ï', 0xBF}, {'Ð', 0xC0}, {'Ñ', 0xC1}, {'Ò', 0xC2}, {'Ó', 0xC3},
            {'Ô', 0xC4}, {'Õ', 0xC5}, {'Ö', 0xC6}, {'×', 0xC7}, {'Ø', 0xC8},
            {'Ù', 0xC9}, {'Ú', 0xCA}, {'Û', 0xCB}, {'Ü', 0xCC}, {'Ý', 0xCD},
            {'Þ', 0xCE}, {'ß', 0xCF}, {'à', 0xD0}, {'á', 0xD1}, {'â', 0xD2},
            {'ã', 0xD3}, {'ä', 0xD4}, {'å', 0xD5}, {'æ', 0xD6}, {'ç', 0xD7},
            {'è', 0xD8}, {'é', 0xD9}, {'ê', 0xDA}, {'ë', 0xDB}, {'ì', 0xDC},
            {'í', 0xDD}, {'î', 0xDE}, {'ï', 0xDF}, {'ð', 0xE0}, {'ñ', 0xE1},
            {'ò', 0xE2}, {'ó', 0xE3}, {'ô', 0xE4}, {'õ', 0xE5}, {'ö', 0xE6},
            {'÷', 0xE7}, {'ø', 0xE8}, {'ù', 0xE9}, {'ú', 0xEA}, {'û', 0xEB},
            {'ü', 0xEC}, {'ý', 0xED}, {'þ', 0xEE}, {'ÿ', 0xEF}, {' ', 0xFF}
        };
        Dictionary<string, char> iso8859_52 = new Dictionary<string, char>
            {
                { "B0", 'À' }, { "B1", 'Á' }, { "B2", 'Â' }, { "B3", 'Ã' }, { "B4", 'Ä' },
                { "B5", 'Å' }, { "B6", 'Æ' }, { "B7", 'Ç' }, { "B8", 'È' }, { "B9", 'É' },
                { "BA", 'Ê' }, { "BB", 'Ë' }, { "BC", 'Ì' }, { "BD", 'Í' }, { "BE", 'Î' },
                { "BF", 'Ï' }, { "C0", 'Ð' }, { "C1", 'Ñ' }, { "C2", 'Ò' }, { "C3", 'Ó' },
                { "C4", 'Ô' }, { "C5", 'Õ' }, { "C6", 'Ö' }, { "C7", '×' }, { "C8", 'Ø' },
                { "C9", 'Ù' }, { "CA", 'Ú' }, { "CB", 'Û' }, { "CC", 'Ü' }, { "CD", 'Ý' },
                { "CE", 'Þ' }, { "CF", 'ß' }, { "D0", 'à' }, { "D1", 'á' }, { "D2", 'â' },
                { "D3", 'ã' }, { "D4", 'ä' }, { "D5", 'å' }, { "D6", 'æ' }, { "D7", 'ç' },
                { "D8", 'è' }, { "D9", 'é' }, { "DA", 'ê' }, { "DB", 'ë' }, { "DC", 'ì' },
                { "DD", 'í' }, { "DE", 'î' }, { "DF", 'ï' }, { "E0", 'ð' }, { "E1", 'ñ' },
                { "E2", 'ò' }, { "E3", 'ó' }, { "E4", 'ô' }, { "E5", 'õ' }, { "E6", 'ö' },
                { "E7", '÷' }, { "E8", 'ø' }, { "E9", 'ù' }, { "EA", 'ú' }, { "EB", 'û' },
                { "EC", 'ü' }, { "ED", 'ý' }, { "EE", 'þ' }, { "EF", 'ÿ' }, {"FF", ' '}
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
