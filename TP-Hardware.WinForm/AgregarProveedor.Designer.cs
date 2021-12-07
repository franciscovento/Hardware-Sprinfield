
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProveedor));
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
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bntVolver
            // 
            this._bntVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._bntVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this._bntVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._bntVolver.Image = ((System.Drawing.Image)(resources.GetObject("_bntVolver.Image")));
            this._bntVolver.Location = new System.Drawing.Point(34, 39);
            this._bntVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._bntVolver.Name = "_bntVolver";
            this._bntVolver.Size = new System.Drawing.Size(61, 44);
            this._bntVolver.TabIndex = 8;
            this._bntVolver.UseVisualStyleBackColor = false;
            this._bntVolver.Click += new System.EventHandler(this._bntVolver_Click);
            // 
            // _btnAgregarCliente
            // 
            this._btnAgregarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAgregarCliente.Location = new System.Drawing.Point(273, 552);
            this._btnAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAgregarCliente.Name = "_btnAgregarCliente";
            this._btnAgregarCliente.Size = new System.Drawing.Size(164, 44);
            this._btnAgregarCliente.TabIndex = 7;
            this._btnAgregarCliente.Text = "AGREGAR";
            this._btnAgregarCliente.UseVisualStyleBackColor = false;
            this._btnAgregarCliente.Click += new System.EventHandler(this._btnAgregarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cuit";
            // 
            // _txtEmail
            // 
            this._txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmail.Location = new System.Drawing.Point(187, 385);
            this._txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtEmail.Multiline = true;
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(315, 33);
            this._txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // _txtApellido
            // 
            this._txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtApellido.Location = new System.Drawing.Point(187, 303);
            this._txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtApellido.Multiline = true;
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(315, 33);
            this._txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // _txtCuit
            // 
            this._txtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCuit.Location = new System.Drawing.Point(187, 457);
            this._txtCuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtCuit.Multiline = true;
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(315, 33);
            this._txtCuit.TabIndex = 5;
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(434, 508);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(4);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(68, 21);
            this.cbActivo.TabIndex = 6;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // _txtNombre
            // 
            this._txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNombre.Location = new System.Drawing.Point(187, 219);
            this._txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtNombre.Multiline = true;
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(315, 33);
            this._txtNombre.TabIndex = 2;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProd.Location = new System.Drawing.Point(187, 132);
            this.txtIDProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDProd.Multiline = true;
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(315, 33);
            this.txtIDProd.TabIndex = 1;
            // 
            // lbIdProd
            // 
            this.lbIdProd.AutoSize = true;
            this.lbIdProd.Location = new System.Drawing.Point(186, 109);
            this.lbIdProd.Name = "lbIdProd";
            this.lbIdProd.Size = new System.Drawing.Size(82, 17);
            this.lbIdProd.TabIndex = 30;
            this.lbIdProd.Text = "ID Producto";
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.ForeColor = System.Drawing.Color.GreenYellow;
            this._lblTituloTienda.Location = new System.Drawing.Point(255, 55);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(191, 28);
            this._lblTituloTienda.TabIndex = 31;
            this._lblTituloTienda.Text = "Agregar proveedor";
            // 
            // FrmAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this._lblTituloTienda);
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
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label _lblTituloTienda;
    }
}