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

namespace Reproductor
{
    public partial class Form1 : Form
    {

        bool Play = false;
        string[] ArchivosMP3;
        string[] direccionesArchivosMP3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if(CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                direccionesArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
           
                foreach ( var ArchivoMP3 in ArchivosMP3)
                {
                    listCanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = direccionesArchivosMP3[0];
                listCanciones.SelectedIndex = 0;
                
            }
        }
    }
}
