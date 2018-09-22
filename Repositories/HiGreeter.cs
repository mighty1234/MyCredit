using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
   public class HiGreeter : IGreeter
    {

        public string SayHello()
        {
            return "Hi there!";
        }
    }
}
