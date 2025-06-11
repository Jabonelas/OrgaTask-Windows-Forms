namespace WindowsForms.Forms
{
    partial class uc_CardTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_CardTarefa));
            this.lblDescricao = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblPrazo = new DevExpress.XtraEditors.LabelControl();
            this.lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            this.btnExcluirTarefa = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarTarefa = new DevExpress.XtraEditors.SimpleButton();
            this.btnVisualizarTarefa = new DevExpress.XtraEditors.SimpleButton();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.lblIdTarefa = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.SimpleButton();
            this.lblPrioridade = new DevExpress.XtraEditors.SimpleButton();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Appearance.Options.UseFont = true;
            this.lblDescricao.Location = new System.Drawing.Point(7, 71);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(49, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(7, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblPrazo
            // 
            this.lblPrazo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Appearance.Options.UseFont = true;
            this.lblPrazo.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrazo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblPrazo.ImageOptions.SvgImage")));
            this.lblPrazo.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblPrazo.Location = new System.Drawing.Point(195, 113);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(49, 15);
            this.lblPrazo.TabIndex = 20;
            this.lblPrazo.Text = "       Prazo";
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacao.Appearance.Options.UseFont = true;
            this.lblDataCriacao.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataCriacao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblDataCriacao.ImageOptions.SvgImage")));
            this.lblDataCriacao.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblDataCriacao.Location = new System.Drawing.Point(7, 113);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(86, 15);
            this.lblDataCriacao.TabIndex = 21;
            this.lblDataCriacao.Text = "       Data Criação";
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExcluirTarefa.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnExcluirTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTarefa.Appearance.Options.UseBackColor = true;
            this.btnExcluirTarefa.Appearance.Options.UseBorderColor = true;
            this.btnExcluirTarefa.Appearance.Options.UseFont = true;
            this.btnExcluirTarefa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExcluirTarefa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcluirTarefa.ImageOptions.SvgImage")));
            this.btnExcluirTarefa.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnExcluirTarefa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(308, 141);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(43, 29);
            this.btnExcluirTarefa.TabIndex = 22;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditarTarefa.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(157)))), ((int)(((byte)(74)))));
            this.btnEditarTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarefa.Appearance.Options.UseBackColor = true;
            this.btnEditarTarefa.Appearance.Options.UseBorderColor = true;
            this.btnEditarTarefa.Appearance.Options.UseFont = true;
            this.btnEditarTarefa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditarTarefa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditarTarefa.ImageOptions.SvgImage")));
            this.btnEditarTarefa.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnEditarTarefa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarTarefa.Location = new System.Drawing.Point(259, 141);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(43, 29);
            this.btnEditarTarefa.TabIndex = 23;
            this.btnEditarTarefa.Click += new System.EventHandler(this.btnEditarTarefa_Click);
            // 
            // btnVisualizarTarefa
            // 
            this.btnVisualizarTarefa.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVisualizarTarefa.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVisualizarTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarTarefa.Appearance.Options.UseBackColor = true;
            this.btnVisualizarTarefa.Appearance.Options.UseBorderColor = true;
            this.btnVisualizarTarefa.Appearance.Options.UseFont = true;
            this.btnVisualizarTarefa.Appearance.Options.UseForeColor = true;
            this.btnVisualizarTarefa.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnVisualizarTarefa.AppearanceHovered.Options.UseBorderColor = true;
            this.btnVisualizarTarefa.AppearancePressed.Options.UseBorderColor = true;
            this.btnVisualizarTarefa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnVisualizarTarefa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVisualizarTarefa.ImageOptions.SvgImage")));
            this.btnVisualizarTarefa.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnVisualizarTarefa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVisualizarTarefa.Location = new System.Drawing.Point(210, 141);
            this.btnVisualizarTarefa.Name = "btnVisualizarTarefa";
            this.btnVisualizarTarefa.Size = new System.Drawing.Size(43, 29);
            this.btnVisualizarTarefa.TabIndex = 24;
            this.btnVisualizarTarefa.Click += new System.EventHandler(this.btnVisualizarTarefa_Click);
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.White;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.lblIdTarefa);
            this.pnlFundo.Controls.Add(this.lblStatus);
            this.pnlFundo.Controls.Add(this.lblTitulo);
            this.pnlFundo.Controls.Add(this.lblDescricao);
            this.pnlFundo.Controls.Add(this.lblPrazo);
            this.pnlFundo.Controls.Add(this.lblDataCriacao);
            this.pnlFundo.Location = new System.Drawing.Point(-1, -1);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(361, 137);
            this.pnlFundo.TabIndex = 25;
            // 
            // lblIdTarefa
            // 
            this.lblIdTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTarefa.Appearance.Options.UseFont = true;
            this.lblIdTarefa.Location = new System.Drawing.Point(159, 8);
            this.lblIdTarefa.Name = "lblIdTarefa";
            this.lblIdTarefa.Size = new System.Drawing.Size(51, 17);
            this.lblIdTarefa.TabIndex = 22;
            this.lblIdTarefa.Text = "idTarefa";
            this.lblIdTarefa.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Appearance.Options.UseBackColor = true;
            this.lblStatus.Appearance.Options.UseFont = true;
            this.lblStatus.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(231, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 29);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.lblPrioridade.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPrioridade.Appearance.Options.UseBackColor = true;
            this.lblPrioridade.Appearance.Options.UseFont = true;
            this.lblPrioridade.Appearance.Options.UseForeColor = true;
            this.lblPrioridade.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.lblPrioridade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrioridade.Location = new System.Drawing.Point(7, 3);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(91, 29);
            this.lblPrioridade.TabIndex = 18;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // uc_CardTarefa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnVisualizarTarefa);
            this.Controls.Add(this.btnEditarTarefa);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.pnlFundo);
            this.Name = "uc_CardTarefa";
            this.Size = new System.Drawing.Size(359, 176);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblDescricao;
        public DevExpress.XtraEditors.LabelControl lblTitulo;
        public DevExpress.XtraEditors.LabelControl lblPrazo;
        public DevExpress.XtraEditors.LabelControl lblDataCriacao;
        private DevExpress.XtraEditors.SimpleButton btnExcluirTarefa;
        private DevExpress.XtraEditors.SimpleButton btnEditarTarefa;
        private DevExpress.XtraEditors.SimpleButton btnVisualizarTarefa;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton lblStatus;
        private DevExpress.XtraEditors.SimpleButton lblPrioridade;
        public DevExpress.XtraEditors.LabelControl lblIdTarefa;
    }
}
