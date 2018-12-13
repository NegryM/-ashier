using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сashier.Model
{
   public class Check
    {
        private string number;
        private decimal summ;
        private int type;
        private bool close;

        public Check(string number)
        {
            this.number = number;
            this.summ = 0;
            this.type = 0;
            this.close = false;
        }
    }
}
