
using H1_BoGodt.Model.window;
using H1_BoGodt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BoGodt.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the main part of the program
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the controller
        /// </summary>
        internal void Start()
        {
            #region An apartment example with 0 extra rooms
            Window window = new TwoBayWindow(Window.EWindowSupplier.KHF);
            List<Window> windows = new List<Window>()
            {
                window
            };

            Apartment apartment = new Apartment
            (
                new Room(15, windows, new Floor(Floor.EFloorSuppliers.Supplier1)),
                new Room(10, windows, new Floor(Floor.EFloorSuppliers.Supplier2)),
                new Room(15, windows, new Floor(Floor.EFloorSuppliers.Supplier1))
            );
            #endregion
        }
    }
}
