
namespace Funda_Trabajo_Parcial
{
    partial class InicioDeSesion
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
        public string GetUsuarioLogin
        {
            get { return txtboxUsuario.Text; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panelDerechoLogin = new Bunifu.UI.WinForms.BunifuPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LoaderLogin = new Bunifu.UI.WinForms.BunifuLoader();
            this.lblError = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtboxContrasena = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtboxUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFondo = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDerechoLogin.SuspendLayout();
            this.PanelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDerechoLogin
            // 
            this.panelDerechoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDerechoLogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelDerechoLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDerechoLogin.BackgroundImage")));
            this.panelDerechoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDerechoLogin.BorderColor = System.Drawing.Color.Transparent;
            this.panelDerechoLogin.BorderRadius = 3;
            this.panelDerechoLogin.BorderThickness = 0;
            this.panelDerechoLogin.Controls.Add(this.label3);
            this.panelDerechoLogin.Controls.Add(this.label1);
            this.panelDerechoLogin.Controls.Add(this.btnRegister);
            this.panelDerechoLogin.Controls.Add(this.btnLogin);
            this.panelDerechoLogin.Controls.Add(this.LoaderLogin);
            this.panelDerechoLogin.Controls.Add(this.lblError);
            this.panelDerechoLogin.Controls.Add(this.linkLabel1);
            this.panelDerechoLogin.Controls.Add(this.txtboxContrasena);
            this.panelDerechoLogin.Controls.Add(this.bunifuSeparator1);
            this.panelDerechoLogin.Controls.Add(this.txtboxUsuario);
            this.panelDerechoLogin.Controls.Add(this.label2);
            this.panelDerechoLogin.Location = new System.Drawing.Point(364, 12);
            this.panelDerechoLogin.Name = "panelDerechoLogin";
            this.panelDerechoLogin.ShowBorders = true;
            this.panelDerechoLogin.Size = new System.Drawing.Size(513, 449);
            this.panelDerechoLogin.TabIndex = 8;
            this.panelDerechoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDerechoLogin_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario";
            // 
            // btnRegister
            // 
            this.btnRegister.AllowAnimations = true;
            this.btnRegister.AllowMouseEffects = true;
            this.btnRegister.AllowToggling = false;
            this.btnRegister.AnimationSpeed = 200;
            this.btnRegister.AutoGenerateColors = false;
            this.btnRegister.AutoRoundBorders = false;
            this.btnRegister.AutoSizeLeftIcon = true;
            this.btnRegister.AutoSizeRightIcon = true;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.ButtonText = "Registrarse";
            this.btnRegister.ButtonTextMarginLeft = 0;
            this.btnRegister.ColorContrastOnClick = 45;
            this.btnRegister.ColorContrastOnHover = 45;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRegister.CustomizableEdges = borderEdges1;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegister.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRegister.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRegister.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnRegister.IconLeft = null;
            this.btnRegister.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegister.IconMarginLeft = 11;
            this.btnRegister.IconPadding = 10;
            this.btnRegister.IconRight = null;
            this.btnRegister.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegister.IconSize = 25;
            this.btnRegister.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRegister.IdleBorderRadius = 0;
            this.btnRegister.IdleBorderThickness = 0;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRegister.IdleIconLeftImage = null;
            this.btnRegister.IdleIconRightImage = null;
            this.btnRegister.IndicateFocus = false;
            this.btnRegister.Location = new System.Drawing.Point(206, 384);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegister.OnDisabledState.BorderRadius = 30;
            this.btnRegister.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnDisabledState.BorderThickness = 2;
            this.btnRegister.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegister.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.OnDisabledState.IconLeftImage = null;
            this.btnRegister.OnDisabledState.IconRightImage = null;
            this.btnRegister.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegister.onHoverState.BorderRadius = 30;
            this.btnRegister.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.onHoverState.BorderThickness = 2;
            this.btnRegister.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnRegister.onHoverState.IconLeftImage = null;
            this.btnRegister.onHoverState.IconRightImage = null;
            this.btnRegister.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnRegister.OnIdleState.BorderRadius = 30;
            this.btnRegister.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnIdleState.BorderThickness = 2;
            this.btnRegister.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnRegister.OnIdleState.IconLeftImage = null;
            this.btnRegister.OnIdleState.IconRightImage = null;
            this.btnRegister.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnRegister.OnPressedState.BorderRadius = 30;
            this.btnRegister.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnPressedState.BorderThickness = 2;
            this.btnRegister.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnRegister.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnPressedState.IconLeftImage = null;
            this.btnRegister.OnPressedState.IconRightImage = null;
            this.btnRegister.Size = new System.Drawing.Size(118, 39);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.TextMarginLeft = 0;
            this.btnRegister.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegister.UseDefaultRadiusAndThickness = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.ButtonText = "Iniciar sesión";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges2;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLogin.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnLogin.IconLeft = null;
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRight = null;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLogin.IdleBorderRadius = 0;
            this.btnLogin.IdleBorderThickness = 0;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(175, 339);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.OnDisabledState.BorderRadius = 30;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 2;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.onHoverState.BorderRadius = 30;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 2;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnLogin.OnIdleState.BorderRadius = 30;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnIdleState.BorderThickness = 2;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnLogin.OnIdleState.IconLeftImage = null;
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnLogin.OnPressedState.BorderRadius = 30;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 2;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(187, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoaderLogin
            // 
            this.LoaderLogin.AllowStylePresets = true;
            this.LoaderLogin.BackColor = System.Drawing.Color.Transparent;
            this.LoaderLogin.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.LoaderLogin.Color = System.Drawing.Color.Coral;
            this.LoaderLogin.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.LoaderLogin.Customization = "";
            this.LoaderLogin.DashWidth = 0.5F;
            this.LoaderLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoaderLogin.Image = null;
            this.LoaderLogin.Location = new System.Drawing.Point(253, 303);
            this.LoaderLogin.Name = "LoaderLogin";
            this.LoaderLogin.NoRounding = false;
            this.LoaderLogin.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Dotted;
            this.LoaderLogin.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Dotted;
            this.LoaderLogin.ShowText = false;
            this.LoaderLogin.Size = new System.Drawing.Size(30, 30);
            this.LoaderLogin.Speed = 4;
            this.LoaderLogin.TabIndex = 12;
            this.LoaderLogin.Text = "bunifuLoader1";
            this.LoaderLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoaderLogin.Thickness = 6;
            this.LoaderLogin.Transparent = true;
            this.LoaderLogin.Visible = false;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(171, 267);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(208, 33);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "{ErrorMessage}";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(402, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvide mi contraseña";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // txtboxContrasena
            // 
            this.txtboxContrasena.AcceptsReturn = false;
            this.txtboxContrasena.AcceptsTab = false;
            this.txtboxContrasena.AnimationSpeed = 200;
            this.txtboxContrasena.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtboxContrasena.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtboxContrasena.AutoSizeHeight = true;
            this.txtboxContrasena.BackColor = System.Drawing.Color.Transparent;
            this.txtboxContrasena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtboxContrasena.BackgroundImage")));
            this.txtboxContrasena.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxContrasena.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtboxContrasena.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxContrasena.BorderColorIdle = System.Drawing.Color.White;
            this.txtboxContrasena.BorderRadius = 32;
            this.txtboxContrasena.BorderThickness = 1;
            this.txtboxContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtboxContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxContrasena.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtboxContrasena.DefaultText = "";
            this.txtboxContrasena.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.txtboxContrasena.ForeColor = System.Drawing.Color.White;
            this.txtboxContrasena.HideSelection = true;
            this.txtboxContrasena.IconLeft = global::Funda_Trabajo_Parcial.Properties.Resources._lock;
            this.txtboxContrasena.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxContrasena.IconPadding = 9;
            this.txtboxContrasena.IconRight = null;
            this.txtboxContrasena.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxContrasena.Lines = new string[0];
            this.txtboxContrasena.Location = new System.Drawing.Point(119, 226);
            this.txtboxContrasena.MaxLength = 32767;
            this.txtboxContrasena.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtboxContrasena.Modified = false;
            this.txtboxContrasena.Multiline = false;
            this.txtboxContrasena.Name = "txtboxContrasena";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtboxContrasena.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtboxContrasena.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtboxContrasena.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtboxContrasena.OnIdleState = stateProperties4;
            this.txtboxContrasena.Padding = new System.Windows.Forms.Padding(3);
            this.txtboxContrasena.PasswordChar = '●';
            this.txtboxContrasena.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtboxContrasena.PlaceholderText = "Enter password";
            this.txtboxContrasena.ReadOnly = false;
            this.txtboxContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxContrasena.SelectedText = "";
            this.txtboxContrasena.SelectionLength = 0;
            this.txtboxContrasena.SelectionStart = 0;
            this.txtboxContrasena.ShortcutsEnabled = true;
            this.txtboxContrasena.Size = new System.Drawing.Size(298, 39);
            this.txtboxContrasena.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtboxContrasena.TabIndex = 2;
            this.txtboxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxContrasena.TextMarginBottom = 0;
            this.txtboxContrasena.TextMarginLeft = 7;
            this.txtboxContrasena.TextMarginTop = 1;
            this.txtboxContrasena.TextPlaceholder = "Enter password";
            this.txtboxContrasena.UseSystemPasswordChar = true;
            this.txtboxContrasena.WordWrap = true;
            this.txtboxContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxContrasena_KeyDown);
            this.txtboxContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxContrasena_KeyPress);
            this.txtboxContrasena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxContrasena_KeyUp);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(155, 80);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(224, 14);
            this.bunifuSeparator1.TabIndex = 7;
            // 
            // txtboxUsuario
            // 
            this.txtboxUsuario.AcceptsReturn = false;
            this.txtboxUsuario.AcceptsTab = false;
            this.txtboxUsuario.AnimationSpeed = 200;
            this.txtboxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtboxUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtboxUsuario.AutoSizeHeight = true;
            this.txtboxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtboxUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtboxUsuario.BackgroundImage")));
            this.txtboxUsuario.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtboxUsuario.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtboxUsuario.BorderColorIdle = System.Drawing.Color.White;
            this.txtboxUsuario.BorderRadius = 32;
            this.txtboxUsuario.BorderThickness = 1;
            this.txtboxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtboxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUsuario.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtboxUsuario.DefaultText = "";
            this.txtboxUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.txtboxUsuario.ForeColor = System.Drawing.Color.White;
            this.txtboxUsuario.HideSelection = true;
            this.txtboxUsuario.IconLeft = global::Funda_Trabajo_Parcial.Properties.Resources.user;
            this.txtboxUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUsuario.IconPadding = 8;
            this.txtboxUsuario.IconRight = null;
            this.txtboxUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUsuario.Lines = new string[0];
            this.txtboxUsuario.Location = new System.Drawing.Point(119, 150);
            this.txtboxUsuario.MaxLength = 32767;
            this.txtboxUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtboxUsuario.Modified = false;
            this.txtboxUsuario.Multiline = false;
            this.txtboxUsuario.Name = "txtboxUsuario";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtboxUsuario.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtboxUsuario.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtboxUsuario.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtboxUsuario.OnIdleState = stateProperties8;
            this.txtboxUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.txtboxUsuario.PasswordChar = '\0';
            this.txtboxUsuario.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtboxUsuario.PlaceholderText = "JhonDoe";
            this.txtboxUsuario.ReadOnly = false;
            this.txtboxUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxUsuario.SelectedText = "";
            this.txtboxUsuario.SelectionLength = 0;
            this.txtboxUsuario.SelectionStart = 0;
            this.txtboxUsuario.ShortcutsEnabled = true;
            this.txtboxUsuario.Size = new System.Drawing.Size(298, 39);
            this.txtboxUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtboxUsuario.TabIndex = 1;
            this.txtboxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxUsuario.TextMarginBottom = 0;
            this.txtboxUsuario.TextMarginLeft = 7;
            this.txtboxUsuario.TextMarginTop = 1;
            this.txtboxUsuario.TextPlaceholder = "JhonDoe";
            this.txtboxUsuario.UseSystemPasswordChar = false;
            this.txtboxUsuario.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iniciar sesión";
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.Transparent;
            this.PanelFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFondo.BackgroundImage")));
            this.PanelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelFondo.BorderRadius = 1;
            this.PanelFondo.Controls.Add(this.guna2ImageButton1);
            this.PanelFondo.Controls.Add(this.pictureBox1);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFondo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.PanelFondo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.PanelFondo.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.PanelFondo.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.PanelFondo.Location = new System.Drawing.Point(0, 0);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Quality = 10;
            this.PanelFondo.Size = new System.Drawing.Size(353, 473);
            this.PanelFondo.TabIndex = 5;
            this.PanelFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelFondo_MouseDown);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Funda_Trabajo_Parcial.Properties.Resources.cancelar;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(33, 38);
            this.guna2ImageButton1.TabIndex = 15;
            this.guna2ImageButton1.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funda_Trabajo_Parcial.Properties.Resources.LOGO_NOVA;
            this.pictureBox1.Location = new System.Drawing.Point(30, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(884, 473);
            this.Controls.Add(this.panelDerechoLogin);
            this.Controls.Add(this.PanelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioDeSesion";
            this.Text = "InicioDeSesion";
            this.panelDerechoLogin.ResumeLayout(false);
            this.panelDerechoLogin.PerformLayout();
            this.PanelFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuGradientPanel PanelFondo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txtboxUsuario;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel panelDerechoLogin;
        private Bunifu.UI.WinForms.BunifuTextBox txtboxContrasena;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblError;
        private Bunifu.UI.WinForms.BunifuLoader LoaderLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegister;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}