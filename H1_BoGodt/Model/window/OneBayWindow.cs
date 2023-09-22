using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BoGodt.Model.window
{
    /// <summary>
    /// Class <see cref="OneBayWindow"/> represents a window with a single bay
    /// </summary>
    internal class OneBayWindow : Window
    {
        private bool _canOpen;
        private bool _isMatte;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneBayWindow"/> class, using multiple arguments
        /// </summary>
        /// <param name="windowSupplier">window supplier</param>
        /// <param name="isMatte">is the window matte or not</param>
        internal OneBayWindow(EWindowSupplier windowSupplier, bool isMatte)
        {
            Supplier = windowSupplier;
            Price = 1879;
            IsMatte = isMatte;
            CanOpen = false;

            // Adds 25% to the price if the supplier is Vindbjerg
            if (windowSupplier == EWindowSupplier.Vindbjerg)
            {
                Price *= 1.25;
            }

            // Adds 30% to the price if the window is matte
            if (isMatte)
            {
                Price *= 1.30;
            }
        }

        internal bool CanOpen
        {
            get { return _canOpen; }
            private set { _canOpen = value; }
        }

        internal bool IsMatte
        {
            get { return _isMatte; }
            private set { _isMatte = value; }
        }
    }
}
