
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProductos));
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnBuscarProducto = new System.Windows.Forms.Button();
            this._txtBuscarProducto = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this._lstProductos = new System.Windows.Forms.ListBox();
            this._btnAgregarProd = new System.Windows.Forms.Button();
            this._btnRefrescar = new System.Windows.Forms.Button();
            this._cbListarPorCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.ForeColor = System.Drawing.Color.GreenYellow;
            this._lblTituloTienda.Location = new System.Drawing.Point(234, 37);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(186, 28);
            this._lblTituloTienda.TabIndex = 11;
            this._lblTituloTienda.Text = "Lista de Productos";
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnVolver.ForeColor = System.Drawing.Color.RoyalBlue;
            this._btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("_btnVolver.Image")));
            this._btnVolver.Location = new System.Drawing.Point(33, 34);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(56, 42);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarProducto
            // 
            this._btnBuscarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBuscarProducto.Location = new System.Drawing.Point(507, 200);
            this._btnBuscarProducto.Name = "_btnBuscarProducto";
            this._btnBuscarProducto.Size = new System.Drawing.Size(134, 36);
            this._btnBuscarProducto.TabIndex = 9;
            this._btnBuscarProducto.Text = "BUSCAR";
            this._btnBuscarProducto.UseVisualStyleBackColor = false;
            this._btnBuscarProducto.Click += new System.EventHandler(this._btnBuscarProducto_Click);
            // 
            // _txtBuscarProducto
            // 
            this._txtBuscarProducto.BackColor = System.Drawing.SystemColors.MenuBar;
            this._txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBuscarProducto.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBuscarProducto.Location = new System.Drawing.Point(278, 208);
            this._txtBuscarProducto.Name = "_txtBuscarProducto";
            this._txtBuscarProducto.Size = new System.Drawing.Size(200, 22);
            this._txtBuscarProducto.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCodigoProd.Location = new System.Drawing.Point(275, 177);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(145, 17);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Buscar por código:";
            // 
            // _lstProductos
            // 
            this._lstProductos.BackColor = System.Drawing.SystemColors.MenuText;
            this._lstProductos.ForeColor = System.Drawing.SystemColors.Window;
            this._lstProductos.FormattingEnabled = true;
            this._lstProductos.ItemHeight = 16;
            this._lstProductos.Location = new System.Drawing.Point(33, 320);
            this._lstProductos.Name = "_lstProductos";
            this._lstProductos.Size = new System.Drawing.Size(608, 228);
            this._lstProductos.TabIndex = 6;
            // 
            // _btnAgregarProd
            // 
            this._btnAgregarProd.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAgregarProd.Location = new System.Drawing.Point(498, 568);
            this._btnAgregarProd.Name = "_btnAgregarProd";
            this._btnAgregarProd.Size = new System.Drawing.Size(134, 46);
            this._btnAgregarProd.TabIndex = 12;
            this._btnAgregarProd.Text = "AGREGAR";
            this._btnAgregarProd.UseVisualStyleBackColor = false;
            this._btnAgregarProd.Click += new System.EventHandler(this._btnAgregarProd_Click);
            // 
            // _btnRefrescar
            // 
            this._btnRefrescar.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRefrescar.Location = new System.Drawing.Point(340, 568);
            this._btnRefrescar.Name = "_btnRefrescar";
            this._btnRefrescar.Size = new System.Drawing.Size(134, 46);
            this._btnRefrescar.TabIndex = 13;
            this._btnRefrescar.Text = "ACTUALIZAR";
            this._btnRefrescar.UseVisualStyleBackColor = false;
            this._btnRefrescar.Click += new System.EventHandler(this._btnRefrescar_Click);
            // 
            // _cbListarPorCategoria
            // 
            this._cbListarPorCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbListarPorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbListarPorCategoria.FormattingEnabled = true;
            this._cbListarPorCategoria.Location = new System.Drawing.Point(33, 206);
            this._cbListarPorCategoria.Name = "_cbListarPorCategoria";
            this._cbListarPorCategoria.Size = new System.Drawing.Size(200, 24);
            this._cbListarPorCategoria.TabIndex = 14;
            this._cbListarPorCategoria.SelectedIndexChanged += new System.EventHandler(this._cbListarPorCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ver por categoría:";
            // 
            // FrmConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbListarPorCategoria);
            this.Controls.Add(this._btnRefrescar);
            this.Controls.Add(this._btnAgregarProd);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarProducto);
            this.Controls.Add(this._txtBuscarProducto);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this._lstProductos);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FrmConsultarProductos";
            this.Text = "FrmConsultarProductos";
            this.Load += new System.EventHandler(this.FrmConsultarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarProducto;
        private System.Windows.Forms.TextBox _txtBuscarProducto;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox _lstProductos;
        private System.Windows.Forms.Button _btnAgregarProd;
        private System.Windows.Forms.Button _btnRefrescar;
        private System.Windows.Forms.ComboBox _cbListarPorCategoria;
        private System.Windows.Forms.Label label1;
    }
}