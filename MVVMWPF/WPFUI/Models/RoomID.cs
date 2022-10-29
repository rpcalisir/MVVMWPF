using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class RoomID
    {
        public int RoomNumber { get; }
        public int FloorNumber { get; }
        public RoomID(int roomNumber, int floorNumber)
        {
            RoomNumber = roomNumber;
            FloorNumber = floorNumber;
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID &&
                    RoomNumber == roomID.RoomNumber &&
                    FloorNumber == roomID.FloorNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RoomNumber, FloorNumber);
        }

        public override string ToString()
        {
            return RoomNumber.ToString() + "," + FloorNumber.ToString();
        }
    }
}
