using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProgram
{
    public class Commodity
    {
        public Dictionary <string, int> dic = new Dictionary <string, int>();
        
        public Commodity()
        {
            dic.Add("apple", 5);
            dic.Add("banana", 2);
        }
        public override string ToString()
        {
            String str = "";
            foreach(String Key in dic.Keys)
            {
                str += "[ " + Key + "：" + dic[Key] + " ]\n";
            }
            return str;
        }
    }
}
