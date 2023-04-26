
using System.Windows.Forms;

namespace Funda_Trabajo_Parcial
{
    partial class ListarProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarProyectos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblSuccessProyectos = new System.Windows.Forms.Label();
            this.btnFinalizarProyecto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridViewProyectos = new System.Windows.Forms.DataGridView();
            this.btnActualizarProyectos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblMessageErrorProyectos = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyectos)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.lblMessageErrorProyectos);
            this.bunifuPanel1.Controls.Add(this.lblSuccessProyectos);
            this.bunifuPanel1.Controls.Add(this.btnFinalizarProyecto);
            this.bunifuPanel1.Controls.Add(this.dataGridViewProyectos);
            this.bunifuPanel1.Controls.Add(this.btnActualizarProyectos);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.TabIndex = 0;
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
            this.lblSuccessProyectos.Text = "{SuccessMessage}";
            this.lblSuccessProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuccessProyectos.Visible = false;
            // 
            // btnFinalizarProyecto
            // 
            this.btnFinalizarProyecto.AllowAnimations = true;
            this.btnFinalizarProyecto.AllowMouseEffects = true;
            this.btnFinalizarProyecto.AllowToggling = false;
            this.btnFinalizarProyecto.AnimationSpeed = 200;
            this.btnFinalizarProyecto.AutoGenerateColors = false;
            this.btnFinalizarProyecto.AutoRoundBorders = false;
            this.btnFinalizarProyecto.AutoSizeLeftIcon = true;
            this.btnFinalizarProyecto.AutoSizeRightIcon = true;
            this.btnFinalizarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarProyecto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnFinalizarProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarProyecto.BackgroundImage")));
            this.btnFinalizarProyecto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarProyecto.ButtonText = "Proyecto finalizado";
            this.btnFinalizarProyecto.ButtonTextMarginLeft = 0;
            this.btnFinalizarProyecto.ColorContrastOnClick = 45;
            this.btnFinalizarProyecto.ColorContrastOnHover = 45;
            this.btnFinalizarProyecto.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFinalizarProyecto.CustomizableEdges = borderEdges1;
            this.btnFinalizarProyecto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizarProyecto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinalizarProyecto.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnFinalizarProyecto.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnFinalizarProyecto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFinalizarProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnFinalizarProyecto.IconLeft = null;
            this.btnFinalizarProyecto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarProyecto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinalizarProyecto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFinalizarProyecto.IconMarginLeft = 11;
            this.btnFinalizarProyecto.IconPadding = 10;
            this.btnFinalizarProyecto.IconRight = null;
            this.btnFinalizarProyecto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarProyecto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinalizarProyecto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFinalizarProyecto.IconSize = 25;
            this.btnFinalizarProyecto.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnFinalizarProyecto.IdleBorderRadius = 0;
            this.btnFinalizarProyecto.IdleBorderThickness = 0;
            this.btnFinalizarProyecto.IdleFillColor = System.Drawing.Color.Empty;
            this.btnFinalizarProyecto.IdleIconLeftImage = null;
            this.btnFinalizarProyecto.IdleIconRightImage = null;
            this.btnFinalizarProyecto.IndicateFocus = false;
            this.btnFinalizarProyecto.Location = new System.Drawing.Point(688, 527);
            this.btnFinalizarProyecto.Name = "btnFinalizarProyecto";
            this.btnFinalizarProyecto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinalizarProyecto.OnDisabledState.BorderRadius = 30;
            this.btnFinalizarProyecto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarProyecto.OnDisabledState.BorderThickness = 2;
            this.btnFinalizarProyecto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFinalizarProyecto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFinalizarProyecto.OnDisabledState.IconLeftImage = null;
            this.btnFinalizarProyecto.OnDisabledState.IconRightImage = null;
            this.btnFinalizarProyecto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinalizarProyecto.onHoverState.BorderRadius = 30;
            this.btnFinalizarProyecto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarProyecto.onHoverState.BorderThickness = 2;
            this.btnFinalizarProyecto.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinalizarProyecto.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnFinalizarProyecto.onHoverState.IconLeftImage = null;
            this.btnFinalizarProyecto.onHoverState.IconRightImage = null;
            this.btnFinalizarProyecto.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnFinalizarProyecto.OnIdleState.BorderRadius = 30;
            this.btnFinalizarProyecto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarProyecto.OnIdleState.BorderThickness = 2;
            this.btnFinalizarProyecto.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinalizarProyecto.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnFinalizarProyecto.OnIdleState.IconLeftImage = null;
            this.btnFinalizarProyecto.OnIdleState.IconRightImage = null;
            this.btnFinalizarProyecto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnFinalizarProyecto.OnPressedState.BorderRadius = 30;
            this.btnFinalizarProyecto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarProyecto.OnPressedState.BorderThickness = 2;
            this.btnFinalizarProyecto.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnFinalizarProyecto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarProyecto.OnPressedState.IconLeftImage = null;
            this.btnFinalizarProyecto.OnPressedState.IconRightImage = null;
            this.btnFinalizarProyecto.Size = new System.Drawing.Size(187, 39);
            this.btnFinalizarProyecto.TabIndex = 23;
            this.btnFinalizarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizarProyecto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizarProyecto.TextMarginLeft = 0;
            this.btnFinalizarProyecto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFinalizarProyecto.UseDefaultRadiusAndThickness = true;
            this.btnFinalizarProyecto.Click += new System.EventHandler(this.btnFinalizarProyecto_Click);
            // 
            // dataGridViewProyectos
            // 
            this.dataGridViewProyectos.AllowUserToAddRows = false;
            this.dataGridViewProyectos.AllowUserToDeleteRows = false;
            this.dataGridViewProyectos.AllowUserToOrderColumns = true;
            this.dataGridViewProyectos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProyectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProyectos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.dataGridViewProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProyectos.ColumnHeadersHeight = 30;
            this.dataGridViewProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProyectos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProyectos.EnableHeadersVisualStyles = false;
            this.dataGridViewProyectos.Location = new System.Drawing.Point(15, 10);
            this.dataGridViewProyectos.Name = "dataGridViewProyectos";
            this.dataGridViewProyectos.ReadOnly = true;
            this.dataGridViewProyectos.RowHeadersVisible = false;
            this.dataGridViewProyectos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProyectos.RowTemplate.Height = 50;
            this.dataGridViewProyectos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProyectos.Size = new System.Drawing.Size(1053, 502);
            this.dataGridViewProyectos.TabIndex = 22;
            this.dataGridViewProyectos.MouseWheel += new MouseEventHandler(dataGridViewProyectos_MouseWheel);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnActualizarProyectos.CustomizableEdges = borderEdges2;
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
            // lblMessageErrorProyectos
            // 
            this.lblMessageErrorProyectos.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErrorProyectos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessageErrorProyectos.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErrorProyectos.Location = new System.Drawing.Point(11, 533);
            this.lblMessageErrorProyectos.Name = "lblMessageErrorProyectos";
            this.lblMessageErrorProyectos.Size = new System.Drawing.Size(440, 33);
            this.lblMessageErrorProyectos.TabIndex = 25;
            this.lblMessageErrorProyectos.Text = "{MessageError}";
            this.lblMessageErrorProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageErrorProyectos.Visible = false;
            // 
            // ListarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ListarProyectos";
            this.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActualizarProyectos;
        private System.Windows.Forms.DataGridView dataGridViewProyectos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFinalizarProyecto;
        private System.Windows.Forms.Label lblSuccessProyectos;
        private System.Windows.Forms.Label lblMessageErrorProyectos;
    }
}
