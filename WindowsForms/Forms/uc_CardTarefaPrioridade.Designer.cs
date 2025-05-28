namespace WindowsForms.Forms
{
    partial class uc_CardTarefaPrioridade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_CardTarefaPrioridade));
            this.btnExibirTarefa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            this.lblPrazo = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblPendente = new DevExpress.XtraEditors.SimpleButton();
            this.lblIdTarefa = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnExibirTarefa
            // 
            this.btnExibirTarefa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnExibirTarefa.Appearance.Options.UseBackColor = true;
            this.btnExibirTarefa.Location = new System.Drawing.Point(10, 8);
            this.btnExibirTarefa.Name = "btnExibirTarefa";
            this.btnExibirTarefa.Size = new System.Drawing.Size(654, 44);
            this.btnExibirTarefa.TabIndex = 0;
            this.btnExibirTarefa.Click += new System.EventHandler(this.btnExibirTarefa_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.Location = new System.Drawing.Point(6, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(188, 44);
            this.simpleButton2.TabIndex = 1;
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lblDataCriacao.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblDataCriacao.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacao.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblDataCriacao.Appearance.Options.UseBackColor = true;
            this.lblDataCriacao.Appearance.Options.UseBorderColor = true;
            this.lblDataCriacao.Appearance.Options.UseFont = true;
            this.lblDataCriacao.Appearance.Options.UseForeColor = true;
            this.lblDataCriacao.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataCriacao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblDataCriacao.ImageOptions.SvgImage")));
            this.lblDataCriacao.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblDataCriacao.Location = new System.Drawing.Point(18, 32);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(86, 15);
            this.lblDataCriacao.TabIndex = 22;
            this.lblDataCriacao.Text = "       Data Criação";
            this.lblDataCriacao.Click += new System.EventHandler(this.lblDataCriacao_Click);
            // 
            // lblPrazo
            // 
            this.lblPrazo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lblPrazo.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblPrazo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblPrazo.Appearance.Options.UseBackColor = true;
            this.lblPrazo.Appearance.Options.UseBorderColor = true;
            this.lblPrazo.Appearance.Options.UseFont = true;
            this.lblPrazo.Appearance.Options.UseForeColor = true;
            this.lblPrazo.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrazo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblPrazo.ImageOptions.SvgImage")));
            this.lblPrazo.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblPrazo.Location = new System.Drawing.Point(295, 32);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(49, 15);
            this.lblPrazo.TabIndex = 23;
            this.lblPrazo.Text = "       Prazo";
            this.lblPrazo.Click += new System.EventHandler(this.lblPrazo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lblTitulo.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Appearance.Options.UseBackColor = true;
            this.lblTitulo.Appearance.Options.UseBorderColor = true;
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseForeColor = true;
            this.lblTitulo.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblTitulo.Location = new System.Drawing.Point(18, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(30, 13);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblPendente
            // 
            this.lblPendente.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lblPendente.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendente.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.lblPendente.Appearance.Options.UseBackColor = true;
            this.lblPendente.Appearance.Options.UseFont = true;
            this.lblPendente.Appearance.Options.UseForeColor = true;
            this.lblPendente.Enabled = false;
            this.lblPendente.Location = new System.Drawing.Point(578, 18);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(75, 23);
            this.lblPendente.TabIndex = 25;
            this.lblPendente.Text = "PENDENTE";
            this.lblPendente.Click += new System.EventHandler(this.lblPendente_Click);
            // 
            // lblIdTarefa
            // 
            this.lblIdTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTarefa.Appearance.Options.UseFont = true;
            this.lblIdTarefa.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIdTarefa.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblIdTarefa.Location = new System.Drawing.Point(543, 11);
            this.lblIdTarefa.Name = "lblIdTarefa";
            this.lblIdTarefa.Size = new System.Drawing.Size(10, 13);
            this.lblIdTarefa.TabIndex = 26;
            this.lblIdTarefa.Text = "Id";
            this.lblIdTarefa.Visible = false;
            // 
            // uc_CardTarefaPrioridade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIdTarefa);
            this.Controls.Add(this.lblPendente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblDataCriacao);
            this.Controls.Add(this.btnExibirTarefa);
            this.Controls.Add(this.simpleButton2);
            this.Name = "uc_CardTarefaPrioridade";
            this.Size = new System.Drawing.Size(668, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExibirTarefa;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.LabelControl lblDataCriacao;
        public DevExpress.XtraEditors.LabelControl lblPrazo;
        public DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.SimpleButton lblPendente;
        public DevExpress.XtraEditors.LabelControl lblIdTarefa;
    }
}
