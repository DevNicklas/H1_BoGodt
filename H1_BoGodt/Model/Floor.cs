using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BoGodt.Model
{
    /// <summary>
    /// Class <see cref="Floor"/> represents a floor with a certain floor type
    /// </summary>
    internal class Floor
    {
        private EFloorSuppliers _supplier;
        private EFloorTypes _floorType;

        private const double _pricePerSqm = 179;

        /// <summary>
        /// Initializes a new instance of the <see cref="Floor"/> class.
        /// </summary>
        internal Floor(EFloorSuppliers supplier)
        {
            _supplier = supplier;
            _floorType = EFloorTypes.Laminate;
        }

        internal EFloorTypes FloorType
        {
            get { return _floorType; }
            private set { _floorType = value; }
        }

        internal enum EFloorSuppliers
        {
            Supplier1 = 1,
            Supplier2
        }

        internal enum EFloorTypes
        {
            Laminate = 1
        }
    }
}
