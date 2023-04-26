
namespace Funda_Trabajo_Parcial
{
    partial class AgregarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblMessageErrorClienteAgregado = new System.Windows.Forms.Label();
            this.lblSuccessClienteAgregado = new System.Windows.Forms.Label();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datepickerFechaInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtboxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxNombreProyecto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombreProyecto = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblClienteEmpresa = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtboxNombreEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.lblMessageErrorClienteAgregado);
            this.bunifuPanel1.Controls.Add(this.lblSuccessClienteAgregado);
            this.bunifuPanel1.Controls.Add(this.btnAgregarDatos);
            this.bunifuPanel1.Controls.Add(this.groupBox2);
            this.bunifuPanel1.Controls.Add(this.groupBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // lblMessageErrorClienteAgregado
            // 
            this.lblMessageErrorClienteAgregado.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErrorClienteAgregado.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessageErrorClienteAgregado.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErrorClienteAgregado.Location = new System.Drawing.Point(12, 527);
            this.lblMessageErrorClienteAgregado.Name = "lblMessageErrorClienteAgregado";
            this.lblMessageErrorClienteAgregado.Size = new System.Drawing.Size(828, 33);
            this.lblMessageErrorClienteAgregado.TabIndex = 24;
            this.lblMessageErrorClienteAgregado.Text = "{MessageError}";
            this.lblMessageErrorClienteAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageErrorClienteAgregado.Visible = false;
            // 
            // lblSuccessClienteAgregado
            // 
            this.lblSuccessClienteAgregado.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessClienteAgregado.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuccessClienteAgregado.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccessClienteAgregado.Location = new System.Drawing.Point(8, 527);
            this.lblSuccessClienteAgregado.Name = "lblSuccessClienteAgregado";
            this.lblSuccessClienteAgregado.Size = new System.Drawing.Size(440, 33);
            this.lblSuccessClienteAgregado.TabIndex = 23;
            this.lblSuccessClienteAgregado.Text = "Cliente agregado satisfactoriamente.";
            this.lblSuccessClienteAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuccessClienteAgregado.Visible = false;
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btnAgregarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btnAgregarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnAgregarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDatos.Location = new System.Drawing.Point(846, 523);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(200, 37);
            this.btnAgregarDatos.TabIndex = 7;
            this.btnAgregarDatos.Text = "Agregar Datos";
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.groupBox2.Controls.Add(this.datepickerFechaInicio);
            this.groupBox2.Controls.Add(this.txtboxPrice);
            this.groupBox2.Controls.Add(this.txtboxNombreProyecto);
            this.groupBox2.Controls.Add(this.lblNombreProyecto);
            this.groupBox2.Controls.Add(this.bunifuLabel8);
            this.groupBox2.Controls.Add(this.bunifuLabel2);
            this.groupBox2.Controls.Add(this.lblClienteEmpresa);
            this.groupBox2.Controls.Add(this.bunifuLabel6);
            this.groupBox2.Controls.Add(this.bunifuLabel5);
            this.groupBox2.Controls.Add(this.bunifuLabel4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 290);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del proyecto";
            // 
            // datepickerFechaInicio
            // 
            this.datepickerFechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.datepickerFechaInicio.Checked = true;
            this.datepickerFechaInicio.FillColor = System.Drawing.Color.Transparent;
            this.datepickerFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepickerFechaInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerFechaInicio.Location = new System.Drawing.Point(179, 38);
            this.datepickerFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepickerFechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepickerFechaInicio.Name = "datepickerFechaInicio";
            this.datepickerFechaInicio.Size = new System.Drawing.Size(226, 25);
            this.datepickerFechaInicio.TabIndex = 20;
            this.datepickerFechaInicio.Value = new System.DateTime(2023, 4, 19, 16, 44, 51, 132);
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Animated = true;
            this.txtboxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPrice.DefaultText = "";
            this.txtboxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPrice.Location = new System.Drawing.Point(179, 113);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.PasswordChar = '\0';
            this.txtboxPrice.PlaceholderText = "8700.40";
            this.txtboxPrice.SelectedText = "";
            this.txtboxPrice.Size = new System.Drawing.Size(65, 23);
            this.txtboxPrice.TabIndex = 19;
            this.txtboxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxPrice_Validating);
            this.txtboxPrice.Validated += new System.EventHandler(this.txtboxPrice_Validated);
            // 
            // txtboxNombreProyecto
            // 
            this.txtboxNombreProyecto.Animated = true;
            this.txtboxNombreProyecto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxNombreProyecto.DefaultText = "";
            this.txtboxNombreProyecto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxNombreProyecto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxNombreProyecto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxNombreProyecto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxNombreProyecto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNombreProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxNombreProyecto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNombreProyecto.Location = new System.Drawing.Point(179, 76);
            this.txtboxNombreProyecto.Name = "txtboxNombreProyecto";
            this.txtboxNombreProyecto.PasswordChar = '\0';
            this.txtboxNombreProyecto.PlaceholderText = "Elaboración Landing Page";
            this.txtboxNombreProyecto.SelectedText = "";
            this.txtboxNombreProyecto.Size = new System.Drawing.Size(200, 23);
            this.txtboxNombreProyecto.TabIndex = 18;
            this.txtboxNombreProyecto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxNombreProyecto_KeyUp);
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AllowParentOverrides = false;
            this.lblNombreProyecto.AutoEllipsis = false;
            this.lblNombreProyecto.AutoSize = false;
            this.lblNombreProyecto.CursorType = null;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombreProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreProyecto.Location = new System.Drawing.Point(168, 190);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreProyecto.Size = new System.Drawing.Size(861, 20);
            this.lblNombreProyecto.TabIndex = 14;
            this.lblNombreProyecto.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombreProyecto.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel8.Location = new System.Drawing.Point(16, 190);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(146, 20);
            this.bunifuLabel8.TabIndex = 13;
            this.bunifuLabel8.Text = "Nombre del proyecto:";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel2.Location = new System.Drawing.Point(16, 76);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(146, 20);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Nombre del proyecto:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblClienteEmpresa
            // 
            this.lblClienteEmpresa.AllowParentOverrides = false;
            this.lblClienteEmpresa.AutoEllipsis = false;
            this.lblClienteEmpresa.AutoSize = false;
            this.lblClienteEmpresa.CursorType = null;
            this.lblClienteEmpresa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblClienteEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClienteEmpresa.Location = new System.Drawing.Point(168, 153);
            this.lblClienteEmpresa.Name = "lblClienteEmpresa";
            this.lblClienteEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClienteEmpresa.Size = new System.Drawing.Size(861, 20);
            this.lblClienteEmpresa.TabIndex = 12;
            this.lblClienteEmpresa.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblClienteEmpresa.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel6.Location = new System.Drawing.Point(39, 153);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(120, 20);
            this.bunifuLabel6.TabIndex = 11;
            this.bunifuLabel6.Text = "Cliente / Empresa:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel5.Location = new System.Drawing.Point(87, 113);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(72, 20);
            this.bunifuLabel5.TabIndex = 9;
            this.bunifuLabel5.Text = "Costo (S/.):";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel4.Location = new System.Drawing.Point(61, 39);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(102, 20);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Fecha de inicio:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.txtboxRUC);
            this.groupBox1.Controls.Add(this.bunifuLabel3);
            this.groupBox1.Controls.Add(this.txtboxNombreEmpresa);
            this.groupBox1.Controls.Add(this.bunifuLabel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // txtboxRUC
            // 
            this.txtboxRUC.Animated = true;
            this.txtboxRUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxRUC.DefaultText = "";
            this.txtboxRUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxRUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxRUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxRUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxRUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxRUC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxRUC.Location = new System.Drawing.Point(205, 85);
            this.txtboxRUC.Name = "txtboxRUC";
            this.txtboxRUC.PasswordChar = '\0';
            this.txtboxRUC.PlaceholderText = "10778965293";
            this.txtboxRUC.SelectedText = "";
            this.txtboxRUC.Size = new System.Drawing.Size(92, 23);
            this.txtboxRUC.TabIndex = 17;
            this.txtboxRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxRUC_KeyPress);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel3.Location = new System.Drawing.Point(168, 88);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(31, 20);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "RUC:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtboxNombreEmpresa
            // 
            this.txtboxNombreEmpresa.Animated = true;
            this.txtboxNombreEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxNombreEmpresa.DefaultText = "";
            this.txtboxNombreEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxNombreEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxNombreEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxNombreEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxNombreEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNombreEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxNombreEmpresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNombreEmpresa.Location = new System.Drawing.Point(205, 44);
            this.txtboxNombreEmpresa.Name = "txtboxNombreEmpresa";
            this.txtboxNombreEmpresa.PasswordChar = '\0';
            this.txtboxNombreEmpresa.PlaceholderText = "Facebook INC";
            this.txtboxNombreEmpresa.SelectedText = "";
            this.txtboxNombreEmpresa.Size = new System.Drawing.Size(200, 23);
            this.txtboxNombreEmpresa.TabIndex = 16;
            this.txtboxNombreEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxNombreEmpresa_KeyUp);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel1.Location = new System.Drawing.Point(20, 44);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(179, 20);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Nombre Empresa / Cliente:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "AgregarClientes";
            this.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuLabel lblNombreProyecto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel lblClienteEmpresa;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Label lblSuccessClienteAgregado;
        private System.Windows.Forms.Label lblMessageErrorClienteAgregado;
        private Guna.UI2.WinForms.Guna2TextBox txtboxNombreEmpresa;
        private Guna.UI2.WinForms.Guna2TextBox txtboxRUC;
        private Guna.UI2.WinForms.Guna2TextBox txtboxNombreProyecto;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPrice;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerFechaInicio;
    }
}
