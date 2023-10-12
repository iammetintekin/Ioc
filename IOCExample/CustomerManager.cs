using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCExample
{
    public class CustomerManager
    {
        private IMevzuat _mevzuat;
        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;            
        }

        public async Task Add()
        {
            Console.WriteLine(await _mevzuat.RunFunction()); 
        }
    }
}
