using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Exceptions;

namespace WPFUI.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {
            return _reservations.Where(r => r.UserName == userName);
        }

        /// <summary>
        /// Adds a new reservation into Reservation Book
        /// </summary>
        /// <param name="reservation"></param>
        /// <exception cref="ReservationConflictsException"></exception>
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictsException(existingReservation, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}
