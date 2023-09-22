using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BoGodt.Model.window
{
    /// <summary>
    /// Class <see cref="Window"/> represents a window
    /// </summary>
    internal abstract class Window
    {
        private EWindowSupplier _supplier;
        private double _price;

        internal enum EWindowSupplier
        {
            KHF = 1,
            Vindbjerg
        }

        internal EWindowSupplier Supplier
        {
            get { return _supplier; }
            private protected set { _supplier = value; }
        }

        internal double Price
        {
            get { return _price; }
            private protected set { _price = value; }
        }
    }
}
