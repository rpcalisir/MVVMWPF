using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFUI.Exceptions;
using WPFUI.Models;
using WPFUI.ViewModels;

namespace WPFUI.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;

            //Creation of event subscriber for PropertyChanged event, to be able to capture when PropertyChanged event is raised to understand Username is changed.
            _makeReservationViewModel.PropertyChanged += _makeReservationViewModel_PropertyChanged;
        }

        /// <summary>
        /// If this event subscriber method is called, it means PropertyChanged event was raised,
        /// which means UserName property is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _makeReservationViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //If changed property's name is UserName, then run OnExecuteChanged event subscriber method,
            //to invoke CanExecuteChanged event so CanExecute method is runned again and button can be enabled.
            if (e.PropertyName == nameof(_makeReservationViewModel.UserName))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            //Makes sure UserName is entered before enabling Submit button to be clicked.
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            try
            {
                _hotel.MakeReservation(new Reservation(new RoomID(_makeReservationViewModel.RoomNumber, _makeReservationViewModel.FloorNumber), _makeReservationViewModel.UserName, _makeReservationViewModel.StartDate, _makeReservationViewModel.EndDate));
                MessageBox.Show("Reservation is created successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictsException)
            {
                MessageBox.Show("Reservation is already existed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
