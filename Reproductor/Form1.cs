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

        private void listCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = direccionesArchivosMP3[listCanciones.SelectedIndex];
            listCanciones.Text = ArchivosMP3[listCanciones.SelectedIndex];
        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                direccionesArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;

                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    listCanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = direccionesArchivosMP3[0];
                listCanciones.SelectedIndex = 0;
                Play1.Image = Properties.Resources.wm_pause_2400px;

            }
        }

        private void Play1_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    Play1.Image = Properties.Resources.Play_Button;
                    Play = false;
                    break;

                case false:
                    Reproductor.Ctlcontrols.play();
                    Play1.Image = Properties.Resources.wm_pause_2400px;
                    Play = true;
                    break;

            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            Play1.Image = Properties.Resources.Play_Button;
            Play = false;
        }
        

    private void timer1_Tick(object sender, EventArgs e)
    {
            ActualizarDatos();
            Estatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            Volumen.Value = Reproductor.settings.volume;


    }
        public void ActualizarDatos()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Estatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else
                    if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else
                if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                Estatus.Value = 0;
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatos();
        }
    }
}
    

