
namespace TP_Hardware.WinForm
{
    partial class FrmAgregarVenta
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
            this.txEstado = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbidProd = new System.Windows.Forms.Label();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.cmbIdProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _bntVolver
            // 
            this._bntVolver.Location = new System.Drawing.Point(118, 321);
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
            this._btnAgregarCliente.Location = new System.Drawing.Point(198, 321);
            this._btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this._btnAgregarCliente.Name = "_btnAgregarCliente";
            this._btnAgregarCliente.Size = new System.Drawing.Size(58, 36);
            this._btnAgregarCliente.TabIndex = 26;
            this._btnAgregarCliente.Text = "Agregar";
            this._btnAgregarCliente.UseVisualStyleBackColor = true;
            this._btnAgregarCliente.Click += new System.EventHandler(this._btnAgregarCliente_Click);
            // 
            // txEstado
            // 
            this.txEstado.Location = new System.Drawing.Point(118, 260);
            this.txEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txEstado.Name = "txEstado";
            this.txEstado.Size = new System.Drawing.Size(138, 20);
            this.txEstado.TabIndex = 21;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(116, 244);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 20;
            this.lbEstado.Text = "Estado";
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(118, 213);
            this.txCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(138, 20);
            this.txCantidad.TabIndex = 19;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(116, 197);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 18;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbidProd
            // 
            this.lbidProd.AutoSize = true;
            this.lbidProd.Location = new System.Drawing.Point(116, 152);
            this.lbidProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbidProd.Name = "lbidProd";
            this.lbidProd.Size = new System.Drawing.Size(62, 13);
            this.lbidProd.TabIndex = 16;
            this.lbidProd.Text = "Id Producto";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(116, 103);
            this.lbIdCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(51, 13);
            this.lbIdCliente.TabIndex = 14;
            this.lbIdCliente.Text = "Id Cliente";
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(119, 120);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(137, 21);
            this.cmbIdCliente.TabIndex = 28;
            // 
            // cmbIdProducto
            // 
            this.cmbIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdProducto.FormattingEnabled = true;
            this.cmbIdProducto.Location = new System.Drawing.Point(119, 169);
            this.cmbIdProducto.Name = "cmbIdProducto";
            this.cmbIdProducto.Size = new System.Drawing.Size(137, 21);
            this.cmbIdProducto.TabIndex = 29;
            // 
            // FrmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 414);
            this.Controls.Add(this.cmbIdProducto);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this._bntVolver);
            this.Controls.Add(this._btnAgregarCliente);
            this.Controls.Add(this.txEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbidProd);
            this.Controls.Add(this.lbIdCliente);
            this.Name = "FrmAgregarVenta";
            this.Text = "AgregarVenta";
            this.Load += new System.EventHandler(this.FrmAgregarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bntVolver;
        private System.Windows.Forms.Button _btnAgregarCliente;
        private System.Windows.Forms.TextBox txEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbidProd;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.ComboBox cmbIdProducto;
    }
}