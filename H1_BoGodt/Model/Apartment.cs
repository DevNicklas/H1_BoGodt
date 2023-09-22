using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BoGodt.Model
{
    /// <summary>
    /// Class <see cref="Apartment"/> represents a apartment, and uses different values which defines a apartment 
    /// </summary>
    internal class Apartment
    {
        private float _squareMeters;
        private Room _kitchen;
        private Room _bathroom;
        private Room _livingRoom;
        private List<Room> _extraRooms = new List<Room>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Apartment"/> class using multiple arguments, but with none extra rooms
        /// </summary>
        /// <param name="kitchen">kitchen of apartment</param>
        /// <param name="bathroom">bathroom of apartment</param>
        /// <param name="livingRoom">livingroom of apartment</param>
        internal Apartment(Room kitchen, Room bathroom, Room livingRoom)
        {
            _squareMeters = 40;
            _kitchen = kitchen;
            _bathroom = bathroom;
            _livingRoom = livingRoom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Apartment"/> class using multiple arguments, but with one extra room
        /// </summary>
        /// <param name="kitchen">kitchen of apartment</param>
        /// <param name="bathroom">bathroom of apartment</param>
        /// <param name="livingRoom">livingroom of apartment</param>
        internal Apartment(Room kitchen, Room bathroom, Room livingRoom, Room room1) : this(kitchen, bathroom, livingRoom)
        {
            _squareMeters = 55;
            _kitchen = kitchen;
            _bathroom = bathroom;
            _livingRoom = livingRoom;
            _extraRooms.Add(room1);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Apartment"/> class using multiple arguments, but with two extra rooms
        /// </summary>
        /// <param name="kitchen">kitchen of apartment</param>
        /// <param name="bathroom">bathroom of apartment</param>
        /// <param name="livingRoom">livingroom of apartment</param>
        internal Apartment(Room kitchen, Room bathroom, Room livingRoom, Room room1, Room room2) : this(kitchen, bathroom, livingRoom, room1)
        {
            _squareMeters = 70;
            _kitchen = kitchen;
            _bathroom = bathroom;
            _livingRoom = livingRoom;
            _extraRooms.Add(room2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Apartment"/> class using multiple arguments, but with three extra rooms
        /// </summary>
        /// <param name="kitchen">kitchen of apartment</param>
        /// <param name="bathroom">bathroom of apartment</param>
        /// <param name="livingRoom">livingroom of apartment</param>
        internal Apartment(Room kitchen, Room bathroom, Room livingRoom, Room room1, Room room2, Room room3) : this(kitchen, bathroom, livingRoom, room1, room2)
        {
            _squareMeters = 85;
            _kitchen = kitchen;
            _bathroom = bathroom;
            _livingRoom = livingRoom;
            _extraRooms.Add(room3);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Apartment"/> class using multiple arguments, but with four extra rooms
        /// </summary>
        /// <param name="kitchen">kitchen of apartment</param>
        /// <param name="bathroom">bathroom of apartment</param>
        /// <param name="livingRoom">livingroom of apartment</param>
        internal Apartment(Room kitchen, Room bathroom, Room livingRoom, Room room1, Room room2, Room room3, Room room4) : this(kitchen, bathroom, livingRoom, room1, room2)
        {
            _squareMeters = 110;
            _kitchen = kitchen;
            _bathroom = bathroom;
            _livingRoom = livingRoom;
            _extraRooms.Add(room4);
        }

        internal float SquareMeters
        {
            get { return _squareMeters; }
            private set { _squareMeters = value; }
        }

        internal Room Kitchen
        {
            get { return _kitchen; }
            private set { _kitchen = value; }
        }
        
        internal Room Bathroom
        {
            get { return _bathroom; }
            private set { _bathroom = value; }
        }

        internal Room LivingRoom
        {
            get { return _livingRoom; }
            private set { _livingRoom = value; }
        }

        internal List<Room> ExtraRooms
        {
            get { return _extraRooms; }
            private set { _extraRooms = value; }
        }

        internal string Print()
        {
            return $"Apartment:\nSquare meters: {_squareMeters}\n\nKitchen:\n{_kitchen.Print()}\n\nBathroom:\n{_bathroom.Print()}\n\nLiving room:\n{_livingRoom.Print()}";
        }
    }
}
