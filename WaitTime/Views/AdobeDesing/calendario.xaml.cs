using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WaitTime.Views.Home
{
    public partial class calendario : ContentPage
    {
        private DateTime fechaSeleccionada;
        private List<DateTime> fechasReservadas = new List<DateTime>();
        

        public DateTime FechaSeleccionada { get => fechaSeleccionada; set => fechaSeleccionada = value; }

        public calendario()
        {
            InitializeComponent();

            miDatePicker.DateSelected += (sender, args) =>
            {
                fechaSeleccionada = args.NewDate;
            };

        }
        private void OnReservarClicked(object sender, EventArgs e)
        {
            fechasReservadas.Add(FechaSeleccionada);
            DisplayAlert("Fecha reservada", FechaSeleccionada.ToString("dd/MM/yyyy"), "Aceptar");
            MostrarFechasReservadas();
        }

        private void MostrarFechasReservadas()
        {
            string mensaje = "Fechas reservadas:";
            foreach (DateTime fecha in fechasReservadas)
            {
                mensaje += "\n" + fecha.ToString("dd/MM/yyyy");
            }
            fechasReservadasLabel.Text = mensaje;
        }

        public class ClockViewModel : INotifyPropertyChanged
        {
            private DateTime _currentTime;

            public DateTime CurrentTime
            {
                get { return _currentTime; }
                set
                {
                    _currentTime = value;
                    OnPropertyChanged(nameof(CurrentTime));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }




    }
}
	