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

        public DateTime StartDate { get; }
        public DateTime EndDate { get; } 
        public TimeSpan Length => EndDate.Subtract(StartDate);
        public Reservation(RoomID roomId, string userName, DateTime startTime, DateTime endTime)
        {
            RoomId = roomId;
            UserName = userName;
            StartDate = startTime;
            EndDate = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomId == RoomId)
            {
                return true;
            }

            bool result = reservation.StartDate < EndDate && reservation.EndDate > StartDate;
            return result;
        }
    }
}
