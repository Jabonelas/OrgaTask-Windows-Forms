namespace WindowsForms.Forms
{
    partial class uc_DashboardTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DashboardTarefas));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPendente = new DevExpress.XtraEditors.LabelControl();
            this.lblEmProgresso = new DevExpress.XtraEditors.LabelControl();
            this.lblConcluidas = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblFraseCompletando = new DevExpress.XtraEditors.LabelControl();
            this.lblPorcentagem = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtdTarefasEmProgresso = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtdTarefasPendentes = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtdTarefasConcluida = new DevExpress.XtraEditors.SimpleButton();
            this.pnlListaTarefaaPrioritarias = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnQtdTarefasPrioritarias = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pgbProgresso = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgresso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(184, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(328, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Dashboard de Tarefas";
            // 
            // lblPendente
            // 
            this.lblPendente.Appearance.BackColor = System.Drawing.Color.White;
            this.lblPendente.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendente.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblPendente.Appearance.Options.UseBackColor = true;
            this.lblPendente.Appearance.Options.UseFont = true;
            this.lblPendente.Appearance.Options.UseForeColor = true;
            this.lblPendente.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblPendente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblPendente.ImageOptions.Image")));
            this.lblPendente.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lblPendente.Location = new System.Drawing.Point(112, 118);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(60, 51);
            this.lblPendente.TabIndex = 2;
            this.lblPendente.Text = "\r\n\r\nPendentes";
            this.lblPendente.Click += new System.EventHandler(this.lblPendente_Click);
            // 
            // lblEmProgresso
            // 
            this.lblEmProgresso.Appearance.BackColor = System.Drawing.Color.White;
            this.lblEmProgresso.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmProgresso.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblEmProgresso.Appearance.Options.UseBackColor = true;
            this.lblEmProgresso.Appearance.Options.UseFont = true;
            this.lblEmProgresso.Appearance.Options.UseForeColor = true;
            this.lblEmProgresso.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblEmProgresso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblEmProgresso.ImageOptions.Image")));
            this.lblEmProgresso.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lblEmProgresso.Location = new System.Drawing.Point(330, 118);
            this.lblEmProgresso.Name = "lblEmProgresso";
            this.lblEmProgresso.Size = new System.Drawing.Size(82, 51);
            this.lblEmProgresso.TabIndex = 5;
            this.lblEmProgresso.Text = "\r\n\r\nEm Progresso";
            this.lblEmProgresso.Click += new System.EventHandler(this.lblEmProgresso_Click);
            // 
            // lblConcluidas
            // 
            this.lblConcluidas.Appearance.BackColor = System.Drawing.Color.White;
            this.lblConcluidas.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcluidas.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblConcluidas.Appearance.Options.UseBackColor = true;
            this.lblConcluidas.Appearance.Options.UseFont = true;
            this.lblConcluidas.Appearance.Options.UseForeColor = true;
            this.lblConcluidas.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblConcluidas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblConcluidas.ImageOptions.Image")));
            this.lblConcluidas.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lblConcluidas.Location = new System.Drawing.Point(565, 118);
            this.lblConcluidas.Name = "lblConcluidas";
            this.lblConcluidas.Size = new System.Drawing.Size(63, 51);
            this.lblConcluidas.TabIndex = 6;
            this.lblConcluidas.Text = "\r\n\r\nConcluídas";
            this.lblConcluidas.Click += new System.EventHandler(this.lblConcluidas_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.Controls.Add(this.lblFraseCompletando);
            this.panelControl2.Controls.Add(this.lblPorcentagem);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.pgbProgresso);
            this.panelControl2.Location = new System.Drawing.Point(14, 234);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(705, 98);
            this.panelControl2.TabIndex = 8;
            // 
            // lblFraseCompletando
            // 
            this.lblFraseCompletando.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseCompletando.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblFraseCompletando.Appearance.Options.UseFont = true;
            this.lblFraseCompletando.Appearance.Options.UseForeColor = true;
            this.lblFraseCompletando.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFraseCompletando.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblFraseCompletando.ImageOptions.Image")));
            this.lblFraseCompletando.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblFraseCompletando.Location = new System.Drawing.Point(11, 75);
            this.lblFraseCompletando.Name = "lblFraseCompletando";
            this.lblFraseCompletando.Size = new System.Drawing.Size(262, 16);
            this.lblFraseCompletando.TabIndex = 13;
            this.lblFraseCompletando.Text = "       Você completou 0,00% das tarefas cadastradas";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblPorcentagem.Appearance.Options.UseFont = true;
            this.lblPorcentagem.Appearance.Options.UseForeColor = true;
            this.lblPorcentagem.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblPorcentagem.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.lblPorcentagem.Location = new System.Drawing.Point(654, 43);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(31, 13);
            this.lblPorcentagem.TabIndex = 12;
            this.lblPorcentagem.Text = "0.00%";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(11, 43);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Progresso";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl8.ImageOptions.Image")));
            this.labelControl8.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl8.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.labelControl8.Location = new System.Drawing.Point(9, 8);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(224, 25);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "        Dashboard de Tarefas";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(37, 116);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(33, 100);
            this.simpleButton1.TabIndex = 11;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.Location = new System.Drawing.Point(265, 116);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(33, 100);
            this.simpleButton2.TabIndex = 12;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Enabled = false;
            this.simpleButton3.Location = new System.Drawing.Point(493, 116);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(33, 100);
            this.simpleButton3.TabIndex = 13;
            // 
            // btnQtdTarefasEmProgresso
            // 
            this.btnQtdTarefasEmProgresso.Appearance.BackColor = System.Drawing.Color.White;
            this.btnQtdTarefasEmProgresso.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnQtdTarefasEmProgresso.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.btnQtdTarefasEmProgresso.Appearance.Options.UseBackColor = true;
            this.btnQtdTarefasEmProgresso.Appearance.Options.UseFont = true;
            this.btnQtdTarefasEmProgresso.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasEmProgresso.Location = new System.Drawing.Point(269, 116);
            this.btnQtdTarefasEmProgresso.Name = "btnQtdTarefasEmProgresso";
            this.btnQtdTarefasEmProgresso.Size = new System.Drawing.Size(200, 100);
            this.btnQtdTarefasEmProgresso.TabIndex = 2;
            this.btnQtdTarefasEmProgresso.Text = "\r\n0";
            this.btnQtdTarefasEmProgresso.Click += new System.EventHandler(this.btnQtdTarefasEmProgresso_Click);
            // 
            // btnQtdTarefasPendentes
            // 
            this.btnQtdTarefasPendentes.Appearance.BackColor = System.Drawing.Color.White;
            this.btnQtdTarefasPendentes.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnQtdTarefasPendentes.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.btnQtdTarefasPendentes.Appearance.Options.UseBackColor = true;
            this.btnQtdTarefasPendentes.Appearance.Options.UseFont = true;
            this.btnQtdTarefasPendentes.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasPendentes.Location = new System.Drawing.Point(41, 116);
            this.btnQtdTarefasPendentes.Name = "btnQtdTarefasPendentes";
            this.btnQtdTarefasPendentes.Size = new System.Drawing.Size(200, 100);
            this.btnQtdTarefasPendentes.TabIndex = 1;
            this.btnQtdTarefasPendentes.Text = "\r\n0";
            this.btnQtdTarefasPendentes.Click += new System.EventHandler(this.btnQtdTarefasPendentes_Click);
            // 
            // btnQtdTarefasConcluida
            // 
            this.btnQtdTarefasConcluida.Appearance.BackColor = System.Drawing.Color.White;
            this.btnQtdTarefasConcluida.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnQtdTarefasConcluida.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.btnQtdTarefasConcluida.Appearance.Options.UseBackColor = true;
            this.btnQtdTarefasConcluida.Appearance.Options.UseFont = true;
            this.btnQtdTarefasConcluida.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasConcluida.Location = new System.Drawing.Point(497, 116);
            this.btnQtdTarefasConcluida.Name = "btnQtdTarefasConcluida";
            this.btnQtdTarefasConcluida.Size = new System.Drawing.Size(200, 100);
            this.btnQtdTarefasConcluida.TabIndex = 3;
            this.btnQtdTarefasConcluida.Text = "\r\n0";
            this.btnQtdTarefasConcluida.Click += new System.EventHandler(this.btnQtdTarefasConcluida_Click);
            // 
            // pnlListaTarefaaPrioritarias
            // 
            this.pnlListaTarefaaPrioritarias.AutoScroll = true;
            this.pnlListaTarefaaPrioritarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlListaTarefaaPrioritarias.Location = new System.Drawing.Point(17, 375);
            this.pnlListaTarefaaPrioritarias.Name = "pnlListaTarefaaPrioritarias";
            this.pnlListaTarefaaPrioritarias.Size = new System.Drawing.Size(698, 274);
            this.pnlListaTarefaaPrioritarias.TabIndex = 17;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnQtdTarefasPrioritarias);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Location = new System.Drawing.Point(14, 339);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(705, 315);
            this.panelControl1.TabIndex = 18;
            // 
            // btnQtdTarefasPrioritarias
            // 
            this.btnQtdTarefasPrioritarias.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.btnQtdTarefasPrioritarias.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdTarefasPrioritarias.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnQtdTarefasPrioritarias.Appearance.Options.UseBackColor = true;
            this.btnQtdTarefasPrioritarias.Appearance.Options.UseFont = true;
            this.btnQtdTarefasPrioritarias.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasPrioritarias.Enabled = false;
            this.btnQtdTarefasPrioritarias.Location = new System.Drawing.Point(594, 8);
            this.btnQtdTarefasPrioritarias.Name = "btnQtdTarefasPrioritarias";
            this.btnQtdTarefasPrioritarias.Size = new System.Drawing.Size(75, 23);
            this.btnQtdTarefasPrioritarias.TabIndex = 26;
            this.btnQtdTarefasPrioritarias.Text = "PRIORIDADE";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.ImageOptions.Image")));
            this.labelControl5.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl5.Location = new System.Drawing.Point(8, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(198, 25);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "        Tarefas Prioritárias";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelControl3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Appearance.Options.UseBorderColor = true;
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Location = new System.Drawing.Point(14, 54);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(705, 174);
            this.panelControl3.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.labelControl2.Location = new System.Drawing.Point(11, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(191, 25);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "        Status das Tarefas";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.labelControl3.Location = new System.Drawing.Point(11, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(259, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Clique em um card para filtrar as tarefas por status";
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Location = new System.Drawing.Point(11, 60);
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pgbProgresso.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.pgbProgresso.Properties.Appearance.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.pgbProgresso.Size = new System.Drawing.Size(679, 10);
            this.pgbProgresso.TabIndex = 3;
            // 
            // uc_DashboardTarefas
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListaTarefaaPrioritarias);
            this.Controls.Add(this.lblConcluidas);
            this.Controls.Add(this.btnQtdTarefasConcluida);
            this.Controls.Add(this.lblEmProgresso);
            this.Controls.Add(this.btnQtdTarefasEmProgresso);
            this.Controls.Add(this.lblPendente);
            this.Controls.Add(this.btnQtdTarefasPendentes);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "uc_DashboardTarefas";
            this.Size = new System.Drawing.Size(731, 664);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgresso.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPendente;
        private DevExpress.XtraEditors.ProgressBarControl pgbProgresso;
        private DevExpress.XtraEditors.LabelControl lblEmProgresso;
        private DevExpress.XtraEditors.LabelControl lblConcluidas;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblFraseCompletando;
        private DevExpress.XtraEditors.LabelControl lblPorcentagem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnQtdTarefasEmProgresso;
        private DevExpress.XtraEditors.SimpleButton btnQtdTarefasPendentes;
        private DevExpress.XtraEditors.SimpleButton btnQtdTarefasConcluida;
        private System.Windows.Forms.FlowLayoutPanel pnlListaTarefaaPrioritarias;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnQtdTarefasPrioritarias;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}