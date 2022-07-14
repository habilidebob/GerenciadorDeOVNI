namespace GerenciadorDeOVNI.Forms
{
    partial class PainelDeControle
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
            this.grbInfos = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPlanetaAtual = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.btnRemoverTrip = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.grbInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfos
            // 
            this.grbInfos.Controls.Add(this.lblAbduzidos);
            this.grbInfos.Controls.Add(this.lblPlanetaAtual);
            this.grbInfos.Controls.Add(this.lblTripulantes);
            this.grbInfos.Controls.Add(this.lblSituacao);
            this.grbInfos.Location = new System.Drawing.Point(320, 83);
            this.grbInfos.Name = "grbInfos";
            this.grbInfos.Size = new System.Drawing.Size(283, 152);
            this.grbInfos.TabIndex = 0;
            this.grbInfos.TabStop = false;
            this.grbInfos.Text = "Informações do Veículo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(170, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 27);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "UFO Control Panel";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(66, 25);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(97, 16);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(36, 80);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(127, 16);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblPlanetaAtual
            // 
            this.lblPlanetaAtual.AutoSize = true;
            this.lblPlanetaAtual.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetaAtual.Location = new System.Drawing.Point(16, 52);
            this.lblPlanetaAtual.Name = "lblPlanetaAtual";
            this.lblPlanetaAtual.Size = new System.Drawing.Size(147, 16);
            this.lblPlanetaAtual.TabIndex = 2;
            this.lblPlanetaAtual.Text = "Planeta Atual:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(56, 108);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(107, 16);
            this.lblAbduzidos.TabIndex = 3;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // btnLigar
            // 
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLigar.Location = new System.Drawing.Point(13, 83);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(280, 32);
            this.btnLigar.TabIndex = 2;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTripulante.Location = new System.Drawing.Point(13, 121);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(280, 32);
            this.btnAddTripulante.TabIndex = 3;
            this.btnAddTripulante.Text = "Adicionar Tripulante";
            this.btnAddTripulante.UseVisualStyleBackColor = true;
            // 
            // btnRemoverTrip
            // 
            this.btnRemoverTrip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverTrip.Location = new System.Drawing.Point(13, 159);
            this.btnRemoverTrip.Name = "btnRemoverTrip";
            this.btnRemoverTrip.Size = new System.Drawing.Size(280, 32);
            this.btnRemoverTrip.TabIndex = 4;
            this.btnRemoverTrip.Text = "Remover Tripulante";
            this.btnRemoverTrip.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbduzir.Location = new System.Drawing.Point(13, 197);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(280, 32);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesabduzir.Location = new System.Drawing.Point(13, 235);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(280, 32);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(13, 274);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(121, 28);
            this.cmbPlanetas.TabIndex = 7;
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMudarPlaneta.Location = new System.Drawing.Point(140, 273);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(154, 29);
            this.btnMudarPlaneta.TabIndex = 8;
            this.btnMudarPlaneta.Text = "Mudar de Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            // 
            // PainelDeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 327);
            this.Controls.Add(this.btnMudarPlaneta);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRemoverTrip);
            this.Controls.Add(this.btnAddTripulante);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbInfos);
            this.Name = "PainelDeControle";
            this.Text = "Painel de Controle";
            this.grbInfos.ResumeLayout(false);
            this.grbInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfos;
        private System.Windows.Forms.Label lblPlanetaAtual;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.Button btnRemoverTrip;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnMudarPlaneta;
    }
}