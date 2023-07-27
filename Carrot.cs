using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// Carrot.
/// </summary>
    internal class Carrot : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrot"/> class.
        /// </summary>
        /// <param name="weight">weight.</param>
        public Carrot(double weight)
            : base("Carrot", 32, weight)
        {
        }
    }
}
