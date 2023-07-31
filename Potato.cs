using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// Potato.
/// </summary>
    internal class Potato : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Potato"/> class.
        /// </summary>
        /// <param name="weight">weight.</param>
        public Potato(double weight)
            : base("Potato", 82, weight)
        {
        }
    }
}
