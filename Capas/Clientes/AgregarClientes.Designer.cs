
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxNombreEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.lblMessageErrorClienteAgregado);
            this.bunifuPanel1.Controls.Add(this.lblSuccessClienteAgregado);
            this.bunifuPanel1.Controls.Add(this.btnAgregarDatos);
            this.bunifuPanel1.Controls.Add(this.groupBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1436, 715);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // lblMessageErrorClienteAgregado
            // 
            this.lblMessageErrorClienteAgregado.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErrorClienteAgregado.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMessageErrorClienteAgregado.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErrorClienteAgregado.Location = new System.Drawing.Point(11, 644);
            this.lblMessageErrorClienteAgregado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageErrorClienteAgregado.Name = "lblMessageErrorClienteAgregado";
            this.lblMessageErrorClienteAgregado.Size = new System.Drawing.Size(1104, 46);
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
            this.lblSuccessClienteAgregado.Location = new System.Drawing.Point(11, 649);
            this.lblSuccessClienteAgregado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuccessClienteAgregado.Name = "lblSuccessClienteAgregado";
            this.lblSuccessClienteAgregado.Size = new System.Drawing.Size(587, 41);
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
            this.btnAgregarDatos.Location = new System.Drawing.Point(1128, 252);
            this.btnAgregarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(267, 46);
            this.btnAgregarDatos.TabIndex = 7;
            this.btnAgregarDatos.Text = "Agregar cliente";
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxRUC);
            this.groupBox1.Controls.Add(this.txtboxNombreEmpresa);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1379, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(206, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "RUC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre Empresa / Cliente:";
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
            this.txtboxRUC.ForeColor = System.Drawing.Color.Black;
            this.txtboxRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxRUC.Location = new System.Drawing.Point(265, 102);
            this.txtboxRUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxRUC.Name = "txtboxRUC";
            this.txtboxRUC.PasswordChar = '\0';
            this.txtboxRUC.PlaceholderText = "10778965293";
            this.txtboxRUC.SelectedText = "";
            this.txtboxRUC.Size = new System.Drawing.Size(123, 28);
            this.txtboxRUC.TabIndex = 17;
            this.txtboxRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxRUC_KeyPress);
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
            this.txtboxNombreEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtboxNombreEmpresa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNombreEmpresa.Location = new System.Drawing.Point(265, 51);
            this.txtboxNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxNombreEmpresa.Name = "txtboxNombreEmpresa";
            this.txtboxNombreEmpresa.PasswordChar = '\0';
            this.txtboxNombreEmpresa.PlaceholderText = "Facebook INC";
            this.txtboxNombreEmpresa.SelectedText = "";
            this.txtboxNombreEmpresa.Size = new System.Drawing.Size(267, 28);
            this.txtboxNombreEmpresa.TabIndex = 16;
            this.txtboxNombreEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxNombreEmpresa_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.pictureBox1.Image = global::Funda_Trabajo_Parcial.Properties.Resources.undraw_Engineering_team_a7n2_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(400, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 324);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarClientes";
            this.Size = new System.Drawing.Size(1436, 715);
            this.bunifuPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.Label lblSuccessClienteAgregado;
        private System.Windows.Forms.Label lblMessageErrorClienteAgregado;
        private Guna.UI2.WinForms.Guna2TextBox txtboxNombreEmpresa;
        private Guna.UI2.WinForms.Guna2TextBox txtboxRUC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
