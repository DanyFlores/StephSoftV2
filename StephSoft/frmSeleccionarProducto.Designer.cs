﻿using System.Windows.Forms;
namespace StephSoft
{

    class customDataGridView : DataGridView
    {
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.Rows.Count > 0)
                {
                    int col = this.CurrentCell.ColumnIndex;
                    int row = this.CurrentCell.RowIndex;
                    this.CurrentCell = this[col, row];
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (this.Rows.Count > 0)
                {
                    int col = this.CurrentCell.ColumnIndex;
                    int row = this.CurrentCell.RowIndex;
                    this.CurrentCell = this[col, row];
                }
                e.Handled = true;
            }
            base.OnKeyDown(e);
        }
    }

    partial class frmSeleccionarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductos = new StephSoft.customDataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedidaDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAgregar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCerrarForm = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvProductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 176);
            this.panel3.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.TiempoMinutos,
            this.Clave,
            this.NombreProducto,
            this.IDUnidadMedida,
            this.UnidadMedidaDesc,
            this.UltimoCosto,
            this.Metrica,
            this.IDTipoProducto});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(405, 176);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            this.dgvProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProductos_KeyPress);
            // 
            // IDProducto
            // 
            this.IDProducto.DataPropertyName = "IDProducto";
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDProducto.Visible = false;
            // 
            // TiempoMinutos
            // 
            this.TiempoMinutos.DataPropertyName = "TiempoMinutos";
            dataGridViewCellStyle1.NullValue = "0";
            this.TiempoMinutos.DefaultCellStyle = dataGridViewCellStyle1;
            this.TiempoMinutos.HeaderText = "TiempoMinutos";
            this.TiempoMinutos.Name = "TiempoMinutos";
            this.TiempoMinutos.ReadOnly = true;
            this.TiempoMinutos.Visible = false;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.FillWeight = 120F;
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.FillWeight = 300F;
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreProducto.Width = 270;
            // 
            // IDUnidadMedida
            // 
            this.IDUnidadMedida.DataPropertyName = "IDUnidadMedida";
            this.IDUnidadMedida.HeaderText = "IDUnidadMedida";
            this.IDUnidadMedida.Name = "IDUnidadMedida";
            this.IDUnidadMedida.ReadOnly = true;
            this.IDUnidadMedida.Visible = false;
            // 
            // UnidadMedidaDesc
            // 
            this.UnidadMedidaDesc.DataPropertyName = "UnidadMedida";
            this.UnidadMedidaDesc.HeaderText = "UnidadMedida";
            this.UnidadMedidaDesc.Name = "UnidadMedidaDesc";
            this.UnidadMedidaDesc.ReadOnly = true;
            this.UnidadMedidaDesc.Visible = false;
            // 
            // UltimoCosto
            // 
            this.UltimoCosto.DataPropertyName = "UltimoCosto";
            this.UltimoCosto.HeaderText = "UltimoCosto";
            this.UltimoCosto.Name = "UltimoCosto";
            this.UltimoCosto.ReadOnly = true;
            this.UltimoCosto.Visible = false;
            // 
            // Metrica
            // 
            this.Metrica.DataPropertyName = "Metrica";
            this.Metrica.HeaderText = "Metrica";
            this.Metrica.Name = "Metrica";
            this.Metrica.ReadOnly = true;
            this.Metrica.Visible = false;
            // 
            // IDTipoProducto
            // 
            this.IDTipoProducto.DataPropertyName = "IDTipoProducto";
            this.IDTipoProducto.HeaderText = "IDTipoProducto";
            this.IDTipoProducto.Name = "IDTipoProducto";
            this.IDTipoProducto.ReadOnly = true;
            this.IDTipoProducto.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 24);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 24);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtBusqueda);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 24);
            this.panel7.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.txtBusqueda.Location = new System.Drawing.Point(0, 0);
            this.txtBusqueda.MaxLength = 130;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(267, 25);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBuscar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(267, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 24);
            this.panel6.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Red;
            this.btnBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnBuscar.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.FocusRectangle = true;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageBorderColor = System.Drawing.Color.Red;
            this.btnBuscar.ImageFocused = null;
            this.btnBuscar.ImageInactive = null;
            this.btnBuscar.ImageMouseOver = null;
            this.btnBuscar.ImageNormal = null;
            this.btnBuscar.ImagePressed = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBuscar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnBuscar.KeyButtonView = false;
            this.btnBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuscar.MouseOverColor = System.Drawing.Color.Red;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OffsetPressedContent = true;
            this.btnBuscar.Size = new System.Drawing.Size(57, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextDropShadow = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(324, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(81, 24);
            this.panel4.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnAgregar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(57, 24);
            this.panel9.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Red;
            this.btnAgregar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnAgregar.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FocusRectangle = true;
            this.btnAgregar.Image = null;
            this.btnAgregar.ImageBorderColor = System.Drawing.Color.Red;
            this.btnAgregar.ImageFocused = null;
            this.btnAgregar.ImageInactive = null;
            this.btnAgregar.ImageMouseOver = null;
            this.btnAgregar.ImageNormal = null;
            this.btnAgregar.ImagePressed = null;
            this.btnAgregar.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAgregar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnAgregar.KeyButtonView = false;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAgregar.MouseOverColor = System.Drawing.Color.Red;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OffsetPressedContent = true;
            this.btnAgregar.Size = new System.Drawing.Size(57, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.TextDropShadow = true;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCerrarForm);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(57, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(24, 24);
            this.panel8.TabIndex = 0;
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnCerrarForm.BorderColor = System.Drawing.Color.Red;
            this.btnCerrarForm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnCerrarForm.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarForm.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnCerrarForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrarForm.FocusRectangle = true;
            this.btnCerrarForm.Image = null;
            this.btnCerrarForm.ImageBorderColor = System.Drawing.Color.Red;
            this.btnCerrarForm.ImageFocused = null;
            this.btnCerrarForm.ImageInactive = null;
            this.btnCerrarForm.ImageMouseOver = null;
            this.btnCerrarForm.ImageNormal = null;
            this.btnCerrarForm.ImagePressed = null;
            this.btnCerrarForm.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCerrarForm.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnCerrarForm.KeyButtonView = false;
            this.btnCerrarForm.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarForm.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCerrarForm.MouseOverColor = System.Drawing.Color.Red;
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.OffsetPressedContent = true;
            this.btnCerrarForm.Size = new System.Drawing.Size(24, 24);
            this.btnCerrarForm.TabIndex = 2;
            this.btnCerrarForm.Text = "x";
            this.btnCerrarForm.TextDropShadow = true;
            this.btnCerrarForm.UseVisualStyleBackColor = false;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // frmSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 200);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSeleccionarProducto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Seleccionar Cliente";
            this.Load += new System.EventHandler(this.frmSeleccionarProducto_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSeleccionarProducto_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBusqueda;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnBuscar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnCerrarForm;
        private customDataGridView dgvProductos;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewTextBoxColumn TiempoMinutos;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn IDUnidadMedida;
        private DataGridViewTextBoxColumn UnidadMedidaDesc;
        private DataGridViewTextBoxColumn UltimoCosto;
        private DataGridViewTextBoxColumn Metrica;
        private DataGridViewTextBoxColumn IDTipoProducto;

    }
}