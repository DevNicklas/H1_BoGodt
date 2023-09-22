using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static H1_BoGodt.Model.window.Window;

namespace H1_BoGodt.Model.window
{
    /// <summary>
    /// Class <see cref="ThreeBayWindow"/> represents a window with a triple bay
    /// </summary>
    internal class ThreeBayWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeBayWindow"/> class, using multiple arguments
        /// </summary>
        /// <param name="windowSupplier">window supplier</param>
        public ThreeBayWindow(EWindowSupplier windowSupplier)
        {
            Supplier = windowSupplier;
            Price = 4678;
            // Adds 25% to the price if the supplier is Vindbjerg
            if (windowSupplier == EWindowSupplier.Vindbjerg)
            {
                Price *= 1.25;
            }
        }
    }
}
