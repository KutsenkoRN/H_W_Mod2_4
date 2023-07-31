using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// Cucumber.
/// </summary>
    internal class Cucumber : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cucumber"/> class.
        /// </summary>
        /// <param name="weight">weight.</param>
        public Cucumber(double weight)
            : base("Cucumber", 43, weight)
        {
        }
    }
}
