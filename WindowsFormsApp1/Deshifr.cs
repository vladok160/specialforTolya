using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Deshifr
    {
        static Dictionary<char, int> d1 = new Dictionary<char, int>();

        static Dictionary<char, double> arr_frequency = new Dictionary<char, double>();

        static Dictionary<char, double> sortdict;

        int lenofdict = 0;

        static char[] arr_letters = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж',
                       'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                       'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
                       'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', ' '};

        static char[] arr_encrypt_letters = { ' ', 'о', 'а', 'е', 'и', 'т', 'н', 'л',
            'р', 'с', 'в', 'к', 'м', 'д', 'у', 'п', 'б', 'г', 'ы', 'ч', 'ь',
            'з', 'я', 'й', 'х', 'ж', 'ш', 'ю', 'ф', 'э', 'щ', 'ё', 'ц', 'ъ' };

        public static void Count_letters(string string_for_decrypt)
        {
            char[] text_for_decrypt = string_for_decrypt.ToCharArray();

            for (int i = 0; i < text_for_decrypt.Length; i++)
            {
                char ch = text_for_decrypt[i];
                if (d1.ContainsKey(ch))
                    d1[ch]++;
                else
                    d1.Add(ch, 1);
            }
        }

        public static void Frequency(string string_for_decrypt)
        {
            Count_letters(string_for_decrypt);

            char[] text_for_decrypt = string_for_decrypt.ToCharArray();
            int count = text_for_decrypt.Length;

            foreach (KeyValuePair<char, int> entry in d1)
            {
                double frequency = Convert.ToDouble(entry.Value) / count * 100;
                arr_frequency.Add(entry.Key, frequency);
            }
        }

        public static string DeshifrText(string string_for_decrypt)
        {
            StringBuilder sb = new StringBuilder();
            Frequency(string_for_decrypt);

            char[] text_for_decrypt = string_for_decrypt.ToCharArray();

            //Символы по убыванию встречаемости в тексте
            sortdict = arr_frequency.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            //sortdict.ToList<>;
            //var sortlistofdict = arr_frequency.Keys.ToList();

            List<char> sortlist = new List<char>();

            foreach (KeyValuePair<char, double> entry in sortdict)
            {
                sortlist.Add(entry.Key);
            }

            foreach(char ch in string_for_decrypt)
            {
                sb.Append(DecriptSymbol(ch, sortlist));
            }

            //foreach (char ch in string_for_decrypt)
            //{
            //    sb.Append(sortdict[ch]);
            //}

            //char[] arr_encrypt_text = { };
            //Dictionary<char, char> zip = new Dictionary<char, char>();

            //foreach (KeyValuePair<char, double> entry in sortdict)
            //{
            //    str.Append(entry.Key)

            //    arr_frequency.Add(entry.Key, frequency);
            //}


            return sb.ToString();
        }

        public static char DecriptSymbol(char ch, List<char> sortlist)
        {
            return arr_encrypt_letters[sortlist.IndexOf(ch)];
        }
        public static int LenOfDict(Dictionary<char, double> dict)
        {
            int i = 0;
            foreach (KeyValuePair<char, double> entry in dict)
            {
                i++;
            }
            return i;
        }

        //def decrypt_text(text_for_decrypt, arr_decrypt_letters):
        //arr_encrypt_text = []
        //arr_encrypt_letters = [' ', 'о', 'а', 'е', 'и', 'т', 'н', 'л',
        //                               'р', 'с', 'в', 'к', 'м', 'д', 'у', 'п',
        //                               'б', 'г', 'ы', 'ч', 'ь', 'з', 'я', 'й',
        //                               'х', 'ж', 'ш', 'ю', 'ф', 'э', 'щ',
        //                               'ё', 'ц', 'ъ']
        //dictionary = dict(zip(arr_decrypt_letters, arr_encrypt_letters))
        //for i in text_for_decrypt:
        //    arr_encrypt_text.append(dictionary.get(i))
        //text_for_decrypt = ''.join(arr_encrypt_text)
        //print(text_for_decrypt)
    }
}
