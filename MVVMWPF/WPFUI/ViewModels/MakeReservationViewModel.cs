using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.Commands;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class MakeReservationViewModel: BaseViewModel
    {
		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set 
			{
                //If OnPropertyChanged event subscriber method is called before setting the value, then UserName property will return null after something is typed in TextBox.
                //OnPropertyChanged(nameof(UserName));
				_userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

		private int _floorNumber;

		public int FloorNumber
		{
			get { return _floorNumber; }
            set
            {
                OnPropertyChanged(nameof(FloorNumber));
                _floorNumber = value;
            }
        }

		private int _roomNumber;

		public int RoomNumber
		{
			get { return _roomNumber; }
            set
            {
                OnPropertyChanged(nameof(RoomNumber));
                _roomNumber = value;
            }
        }

		private DateTime _startDate;

		public DateTime StartDate
		{
			get { return _startDate; }
            set
            {
                OnPropertyChanged(nameof(StartDate));
                _startDate = value;
            }
        }

		private DateTime _endDate;

		public DateTime EndDate
		{
			get { return _endDate; }
            set
            {
                OnPropertyChanged(nameof(EndDate));
                _endDate = value;
            }
        }

		public ICommand SubmitCommand { get; }
		public ICommand CancelCommand { get; }

		public MakeReservationViewModel(Hotel hotel)
		{
			SubmitCommand = new MakeReservationCommand(this, hotel); 
		}

	}
}
