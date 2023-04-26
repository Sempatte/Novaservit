
namespace Funda_Trabajo_Parcial
{
    partial class ModificarProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProyectos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblMessageErrorModificarProyecto = new System.Windows.Forms.Label();
            this.lblSuccessModificarProyecto = new System.Windows.Forms.Label();
            this.btnGuardarDatosProyecto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridViewProyectoEditables = new System.Windows.Forms.DataGridView();
            this.comboBoxListProyectos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUserC = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyectoEditables)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.lblMessageErrorModificarProyecto);
            this.bunifuPanel1.Controls.Add(this.lblSuccessModificarProyecto);
            this.bunifuPanel1.Controls.Add(this.btnGuardarDatosProyecto);
            this.bunifuPanel1.Controls.Add(this.dataGridViewProyectoEditables);
            this.bunifuPanel1.Controls.Add(this.comboBoxListProyectos);
            this.bunifuPanel1.Controls.Add(this.lblUserC);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // lblMessageErrorModificarProyecto
            // 
            this.lblMessageErrorModificarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErrorModificarProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessageErrorModificarProyecto.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErrorModificarProyecto.Location = new System.Drawing.Point(8, 536);
            this.lblMessageErrorModificarProyecto.Name = "lblMessageErrorModificarProyecto";
            this.lblMessageErrorModificarProyecto.Size = new System.Drawing.Size(440, 33);
            this.lblMessageErrorModificarProyecto.TabIndex = 31;
            this.lblMessageErrorModificarProyecto.Text = "{MessageError}";
            this.lblMessageErrorModificarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageErrorModificarProyecto.Visible = false;
            // 
            // lblSuccessModificarProyecto
            // 
            this.lblSuccessModificarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessModificarProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuccessModificarProyecto.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccessModificarProyecto.Location = new System.Drawing.Point(6, 536);
            this.lblSuccessModificarProyecto.Name = "lblSuccessModificarProyecto";
            this.lblSuccessModificarProyecto.Size = new System.Drawing.Size(440, 33);
            this.lblSuccessModificarProyecto.TabIndex = 30;
            this.lblSuccessModificarProyecto.Text = "Cliente actualizado.";
            this.lblSuccessModificarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuccessModificarProyecto.Visible = false;
            // 
            // btnGuardarDatosProyecto
            // 
            this.btnGuardarDatosProyecto.AllowAnimations = true;
            this.btnGuardarDatosProyecto.AllowMouseEffects = true;
            this.btnGuardarDatosProyecto.AllowToggling = false;
            this.btnGuardarDatosProyecto.AnimationSpeed = 200;
            this.btnGuardarDatosProyecto.AutoGenerateColors = false;
            this.btnGuardarDatosProyecto.AutoRoundBorders = false;
            this.btnGuardarDatosProyecto.AutoSizeLeftIcon = true;
            this.btnGuardarDatosProyecto.AutoSizeRightIcon = true;
            this.btnGuardarDatosProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarDatosProyecto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGuardarDatosProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarDatosProyecto.BackgroundImage")));
            this.btnGuardarDatosProyecto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatosProyecto.ButtonText = "Guardar";
            this.btnGuardarDatosProyecto.ButtonTextMarginLeft = 0;
            this.btnGuardarDatosProyecto.ColorContrastOnClick = 45;
            this.btnGuardarDatosProyecto.ColorContrastOnHover = 45;
            this.btnGuardarDatosProyecto.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGuardarDatosProyecto.CustomizableEdges = borderEdges1;
            this.btnGuardarDatosProyecto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarDatosProyecto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardarDatosProyecto.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGuardarDatosProyecto.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGuardarDatosProyecto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGuardarDatosProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDatosProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnGuardarDatosProyecto.IconLeft = null;
            this.btnGuardarDatosProyecto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDatosProyecto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarDatosProyecto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGuardarDatosProyecto.IconMarginLeft = 11;
            this.btnGuardarDatosProyecto.IconPadding = 10;
            this.btnGuardarDatosProyecto.IconRight = null;
            this.btnGuardarDatosProyecto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDatosProyecto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarDatosProyecto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGuardarDatosProyecto.IconSize = 25;
            this.btnGuardarDatosProyecto.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGuardarDatosProyecto.IdleBorderRadius = 0;
            this.btnGuardarDatosProyecto.IdleBorderThickness = 0;
            this.btnGuardarDatosProyecto.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGuardarDatosProyecto.IdleIconLeftImage = null;
            this.btnGuardarDatosProyecto.IdleIconRightImage = null;
            this.btnGuardarDatosProyecto.IndicateFocus = false;
            this.btnGuardarDatosProyecto.Location = new System.Drawing.Point(887, 530);
            this.btnGuardarDatosProyecto.Name = "btnGuardarDatosProyecto";
            this.btnGuardarDatosProyecto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardarDatosProyecto.OnDisabledState.BorderRadius = 30;
            this.btnGuardarDatosProyecto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatosProyecto.OnDisabledState.BorderThickness = 2;
            this.btnGuardarDatosProyecto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardarDatosProyecto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardarDatosProyecto.OnDisabledState.IconLeftImage = null;
            this.btnGuardarDatosProyecto.OnDisabledState.IconRightImage = null;
            this.btnGuardarDatosProyecto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarDatosProyecto.onHoverState.BorderRadius = 30;
            this.btnGuardarDatosProyecto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatosProyecto.onHoverState.BorderThickness = 2;
            this.btnGuardarDatosProyecto.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarDatosProyecto.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnGuardarDatosProyecto.onHoverState.IconLeftImage = null;
            this.btnGuardarDatosProyecto.onHoverState.IconRightImage = null;
            this.btnGuardarDatosProyecto.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnGuardarDatosProyecto.OnIdleState.BorderRadius = 30;
            this.btnGuardarDatosProyecto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatosProyecto.OnIdleState.BorderThickness = 2;
            this.btnGuardarDatosProyecto.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarDatosProyecto.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnGuardarDatosProyecto.OnIdleState.IconLeftImage = null;
            this.btnGuardarDatosProyecto.OnIdleState.IconRightImage = null;
            this.btnGuardarDatosProyecto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnGuardarDatosProyecto.OnPressedState.BorderRadius = 30;
            this.btnGuardarDatosProyecto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatosProyecto.OnPressedState.BorderThickness = 2;
            this.btnGuardarDatosProyecto.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnGuardarDatosProyecto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDatosProyecto.OnPressedState.IconLeftImage = null;
            this.btnGuardarDatosProyecto.OnPressedState.IconRightImage = null;
            this.btnGuardarDatosProyecto.Size = new System.Drawing.Size(187, 39);
            this.btnGuardarDatosProyecto.TabIndex = 29;
            this.btnGuardarDatosProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarDatosProyecto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardarDatosProyecto.TextMarginLeft = 0;
            this.btnGuardarDatosProyecto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGuardarDatosProyecto.UseDefaultRadiusAndThickness = true;
            this.btnGuardarDatosProyecto.Click += new System.EventHandler(this.btnGuardarDatosProyecto_Click);
            // 
            // dataGridViewProyectoEditables
            // 
            this.dataGridViewProyectoEditables.AllowUserToAddRows = false;
            this.dataGridViewProyectoEditables.AllowUserToDeleteRows = false;
            this.dataGridViewProyectoEditables.AllowUserToOrderColumns = true;
            this.dataGridViewProyectoEditables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProyectoEditables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProyectoEditables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProyectoEditables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.dataGridViewProyectoEditables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProyectoEditables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProyectoEditables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProyectoEditables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProyectoEditables.ColumnHeadersHeight = 30;
            this.dataGridViewProyectoEditables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProyectoEditables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column5,
            this.ColumnEstado});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProyectoEditables.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProyectoEditables.EnableHeadersVisualStyles = false;
            this.dataGridViewProyectoEditables.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewProyectoEditables.Name = "dataGridViewProyectoEditables";
            this.dataGridViewProyectoEditables.RowHeadersVisible = false;
            this.dataGridViewProyectoEditables.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProyectoEditables.RowTemplate.Height = 50;
            this.dataGridViewProyectoEditables.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewProyectoEditables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProyectoEditables.Size = new System.Drawing.Size(1060, 82);
            this.dataGridViewProyectoEditables.TabIndex = 28;
            // 
            // comboBoxListProyectos
            // 
            this.comboBoxListProyectos.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxListProyectos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.comboBoxListProyectos.BorderRadius = 1;
            this.comboBoxListProyectos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxListProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListProyectos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxListProyectos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxListProyectos.FocusedState.Parent = this.comboBoxListProyectos;
            this.comboBoxListProyectos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxListProyectos.ForeColor = System.Drawing.Color.Black;
            this.comboBoxListProyectos.HoverState.Parent = this.comboBoxListProyectos;
            this.comboBoxListProyectos.ItemHeight = 17;
            this.comboBoxListProyectos.ItemsAppearance.Parent = this.comboBoxListProyectos;
            this.comboBoxListProyectos.Location = new System.Drawing.Point(100, 15);
            this.comboBoxListProyectos.Name = "comboBoxListProyectos";
            this.comboBoxListProyectos.ShadowDecoration.Parent = this.comboBoxListProyectos;
            this.comboBoxListProyectos.Size = new System.Drawing.Size(972, 23);
            this.comboBoxListProyectos.TabIndex = 27;
            this.comboBoxListProyectos.SelectedIndexChanged += new System.EventHandler(this.comboBoxListProyectos_SelectedIndexChanged);
            // 
            // lblUserC
            // 
            this.lblUserC.AutoSize = true;
            this.lblUserC.BackColor = System.Drawing.Color.Transparent;
            this.lblUserC.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblUserC.ForeColor = System.Drawing.Color.White;
            this.lblUserC.Location = new System.Drawing.Point(7, 13);
            this.lblUserC.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserC.Name = "lblUserC";
            this.lblUserC.Size = new System.Drawing.Size(90, 25);
            this.lblUserC.TabIndex = 25;
            this.lblUserC.Text = "Proyecto:";
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Nombre del proyecto";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Fecha de Inicio";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Format = "C2";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Costo (S/.)";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnEstado
            // 
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4);
            this.ColumnEstado.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnEstado.DisplayStyleForCurrentCellOnly = true;
            this.ColumnEstado.FillWeight = 30F;
            this.ColumnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Items.AddRange(new object[] {
            "Finalizado",
            "No finalizado"});
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ModificarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ModificarProyectos";
            this.Size = new System.Drawing.Size(1077, 581);
            this.Load += new System.EventHandler(this.ModificarClientes_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyectoEditables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lblUserC;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxListProyectos;
        private System.Windows.Forms.DataGridView dataGridViewProyectoEditables;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGuardarDatosProyecto;
        private System.Windows.Forms.Label lblMessageErrorModificarProyecto;
        private System.Windows.Forms.Label lblSuccessModificarProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnEstado;
    }
}
