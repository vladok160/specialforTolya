using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Deshifr
    {
        public static string DeshifrText(string string_for_decrypt, string arr_decrypt_letters)
        {
            char[] text_for_decrypt = string_for_decrypt.ToCharArray();
            //Символы по убыванию встречаемости в русском языке
            char[] arr_encrypt_letters = { ' ', 'о', 'а', 'е', 'и', 'т', 'н', 'л', 'р', 'с', 'в', 'к', 'м', 'д', 'у', 'п', 'б', 'г', 'ы', 'ч', 'ь', 'з', 'я', 'й', 'х', 'ж', 'ш', 'ю', 'ф', 'э', 'щ', 'ё', 'ц', 'ъ' };
            char[] arr_encrypt_text = { };
            Dictionary<char, char> zip = new Dictionary<char, char>();
            return "ss";
        }
    }
}
