using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnsalvar_Clicked(object sender, EventArgs e)
        {
            var resul = new Class1
            {
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = txtedad.Text,
                correo = txtcorreo.Text,
                dirrecion = txtdirecion.Text,

            };
            var scondpnge = new Resultado();
            scondpnge.BindingContext = resul;

            Navigation.PushAsync(scondpnge);

        }
    }
}
