using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// salad.
/// </summary>
    internal class Salad
    {
        private Vegetable[] vegetables;
        private int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="Salad"/> class.
        /// </summary>
        /// <param name="capacity">Number of vegetables.</param>
        public Salad(int capacity)
        {
            this.vegetables = new Vegetable[capacity];
            this.count = 0;
        }

        /// <summary>
        /// Gets number of ingerients.
        /// </summary>
        public int Capacity
        {
            get
            {
                return this.vegetables.Length;
            }
        }

        /// <summary>
        /// Adding Vegetables to a salad.
        /// </summary>
        /// <param name="vegetable">Success message.</param>
        /// <returns>Message about successeful operation.</returns>
        public string AddVegetable(Vegetable vegetable)
        {
            if (this.count < this.vegetables.Length)
            {
                this.vegetables[this.count] = vegetable;
                this.count++;
                return $"You successfully added new {vegetable.Name}.";
            }
            else
            {
                return "Salad can't be expanded anymore.";
            }
        }

        /// <summary>
        /// Info your salad.
        /// </summary>
        /// <returns>info.</returns>
        public string SaladPreparation()
        {
            double allCalories = 0;
            string res = string.Empty;
            res += $"Your salad contains {this.vegetables.Length} vegetablse.\n";
            for (int i = 0; i < this.vegetables.Length; i++)
            {
                res += $"{this.vegetables[i].GetInfo()}\n";
                allCalories += this.vegetables[i].CalcCalories();
            }

            res += $"Calories in the salad: {allCalories}\n";
            return res;
        }

        /// <summary>
        /// descending order.
        /// </summary>
        /// <param name="vegetable">vegetable.</param>
        /// <param name="weight">weight.</param>
        /// <returns>info.</returns>
        public string SortByWeight(Vegetable vegetable, double weight)
        {
            if (vegetable.Weight <= weight)
            {
                return this.AddVegetable(vegetable);
            }

            return "Vegetable is too big.";
        }
    }
}
