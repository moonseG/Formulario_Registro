using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario_Registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string nombres = texNombre.Text;
            string apellidos = texApellido.Text;
            string edades = texEdad.Text;
            string estaturas = texEstatura.Text;
            string telefonos = texTelefono.Text;
            string genero = "";
            if (BHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (BMujer.Checked) 
            { 
                genero = "Mujer";
            }
            string datos = $"Nombres: {nombres}\r\n\nApellidos:{apellidos}\r\n\nEdad: {edades}\r\n\nEstatura: {estaturas}\r\n\nTelefono: {telefonos}\r\n\nGenero: {genero}";

            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Infromacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string rutaArchivo = "C:\\Users\\monse";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            texNombre.Clear();
            texEstatura.Clear();
            texApellido.Clear();
            texEdad.Clear();
            texTelefono.Clear();
            texEdad.Clear();
            BMujer.Checked = false;
            BHombre.Checked = false;
        }
    }
}
