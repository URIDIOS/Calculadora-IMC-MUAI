using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PROYECTO_TROU_MVVM.Models;
using PROYECTO_TROU_MVVM.View;

namespace PROYECTO_TROU_MVVM.ViewModels
{
    public class LoginViewModel
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

        public ICommand IniciarSesion { get; }
        public ICommand IrRegistro { get; }
        public ICommand IrRecover { get; }


        public LoginViewModel()
        {
            IniciarSesion = new Command(menuNav);
            IrRegistro = new Command(regNav);
            IrRecover = new Command(recNav);
        }

        private async void regNav()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Login());
        }

        private async void recNav()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RecuperarContraseña());
        }

        private async void menuNav()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        //NO TOCAR
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
