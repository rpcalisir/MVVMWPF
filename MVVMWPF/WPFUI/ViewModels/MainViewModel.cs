using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            SelectedViewModel = new MakeReservationViewModel(hotel);
        }
    }
}
