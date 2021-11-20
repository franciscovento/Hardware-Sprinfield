
namespace TP_Hardware.WinForm
{
    partial class FrmAgregarProveedor
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
            this._bntVolver = new System.Windows.Forms.Button();
            this._btnAgregarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtCuit = new System.Windows.Forms.TextBox();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.lbIdProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bntVolver
            // 
            this._bntVolver.Location = new System.Drawing.Point(120, 328);
            this._bntVolver.Margin = new System.Windows.Forms.Padding(2);
            this._bntVolver.Name = "_bntVolver";
            this._bntVolver.Size = new System.Drawing.Size(58, 36);
            this._bntVolver.TabIndex = 27;
            this._bntVolver.Text = "Volver";
            this._bntVolver.UseVisualStyleBackColor = true;
            this._bntVolver.Click += new System.EventHandler(this._bntVolver_Click);
            // 
            // _btnAgregarCliente
            // 
            this._btnAgregarCliente.Location = new System.Drawing.Point(199, 328);
            this._btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this._btnAgregarCliente.Name = "_btnAgregarCliente";
            this._btnAgregarCliente.Size = new System.Drawing.Size(58, 36);
            this._btnAgregarCliente.TabIndex = 26;
            this._btnAgregarCliente.Text = "Agregar";
            this._btnAgregarCliente.UseVisualStyleBackColor = true;
            this._btnAgregarCliente.Click += new System.EventHandler(this._btnAgregarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cuit";
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(120, 182);
            this._txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(138, 20);
            this._txtEmail.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(120, 137);
            this._txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(138, 20);
            this._txtApellido.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // _txtCuit
            // 
            this._txtCuit.Location = new System.Drawing.Point(120, 229);
            this._txtCuit.Margin = new System.Windows.Forms.Padding(2);
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(138, 20);
            this._txtCuit.TabIndex = 21;
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(163, 260);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(56, 17);
            this.cbActivo.TabIndex = 28;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(120, 88);
            this._txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(138, 20);
            this._txtNombre.TabIndex = 15;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(120, 50);
            this.txtIDProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(138, 20);
            this.txtIDProd.TabIndex = 29;
            // 
            // lbIdProd
            // 
            this.lbIdProd.AutoSize = true;
            this.lbIdProd.Location = new System.Drawing.Point(118, 35);
            this.lbIdProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdProd.Name = "lbIdProd";
            this.lbIdProd.Size = new System.Drawing.Size(64, 13);
            this.lbIdProd.TabIndex = 30;
            this.lbIdProd.Text = "ID Producto";
            // 
            // FrmAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(362, 422);
            this.Controls.Add(this.lbIdProd);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this._bntVolver);
            this.Controls.Add(this._btnAgregarCliente);
            this.Controls.Add(this._txtCuit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarProveedor";
            this.Text = "AgregarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bntVolver;
        private System.Windows.Forms.Button _btnAgregarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtCuit;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Label lbIdProd;
    }
}