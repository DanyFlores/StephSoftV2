﻿namespace StephSoft
{
    partial class frmInventario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiereStock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StockMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDescantarExistencia = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnDescargarArchivo = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnLeerInventario = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label42 = new System.Windows.Forms.Label();
            this.bgwFormato = new System.ComponentModel.BackgroundWorker();
            this.bgwActualizarDatos = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel7.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 688);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 608);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 558);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1008, 478);
            this.panel8.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.AutoScroll = true;
            this.panel12.Controls.Add(this.dgvProductos);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1008, 478);
            this.panel12.TabIndex = 2;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.IDSucursal,
            this.Clave,
            this.NombreProducto,
            this.ExistenciaAlmacen,
            this.ExistenciaUso,
            this.Existencia,
            this.RequiereStock,
            this.StockMaximo,
            this.StockMinimo});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1008, 478);
            this.dgvProductos.TabIndex = 3;
            // 
            // IDProducto
            // 
            this.IDProducto.DataPropertyName = "IDProducto";
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // IDSucursal
            // 
            this.IDSucursal.DataPropertyName = "IDSucursal";
            this.IDSucursal.HeaderText = "IDSucursal";
            this.IDSucursal.Name = "IDSucursal";
            this.IDSucursal.ReadOnly = true;
            this.IDSucursal.Visible = false;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 120;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 280;
            // 
            // ExistenciaAlmacen
            // 
            this.ExistenciaAlmacen.DataPropertyName = "ExistenciaAlmacen";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.ExistenciaAlmacen.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExistenciaAlmacen.HeaderText = "Existencia en almacén";
            this.ExistenciaAlmacen.Name = "ExistenciaAlmacen";
            this.ExistenciaAlmacen.ReadOnly = true;
            this.ExistenciaAlmacen.Width = 120;
            // 
            // ExistenciaUso
            // 
            this.ExistenciaUso.DataPropertyName = "ExistenciaUso";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.ExistenciaUso.DefaultCellStyle = dataGridViewCellStyle7;
            this.ExistenciaUso.HeaderText = "Existencia en producción";
            this.ExistenciaUso.Name = "ExistenciaUso";
            this.ExistenciaUso.ReadOnly = true;
            this.ExistenciaUso.Width = 120;
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.Existencia.DefaultCellStyle = dataGridViewCellStyle8;
            this.Existencia.HeaderText = "Existencia total";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.Width = 120;
            // 
            // RequiereStock
            // 
            this.RequiereStock.DataPropertyName = "RequiereStock";
            this.RequiereStock.HeaderText = "¿Requiere Stock?";
            this.RequiereStock.Name = "RequiereStock";
            this.RequiereStock.ReadOnly = true;
            this.RequiereStock.Width = 120;
            // 
            // StockMaximo
            // 
            this.StockMaximo.DataPropertyName = "StockMaximo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            this.StockMaximo.DefaultCellStyle = dataGridViewCellStyle9;
            this.StockMaximo.HeaderText = "Stock Máximo";
            this.StockMaximo.Name = "StockMaximo";
            this.StockMaximo.ReadOnly = true;
            this.StockMaximo.Width = 120;
            // 
            // StockMinimo
            // 
            this.StockMinimo.DataPropertyName = "StockMinimo";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "0";
            this.StockMinimo.DefaultCellStyle = dataGridViewCellStyle10;
            this.StockMinimo.HeaderText = "Stock Mínimo";
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            this.StockMinimo.Width = 120;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.PanelMenu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 478);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1008, 80);
            this.panel7.TabIndex = 0;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Gray;
            this.PanelMenu.Controls.Add(this.lblMessage);
            this.PanelMenu.Controls.Add(this.btnDescantarExistencia);
            this.PanelMenu.Controls.Add(this.btnDescargarArchivo);
            this.PanelMenu.Controls.Add(this.btnLeerInventario);
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1008, 80);
            this.PanelMenu.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.SeaShell;
            this.lblMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Location = new System.Drawing.Point(85, 6);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(398, 65);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Visible = false;
            // 
            // btnDescantarExistencia
            // 
            this.btnDescantarExistencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDescantarExistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnDescantarExistencia.BorderColor = System.Drawing.Color.Red;
            this.btnDescantarExistencia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnDescantarExistencia.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDescantarExistencia.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnDescantarExistencia.FocusRectangle = true;
            this.btnDescantarExistencia.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescantarExistencia.ForeColor = System.Drawing.Color.White;
            this.btnDescantarExistencia.Image = null;
            this.btnDescantarExistencia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescantarExistencia.ImageBorderColor = System.Drawing.Color.Red;
            this.btnDescantarExistencia.ImageFocused = null;
            this.btnDescantarExistencia.ImageInactive = null;
            this.btnDescantarExistencia.ImageMouseOver = global::StephSoft.Properties.Resources.icons_steph_vino_descontar_existencias_a;
            this.btnDescantarExistencia.ImageNormal = global::StephSoft.Properties.Resources.icons_steph_vino_descontar_existencias;
            this.btnDescantarExistencia.ImagePressed = null;
            this.btnDescantarExistencia.ImageSize = new System.Drawing.Size(44, 44);
            this.btnDescantarExistencia.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnDescantarExistencia.KeyButtonView = false;
            this.btnDescantarExistencia.Location = new System.Drawing.Point(650, 5);
            this.btnDescantarExistencia.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDescantarExistencia.MouseOverColor = System.Drawing.Color.Red;
            this.btnDescantarExistencia.Name = "btnDescantarExistencia";
            this.btnDescantarExistencia.OffsetPressedContent = true;
            this.btnDescantarExistencia.Size = new System.Drawing.Size(80, 70);
            this.btnDescantarExistencia.TabIndex = 11;
            this.btnDescantarExistencia.Text = "Desct. Exist.";
            this.btnDescantarExistencia.TextDropShadow = true;
            this.btnDescantarExistencia.UseVisualStyleBackColor = false;
            this.btnDescantarExistencia.Click += new System.EventHandler(this.btnDescantarExistencia_Click);
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDescargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnDescargarArchivo.BorderColor = System.Drawing.Color.Red;
            this.btnDescargarArchivo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnDescargarArchivo.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDescargarArchivo.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnDescargarArchivo.FocusRectangle = true;
            this.btnDescargarArchivo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnDescargarArchivo.Image = null;
            this.btnDescargarArchivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescargarArchivo.ImageBorderColor = System.Drawing.Color.Red;
            this.btnDescargarArchivo.ImageFocused = null;
            this.btnDescargarArchivo.ImageInactive = null;
            this.btnDescargarArchivo.ImageMouseOver = global::StephSoft.Properties.Resources.icons_steph_negro___0008_excel;
            this.btnDescargarArchivo.ImageNormal = global::StephSoft.Properties.Resources.icons_steph_negro___0008_excel_a;
            this.btnDescargarArchivo.ImagePressed = null;
            this.btnDescargarArchivo.ImageSize = new System.Drawing.Size(44, 44);
            this.btnDescargarArchivo.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnDescargarArchivo.KeyButtonView = false;
            this.btnDescargarArchivo.Location = new System.Drawing.Point(736, 5);
            this.btnDescargarArchivo.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDescargarArchivo.MouseOverColor = System.Drawing.Color.Red;
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.OffsetPressedContent = true;
            this.btnDescargarArchivo.Size = new System.Drawing.Size(80, 70);
            this.btnDescargarArchivo.TabIndex = 10;
            this.btnDescargarArchivo.Text = "Formato";
            this.btnDescargarArchivo.TextDropShadow = true;
            this.btnDescargarArchivo.UseVisualStyleBackColor = false;
            this.btnDescargarArchivo.Click += new System.EventHandler(this.btnDescargarArchivo_Click);
            // 
            // btnLeerInventario
            // 
            this.btnLeerInventario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLeerInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnLeerInventario.BorderColor = System.Drawing.Color.Red;
            this.btnLeerInventario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnLeerInventario.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeerInventario.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnLeerInventario.FocusRectangle = true;
            this.btnLeerInventario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerInventario.ForeColor = System.Drawing.Color.White;
            this.btnLeerInventario.Image = null;
            this.btnLeerInventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeerInventario.ImageBorderColor = System.Drawing.Color.Red;
            this.btnLeerInventario.ImageFocused = null;
            this.btnLeerInventario.ImageInactive = null;
            this.btnLeerInventario.ImageMouseOver = global::StephSoft.Properties.Resources.icons_steph_vino_leer_inventario_a;
            this.btnLeerInventario.ImageNormal = global::StephSoft.Properties.Resources.icons_steph_vino_leer_inventario;
            this.btnLeerInventario.ImagePressed = null;
            this.btnLeerInventario.ImageSize = new System.Drawing.Size(44, 44);
            this.btnLeerInventario.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnLeerInventario.KeyButtonView = false;
            this.btnLeerInventario.Location = new System.Drawing.Point(822, 5);
            this.btnLeerInventario.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLeerInventario.MouseOverColor = System.Drawing.Color.Red;
            this.btnLeerInventario.Name = "btnLeerInventario";
            this.btnLeerInventario.OffsetPressedContent = true;
            this.btnLeerInventario.Size = new System.Drawing.Size(80, 70);
            this.btnLeerInventario.TabIndex = 9;
            this.btnLeerInventario.Text = "Leer Inv.";
            this.btnLeerInventario.TextDropShadow = true;
            this.btnLeerInventario.UseVisualStyleBackColor = false;
            this.btnLeerInventario.Click += new System.EventHandler(this.btnLeerInventario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnSalir.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = null;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageBorderColor = System.Drawing.Color.Red;
            this.btnSalir.ImageFocused = null;
            this.btnSalir.ImageInactive = null;
            this.btnSalir.ImageMouseOver = global::StephSoft.Properties.Resources._0000s_0001s_0000_salir_a;
            this.btnSalir.ImageNormal = global::StephSoft.Properties.Resources._0000s_0001s_0000_salir;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(44, 44);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(908, 5);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.Red;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 70);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 50);
            this.panel4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGray;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.btnBuscar);
            this.panel10.Controls.Add(this.txtBusqueda);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1008, 50);
            this.panel10.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(255, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Red;
            this.btnBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnBuscar.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnBuscar.FocusRectangle = true;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.ImageBorderColor = System.Drawing.Color.Red;
            this.btnBuscar.ImageFocused = null;
            this.btnBuscar.ImageInactive = null;
            this.btnBuscar.ImageMouseOver = null;
            this.btnBuscar.ImageNormal = null;
            this.btnBuscar.ImagePressed = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(44, 44);
            this.btnBuscar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnBuscar.KeyButtonView = false;
            this.btnBuscar.Location = new System.Drawing.Point(605, 14);
            this.btnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuscar.MouseOverColor = System.Drawing.Color.Red;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OffsetPressedContent = true;
            this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextDropShadow = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.Location = new System.Drawing.Point(368, 13);
            this.txtBusqueda.MaxLength = 20;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(237, 25);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 80);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(205)))), ((int)(((byte)(215)))));
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1008, 80);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(849, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(21, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(245, 55);
            this.label42.TabIndex = 24;
            this.label42.Text = "Inventario";
            // 
            // bgwFormato
            // 
            this.bgwFormato.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFormato_DoWork);
            this.bgwFormato.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFormato_RunWorkerCompleted);
            // 
            // bgwActualizarDatos
            // 
            this.bgwActualizarDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwActualizarDatos_DoWork);
            this.bgwActualizarDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwActualizarDatos_RunWorkerCompleted);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steph v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel7.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel PanelMenu;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnSalir;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dgvProductos;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnLeerInventario;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnDescargarArchivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnDescantarExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaUso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RequiereStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.ComponentModel.BackgroundWorker bgwFormato;
        private System.Windows.Forms.Label lblMessage;
        private System.ComponentModel.BackgroundWorker bgwActualizarDatos;
    }
}

