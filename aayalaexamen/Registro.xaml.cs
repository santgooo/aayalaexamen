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
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = "USUARIO CONECTADO" + usuario;
            this.usuario = usuario; 
        }

        private void btnPagoM_Clicked(object sender, EventArgs e)
        {
            double valorCurso = 1500;


            double montoInical = Convert.ToDouble(txtMontI);
            double valorPendi = valorCurso - montoInical;
            double valorCuota = valorPendi / 4;
            double valorInteres = valorCurso * 0.04;
            double valorCuotaInteres = valorCuota + valorInteres;
            txtMontoM.Text = valorCuotaInteres.ToString();
            



        }


        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string fecha = dpFecha.Date.ToString("M/d/yyyy");
            string pais = pkPais.SelectedItem.ToString();
            string ciudades = pkCiudades.SelectedItem.ToString();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double edad = Convert.ToDouble(txtEdad.Text);
            double MontoM = Convert.ToDouble(txtMontoM.Text);
            

            Navigation.PushAsync(new Resumen(usuario,fecha, pais, ciudades, nombre, apellido, edad));
        }
    }
}