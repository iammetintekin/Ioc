using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCExample
{
    public class FirstMevzuat  : IMevzuat
    {
        public async Task<string> RunFunction()
        {
            return "First mevzuat run";
        }
    }
}
