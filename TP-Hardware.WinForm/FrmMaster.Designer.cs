
namespace TP_Hardware.WinForm
{
    partial class FrmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaster));
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this._btnConsultarClientes = new System.Windows.Forms.Button();
            this._btnConsultarProductos = new System.Windows.Forms.Button();
            this._btnConsultarVentas = new System.Windows.Forms.Button();
            this._btnConsultarProv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Image = ((System.Drawing.Image)(resources.GetObject("_lblTituloTienda.Image")));
            this._lblTituloTienda.Location = new System.Drawing.Point(277, 73);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Padding = new System.Windows.Forms.Padding(60);
            this._lblTituloTienda.Size = new System.Drawing.Size(120, 148);
            this._lblTituloTienda.TabIndex = 0;
            // 
            // _btnConsultarClientes
            // 
            this._btnConsultarClientes.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnConsultarClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnConsultarClientes.Location = new System.Drawing.Point(226, 240);
            this._btnConsultarClientes.Name = "_btnConsultarClientes";
            this._btnConsultarClientes.Size = new System.Drawing.Size(230, 63);
            this._btnConsultarClientes.TabIndex = 1;
            this._btnConsultarClientes.Text = "CLIENTES";
            this._btnConsultarClientes.UseVisualStyleBackColor = false;
            this._btnConsultarClientes.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // _btnConsultarProductos
            // 
            this._btnConsultarProductos.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnConsultarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnConsultarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnConsultarProductos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnConsultarProductos.Location = new System.Drawing.Point(226, 322);
            this._btnConsultarProductos.Name = "_btnConsultarProductos";
            this._btnConsultarProductos.Size = new System.Drawing.Size(230, 63);
            this._btnConsultarProductos.TabIndex = 2;
            this._btnConsultarProductos.Tag = "";
            this._btnConsultarProductos.Text = "PRODUCTOS";
            this._btnConsultarProductos.UseVisualStyleBackColor = false;
            this._btnConsultarProductos.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // _btnConsultarVentas
            // 
            this._btnConsultarVentas.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnConsultarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnConsultarVentas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnConsultarVentas.Location = new System.Drawing.Point(226, 407);
            this._btnConsultarVentas.Name = "_btnConsultarVentas";
            this._btnConsultarVentas.Size = new System.Drawing.Size(230, 63);
            this._btnConsultarVentas.TabIndex = 3;
            this._btnConsultarVentas.Text = "VENTAS";
            this._btnConsultarVentas.UseVisualStyleBackColor = false;
            this._btnConsultarVentas.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // _btnConsultarProv
            // 
            this._btnConsultarProv.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnConsultarProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnConsultarProv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnConsultarProv.Location = new System.Drawing.Point(226, 494);
            this._btnConsultarProv.Name = "_btnConsultarProv";
            this._btnConsultarProv.Size = new System.Drawing.Size(230, 63);
            this._btnConsultarProv.TabIndex = 4;
            this._btnConsultarProv.Text = "PROVEEDORES";
            this._btnConsultarProv.UseVisualStyleBackColor = false;
            this._btnConsultarProv.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(78, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SPRINGFIELD HARDWARE STORE DESARROLLADO POR GONFRAN SYSTEM";
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnConsultarProv);
            this.Controls.Add(this._btnConsultarVentas);
            this.Controls.Add(this._btnConsultarProductos);
            this.Controls.Add(this._btnConsultarClientes);
            this.Controls.Add(this._lblTituloTienda);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnConsultarClientes;
        private System.Windows.Forms.Button _btnConsultarProductos;
        private System.Windows.Forms.Button _btnConsultarVentas;
        private System.Windows.Forms.Button _btnConsultarProv;
        private System.Windows.Forms.Label label1;
    }
}

