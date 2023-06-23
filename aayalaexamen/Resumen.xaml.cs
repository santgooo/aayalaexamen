using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aayalaexamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usario,string fecha,string nombre, string apellido, string pais,string ciudad, double edad )
        {
            InitializeComponent();
            lblusuario.Text = "USUARIO CONECTADO" + usario;
            txtFecha.Text = fecha;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtPais.Text = pais;
            txtCiudad.Text = ciudad;
            txtEdad.Text = edad.ToString();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}