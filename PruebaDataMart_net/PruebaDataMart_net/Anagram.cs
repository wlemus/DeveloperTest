using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PruebaDataMart_net
{
    public static class Anagram
    {
        public static bool isAnagram(string string1, string string2)
        {
            bool is_anagram = false;
            try
            {
                //remove accents and convert to upper strings
                string string1_c = Utils.remove_accents_string(string1.ToLower());
                string string2_c = Utils.remove_accents_string(string2.ToLower());

                ValidateStrings(string1_c, string2_c);
                List<char> charList_1 = string1_c.ToCharArray().ToList().OrderBy(o=> o).ToList();
                List<char> charList_2 = string2_c.ToCharArray().ToList().OrderBy(o => o).ToList();
                                

                if (new string(charList_1.ToArray()) == new string(charList_2.ToArray()))
                    is_anagram = true;
            }
            catch (Exception ex)
            {
                Utils.show_message_console(ex.Message, 1);
            }
            return is_anagram;
        }


        private static void ValidateStrings(string string1, string string2)
        {

            if (string1 == string.Empty || string2 == string.Empty)
                throw new Exception("Strings are requiered.");

            if (string1.Length != string2.Length)
                throw new Exception("Strings must be the same size.");

        }

    }
}
