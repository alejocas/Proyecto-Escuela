namespace Proyecto_Escuela.Views
{
    partial class MenuActividades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloLabel = new System.Windows.Forms.Label();
            this.secuencia = new System.Windows.Forms.Button();
            this.describe = new System.Windows.Forms.Button();
            this.volverEstudiantes = new System.Windows.Forms.Button();
            this.volverTextos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(315, 60);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(189, 78);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "Título";
            // 
            // secuencia
            // 
            this.secuencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.secuencia.BackgroundImage = global::Proyecto_Escuela.Properties.Resources.dragon;
            this.secuencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secuencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secuencia.ForeColor = System.Drawing.Color.Black;
            this.secuencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secuencia.Location = new System.Drawing.Point(12, 355);
            this.secuencia.Name = "secuencia";
            this.secuencia.Size = new System.Drawing.Size(294, 170);
            this.secuencia.TabIndex = 3;
            this.secuencia.Text = "Secuencia de imagenes";
            this.secuencia.UseVisualStyleBackColor = false;
            this.secuencia.Click += new System.EventHandler(this.secuencia_Click);
            // 
            // describe
            // 
            this.describe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.describe.BackgroundImage = global::Proyecto_Escuela.Properties.Resources.draco;
            this.describe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.describe.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describe.ForeColor = System.Drawing.Color.Black;
            this.describe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.describe.Location = new System.Drawing.Point(12, 179);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(294, 170);
            this.describe.TabIndex = 4;
            this.describe.Text = "Describe una imagen";
            this.describe.UseVisualStyleBackColor = false;
            this.describe.Click += new System.EventHandler(this.describe_Click);
            // 
            // volverEstudiantes
            // 
            this.volverEstudiantes.Enabled = false;
            this.volverEstudiantes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverEstudiantes.Location = new System.Drawing.Point(775, 426);
            this.volverEstudiantes.Name = "volverEstudiantes";
            this.volverEstudiantes.Size = new System.Drawing.Size(221, 99);
            this.volverEstudiantes.TabIndex = 6;
            this.volverEstudiantes.Text = "Volver a estudiantes";
            this.volverEstudiantes.UseVisualStyleBackColor = true;
            this.volverEstudiantes.Click += new System.EventHandler(this.button2_Click);
            // 
            // volverTextos
            // 
            this.volverTextos.Enabled = false;
            this.volverTextos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverTextos.Location = new System.Drawing.Point(775, 321);
            this.volverTextos.Name = "volverTextos";
            this.volverTextos.Size = new System.Drawing.Size(221, 99);
            this.volverTextos.TabIndex = 7;
            this.volverTextos.Text = "Volver a textos";
            this.volverTextos.UseVisualStyleBackColor = true;
            this.volverTextos.Click += new System.EventHandler(this.volverTextos_Click);
            // 
            // MenuActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.volverTextos);
            this.Controls.Add(this.volverEstudiantes);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.secuencia);
            this.Controls.Add(this.tituloLabel);
            this.Name = "MenuActividades";
            this.Text = "MenuActividades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuActividades_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button secuencia;
        private System.Windows.Forms.Button describe;
        private System.Windows.Forms.Button volverEstudiantes;
        private System.Windows.Forms.Button volverTextos;
    }
}