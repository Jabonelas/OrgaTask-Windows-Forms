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
            this.pgbProgresso = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblEmProgresso = new DevExpress.XtraEditors.LabelControl();
            this.lblConcluidas = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblFraseCompletando = new DevExpress.XtraEditors.LabelControl();
            this.lblPorcentagem = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtdTarefasEmProgresso = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtdTarefasPendentes = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtdTarefasConcluida = new DevExpress.XtraEditors.SimpleButton();
            this.pnlListaTarefaaPrioritarias = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgresso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
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
            this.lblPendente.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendente.Appearance.Options.UseBackColor = true;
            this.lblPendente.Appearance.Options.UseFont = true;
            this.lblPendente.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblPendente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblPendente.ImageOptions.SvgImage")));
            this.lblPendente.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lblPendente.Location = new System.Drawing.Point(112, 74);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(64, 51);
            this.lblPendente.TabIndex = 2;
            this.lblPendente.Text = "\r\n\r\nPendentes";
            this.lblPendente.Click += new System.EventHandler(this.lblPendente_Click);
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Location = new System.Drawing.Point(11, 67);
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Size = new System.Drawing.Size(679, 10);
            this.pgbProgresso.TabIndex = 3;
            // 
            // lblEmProgresso
            // 
            this.lblEmProgresso.Appearance.BackColor = System.Drawing.Color.White;
            this.lblEmProgresso.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmProgresso.Appearance.Options.UseBackColor = true;
            this.lblEmProgresso.Appearance.Options.UseFont = true;
            this.lblEmProgresso.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblEmProgresso.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblEmProgresso.ImageOptions.SvgImage")));
            this.lblEmProgresso.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lblEmProgresso.Location = new System.Drawing.Point(330, 74);
            this.lblEmProgresso.Name = "lblEmProgresso";
            this.lblEmProgresso.Size = new System.Drawing.Size(84, 51);
            this.lblEmProgresso.TabIndex = 5;
            this.lblEmProgresso.Text = "\r\n\r\nEm Progresso";
            this.lblEmProgresso.Click += new System.EventHandler(this.lblEmProgresso_Click);
            // 
            // lblConcluidas
            // 
            this.lblConcluidas.Appearance.BackColor = System.Drawing.Color.White;
            this.lblConcluidas.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcluidas.Appearance.Options.UseBackColor = true;
            this.lblConcluidas.Appearance.Options.UseFont = true;
            this.lblConcluidas.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblConcluidas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblConcluidas.ImageOptions.SvgImage")));
            this.lblConcluidas.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lblConcluidas.Location = new System.Drawing.Point(565, 74);
            this.lblConcluidas.Name = "lblConcluidas";
            this.lblConcluidas.Size = new System.Drawing.Size(67, 51);
            this.lblConcluidas.TabIndex = 6;
            this.lblConcluidas.Text = "\r\n\r\nConcluídas";
            this.lblConcluidas.Click += new System.EventHandler(this.lblConcluidas_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.Controls.Add(this.lblFraseCompletando);
            this.panelControl2.Controls.Add(this.lblPorcentagem);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.pgbProgresso);
            this.panelControl2.Location = new System.Drawing.Point(14, 192);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(705, 107);
            this.panelControl2.TabIndex = 8;
            // 
            // lblFraseCompletando
            // 
            this.lblFraseCompletando.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseCompletando.Appearance.Options.UseFont = true;
            this.lblFraseCompletando.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFraseCompletando.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblFraseCompletando.ImageOptions.SvgImage")));
            this.lblFraseCompletando.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.lblFraseCompletando.Location = new System.Drawing.Point(11, 82);
            this.lblFraseCompletando.Name = "lblFraseCompletando";
            this.lblFraseCompletando.Size = new System.Drawing.Size(262, 15);
            this.lblFraseCompletando.TabIndex = 13;
            this.lblFraseCompletando.Text = "       Você completou 0,00% das tarefas cadastradas";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Appearance.Options.UseFont = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(654, 50);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(31, 13);
            this.lblPorcentagem.TabIndex = 12;
            this.lblPorcentagem.Text = "0.00%";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(11, 50);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Progresso";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl8.ImageOptions.SvgImage")));
            this.labelControl8.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl8.Location = new System.Drawing.Point(9, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(233, 30);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "        Dashboard de Tarefas";
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.separatorControl1.Location = new System.Drawing.Point(17, 222);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(698, 21);
            this.separatorControl1.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(37, 72);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(33, 100);
            this.simpleButton1.TabIndex = 11;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(157)))), ((int)(((byte)(73)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.Location = new System.Drawing.Point(265, 72);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(33, 100);
            this.simpleButton2.TabIndex = 12;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(152)))), ((int)(((byte)(83)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Enabled = false;
            this.simpleButton3.Location = new System.Drawing.Point(493, 72);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(33, 100);
            this.simpleButton3.TabIndex = 13;
            // 
            // btnQtdTarefasEmProgresso
            // 
            this.btnQtdTarefasEmProgresso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnQtdTarefasEmProgresso.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnQtdTarefasEmProgresso.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.btnQtdTarefasEmProgresso.Appearance.Options.UseBackColor = true;
            this.btnQtdTarefasEmProgresso.Appearance.Options.UseFont = true;
            this.btnQtdTarefasEmProgresso.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasEmProgresso.Location = new System.Drawing.Point(269, 72);
            this.btnQtdTarefasEmProgresso.Name = "btnQtdTarefasEmProgresso";
            this.btnQtdTarefasEmProgresso.Size = new System.Drawing.Size(200, 100);
            this.btnQtdTarefasEmProgresso.TabIndex = 2;
            this.btnQtdTarefasEmProgresso.Text = "\r\n0";
            this.btnQtdTarefasEmProgresso.Click += new System.EventHandler(this.btnQtdTarefasEmProgresso_Click);
            // 
            // btnQtdTarefasPendentes
            // 
            this.btnQtdTarefasPendentes.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnQtdTarefasPendentes.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.btnQtdTarefasPendentes.Appearance.Options.UseFont = true;
            this.btnQtdTarefasPendentes.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasPendentes.Location = new System.Drawing.Point(41, 72);
            this.btnQtdTarefasPendentes.Name = "btnQtdTarefasPendentes";
            this.btnQtdTarefasPendentes.Size = new System.Drawing.Size(200, 100);
            this.btnQtdTarefasPendentes.TabIndex = 1;
            this.btnQtdTarefasPendentes.Text = "\r\n0";
            this.btnQtdTarefasPendentes.Click += new System.EventHandler(this.btnQtdTarefasPendentes_Click);
            // 
            // btnQtdTarefasConcluida
            // 
            this.btnQtdTarefasConcluida.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnQtdTarefasConcluida.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnQtdTarefasConcluida.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.btnQtdTarefasConcluida.Appearance.Options.UseBackColor = true;
            this.btnQtdTarefasConcluida.Appearance.Options.UseFont = true;
            this.btnQtdTarefasConcluida.Appearance.Options.UseForeColor = true;
            this.btnQtdTarefasConcluida.Location = new System.Drawing.Point(497, 72);
            this.btnQtdTarefasConcluida.Name = "btnQtdTarefasConcluida";
            this.btnQtdTarefasConcluida.Size = new System.Drawing.Size(200, 100);
            this.btnQtdTarefasConcluida.TabIndex = 3;
            this.btnQtdTarefasConcluida.Text = "\r\n0";
            this.btnQtdTarefasConcluida.Click += new System.EventHandler(this.btnQtdTarefasConcluida_Click);
            // 
            // pnlListaTarefaaPrioritarias
            // 
            this.pnlListaTarefaaPrioritarias.AutoScroll = true;
            this.pnlListaTarefaaPrioritarias.Location = new System.Drawing.Point(17, 376);
            this.pnlListaTarefaaPrioritarias.Name = "pnlListaTarefaaPrioritarias";
            this.pnlListaTarefaaPrioritarias.Size = new System.Drawing.Size(698, 273);
            this.pnlListaTarefaaPrioritarias.TabIndex = 17;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Location = new System.Drawing.Point(14, 314);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(705, 340);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl5.ImageOptions.SvgImage")));
            this.labelControl5.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl5.Location = new System.Drawing.Point(8, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(207, 30);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "        Tarefas Prioritárias";
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.separatorControl2.Location = new System.Drawing.Point(17, 349);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(698, 21);
            this.separatorControl2.TabIndex = 19;
            // 
            // uc_DashboardTarefas
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.pnlListaTarefaaPrioritarias);
            this.Controls.Add(this.lblConcluidas);
            this.Controls.Add(this.btnQtdTarefasConcluida);
            this.Controls.Add(this.lblEmProgresso);
            this.Controls.Add(this.btnQtdTarefasEmProgresso);
            this.Controls.Add(this.lblPendente);
            this.Controls.Add(this.btnQtdTarefasPendentes);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.panelControl1);
            this.Name = "uc_DashboardTarefas";
            this.Size = new System.Drawing.Size(731, 664);
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgresso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
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
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
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
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
    }
}
