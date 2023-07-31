using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_4
{/// <summary>
/// Base abstract class.
/// </summary>
    internal abstract class Vegetable
    {
        private readonly string name;
        private readonly double calorie;
        private readonly double weight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vegetable"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="calorie">calories.</param>
        /// <param name="weight">weight.</param>
        public Vegetable(string name, double calorie, double weight)
        {
            this.name = name;
            this.calorie = calorie;
            this.weight = weight;
        }

        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets calorie.
        /// </summary>
        public double Calorie
        {
            get { return this.calorie; }
        }

        /// <summary>
        /// Gets weight.
        /// </summary>
        public double Weight
        {
            get { return this.weight; }
        }

        /// <summary>
        /// All propertiens of vegetable.
        /// </summary>
        /// <returns>All info about vegetable.</returns>
        public string GetInfo()
        {
            string info = string.Empty;
            info = $"Name: {this.Name}\nCalorie: {this.Calorie}\nWeight: {this.Weight}\n";
            return info;
        }

        /// <summary>
        /// Get calories.
        /// </summary>
        /// <returns>result.</returns>
        public double CalcCalories()
        {
            double cal = this.weight * this.calorie;
            return cal;
        }
    }
}
