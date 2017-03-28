namespace ColoreaPalabras
{
    partial class coloreaPalabras
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnVerde;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coloreaPalabras));
            this.pickWord = new System.Windows.Forms.Label();
            this.textColor = new System.Windows.Forms.TextBox();
            this.pickColor = new System.Windows.Forms.Label();
            this.textPalabra = new System.Windows.Forms.TextBox();
            this.panelRojo = new System.Windows.Forms.Panel();
            this.panelVerde = new System.Windows.Forms.Panel();
            this.panelNaranja = new System.Windows.Forms.Panel();
            this.panelAzul = new System.Windows.Forms.Panel();
            this.panelVioleta = new System.Windows.Forms.Panel();
            this.panelAmarillo = new System.Windows.Forms.Panel();
            this.panelImg = new System.Windows.Forms.Panel();
            this.panelTexto = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.modificador = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVioleta = new System.Windows.Forms.Button();
            btnVerde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerde
            // 
            btnVerde.BackColor = System.Drawing.Color.Transparent;
            btnVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerde.BackgroundImage")));
            btnVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVerde.FlatAppearance.BorderSize = 0;
            btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerde.ForeColor = System.Drawing.Color.Transparent;
            btnVerde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnVerde.Location = new System.Drawing.Point(619, 25);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new System.Drawing.Size(70, 70);
            btnVerde.TabIndex = 19;
            btnVerde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnVerde.UseVisualStyleBackColor = false;
            btnVerde.Click += new System.EventHandler(this.panelVerde_Click);
            // 
            // pickWord
            // 
            this.pickWord.AutoSize = true;
            this.pickWord.BackColor = System.Drawing.Color.Transparent;
            this.pickWord.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickWord.Location = new System.Drawing.Point(75, 108);
            this.pickWord.Name = "pickWord";
            this.pickWord.Size = new System.Drawing.Size(192, 25);
            this.pickWord.TabIndex = 1;
            this.pickWord.Text = "Busca la palabra:";
            // 
            // textColor
            // 
            this.textColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textColor.Enabled = false;
            this.textColor.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColor.ForeColor = System.Drawing.Color.Black;
            this.textColor.Location = new System.Drawing.Point(254, 47);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(135, 23);
            this.textColor.TabIndex = 2;
            this.textColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pickColor
            // 
            this.pickColor.AutoSize = true;
            this.pickColor.BackColor = System.Drawing.Color.Transparent;
            this.pickColor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pickColor.Location = new System.Drawing.Point(89, 31);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(125, 50);
            this.pickColor.TabIndex = 3;
            this.pickColor.Text = "Selecciona\r\n el color:";
            this.pickColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPalabra
            // 
            this.textPalabra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPalabra.Enabled = false;
            this.textPalabra.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPalabra.ForeColor = System.Drawing.Color.Black;
            this.textPalabra.Location = new System.Drawing.Point(329, 105);
            this.textPalabra.Name = "textPalabra";
            this.textPalabra.Size = new System.Drawing.Size(280, 26);
            this.textPalabra.TabIndex = 4;
            this.textPalabra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelRojo
            // 
            this.panelRojo.BackColor = System.Drawing.Color.Red;
            this.panelRojo.Location = new System.Drawing.Point(625, 58);
            this.panelRojo.Name = "panelRojo";
            this.panelRojo.Size = new System.Drawing.Size(13, 15);
            this.panelRojo.TabIndex = 6;
            this.panelRojo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRojo_Paint);
            // 
            // panelVerde
            // 
            this.panelVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelVerde.Location = new System.Drawing.Point(644, 44);
            this.panelVerde.Name = "panelVerde";
            this.panelVerde.Size = new System.Drawing.Size(30, 15);
            this.panelVerde.TabIndex = 7;
            this.panelVerde.Click += new System.EventHandler(this.panelVerde_Click);
            // 
            // panelNaranja
            // 
            this.panelNaranja.BackColor = System.Drawing.Color.Transparent;
            this.panelNaranja.Location = new System.Drawing.Point(938, 31);
            this.panelNaranja.Name = "panelNaranja";
            this.panelNaranja.Size = new System.Drawing.Size(26, 13);
            this.panelNaranja.TabIndex = 8;
            this.panelNaranja.Visible = false;
            // 
            // panelAzul
            // 
            this.panelAzul.BackColor = System.Drawing.Color.Blue;
            this.panelAzul.Location = new System.Drawing.Point(548, 58);
            this.panelAzul.Name = "panelAzul";
            this.panelAzul.Size = new System.Drawing.Size(28, 16);
            this.panelAzul.TabIndex = 7;
            // 
            // panelVioleta
            // 
            this.panelVioleta.BackColor = System.Drawing.Color.Purple;
            this.panelVioleta.Location = new System.Drawing.Point(804, 46);
            this.panelVioleta.Name = "panelVioleta";
            this.panelVioleta.Size = new System.Drawing.Size(26, 20);
            this.panelVioleta.TabIndex = 10;
            this.panelVioleta.Click += new System.EventHandler(this.panelVioleta_Click);
            // 
            // panelAmarillo
            // 
            this.panelAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.panelAmarillo.Location = new System.Drawing.Point(793, 59);
            this.panelAmarillo.Name = "panelAmarillo";
            this.panelAmarillo.Size = new System.Drawing.Size(29, 18);
            this.panelAmarillo.TabIndex = 7;
            // 
            // panelImg
            // 
            this.panelImg.BackColor = System.Drawing.Color.Transparent;
            this.panelImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImg.BackgroundImage")));
            this.panelImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImg.Location = new System.Drawing.Point(395, 41);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(74, 38);
            this.panelImg.TabIndex = 8;
            // 
            // panelTexto
            // 
            this.panelTexto.BackColor = System.Drawing.Color.Transparent;
            this.panelTexto.Location = new System.Drawing.Point(58, 141);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.Size = new System.Drawing.Size(913, 334);
            this.panelTexto.TabIndex = 11;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Snow;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(58, 481);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(93, 31);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // modificador
            // 
            this.modificador.BackColor = System.Drawing.Color.White;
            this.modificador.Font = new System.Drawing.Font("Century Gothic", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificador.Location = new System.Drawing.Point(768, 482);
            this.modificador.Name = "modificador";
            this.modificador.Size = new System.Drawing.Size(203, 30);
            this.modificador.TabIndex = 15;
            this.modificador.Text = "MODIFICAR TEXTO";
            this.modificador.UseVisualStyleBackColor = false;
            this.modificador.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Transparent;
            this.btnRojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRojo.BackgroundImage")));
            this.btnRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRojo.FlatAppearance.BorderSize = 0;
            this.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRojo.ForeColor = System.Drawing.Color.Transparent;
            this.btnRojo.Location = new System.Drawing.Point(538, 25);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(70, 70);
            this.btnRojo.TabIndex = 16;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.panelRojo_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.btnAmarillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAmarillo.BackgroundImage")));
            this.btnAmarillo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmarillo.FlatAppearance.BorderSize = 0;
            this.btnAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarillo.ForeColor = System.Drawing.Color.Transparent;
            this.btnAmarillo.Location = new System.Drawing.Point(700, 25);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(70, 70);
            this.btnAmarillo.TabIndex = 17;
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.panelAmarillo_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.BackColor = System.Drawing.Color.Transparent;
            this.btnNaranja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNaranja.BackgroundImage")));
            this.btnNaranja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaranja.FlatAppearance.BorderSize = 0;
            this.btnNaranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaranja.Location = new System.Drawing.Point(862, 25);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(70, 70);
            this.btnNaranja.TabIndex = 18;
            this.btnNaranja.UseVisualStyleBackColor = false;
            this.btnNaranja.Click += new System.EventHandler(this.panelNaranja_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Transparent;
            this.btnAzul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAzul.BackgroundImage")));
            this.btnAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzul.FlatAppearance.BorderSize = 0;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.ForeColor = System.Drawing.Color.Transparent;
            this.btnAzul.Location = new System.Drawing.Point(457, 25);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(70, 70);
            this.btnAzul.TabIndex = 17;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.panelAzul_Click);
            // 
            // btnVioleta
            // 
            this.btnVioleta.BackColor = System.Drawing.Color.Transparent;
            this.btnVioleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVioleta.BackgroundImage")));
            this.btnVioleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVioleta.FlatAppearance.BorderSize = 0;
            this.btnVioleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVioleta.Location = new System.Drawing.Point(781, 25);
            this.btnVioleta.Name = "btnVioleta";
            this.btnVioleta.Size = new System.Drawing.Size(70, 70);
            this.btnVioleta.TabIndex = 17;
            this.btnVioleta.UseVisualStyleBackColor = false;
            this.btnVioleta.Click += new System.EventHandler(this.panelVioleta_Click);
            // 
            // coloreaPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 521);
            this.Controls.Add(this.btnVioleta);
            this.Controls.Add(btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.panelNaranja);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.modificador);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelTexto);
            this.Controls.Add(this.panelImg);
            this.Controls.Add(this.panelAmarillo);
            this.Controls.Add(this.panelVioleta);
            this.Controls.Add(this.panelAzul);
            this.Controls.Add(this.panelVerde);
            this.Controls.Add(this.panelRojo);
            this.Controls.Add(this.textPalabra);
            this.Controls.Add(this.pickColor);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.pickWord);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "coloreaPalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colorear Palabras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pickWord;
        private System.Windows.Forms.Label pickColor;
        private System.Windows.Forms.Panel panelRojo;
        private System.Windows.Forms.Panel panelVerde;
        private System.Windows.Forms.Panel panelNaranja;
        private System.Windows.Forms.Panel panelAzul;
        private System.Windows.Forms.Panel panelVioleta;
        private System.Windows.Forms.Panel panelAmarillo;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Panel panelTexto;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button modificador;
        public System.Windows.Forms.TextBox textColor;
        public System.Windows.Forms.TextBox textPalabra;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVioleta;
    }
}

