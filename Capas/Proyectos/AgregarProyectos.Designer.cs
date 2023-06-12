
using System.Windows.Forms;

namespace Funda_Trabajo_Parcial
{
    partial class AgregarProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProyectos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickerFechaInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtboxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxNombreProyecto = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboboxClientes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMessageErrorProyectos = new System.Windows.Forms.Label();
            this.lblSuccessProyectos = new System.Windows.Forms.Label();
            this.btnActualizarProyectos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Controls.Add(this.btnAgregarDatos);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.groupBox2);
            this.bunifuPanel1.Controls.Add(this.comboboxClientes);
            this.bunifuPanel1.Controls.Add(this.lblMessageErrorProyectos);
            this.bunifuPanel1.Controls.Add(this.lblSuccessProyectos);
            this.bunifuPanel1.Controls.Add(this.btnActualizarProyectos);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 301);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
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
            this.btnAgregarDatos.Location = new System.Drawing.Point(849, 327);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(200, 37);
            this.btnAgregarDatos.TabIndex = 25;
            this.btnAgregarDatos.Text = "Agregar proyecto";
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(38, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.datepickerFechaInicio);
            this.groupBox2.Controls.Add(this.txtboxPrice);
            this.groupBox2.Controls.Add(this.txtboxNombreProyecto);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(15, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 184);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(104, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Costo (S/.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre del proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // datepickerFechaInicio
            // 
            this.datepickerFechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.datepickerFechaInicio.Checked = true;
            this.datepickerFechaInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.datepickerFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepickerFechaInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerFechaInicio.Location = new System.Drawing.Point(199, 38);
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
            this.txtboxPrice.ForeColor = System.Drawing.Color.Black;
            this.txtboxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPrice.Location = new System.Drawing.Point(199, 113);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.txtboxNombreProyecto.ForeColor = System.Drawing.Color.Black;
            this.txtboxNombreProyecto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNombreProyecto.Location = new System.Drawing.Point(199, 76);
            this.txtboxNombreProyecto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxNombreProyecto.Name = "txtboxNombreProyecto";
            this.txtboxNombreProyecto.PasswordChar = '\0';
            this.txtboxNombreProyecto.PlaceholderText = "Elaboración Landing Page";
            this.txtboxNombreProyecto.SelectedText = "";
            this.txtboxNombreProyecto.Size = new System.Drawing.Size(200, 23);
            this.txtboxNombreProyecto.TabIndex = 18;
            // 
            // comboboxClientes
            // 
            this.comboboxClientes.BackColor = System.Drawing.Color.Transparent;
            this.comboboxClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxClientes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxClientes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxClientes.ItemHeight = 30;
            this.comboboxClientes.Location = new System.Drawing.Point(98, 35);
            this.comboboxClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboboxClientes.Name = "comboboxClientes";
            this.comboboxClientes.Size = new System.Drawing.Size(255, 36);
            this.comboboxClientes.TabIndex = 32;
            this.comboboxClientes.SelectedIndexChanged += new System.EventHandler(this.comboboxClientes_SelectedIndexChanged);
            // 
            // lblMessageErrorProyectos
            // 
            this.lblMessageErrorProyectos.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErrorProyectos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessageErrorProyectos.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErrorProyectos.Location = new System.Drawing.Point(11, 533);
            this.lblMessageErrorProyectos.Name = "lblMessageErrorProyectos";
            this.lblMessageErrorProyectos.Size = new System.Drawing.Size(864, 33);
            this.lblMessageErrorProyectos.TabIndex = 25;
            this.lblMessageErrorProyectos.Text = "{MessageError}";
            this.lblMessageErrorProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageErrorProyectos.Visible = false;
            // 
            // lblSuccessProyectos
            // 
            this.lblSuccessProyectos.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessProyectos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuccessProyectos.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccessProyectos.Location = new System.Drawing.Point(11, 533);
            this.lblSuccessProyectos.Name = "lblSuccessProyectos";
            this.lblSuccessProyectos.Size = new System.Drawing.Size(440, 33);
            this.lblSuccessProyectos.TabIndex = 31;
            this.lblSuccessProyectos.Text = "Proyecto agregado con éxito.";
            this.lblSuccessProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuccessProyectos.Visible = false;
            // 
            // btnActualizarProyectos
            // 
            this.btnActualizarProyectos.AllowAnimations = true;
            this.btnActualizarProyectos.AllowMouseEffects = true;
            this.btnActualizarProyectos.AllowToggling = false;
            this.btnActualizarProyectos.AnimationSpeed = 200;
            this.btnActualizarProyectos.AutoGenerateColors = false;
            this.btnActualizarProyectos.AutoRoundBorders = false;
            this.btnActualizarProyectos.AutoSizeLeftIcon = true;
            this.btnActualizarProyectos.AutoSizeRightIcon = true;
            this.btnActualizarProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarProyectos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnActualizarProyectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarProyectos.BackgroundImage")));
            this.btnActualizarProyectos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarProyectos.ButtonText = "Actualizar";
            this.btnActualizarProyectos.ButtonTextMarginLeft = 0;
            this.btnActualizarProyectos.ColorContrastOnClick = 45;
            this.btnActualizarProyectos.ColorContrastOnHover = 45;
            this.btnActualizarProyectos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnActualizarProyectos.CustomizableEdges = borderEdges1;
            this.btnActualizarProyectos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizarProyectos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActualizarProyectos.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnActualizarProyectos.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnActualizarProyectos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnActualizarProyectos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnActualizarProyectos.IconLeft = null;
            this.btnActualizarProyectos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarProyectos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizarProyectos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnActualizarProyectos.IconMarginLeft = 11;
            this.btnActualizarProyectos.IconPadding = 10;
            this.btnActualizarProyectos.IconRight = null;
            this.btnActualizarProyectos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarProyectos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizarProyectos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnActualizarProyectos.IconSize = 25;
            this.btnActualizarProyectos.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnActualizarProyectos.IdleBorderRadius = 0;
            this.btnActualizarProyectos.IdleBorderThickness = 0;
            this.btnActualizarProyectos.IdleFillColor = System.Drawing.Color.Empty;
            this.btnActualizarProyectos.IdleIconLeftImage = null;
            this.btnActualizarProyectos.IdleIconRightImage = null;
            this.btnActualizarProyectos.IndicateFocus = false;
            this.btnActualizarProyectos.Location = new System.Drawing.Point(881, 527);
            this.btnActualizarProyectos.Name = "btnActualizarProyectos";
            this.btnActualizarProyectos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActualizarProyectos.OnDisabledState.BorderRadius = 30;
            this.btnActualizarProyectos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarProyectos.OnDisabledState.BorderThickness = 2;
            this.btnActualizarProyectos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActualizarProyectos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActualizarProyectos.OnDisabledState.IconLeftImage = null;
            this.btnActualizarProyectos.OnDisabledState.IconRightImage = null;
            this.btnActualizarProyectos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarProyectos.onHoverState.BorderRadius = 30;
            this.btnActualizarProyectos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarProyectos.onHoverState.BorderThickness = 2;
            this.btnActualizarProyectos.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarProyectos.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnActualizarProyectos.onHoverState.IconLeftImage = null;
            this.btnActualizarProyectos.onHoverState.IconRightImage = null;
            this.btnActualizarProyectos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnActualizarProyectos.OnIdleState.BorderRadius = 30;
            this.btnActualizarProyectos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarProyectos.OnIdleState.BorderThickness = 2;
            this.btnActualizarProyectos.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarProyectos.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnActualizarProyectos.OnIdleState.IconLeftImage = null;
            this.btnActualizarProyectos.OnIdleState.IconRightImage = null;
            this.btnActualizarProyectos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnActualizarProyectos.OnPressedState.BorderRadius = 30;
            this.btnActualizarProyectos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarProyectos.OnPressedState.BorderThickness = 2;
            this.btnActualizarProyectos.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnActualizarProyectos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProyectos.OnPressedState.IconLeftImage = null;
            this.btnActualizarProyectos.OnPressedState.IconRightImage = null;
            this.btnActualizarProyectos.Size = new System.Drawing.Size(187, 39);
            this.btnActualizarProyectos.TabIndex = 21;
            this.btnActualizarProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarProyectos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizarProyectos.TextMarginLeft = 0;
            this.btnActualizarProyectos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnActualizarProyectos.UseDefaultRadiusAndThickness = true;
            this.btnActualizarProyectos.Click += new System.EventHandler(this.btnActualizarProyectos_Click);
            // 
            // AgregarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "AgregarProyectos";
            this.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActualizarProyectos;
        private System.Windows.Forms.Label lblSuccessProyectos;
        private System.Windows.Forms.Label lblMessageErrorProyectos;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxClientes;
        private Label label5;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerFechaInicio;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtboxNombreProyecto;
        private Button btnAgregarDatos;
        private PictureBox pictureBox1;
    }
}
