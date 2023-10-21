using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        // GET: J1
        /// <summary>
        /// Calculates the total calorie count for a meal based on menu item selections.
        /// </summary>
        /// <param name="burger">The index of the chosen burger item.</param>
        /// <param name="drink">The index of the chosen drink item.</param>
        /// <param name="side">The index of the chosen side order item.</param>
        /// <param name="dessert">The index of the chosen dessert item.</param>
        /// <returns>The total calorie count for the selected meal.</returns>


        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            // Define the calorie values for menu items
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };

            if (burger < 1 || burger > 4 || drink < 1 || drink > 4 || side < 1 || side > 4 || dessert < 1 || dessert > 4)
            {
                return "Invalid menu item selection";
            }

            // Calculate the total calories
            int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];

            return "Your total calorie count is " + totalCalories;
        }
    }
}