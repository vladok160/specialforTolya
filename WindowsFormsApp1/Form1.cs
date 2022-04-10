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
            // Cчитываем из файла сообщения
            string m = textBox1.Text;
            string k = textBox3.Text;

            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j, f; // Переменная для циклов
            int t = 0; // Преременная для нумерации символов ключа.

            char[] massage = m.ToCharArray(); // Превращаем сообщение в массив символов.
            char[] key = k.ToCharArray(); // Превращаем ключ в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы

                    // Ключ закончился - начинаем сначала.
                    if (t > key.Length - 1) { t = 0; }

                    // Ищем индекс буквы ключа
                    for (f = 0; f < alfavit.Length; f++)
                    {
                        if (key[t] == alfavit[f])
                        {
                            break;
                        }
                    }

                    t++;

                    if (f != 33) // Если f равно 33, значит символ не из алфавита
                    {
                        d = nomer + f;
                    }
                    else
                    {
                        d = nomer;
                    }

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            textBox2.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //public string rashifr(char[] text_for_decrypt, char[] arr_decrypt_letters)
        //{
        //    char[] arr_encrypt_letters = { ' ', 'о', 'а', 'е', 'и', 'т', 'н', 'л', 'р', 'с', 'в', 'к', 'м', 'д', 'у', 'п', 'б', 'г', 'ы', 'ч', 'ь', 'з', 'я', 'й', 'х', 'ж', 'ш', 'ю', 'ф', 'э', 'щ', 'ё', 'ц', 'ъ' };
        //    char[] arr_encrypt_text = { };
        //    Dictionary<char, char> zip = new Dictionary<char, char>();


        //}



    }
}
