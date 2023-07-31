using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// for extension method.
/// </summary>
    internal static class Extension
    {/// <summary>
     /// Search for a vegetable.
     /// </summary>
     /// <param name="veget">type.</param>
     /// <param name="name">search.</param>
     /// <returns>Matching vegetables.</returns>
        public static Vegetable[] SearchForVegetables(this Vegetable[] veget, string name)
        {
            Vegetable[] extraArr = new Vegetable[veget.Length];
            int counter = 0;
            foreach (var vegetable in veget)
            {
                if (vegetable.Name == name)
                {
                    extraArr[counter++] = vegetable;
                }
            }

            Vegetable[] result = new Vegetable[counter];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = extraArr[i];
            }

            return result;
        }
    }
}
