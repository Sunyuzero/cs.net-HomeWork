using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWinForm.orders
{
    public class stone
    {
        List <Goods> goodStone = new List<Goods>();
        public Goods GetGoods(string name)
        {
            foreach(Goods goods in goodStone)
            {
                if (goods.Name == name) return goods;
            }
            return null;
        }
    }
}
