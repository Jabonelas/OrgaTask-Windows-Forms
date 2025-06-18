namespace WindowsForms
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlTelaPrincipal = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.BarraMenuLateral = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCadastrarTarefa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTarefas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLogin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTrocarUsuario = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSair = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblImagemUsuario = new DevExpress.XtraEditors.LabelControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarraMenuLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.fluentDesignFormControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTelaPrincipal
            // 
            this.pnlTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTelaPrincipal.Location = new System.Drawing.Point(250, 31);
            this.pnlTelaPrincipal.Name = "pnlTelaPrincipal";
            this.pnlTelaPrincipal.Size = new System.Drawing.Size(737, 672);
            this.pnlTelaPrincipal.TabIndex = 0;
            // 
            // BarraMenuLateral
            // 
            this.BarraMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenuLateral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHome,
            this.btnCadastrarTarefa,
            this.btnTarefas,
            this.btnLogin});
            this.BarraMenuLateral.Location = new System.Drawing.Point(0, 31);
            this.BarraMenuLateral.Name = "BarraMenuLateral";
            this.BarraMenuLateral.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.BarraMenuLateral.Size = new System.Drawing.Size(250, 672);
            this.BarraMenuLateral.TabIndex = 1;
            this.BarraMenuLateral.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.BarraMenuLateral.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Appearance.Default.Options.UseFont = true;
            this.btnHome.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnHome.Name = "btnHome";
            this.btnHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCadastrarTarefa
            // 
            this.btnCadastrarTarefa.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTarefa.Appearance.Default.Options.UseFont = true;
            this.btnCadastrarTarefa.Name = "btnCadastrarTarefa";
            this.btnCadastrarTarefa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCadastrarTarefa.Text = "Nova Tarefa";
            this.btnCadastrarTarefa.Click += new System.EventHandler(this.btnCadastrarTarefa_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.Appearance.Default.Options.UseFont = true;
            this.btnTarefas.Expanded = true;
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Default.Options.UseFont = true;
            this.btnLogin.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnTrocarUsuario,
            this.btnSair});
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "Login";
            // 
            // btnTrocarUsuario
            // 
            this.btnTrocarUsuario.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarUsuario.Appearance.Default.Options.UseFont = true;
            this.btnTrocarUsuario.Name = "btnTrocarUsuario";
            this.btnTrocarUsuario.Text = "Trocar usuário";
            this.btnTrocarUsuario.Click += new System.EventHandler(this.btnTrocarUsuario_Click);
            // 
            // btnSair
            // 
            this.btnSair.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Appearance.Default.Options.UseFont = true;
            this.btnSair.Name = "btnSair";
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Controls.Add(this.lblUsuario);
            this.fluentDesignFormControl1.Controls.Add(this.lblImagemUsuario);
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(987, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(278, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // lblImagemUsuario
            // 
            this.lblImagemUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblImagemUsuario.ImageOptions.SvgImage")));
            this.lblImagemUsuario.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.lblImagemUsuario.Location = new System.Drawing.Point(252, 7);
            this.lblImagemUsuario.Name = "lblImagemUsuario";
            this.lblImagemUsuario.Size = new System.Drawing.Size(20, 20);
            this.lblImagemUsuario.TabIndex = 4;
            this.lblImagemUsuario.Visible = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 7;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 703);
            this.ControlContainer = this.pnlTelaPrincipal;
            this.Controls.Add(this.pnlTelaPrincipal);
            this.Controls.Add(this.BarraMenuLateral);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.SvgImage = global::WindowsForms.Properties.Resources.IconeOrgaTask;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.NavigationControl = this.BarraMenuLateral;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrgaTask";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarraMenuLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.fluentDesignFormControl1.ResumeLayout(false);
            this.fluentDesignFormControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLogin;
        public DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pnlTelaPrincipal;
        public DevExpress.XtraBars.Navigation.AccordionControl BarraMenuLateral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCadastrarTarefa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTarefas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTrocarUsuario;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSair;
        public DevExpress.XtraEditors.LabelControl lblUsuario;
        public DevExpress.XtraEditors.LabelControl lblImagemUsuario;
    }
}