
using H1_BoGodt.Model.window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BoGodt.Model
{
    /// <summary>
    /// Class <see cref="Room"/> represents a room, and uses different values which defines a room 
    /// </summary>
    internal class Room
    {
        private float _squareMeters;
        private List<Window> _windows;
        private Floor _floor;

        /// <summary>
        /// Initializes a new instance of the <see cref="Room"/> class, using multiple arguments
        /// </summary>
        /// <param name="squareMeters"></param>
        /// <param name="windows"></param>
        /// <param name="floor"></param>
        /// <param name="doors"></param>
        internal Room(float squareMeters, List<Window> windows, Floor floor)
        {
            _squareMeters = squareMeters;
            _windows = windows;
            _floor = floor;
        }

        internal string Print()
        {
            return $"Square meters: {_squareMeters}\nWindows: {_windows.Count}\nFloor: {_floor.FloorType}";
        }
    }
}
