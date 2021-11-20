
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
            this.txIdProd = new System.Windows.Forms.TextBox();
            this.lbidProd = new System.Windows.Forms.Label();
            this.txIdCliente = new System.Windows.Forms.TextBox();
            this.lbIdCliente = new System.Windows.Forms.Label();
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
            // txIdProd
            // 
            this.txIdProd.Location = new System.Drawing.Point(118, 168);
            this.txIdProd.Margin = new System.Windows.Forms.Padding(2);
            this.txIdProd.Name = "txIdProd";
            this.txIdProd.Size = new System.Drawing.Size(138, 20);
            this.txIdProd.TabIndex = 17;
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
            // txIdCliente
            // 
            this.txIdCliente.Location = new System.Drawing.Point(118, 119);
            this.txIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txIdCliente.Name = "txIdCliente";
            this.txIdCliente.Size = new System.Drawing.Size(138, 20);
            this.txIdCliente.TabIndex = 15;
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
            // FrmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 447);
            this.Controls.Add(this._bntVolver);
            this.Controls.Add(this._btnAgregarCliente);
            this.Controls.Add(this.txEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.txIdProd);
            this.Controls.Add(this.lbidProd);
            this.Controls.Add(this.txIdCliente);
            this.Controls.Add(this.lbIdCliente);
            this.Name = "FrmAgregarVenta";
            this.Text = "AgregarVenta";
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
        private System.Windows.Forms.TextBox txIdProd;
        private System.Windows.Forms.Label lbidProd;
        private System.Windows.Forms.TextBox txIdCliente;
        private System.Windows.Forms.Label lbIdCliente;
    }
}