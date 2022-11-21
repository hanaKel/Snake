using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame

{
    class Settings
    {
        /// <summary>
        /// Lasnosti velikost in širina, katero potrebujemo za določitev koordinat kače, hrane in ovire
        /// </summary>
        public static int Width {get; set; }
        public static int Height {  get; set; }
        /// <summary>
        /// Premiki
        /// </summary>
        public static string directions;

        /// <summary>
        /// Začetni podatki
        /// </summary>
        public Settings()
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }


    }
}
