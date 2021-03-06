﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.StephSoft.Global
{
    public class Caja
    {
        private decimal _Apertura;
        private bool _BuscarTodos;
        private string _CajaCat;
        private bool _Completado;
        private string _Conexion;
        private decimal _Cierre;
        private string _FechaIngreso;
        private string _HoraIngreso;
        private string _IDCaja;
        private string _IDCajaCat;
        private string _IDSucursal;
        private string _IDUsuario;
        private string _Mac;
        private string _NombreCaja;
        private string _NombreUsuario;
        private int _Opcion;
        private int _Resultado;
        private int _Tickets;
        private decimal _TotalCaja;
        private decimal _TotalDepositos;
        private decimal _TotalRetiroCajaLlena;
        private decimal _TotalRetirosPagos;
        private decimal _TotalVentas;
        private string _Turno;
        private int _Vales;

        public decimal Apertura
        {
            get { return _Apertura; }
            set { _Apertura = value; }
        }
        public bool BuscarTodos
        {
            get { return _BuscarTodos; }
            set { _BuscarTodos = value; }
        }
        public bool Completado
        {
            get { return _Completado; }
            set { _Completado = value; }
        }
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public string CajaCat
        {
            get { return _CajaCat; }
            set { _CajaCat = value; }
        }
        public decimal Cierre
        {
            get { return _Cierre; }
            set { _Cierre = value; }
        }
        public string FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }
        public string HoraIngreso
        {
            get { return _HoraIngreso; }
            set { _HoraIngreso = value; }
        }
        public string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }
        public string IDCajaCat
        {
            get { return _IDCajaCat; }
            set { _IDCajaCat = value; }
        }
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public string Mac
        {
            get { return _Mac; }
            set { _Mac = value; }
        }
        public string NombreCaja
        {
            get { return _NombreCaja; }
            set { _NombreCaja = value; }
        }
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
        }
        public int Tickets
        {
            get { return _Tickets; }
            set { _Tickets = value; }
        }
        public decimal TotalCaja
        {
            get { return _TotalCaja; }
            set { _TotalCaja = value; }
        }
        public decimal TotalDepositos
        {
            get { return _TotalDepositos; }
            set { _TotalDepositos = value; }
        }
        public decimal TotalRetirosCajaLlena
        {
            get { return _TotalRetiroCajaLlena; }
            set { _TotalRetiroCajaLlena = value; }
        }
        public decimal TotalRetirosPagos
        {
            get { return _TotalRetirosPagos; }
            set { _TotalRetirosPagos = value; }
        }
        public decimal TotalVentas
        {
            get { return _TotalVentas; }
            set { _TotalVentas = value; }
        }
        public string Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
        }
        public int Vales
        {
            get { return _Vales; }
            set { _Vales = value; }
        }
        private string _NombreImpresora;

        public string NombreImpresora
        {
            get { return _NombreImpresora; }
            set { _NombreImpresora = value; }
        }

        private List<VentaDetalle> _ListaServicios;

        public List<VentaDetalle> ListaServicios
        {
            get { return _ListaServicios; }
            set { _ListaServicios = value; }
        }

        private List<Usuario> _ListaEmpleados;

        public List<Usuario> ListaEmpleados
        {
            get { return _ListaEmpleados; }
            set { _ListaEmpleados = value; }
        }

        private int _FolioTicket;

        public int FolioTicket
        {
            get { return _FolioTicket; }
            set { _FolioTicket = value; }
        }

        private DateTime _FechaTicket;

        public DateTime FechaTicket
        {
            get { return _FechaTicket; }
            set { _FechaTicket = value; }
        }


        private List<FormaPago> _ListaFormasPago;

        public List<FormaPago> ListaFormasPago
        {
            get { return _ListaFormasPago; }
            set { _ListaFormasPago = value; }
        }

        private string _Cajero;

        public string Cajero
        {
            get { return _Cajero; }
            set { _Cajero = value; }
        }

        private string _FechaHoraApertura;

        public string FechaHoraApertura
        {
            get { return _FechaHoraApertura; }
            set { _FechaHoraApertura = value; }
        }

        private string _FechaHoraCierre;

        public string FechaHoraCierre
        {
            get { return _FechaHoraCierre; }
            set { _FechaHoraCierre = value; }
        }

        private decimal _TotalCancelaciones;

        public decimal TotalCancelaciones
        {
            get { return _TotalCancelaciones; }
            set { _TotalCancelaciones = value; }
        }

        private decimal _Penalizaciones;

        public decimal Penalizaciones
        {
            get { return _Penalizaciones; }
            set { _Penalizaciones = value; }
        }

        private decimal _Saldo;

        public decimal Saldo
        {
            get { return _Saldo; }
            set { _Saldo = value; }
        }
        

    }
}
