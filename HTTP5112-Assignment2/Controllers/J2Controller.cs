using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HTTP5112_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        // GET: J2
        /// <summary>
        /// Calculates the number of ways to roll a sum of 10 with two dice.
        /// </summary>
        /// <param name="m">The number of sides on the first die.</param>
        /// <param name="n">The number of sides on the second die.</param>
        /// <returns>The total number of ways to roll a sum of 10 with the given dice.</returns>
        

        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string GetDiceGame(int m, int n)
        {
            int count = 0;

            for (int D1 = 1; D1 <= m; D1++)
            {
                for (int D2 = 1; D2 <= n; D2++)
                {
                    if (D1 + D2 == 10)
                    {
                        count++;
                    }
                }
            }

            return "There are " + count + " total ways to get the sum 10.";
              
        }
    }
}