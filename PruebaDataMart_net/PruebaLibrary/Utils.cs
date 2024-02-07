using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDataMart_net
{
    public static class Utils
    {
        public  enum nodeOrientationType { Left, Right }
        public enum nodeStateType { isLeaf,hasChild, hasChildren }
       
        public static string remove_accents_string(string original_string)
        {
            StringBuilder stringB_whithout_accents = new StringBuilder();
            foreach (char c in original_string.Normalize(NormalizationForm.FormD))
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringB_whithout_accents.Append(c);
            }

            return stringB_whithout_accents.ToString();
        }

        public static void show_message_console(string message, int type = 0)
        {
            System.Diagnostics.Debug.WriteLine((type == 1 ? "Error: " : "Notification") + message);
        }
    }
}
