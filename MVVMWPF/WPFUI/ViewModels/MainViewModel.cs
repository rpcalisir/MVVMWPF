﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; }

        public MainViewModel()
        {
            SelectedViewModel = new ShowReservationsViewModel();
        }
    }
}
