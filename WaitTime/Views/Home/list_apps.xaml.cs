using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace WaitTime.Views.Home
{

    public partial class List_apps : ContentPage
    {
        public string Texto { get; set; }
        // (1, 1, 1) representan la fecha (1 de enero de 1), y los siguientes tres argumentos (13, 45, 0) representan la hora, los minutos y los segundos
        //DateTime tiempo = new DateTime(1, 1, 1, 13, 45, 0);

        // Aquí, los tres argumentos (14, 30, 0) representan la hora, los minutos y los segundos, respectivamente.
        TimeSpan tiempo = new TimeSpan(14, 30, 0);


        public bool tipoTototal_time = true;
        public bool candadotipo = true;

        public List_apps()
        {
            Texto = "Tiempo consumido: " + tiempo.ToString("hh\\:mm");


            InitializeComponent();




            var miLabel = this.FindByName<Label>("miLabel");
            miLabel.BindingContext = this;
            miLabel.SetBinding(Label.TextProperty, nameof(Texto));


            // Agregar varios elementos Label dinámicamente
            for (int i = 0; i < 4; i++)
            {
                var miLabell = new Label()
                {
                    FontFamily = "Segoe UI",
                    FontSize = 21,
                    TextColor = Color.Black,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Start,
                };
                miLabell.Text = $"Elemento {i}";

                // Agregar espacio entre cada Label
                if (i > 0) // asegurarse de que no se aplique el espacio al primer elemento
                {
                    miStackLayout.Spacing = 40;
                }

                miStackLayout.Children.Add(miLabell);
            }

            /*

            MessagingCenter.Subscribe < IMensajePersonalizado, string>(this, "mensajePersonalizado", (sender, mensaje) =>
            {
                // Recupera y muestra el string en una vista
                //Texto = mensaje;

                var miLabel = this.FindByName<Label>("miLabel");
                miLabel.BindingContext = this;
                miLabel.SetBinding(Label.TextProperty, nameof(Texto));
            });

            // Desuscribirse del mensaje cuando ya no se necesite
            MessagingCenter.Unsubscribe<IMensajePersonalizado, string>(this, "mensajePersonalizado");
            */


            /*
            // Crear una nueva etiqueta (label) y configurar sus propiedades
            var label = new Label
            {
                Text = "WhatsAppp",
                FontFamily = "Segoe UI",
                FontSize = 21,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
                Margin = new Thickness(60, 500, 200, 42.5),
                WidthRequest = 112,
                HeightRequest = 42.5
            };

            // Configurar la posición y el tamaño de la etiqueta usando el método SetLayoutBounds de AbsoluteLayout
            AbsoluteLayout.SetLayoutBounds(label, new Rectangle(60, 500, 200, 42.5));

            // Configurar las opciones de diseño de la etiqueta usando el método SetLayoutFlags de AbsoluteLayout
            AbsoluteLayout.SetLayoutFlags(label, AbsoluteLayoutFlags.None);

            // Crear una nueva instancia de AbsoluteLayout y agregar la etiqueta como hijo (child)
            Content = new AbsoluteLayout
            {
                Children = {
                    label
                }
            };
            */


            /*

            // Crear un StackLayout para contener los elementos Label
            var miStackLayout = new StackLayout();

            // Agregar varios elementos Label al StackLayout
            var miLabel1 = new Label();
            miLabel1.Text = "Elemento 1";
            miStackLayout.Children.Add(miLabel1);

            var miLabel2 = new Label();
            miLabel2.Text = "Elemento 2";
            miStackLayout.Children.Add(miLabel2);

            var miLabel3 = new Label();
            miLabel3.Text = "Elemento 3";
            miStackLayout.Children.Add(miLabel3);

            // Agregar el StackLayout a la vista sin afectar lo que ya hay en ella
            if (Content is StackLayout contentStackLayout)
            {
                // Si la vista actual ya es un StackLayout, agregar el nuevo StackLayout como su hijo
                contentStackLayout.Children.Add(miStackLayout);
            }
            else
            {
                // Si la vista actual no es un StackLayout, crear un nuevo StackLayout que contenga la vista actual y el nuevo StackLayout como sus hijos
                var nuevoStackLayout = new StackLayout();
                nuevoStackLayout.Children.Add(Content);
                nuevoStackLayout.Children.Add(miStackLayout);
                Content = nuevoStackLayout;
            }

            */

            // Llamar para crear la lista
            // MostrarListLabel();
            // ListasDemo();

            /*

            MessagingCenter.Subscribe<object, string>(this, "MyDataMessage", (sender, arg) =>
            {
                Texto = arg;
                // Actualiza tu vista con los datos recibidos desde la actividad
                // arg contiene los datos enviados desde la actividad de Xamarin.Android
            });

            */

        }

        private async void Handle_Clicked_header(object sender, EventArgs e)
        {
            if (tipoTototal_time)
            {
                Texto = "Tiempo consumido: " + tiempo.ToString("hh\\:mm");
                miLabel.SetBinding(Label.TextProperty, nameof(Texto));
                tipoTototal_time = false;

            }
            else
            {
                Texto = "Tiempo restante: " + tiempo.ToString("hh\\:mm");
                miLabel.SetBinding(Label.TextProperty, nameof(Texto));
                tipoTototal_time = true;
            }

        }

        async void MostrarAlaertaButtonClicked(object sender, EventArgs e)
        {
            String selectedTime = timePicker1.Time.ToString();


            bool respuesta = await DisplayAlert("Guardando cambios", "¿El valor: " + selectedTime + ", es correcto?", "Si", "No");

            if (respuesta)
            {

            }

            //await DisplayAlert("Alerta", "Ocurrio un erro", "Ok");

            // hojas de accion
            //string opcion = await DisplayActionSheet("Seleccionar pais", "Cancelar", null, "Mexico", "Colombia", "España");
        }

        public async void OnImageTapped(object sender, EventArgs e)
        {
           
            Image image = (Image)sender;  //string imageName = image.AutomationId;  
            var source = image.Source as FileImageSource;

            if (source == "candado_abierto.png")
            {
                image.Source = "candado.png";
            } else
            {
                image.Source = "candado_abierto.png";
            }
            //await DisplayAlert("Alerta", source, "Ok");
        }



        public void ListasDemo()
        {
            var nombres = new[]
            {
                "hector",
                "Cristian"
            };

            var miListaView = new ListView();
            miListaView.ItemsSource = nombres;

            // Asignar la lista creada a la propiedad Content de la página
            Content = miListaView;
        }


        public void MostrarListLabel()
        {
            var nombres = new[]
            {
                "hector",
                "Cristian"
            };

            // Crear una cadena de texto que contenga todos los elementos de la lista separados por una coma
            var listaComoCadena = string.Join(", ", nombres);

            // Crear un Label y asignar la cadena de texto como su texto
            var miLabel = new Label();
            miLabel.Text = listaComoCadena;

            // Asignar el Label a la propiedad Content de la página
            Content = miLabel;
        }

    }
}









