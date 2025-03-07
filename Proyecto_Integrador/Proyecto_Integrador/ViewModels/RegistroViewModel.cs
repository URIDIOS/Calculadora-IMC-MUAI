using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PROYECTO_TROU_MVVM.View;

namespace PROYECTO_TROU_MVVM.ViewModels
{
    public class RegistroViewModel
    {
        private string nombre;
        private string password;
        private string correo;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Correo
        {
            get => correo;
            set
            {
                if (correo != value)
                {
                    correo = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Registrarse { get; }
        public ICommand IrLogin { get; }

        public RegistroViewModel()
        {
            Registrarse = new Command(menuNav);
            IrLogin = new Command(regNav);
        }

        private async void regNav()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Login());
        }

        private async void menuNav()
        {
            //Registrar datos antes de cambiar de pantalla
            await Application.Current.MainPage.Navigation.PushAsync(new Login());
        }


        //NO TOCAR
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
