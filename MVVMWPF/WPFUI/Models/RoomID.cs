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
            bool result = obj is RoomID roomID &&
                    RoomNumber == roomID.RoomNumber &&
                    FloorNumber == roomID.FloorNumber;

            return result;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RoomNumber, FloorNumber);
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null)
            {
                return true;
            }
            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }

        public override string ToString()
        {
            return RoomNumber.ToString() + "," + FloorNumber.ToString();
        }
    }
}
