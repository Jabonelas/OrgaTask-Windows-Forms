namespace WindowsForms.Forms
{
    partial class uc_ExibirTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ExibirTarefas));
            this.pnlListaTarefas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnteriro = new DevExpress.XtraEditors.SimpleButton();
            this.btnProximo = new DevExpress.XtraEditors.SimpleButton();
            this.lblNumeroPagina = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.btnNovaTarefa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCriarTarefa = new DevExpress.XtraEditors.SimpleButton();
            this.lblNenhumaTarefa = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // pnlListaTarefas
            // 
            this.pnlListaTarefas.Location = new System.Drawing.Point(3, 49);
            this.pnlListaTarefas.Name = "pnlListaTarefas";
            this.pnlListaTarefas.Size = new System.Drawing.Size(732, 571);
            this.pnlListaTarefas.TabIndex = 0;
            // 
            // btnAnteriro
            // 
            this.btnAnteriro.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAnteriro.ImageOptions.SvgImage")));
            this.btnAnteriro.ImageOptions.SvgImageSize = new System.Drawing.Size(10, 10);
            this.btnAnteriro.Location = new System.Drawing.Point(260, 626);
            this.btnAnteriro.Name = "btnAnteriro";
            this.btnAnteriro.Size = new System.Drawing.Size(78, 26);
            this.btnAnteriro.TabIndex = 2;
            this.btnAnteriro.Text = "Anterior";
            this.btnAnteriro.Click += new System.EventHandler(this.btnAnteriro_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.btnProximo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Appearance.Options.UseBackColor = true;
            this.btnProximo.Appearance.Options.UseFont = true;
            this.btnProximo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnProximo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProximo.ImageOptions.SvgImage")));
            this.btnProximo.ImageOptions.SvgImageSize = new System.Drawing.Size(10, 10);
            this.btnProximo.Location = new System.Drawing.Point(396, 626);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(78, 26);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = "Próxima";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.Location = new System.Drawing.Point(364, 632);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(6, 13);
            this.lblNumeroPagina.TabIndex = 3;
            this.lblNumeroPagina.Text = "1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseForeColor = true;
            this.lblTitulo.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitulo.Location = new System.Drawing.Point(15, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(336, 40);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Todas as Minhas Tarefas";
            // 
            // btnNovaTarefa
            // 
            this.btnNovaTarefa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.btnNovaTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaTarefa.Appearance.Options.UseBackColor = true;
            this.btnNovaTarefa.Appearance.Options.UseFont = true;
            this.btnNovaTarefa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNovaTarefa.ImageOptions.SvgImage")));
            this.btnNovaTarefa.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnNovaTarefa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovaTarefa.Location = new System.Drawing.Point(602, 13);
            this.btnNovaTarefa.Name = "btnNovaTarefa";
            this.btnNovaTarefa.Size = new System.Drawing.Size(119, 34);
            this.btnNovaTarefa.TabIndex = 3;
            this.btnNovaTarefa.Text = "Nova Tarefa";
            this.btnNovaTarefa.Click += new System.EventHandler(this.btnNovaTarefa_Click);
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.btnCriarTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTarefa.Appearance.Options.UseBackColor = true;
            this.btnCriarTarefa.Appearance.Options.UseFont = true;
            this.btnCriarTarefa.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnCriarTarefa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCriarTarefa.Location = new System.Drawing.Point(292, 254);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(142, 34);
            this.btnCriarTarefa.TabIndex = 19;
            this.btnCriarTarefa.Text = "Criar primeira tarefa";
            this.btnCriarTarefa.Click += new System.EventHandler(this.bntCriarTarefa_Click);
            // 
            // lblNenhumaTarefa
            // 
            this.lblNenhumaTarefa.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhumaTarefa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNenhumaTarefa.Appearance.Options.UseFont = true;
            this.lblNenhumaTarefa.Appearance.Options.UseForeColor = true;
            this.lblNenhumaTarefa.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblNenhumaTarefa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblNenhumaTarefa.ImageOptions.SvgImage")));
            this.lblNenhumaTarefa.Location = new System.Drawing.Point(245, 164);
            this.lblNenhumaTarefa.Name = "lblNenhumaTarefa";
            this.lblNenhumaTarefa.Size = new System.Drawing.Size(238, 75);
            this.lblNenhumaTarefa.TabIndex = 20;
            this.lblNenhumaTarefa.Text = "\r\n\r\nNenhuma tarefa encontrada";
            // 
            // uc_ExibirTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNenhumaTarefa);
            this.Controls.Add(this.btnCriarTarefa);
            this.Controls.Add(this.btnNovaTarefa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnteriro);
            this.Controls.Add(this.pnlListaTarefas);
            this.Name = "uc_ExibirTarefas";
            this.Size = new System.Drawing.Size(735, 666);
            this.Load += new System.EventHandler(this.uc_ExibirTarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlListaTarefas;
        private DevExpress.XtraEditors.SimpleButton btnAnteriro;
        private DevExpress.XtraEditors.SimpleButton btnProximo;
        private DevExpress.XtraEditors.LabelControl lblNumeroPagina;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.SimpleButton btnNovaTarefa;
        private DevExpress.XtraEditors.SimpleButton btnCriarTarefa;
        private DevExpress.XtraEditors.LabelControl lblNenhumaTarefa;
    }
}
