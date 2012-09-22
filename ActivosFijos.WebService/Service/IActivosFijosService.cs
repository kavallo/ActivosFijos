using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ActivosFijosServices
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract]
    public interface IActivosFijosService
    {
        [OperationContract]
        Parametro[] ParametroList(int parame_codigo, int parame_padre, int pardet_padre);
        [OperationContract]
        Parametro[] ParametroTreeList(int parame_inicio, int pardet_inicio, int parame_fin);
        [OperationContract]
        Inventario[] InventariosActivos();
        [OperationContract]
        Empleado[] ListaEmpleados();
        [OperationContract]
        Caracteristica[] ListaCaracteristicas(int parame_tipo, int pardet_tipo);
        [OperationContract]
        Activo CargarActivo(string Activo_Codigo);
        [OperationContract]
        string GuardarInventarioDet(string mUsuario, Inventario mInventario, Activo mActivo, int mCustodio, int mParame_Ubicacion, int mPardet_Ubicacion);
        [OperationContract]
        bool IniciarSesion(string mUsuario, string mContrasena);
    }

    [DataContract]
    public class Parametro
    {
        [DataMember]
        public int Parame_Codigo { get; set; }
        [DataMember]
        public int Pardet_Secuencia { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }

    [DataContract]
    public class Caracteristica
    {
        [DataMember]
        public bool esNuevo { get; set; }
        [DataMember]
        public int Parame_Caracteristica { get; set; }
        [DataMember]
        public int Pardet_Caracteristica { get; set; }
        [DataMember]
        public string CaracteristicaText { get; set; }
        [DataMember]
        public string ActCar_Descripcion { get; set; }
    }

    [DataContract]
    public class Inventario
    {
        [DataMember]
        public int Parame_Ubicacion { get; set; }
        [DataMember]
        public int Pardet_Ubicacion { get; set; }
        [DataMember]
        public int Parame_PeriodoInventario { get; set; }
        [DataMember]
        public int Pardet_PeriodoInventario { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime Invent_Fecha { get; set; }
        [DataMember]
        public int Parame_EstadoInventario { get; set; }
        [DataMember]
        public int Pardet_EstadoInventario { get; set; }
    }

    [DataContract]
    public class Empleado
    {
        [DataMember]
        public int Emplea_Custodio { get; set; }
        [DataMember]
        public string NombreCompleto { get; set; }
    }

    [DataContract]
    public class Activo
    {
        [DataMember]
        public bool esNuevo { get; set; }
        [DataMember]
        public int Activo_Codigo { get; set; }
        [DataMember]
        public string Activo_CodigoBarra { get; set; }
        [DataMember]
        public string Activo_CodigoAux { get; set; }
        [DataMember]
        public string Activo_Serie { get; set; }
        [DataMember]
        public int Parame_ClaseActivo { get; set; }
        [DataMember]
        public int Pardet_ClaseActivo { get; set; }
        [DataMember]
        public string Activo_Descripcion { get; set; }
        [DataMember]
        public int Parame_Marca { get; set; }
        [DataMember]
        public int Pardet_Marca { get; set; }
        [DataMember]
        public string Activo_Modelo { get; set; }
        [DataMember]
        public string Activo_Observacion { get; set; }
        [DataMember]
        public int Parame_EstadoDepreciacion { get; set; }
        [DataMember]
        public int Pardet_EstadoDepreciacion { get; set; }
        [DataMember]
        public int Parame_EstadoActivo { get; set; }
        [DataMember]
        public int Pardet_EstadoActivo { get; set; }
        [DataMember]
        public string Activo_ResponsableMantenimiento { get; set; }
        [DataMember]
        public DateTime Activo_FechaIngreso { get; set; }
        [DataMember]
        public DateTime Activo_FechaCompra { get; set; }
        [DataMember]
        public DateTime Activo_FechaUso { get; set; }
        [DataMember]
        public int Parame_CentroCosto { get; set; }
        [DataMember]
        public int Pardet_CentroCosto { get; set; }
        [DataMember]
        public int Factura_Codigo { get; set; }
        [DataMember]
        public DateTime Activo_FechaBaja { get; set; }
        [DataMember]
        public int Parame_TipoBajaActivo { get; set; }
        [DataMember]
        public int Pardet_TipoBajaActivo { get; set; }
        [DataMember]
        public int Parame_Ubicacion { get; set; }
        [DataMember]
        public int Pardet_Ubicacion { get; set; }
        [DataMember]
        public int Entida_Custodio { get; set; }
        [DataMember]
        public int Pardet_Grupo { get; set; }
        [DataMember]
        public int Pardet_Tipo { get; set; }
        [DataMember]
        public Caracteristica[] Caracteristicas { get; set; }
    }
}
