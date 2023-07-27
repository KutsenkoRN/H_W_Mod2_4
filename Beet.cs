using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// Beet.
/// </summary>
    internal class Beet : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beet"/> class.
        /// </summary>
        /// <param name="weight">weight.</param>
        public Beet(double weight)
            : base("Beet", 43, weight)
        {
        }
    }
}
