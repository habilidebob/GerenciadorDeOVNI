namespace GerenciadorDeOVNI.Forms
{
    partial class TelaInicial
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
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblMaxTripulantes = new System.Windows.Forms.Label();
            this.lblMaxAbduzidos = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.nudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.nudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llblSair = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(251, 98);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(97, 13);
            this.lblPlaneta.TabIndex = 0;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // lblMaxTripulantes
            // 
            this.lblMaxTripulantes.AutoSize = true;
            this.lblMaxTripulantes.Location = new System.Drawing.Point(232, 129);
            this.lblMaxTripulantes.Name = "lblMaxTripulantes";
            this.lblMaxTripulantes.Size = new System.Drawing.Size(116, 13);
            this.lblMaxTripulantes.TabIndex = 1;
            this.lblMaxTripulantes.Text = "Máximo de Tripulantes:";
            // 
            // lblMaxAbduzidos
            // 
            this.lblMaxAbduzidos.AutoSize = true;
            this.lblMaxAbduzidos.Location = new System.Drawing.Point(235, 163);
            this.lblMaxAbduzidos.Name = "lblMaxAbduzidos";
            this.lblMaxAbduzidos.Size = new System.Drawing.Size(113, 13);
            this.lblMaxAbduzidos.TabIndex = 2;
            this.lblMaxAbduzidos.Text = "Máximo de Abduzidos:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(354, 95);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(153, 21);
            this.cmbPlanetas.TabIndex = 3;
            // 
            // nudTripulantes
            // 
            this.nudTripulantes.Location = new System.Drawing.Point(354, 127);
            this.nudTripulantes.Name = "nudTripulantes";
            this.nudTripulantes.Size = new System.Drawing.Size(153, 20);
            this.nudTripulantes.TabIndex = 4;
            // 
            // nudAbduzidos
            // 
            this.nudAbduzidos.Location = new System.Drawing.Point(354, 161);
            this.nudAbduzidos.Name = "nudAbduzidos";
            this.nudAbduzidos.Size = new System.Drawing.Size(153, 20);
            this.nudAbduzidos.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(235, 187);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(272, 48);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(269, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "UFO Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeOVNI.Properties.Resources._3306658;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // llblSair
            // 
            this.llblSair.AutoSize = true;
            this.llblSair.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblSair.LinkColor = System.Drawing.Color.Red;
            this.llblSair.Location = new System.Drawing.Point(510, 9);
            this.llblSair.Name = "llblSair";
            this.llblSair.Size = new System.Drawing.Size(14, 13);
            this.llblSair.TabIndex = 9;
            this.llblSair.TabStop = true;
            this.llblSair.Text = "X";
            this.llblSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSair_LinkClicked);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 252);
            this.Controls.Add(this.llblSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.nudAbduzidos);
            this.Controls.Add(this.nudTripulantes);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblMaxAbduzidos);
            this.Controls.Add(this.lblMaxTripulantes);
            this.Controls.Add(this.lblPlaneta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(350, 200);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblMaxTripulantes;
        private System.Windows.Forms.Label lblMaxAbduzidos;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.NumericUpDown nudTripulantes;
        private System.Windows.Forms.NumericUpDown nudAbduzidos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblSair;
    }
}