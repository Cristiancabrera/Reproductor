namespace Reproductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listCanciones = new System.Windows.Forms.ListBox();
            this.Volumen = new XComponent.SliderBar.MACTrackBar();
            this.Estatus = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play1 = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(14, 12);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(459, 301);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listCanciones
            // 
            this.listCanciones.FormattingEnabled = true;
            this.listCanciones.ItemHeight = 16;
            this.listCanciones.Location = new System.Drawing.Point(479, 48);
            this.listCanciones.Name = "listCanciones";
            this.listCanciones.Size = new System.Drawing.Size(304, 196);
            this.listCanciones.TabIndex = 5;
            this.listCanciones.SelectedIndexChanged += new System.EventHandler(this.listCanciones_SelectedIndexChanged);
            // 
            // Volumen
            // 
            this.Volumen.BackColor = System.Drawing.Color.Transparent;
            this.Volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Volumen.IndentHeight = 6;
            this.Volumen.Location = new System.Drawing.Point(260, 329);
            this.Volumen.Maximum = 100;
            this.Volumen.Minimum = 0;
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(172, 22);
            this.Volumen.TabIndex = 6;
            this.Volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Volumen.TickHeight = 4;
            this.Volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Volumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.Volumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volumen.TrackLineHeight = 3;
            this.Volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volumen.Value = 0;
            this.Volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // Estatus
            // 
            this.Estatus.BackColor = System.Drawing.Color.Transparent;
            this.Estatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Estatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Estatus.IndentHeight = 6;
            this.Estatus.Location = new System.Drawing.Point(286, 385);
            this.Estatus.Maximum = 100;
            this.Estatus.Minimum = 0;
            this.Estatus.Name = "Estatus";
            this.Estatus.Size = new System.Drawing.Size(172, 22);
            this.Estatus.TabIndex = 7;
            this.Estatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Estatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Estatus.TickHeight = 4;
            this.Estatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Estatus.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Estatus.TrackerSize = new System.Drawing.Size(10, 10);
            this.Estatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Estatus.TrackLineHeight = 3;
            this.Estatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Estatus.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Play1
            // 
            this.Play1.Image = ((System.Drawing.Image)(resources.GetObject("Play1.Image")));
            this.Play1.Location = new System.Drawing.Point(24, 329);
            this.Play1.Name = "Play1";
            this.Play1.Size = new System.Drawing.Size(42, 39);
            this.Play1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play1.TabIndex = 10;
            this.Play1.TabStop = false;
            this.Play1.Click += new System.EventHandler(this.Play1_Click);
            // 
            // Stop
            // 
            this.Stop.Image = global::Reproductor.Properties.Resources.Stop1NormalRed_26963;
            this.Stop.Location = new System.Drawing.Point(72, 329);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(47, 39);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Stop.TabIndex = 11;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(125, 329);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 606);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estatus);
            this.Controls.Add(this.Volumen);
            this.Controls.Add(this.listCanciones);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listCanciones;
        private XComponent.SliderBar.MACTrackBar Volumen;
        private XComponent.SliderBar.MACTrackBar Estatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Play1;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
    }
}

