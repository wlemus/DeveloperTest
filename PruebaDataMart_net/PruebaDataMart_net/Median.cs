using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace PruebaDataMart_net
{
    public class Median
    {
        public static decimal find_median(int[] array_int)
        {
            decimal media = 0;
            try
            {
                if (array_int == null)
                    throw new Exception("Empty list");

                List<int> final_list_int = array_int.ToList().OrderBy(o=> o).ToList(); //order list
                int list_lenght = final_list_int.Count();
                
                int half_list = list_lenght/2;
                int mod_list = list_lenght % 2;

                if (mod_list == 0)
                {  //element list pair
                    media = ((decimal)final_list_int[half_list-1] + (decimal)final_list_int[half_list])/2;
                }
                else
                { //element not pair
                    media = final_list_int[half_list];
                }                               
            }
            catch (Exception ex)
            {
                Utils.show_message_console(ex.Message, 1);
            }
            return media;
        }


      


    }
}
