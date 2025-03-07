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
    public class RecuperarContraseñaViewModel
    {
        private string correo;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public ICommand RecuperarContra { get; }

        public RecuperarContraseñaViewModel()
        {
            RecuperarContra = new Command(recover);
        }

        private async void recover()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Login());
        }

        //NO TOCAR
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
