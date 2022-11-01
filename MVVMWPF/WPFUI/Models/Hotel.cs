using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }

        public Hotel(string name)
        {
            _reservationBook = new ReservationBook();
            Name = name;
        }

        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {
            return _reservationBook.GetReservationsForUser(userName);
        }

        /// <summary>
        /// Adds a new reservation into Reservation Book
        /// </summary>
        /// <param name="reservation"></param>
        /// <exception cref="ReservationConflictsException"></exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
