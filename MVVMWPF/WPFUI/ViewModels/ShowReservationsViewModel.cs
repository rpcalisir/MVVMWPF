using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShowReservationsViewModel: BaseViewModel
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }


        public ShowReservationsViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 1), "Recep", new DateTime(2022, 10, 10), new DateTime(2022, 10, 11))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 1), "Recep2", new DateTime(2022, 11, 11), new DateTime(2022, 11, 12))));
        }
    }
}
