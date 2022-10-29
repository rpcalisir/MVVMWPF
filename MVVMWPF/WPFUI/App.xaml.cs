using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFUI.Exceptions;
using WPFUI.Models;
using WPFUI.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            //Hotel hotel = new Hotel("Recep Suites");

            //try
            //{
            //    hotel.MakeReservation(new Reservation(
            //        new RoomID(2, 1),
            //        "Recep",
            //        new DateTime(2022, 10, 28),
            //        new DateTime(2022, 10, 29)
            //        ));

            //    hotel.MakeReservation(new Reservation(
            //        new RoomID(3, 1),
            //        "Recep",
            //        new DateTime(2022, 10, 10),
            //        new DateTime(2022, 10, 11)
            //        ));
            //}
            //catch (ReservationConflictsException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            //var reservations = hotel.GetReservationsForUser("Recep");

            base.OnStartup(e);
        }
    }
}
