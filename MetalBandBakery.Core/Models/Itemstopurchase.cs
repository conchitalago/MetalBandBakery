using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Core.Models
{
    public class Itemstopurchase
    {
        public static string[] ItemsToPurchase()
        {
            Console.WriteLine($@"Choose a product:
                            B  |  Brownie  |  0.65$
                            M  |  Mufflin  |  1.00$
                            C  | Cacke Pop |  1.35$
                            W  |   Water   |  1.50$");
            string[] keysPickUp = Console.ReadLine().ToUpper().Split(',');
            return keysPickUp;
        }

    }
}
