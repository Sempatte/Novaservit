
using System.Windows.Forms;

namespace Funda_Trabajo_Parcial
{
    partial class ListarTodosLosClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarTodosLosClientes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnActualizarClientes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.dataGridViewClientes);
            this.bunifuPanel1.Controls.Add(this.btnActualizarClientes);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.AllowAnimations = true;
            this.btnActualizarClientes.AllowMouseEffects = true;
            this.btnActualizarClientes.AllowToggling = false;
            this.btnActualizarClientes.AnimationSpeed = 200;
            this.btnActualizarClientes.AutoGenerateColors = false;
            this.btnActualizarClientes.AutoRoundBorders = false;
            this.btnActualizarClientes.AutoSizeLeftIcon = true;
            this.btnActualizarClientes.AutoSizeRightIcon = true;
            this.btnActualizarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarClientes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnActualizarClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarClientes.BackgroundImage")));
            this.btnActualizarClientes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarClientes.ButtonText = "Actualizar";
            this.btnActualizarClientes.ButtonTextMarginLeft = 0;
            this.btnActualizarClientes.ColorContrastOnClick = 45;
            this.btnActualizarClientes.ColorContrastOnHover = 45;
            this.btnActualizarClientes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnActualizarClientes.CustomizableEdges = borderEdges1;
            this.btnActualizarClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizarClientes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActualizarClientes.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnActualizarClientes.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnActualizarClientes.Enabled = false;
            this.btnActualizarClientes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnActualizarClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnActualizarClientes.IconLeft = null;
            this.btnActualizarClientes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarClientes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizarClientes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnActualizarClientes.IconMarginLeft = 11;
            this.btnActualizarClientes.IconPadding = 10;
            this.btnActualizarClientes.IconRight = null;
            this.btnActualizarClientes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarClientes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizarClientes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnActualizarClientes.IconSize = 25;
            this.btnActualizarClientes.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnActualizarClientes.IdleBorderRadius = 0;
            this.btnActualizarClientes.IdleBorderThickness = 0;
            this.btnActualizarClientes.IdleFillColor = System.Drawing.Color.Empty;
            this.btnActualizarClientes.IdleIconLeftImage = null;
            this.btnActualizarClientes.IdleIconRightImage = null;
            this.btnActualizarClientes.IndicateFocus = false;
            this.btnActualizarClientes.Location = new System.Drawing.Point(881, 518);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActualizarClientes.OnDisabledState.BorderRadius = 30;
            this.btnActualizarClientes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarClientes.OnDisabledState.BorderThickness = 2;
            this.btnActualizarClientes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActualizarClientes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActualizarClientes.OnDisabledState.IconLeftImage = null;
            this.btnActualizarClientes.OnDisabledState.IconRightImage = null;
            this.btnActualizarClientes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarClientes.onHoverState.BorderRadius = 30;
            this.btnActualizarClientes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarClientes.onHoverState.BorderThickness = 2;
            this.btnActualizarClientes.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarClientes.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnActualizarClientes.onHoverState.IconLeftImage = null;
            this.btnActualizarClientes.onHoverState.IconRightImage = null;
            this.btnActualizarClientes.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnActualizarClientes.OnIdleState.BorderRadius = 30;
            this.btnActualizarClientes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarClientes.OnIdleState.BorderThickness = 2;
            this.btnActualizarClientes.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarClientes.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnActualizarClientes.OnIdleState.IconLeftImage = null;
            this.btnActualizarClientes.OnIdleState.IconRightImage = null;
            this.btnActualizarClientes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnActualizarClientes.OnPressedState.BorderRadius = 30;
            this.btnActualizarClientes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActualizarClientes.OnPressedState.BorderThickness = 2;
            this.btnActualizarClientes.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnActualizarClientes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnActualizarClientes.OnPressedState.IconLeftImage = null;
            this.btnActualizarClientes.OnPressedState.IconRightImage = null;
            this.btnActualizarClientes.Size = new System.Drawing.Size(187, 39);
            this.btnActualizarClientes.TabIndex = 21;
            this.btnActualizarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarClientes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizarClientes.TextMarginLeft = 0;
            this.btnActualizarClientes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnActualizarClientes.UseDefaultRadiusAndThickness = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientes.ColumnHeadersHeight = 30;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientes.EnableHeadersVisualStyles = false;
            this.dataGridViewClientes.Location = new System.Drawing.Point(15, 10);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewClientes.RowTemplate.Height = 50;
            this.dataGridViewClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(1053, 502);
            this.dataGridViewClientes.TabIndex = 23;
            this.dataGridViewClientes.MouseWheel += new MouseEventHandler(dataGridViewClientes_MouseWheel);
            // 
            // ListarTodosLosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ListarTodosLosClientes";
            this.Size = new System.Drawing.Size(1077, 581);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActualizarClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}
