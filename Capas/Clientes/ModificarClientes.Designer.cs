
namespace Funda_Trabajo_Parcial
{
    partial class ModificarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarClientes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblMessageErrorModificarCliente = new System.Windows.Forms.Label();
            this.lblSuccessModificarCliente = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridViewClienteEditables = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxListClientes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUserC = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienteEditables)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.guna2PictureBox1);
            this.bunifuPanel1.Controls.Add(this.lblMessageErrorModificarCliente);
            this.bunifuPanel1.Controls.Add(this.lblSuccessModificarCliente);
            this.bunifuPanel1.Controls.Add(this.btnGuardarDatos);
            this.bunifuPanel1.Controls.Add(this.dataGridViewClienteEditables);
            this.bunifuPanel1.Controls.Add(this.comboBoxListClientes);
            this.bunifuPanel1.Controls.Add(this.lblUserC);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.guna2PictureBox1.Image = global::Funda_Trabajo_Parcial.Properties.Resources.portada_servicio_al_cliente;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(355, 184);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(392, 350);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblMessageErrorModificarCliente
            // 
            this.lblMessageErrorModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErrorModificarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessageErrorModificarCliente.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErrorModificarCliente.Location = new System.Drawing.Point(8, 536);
            this.lblMessageErrorModificarCliente.Name = "lblMessageErrorModificarCliente";
            this.lblMessageErrorModificarCliente.Size = new System.Drawing.Size(857, 33);
            this.lblMessageErrorModificarCliente.TabIndex = 31;
            this.lblMessageErrorModificarCliente.Text = "{MessageError}";
            this.lblMessageErrorModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageErrorModificarCliente.Visible = false;
            // 
            // lblSuccessModificarCliente
            // 
            this.lblSuccessModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessModificarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuccessModificarCliente.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccessModificarCliente.Location = new System.Drawing.Point(6, 536);
            this.lblSuccessModificarCliente.Name = "lblSuccessModificarCliente";
            this.lblSuccessModificarCliente.Size = new System.Drawing.Size(440, 33);
            this.lblSuccessModificarCliente.TabIndex = 30;
            this.lblSuccessModificarCliente.Text = "Cliente actualizado.";
            this.lblSuccessModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuccessModificarCliente.Visible = false;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.AllowAnimations = true;
            this.btnGuardarDatos.AllowMouseEffects = true;
            this.btnGuardarDatos.AllowToggling = false;
            this.btnGuardarDatos.AnimationSpeed = 200;
            this.btnGuardarDatos.AutoGenerateColors = false;
            this.btnGuardarDatos.AutoRoundBorders = false;
            this.btnGuardarDatos.AutoSizeLeftIcon = true;
            this.btnGuardarDatos.AutoSizeRightIcon = true;
            this.btnGuardarDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarDatos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGuardarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarDatos.BackgroundImage")));
            this.btnGuardarDatos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatos.ButtonText = "Guardar cambios";
            this.btnGuardarDatos.ButtonTextMarginLeft = 0;
            this.btnGuardarDatos.ColorContrastOnClick = 45;
            this.btnGuardarDatos.ColorContrastOnHover = 45;
            this.btnGuardarDatos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGuardarDatos.CustomizableEdges = borderEdges1;
            this.btnGuardarDatos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarDatos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardarDatos.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGuardarDatos.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGuardarDatos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGuardarDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnGuardarDatos.IconLeft = null;
            this.btnGuardarDatos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDatos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarDatos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGuardarDatos.IconMarginLeft = 11;
            this.btnGuardarDatos.IconPadding = 10;
            this.btnGuardarDatos.IconRight = null;
            this.btnGuardarDatos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDatos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarDatos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGuardarDatos.IconSize = 25;
            this.btnGuardarDatos.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGuardarDatos.IdleBorderRadius = 0;
            this.btnGuardarDatos.IdleBorderThickness = 0;
            this.btnGuardarDatos.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGuardarDatos.IdleIconLeftImage = null;
            this.btnGuardarDatos.IdleIconRightImage = null;
            this.btnGuardarDatos.IndicateFocus = false;
            this.btnGuardarDatos.Location = new System.Drawing.Point(887, 530);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardarDatos.OnDisabledState.BorderRadius = 30;
            this.btnGuardarDatos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatos.OnDisabledState.BorderThickness = 2;
            this.btnGuardarDatos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardarDatos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardarDatos.OnDisabledState.IconLeftImage = null;
            this.btnGuardarDatos.OnDisabledState.IconRightImage = null;
            this.btnGuardarDatos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarDatos.onHoverState.BorderRadius = 30;
            this.btnGuardarDatos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatos.onHoverState.BorderThickness = 2;
            this.btnGuardarDatos.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarDatos.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnGuardarDatos.onHoverState.IconLeftImage = null;
            this.btnGuardarDatos.onHoverState.IconRightImage = null;
            this.btnGuardarDatos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnGuardarDatos.OnIdleState.BorderRadius = 30;
            this.btnGuardarDatos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatos.OnIdleState.BorderThickness = 2;
            this.btnGuardarDatos.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarDatos.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnGuardarDatos.OnIdleState.IconLeftImage = null;
            this.btnGuardarDatos.OnIdleState.IconRightImage = null;
            this.btnGuardarDatos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnGuardarDatos.OnPressedState.BorderRadius = 30;
            this.btnGuardarDatos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardarDatos.OnPressedState.BorderThickness = 2;
            this.btnGuardarDatos.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnGuardarDatos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDatos.OnPressedState.IconLeftImage = null;
            this.btnGuardarDatos.OnPressedState.IconRightImage = null;
            this.btnGuardarDatos.Size = new System.Drawing.Size(187, 39);
            this.btnGuardarDatos.TabIndex = 29;
            this.btnGuardarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarDatos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardarDatos.TextMarginLeft = 0;
            this.btnGuardarDatos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGuardarDatos.UseDefaultRadiusAndThickness = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // dataGridViewClienteEditables
            // 
            this.dataGridViewClienteEditables.AllowUserToAddRows = false;
            this.dataGridViewClienteEditables.AllowUserToDeleteRows = false;
            this.dataGridViewClienteEditables.AllowUserToOrderColumns = true;
            this.dataGridViewClienteEditables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClienteEditables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClienteEditables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClienteEditables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.dataGridViewClienteEditables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClienteEditables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewClienteEditables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClienteEditables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClienteEditables.ColumnHeadersHeight = 30;
            this.dataGridViewClienteEditables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewClienteEditables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.ColumnFechaRegistro});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClienteEditables.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClienteEditables.EnableHeadersVisualStyles = false;
            this.dataGridViewClienteEditables.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewClienteEditables.Name = "dataGridViewClienteEditables";
            this.dataGridViewClienteEditables.RowHeadersVisible = false;
            this.dataGridViewClienteEditables.RowHeadersWidth = 51;
            this.dataGridViewClienteEditables.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewClienteEditables.RowTemplate.Height = 50;
            this.dataGridViewClienteEditables.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewClienteEditables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClienteEditables.Size = new System.Drawing.Size(1060, 82);
            this.dataGridViewClienteEditables.TabIndex = 28;
            this.dataGridViewClienteEditables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienteEditables_CellClick);
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Empresa";
            this.Column3.MaxInputLength = 100;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // ColumnFechaRegistro
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnFechaRegistro.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnFechaRegistro.FillWeight = 20F;
            this.ColumnFechaRegistro.HeaderText = "Fecha Registro";
            this.ColumnFechaRegistro.MaxInputLength = 17;
            this.ColumnFechaRegistro.MinimumWidth = 6;
            this.ColumnFechaRegistro.Name = "ColumnFechaRegistro";
            // 
            // comboBoxListClientes
            // 
            this.comboBoxListClientes.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxListClientes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.comboBoxListClientes.BorderRadius = 1;
            this.comboBoxListClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxListClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListClientes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxListClientes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxListClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxListClientes.ForeColor = System.Drawing.Color.Black;
            this.comboBoxListClientes.ItemHeight = 17;
            this.comboBoxListClientes.Location = new System.Drawing.Point(85, 15);
            this.comboBoxListClientes.Name = "comboBoxListClientes";
            this.comboBoxListClientes.Size = new System.Drawing.Size(518, 23);
            this.comboBoxListClientes.TabIndex = 27;
            this.comboBoxListClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxListClientes_SelectedIndexChanged);
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
            this.lblUserC.Size = new System.Drawing.Size(75, 25);
            this.lblUserC.TabIndex = 25;
            this.lblUserC.Text = "Cliente:";
            // 
            // ModificarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ModificarClientes";
            this.Size = new System.Drawing.Size(1077, 581);
            this.Load += new System.EventHandler(this.ModificarClientes_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienteEditables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lblUserC;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxListClientes;
        private System.Windows.Forms.DataGridView dataGridViewClienteEditables;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGuardarDatos;
        private System.Windows.Forms.Label lblMessageErrorModificarCliente;
        private System.Windows.Forms.Label lblSuccessModificarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaRegistro;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
