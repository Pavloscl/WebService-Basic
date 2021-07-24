using System;
using System.Windows.Forms;

namespace WsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;

            using (WsPersonas.WSPersonasClient client = new WsPersonas.WSPersonasClient())
            {
                var persona = client.GetPersona(id);
                var nombre = persona.Nombre;
                txtResultado.Text = nombre;
                txtEdad.Text = persona.Edad.ToString();

                if (persona.Error !="")
                {
                    lbError.Text = persona.Error;

                }
               
            }
        }
    }
}
