﻿using CreativaSL.Dll.StephSoft.Global;
using CreativaSL.Dll.StephSoft.Negocio;
using StephSoft.ClasesAux;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StephSoft
{
    public partial class frmPedidoDetalle : Form
    {
        #region Propiedades / Variables
        private Pedido _DatosPedido;
        public Pedido DatosPedido
        {
            get { return _DatosPedido; }
            set { _DatosPedido = value; }
        }
        #endregion

        #region Constructor(es)

        public frmPedidoDetalle(Pedido Datos)
        {
            try
            {
                InitializeComponent();
                this._DatosPedido = Datos;
            }
            catch (Exception ex)
            {
                LogError.AddExcFileTxt(ex, "frmPedidoDetalle ~ frmPedidoDetalle(Pedido Datos)");
            }
        }

        #endregion

        #region Métodos

        private void CargarGridPedidoDetalle()
        {
            try
            {
                this.dgvPedidoDetalle.AutoGenerateColumns = false;
                this.dgvPedidoDetalle.DataSource = null;
                this.dgvPedidoDetalle.DataSource = this._DatosPedido.DetallePedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void CargarDatosAModificar(Pedido Datos)
        {
            try
            {
                if (!string.IsNullOrEmpty(Datos.IDPedido.Trim()))
                {
                    this.txtFolioPedido.Text = this._DatosPedido.FolioPedido;
                    this.txtEstatus.Text = this._DatosPedido.Estatus;
                    this.CargarGridPedidoDetalle();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarForm()
        {
            try
            {
                this._DatosPedido.DetallePedido = this.ObtenerDetallePedidoXID(this._DatosPedido.IDPedido);
                this.CargarDatosAModificar(this._DatosPedido);
                this.ActiveControl = this.btnCancelar;
                this.btnCancelar.Focus();
                if (File.Exists(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\Documents\" + Comun.UrlLogo)))
                {
                    this.pictureBox1.Image = Image.FromFile(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\Documents\" + Comun.UrlLogo));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<PedidoDetalle> ObtenerDetallePedidoXID(string IDPedido)
        {
            try
            {
                Pedido_Negocio PedNeg = new Pedido_Negocio();
                return PedNeg.ObtenerDetalleClavesPedido(new Pedido { IDPedido = IDPedido, Conexion = Comun.Conexion });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos    
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                LogError.AddExcFileTxt(ex, "frmNuevoPedido ~ btnCancelar_Click");
                MessageBox.Show(Comun.MensajeError, Comun.Sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPedidoDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                LogError.AddExcFileTxt(ex, "frmPedidoDetalle ~ frmPedidoDetalle_Load");
                MessageBox.Show(Comun.MensajeError, Comun.Sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
