﻿namespace StephSoft
{
    partial class frmInicializarClaves
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtMensajeError = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMetricaInicial = new System.Windows.Forms.TextBox();
            this.btnElegirProducto = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(205)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(478, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(21, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(364, 55);
            this.label42.TabIndex = 24;
            this.label42.Text = "Inicializar clave";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.txtMensajeError);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 80);
            this.panel2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.panel2, "Guardar la información");
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Red;
            this.btnGuardar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnGuardar.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnGuardar.FocusRectangle = true;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageBorderColor = System.Drawing.Color.Red;
            this.btnGuardar.ImageFocused = null;
            this.btnGuardar.ImageInactive = null;
            this.btnGuardar.ImageMouseOver = global::StephSoft.Properties.Resources._0000s_0000s_0003_guardar_a;
            this.btnGuardar.ImageNormal = global::StephSoft.Properties.Resources._0000s_0000s_0003_guardar;
            this.btnGuardar.ImagePressed = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(44, 44);
            this.btnGuardar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnGuardar.KeyButtonView = false;
            this.btnGuardar.Location = new System.Drawing.Point(453, 5);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.Red;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(80, 70);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnCancelar.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnCancelar.FocusRectangle = true;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageBorderColor = System.Drawing.Color.Red;
            this.btnCancelar.ImageFocused = null;
            this.btnCancelar.ImageInactive = null;
            this.btnCancelar.ImageMouseOver = global::StephSoft.Properties.Resources._0000s_0000s_0002_cancelar_a;
            this.btnCancelar.ImageNormal = global::StephSoft.Properties.Resources._0000s_0000s_0002_cancelar;
            this.btnCancelar.ImagePressed = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(44, 44);
            this.btnCancelar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnCancelar.KeyButtonView = false;
            this.btnCancelar.Location = new System.Drawing.Point(537, 5);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.Red;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(80, 70);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextDropShadow = true;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar y Regresar al Menú");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMensajeError
            // 
            this.txtMensajeError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMensajeError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeError.Location = new System.Drawing.Point(12, 6);
            this.txtMensajeError.Multiline = true;
            this.txtMensajeError.Name = "txtMensajeError";
            this.txtMensajeError.ReadOnly = true;
            this.txtMensajeError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensajeError.Size = new System.Drawing.Size(421, 69);
            this.txtMensajeError.TabIndex = 63;
            this.txtMensajeError.Text = "Ocurrió un Error";
            this.txtMensajeError.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtMetricaInicial);
            this.panel4.Controls.Add(this.btnElegirProducto);
            this.panel4.Controls.Add(this.txtProducto);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 180);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(86, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 177;
            this.label5.Text = "Métrica inicial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(59, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 176;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMetricaInicial
            // 
            this.txtMetricaInicial.Location = new System.Drawing.Point(87, 124);
            this.txtMetricaInicial.Name = "txtMetricaInicial";
            this.txtMetricaInicial.Size = new System.Drawing.Size(186, 25);
            this.txtMetricaInicial.TabIndex = 3;
            this.txtMetricaInicial.Text = "0";
            this.txtMetricaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnElegirProducto
            // 
            this.btnElegirProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnElegirProducto.BorderColor = System.Drawing.Color.Red;
            this.btnElegirProducto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(114)))));
            this.btnElegirProducto.BorderMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnElegirProducto.BorderNoFocusColor = System.Drawing.Color.Maroon;
            this.btnElegirProducto.FocusRectangle = true;
            this.btnElegirProducto.Image = null;
            this.btnElegirProducto.ImageBorderColor = System.Drawing.Color.Red;
            this.btnElegirProducto.ImageFocused = null;
            this.btnElegirProducto.ImageInactive = null;
            this.btnElegirProducto.ImageMouseOver = null;
            this.btnElegirProducto.ImageNormal = null;
            this.btnElegirProducto.ImagePressed = null;
            this.btnElegirProducto.ImageSize = new System.Drawing.Size(35, 35);
            this.btnElegirProducto.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnElegirProducto.KeyButtonView = false;
            this.btnElegirProducto.Location = new System.Drawing.Point(372, 49);
            this.btnElegirProducto.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnElegirProducto.MouseOverColor = System.Drawing.Color.Red;
            this.btnElegirProducto.Name = "btnElegirProducto";
            this.btnElegirProducto.OffsetPressedContent = true;
            this.btnElegirProducto.Size = new System.Drawing.Size(74, 24);
            this.btnElegirProducto.TabIndex = 2;
            this.btnElegirProducto.Text = "Elegir";
            this.btnElegirProducto.TextDropShadow = true;
            this.btnElegirProducto.UseVisualStyleBackColor = false;
            this.btnElegirProducto.Click += new System.EventHandler(this.btnElegirProducto_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.txtProducto.Location = new System.Drawing.Point(87, 48);
            this.txtProducto.MaxLength = 130;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(284, 25);
            this.txtProducto.TabIndex = 113;
            this.txtProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 180);
            this.panel3.TabIndex = 2;
            // 
            // frmInicializarClaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(628, 340);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(630, 425);
            this.Name = "frmInicializarClaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInicializarClaves_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtMensajeError;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnGuardar;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnElegirProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMetricaInicial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

