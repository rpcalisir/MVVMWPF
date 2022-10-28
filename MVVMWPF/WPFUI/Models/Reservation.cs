using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class Reservation
    {
        public RoomID RoomId { get; }
        public string UserName { get; }

        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);
        public Reservation(RoomID roomId, string userName, DateTime startTime, DateTime endTime)
        {
            RoomId = roomId;
            UserName = userName;
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            if (!reservation.RoomId.Equals(RoomId))
            {
                return false;
            }

            return reservation.StartTime < EndTime || reservation.EndTime > StartTime;
        }
    }
}
