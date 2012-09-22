using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;
using System.Xml.Linq;
using System.Collections;
using Infoware.Datos;
using ActivosFijos.Reglas;
using System.Reflection;
using System.Web;

namespace ActivosFijosServices
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class ActivosFijosService : IActivosFijosService
    {
        private OperadorDatosList mOperadorDatosList= OperadorDatosList.dexml(HostingEnvironment.ApplicationPhysicalPath +"\\Conexion.xml");

        public Parametro[] ParametroList(int parame_codigo, int parame_padre, int pardet_padre)
        {
            WWTSParametroDet pardet = null;
            if (parame_padre != 0 && pardet_padre != 0)
            {
                pardet = new WWTSParametroDet(mOperadorDatosList[0], parame_padre, pardet_padre);
            }
            WWTSParametroDetList list;
            list = ActivosFijos.Reglas.WWTSParametroDetList.ObtenerLista(mOperadorDatosList[0], (Enumerados.EnumParametros)parame_codigo, WWTSParametroDetList.enumTipoObjeto.Nada, pardet, "");
            Parametro[] result = new Parametro[list.Count];
            int count = 0;
            foreach (ActivosFijos.Reglas.WWTSParametroDet pardetlist in list)
            {
                Parametro obj = new Parametro();
                obj.Parame_Codigo = pardetlist.Parame_Codigo;
                obj.Pardet_Secuencia = pardetlist.Pardet_Secuencia;
                obj.Descripcion = pardetlist.Descripcion;
                result[count] = obj;
                count++;
            }
            return result;
        }

        public Parametro[] ParametroTreeList(int parame_inicio, int pardet_inicio, int parame_fin)
        {
            WWTSParametroDetList pardetlist = new WWTSParametroDetList();
            if (pardet_inicio != 0)
            {
                pardetlist.Add(new WWTSParametroDet(mOperadorDatosList[0], parame_inicio, pardet_inicio));
            }
            else
            {
                pardetlist = WWTSParametroDetList.ObtenerLista(mOperadorDatosList[0], (Enumerados.EnumParametros)parame_inicio);
            }

            WWTSParametroDetList list = new WWTSParametroDetList();
            ArmarArbol(ref list, pardetlist, parame_fin);

            Parametro[] result = new Parametro[list.Count];
            int count = 0;
            foreach (ActivosFijos.Reglas.WWTSParametroDet pardet in list)
            {
                Parametro obj = new Parametro();
                obj.Parame_Codigo = pardet.Parame_Codigo;
                obj.Pardet_Secuencia = pardet.Pardet_Secuencia;
                obj.Descripcion = pardet.DescripcionLarga;
                result[count] = obj;
                count++;
            }
            return result;
        }

        private void ArmarArbol(ref WWTSParametroDetList list, WWTSParametroDetList iniciolist, int parame_fin)
        {
            foreach (ActivosFijos.Reglas.WWTSParametroDet pardet in iniciolist)
            {
                if (pardet.Parame_Codigo == parame_fin)
                {
                    list.Add(pardet);
                }
                else
                {
                    ArmarArbol(ref list,
                                WWTSParametroDetList.ObtenerLista(mOperadorDatosList[0],
                                    Enumerados.EnumParametros.Nulo, WWTSParametroDetList.enumTipoObjeto.Nada,
                                    pardet),
                                parame_fin);

                                            
                }
            }
        }

        public Inventario[] InventariosActivos()
        {
            //mOperadorDatosList = OperadorDatosList.dexml("/Conexion.xml");
            ActivosFijos.Reglas.InventarioList list;
            list = ActivosFijos.Reglas.InventarioList.ObtenerListaActivos(mOperadorDatosList[0], null);
            Inventario[] result = new Inventario[list.Count];
            int count=0;
            foreach (ActivosFijos.Reglas.Inventario inv in list)
            {
                Inventario obj = new Inventario();
                obj.Parame_PeriodoInventario = inv.Parame_PeriodoInventario;
                obj.Pardet_PeriodoInventario = inv.Pardet_PeriodoInventario;
                obj.Parame_Ubicacion = inv.Parame_Ubicacion;
                obj.Pardet_Ubicacion = inv.Pardet_Ubicacion;
                obj.Description = inv.Descripcion;
                obj.Invent_Fecha = inv.Invent_Fecha;
                obj.Parame_EstadoInventario = inv.Parame_EstadoInventario;
                obj.Pardet_EstadoInventario = inv.Pardet_EstadoInventario;
                result[count] = obj;
                count++;
            }
            return result;
        }

        public Empleado[] ListaEmpleados()
        {
            WWTSParametroDet pardet;
            pardet = new WWTSParametroDet(mOperadorDatosList[0], (int)Enumerados.EnumParametros.TipoEmpleado, (int)Enumerados.enumTipoEmpleado.Custodio);
            ActivosFijos.Reglas.EmpleadoList empleadolist;
            empleadolist = ActivosFijos.Reglas.EmpleadoList.ObtenerLista(mOperadorDatosList[0], pardet);
            Empleado[] result = new Empleado[empleadolist.Count];
            int count = 0;
            foreach (ActivosFijos.Reglas.Empleado emp in empleadolist)
            {
                Empleado obj = new Empleado();
                obj.Emplea_Custodio = emp.Entida_Codigo;
                obj.NombreCompleto = emp.NombreCompleto;
                result[count] = obj;
                count++;
            }
            return result;
        }

        public Caracteristica[] ListaCaracteristicas(int parame_tipo, int pardet_tipo)
        {
            WWTSParametroDet pardet;
            pardet = new WWTSParametroDet(mOperadorDatosList[0], parame_tipo, pardet_tipo);

            ActivosFijos.Reglas.WWTSParametroDetList pardetlist;
            pardetlist = WWTSParametroDetList.ObtenerLista(mOperadorDatosList[0], 
                Enumerados.EnumParametros.CaracteristicaActivo, WWTSParametroDetList.enumTipoObjeto.Nada, 
                pardet);
            Caracteristica[] result = new Caracteristica[pardetlist.Count];
            int count = 0;
            foreach (ActivosFijos.Reglas.WWTSParametroDet pd in pardetlist)
            {
                Caracteristica obj = new Caracteristica();
                obj.Parame_Caracteristica = pd.Parame_Codigo;
                obj.Pardet_Caracteristica = pd.Pardet_Secuencia;
                obj.CaracteristicaText = pd.Pardet_Descripcion;
                obj.esNuevo = true;
                obj.ActCar_Descripcion = "";
                result[count] = obj;
                count++;
            }
            return result;
        }

        public Activo CargarActivo(string mCodigoBarra)
        {
            ActivosFijos.Reglas.Activo activo;
            //ActivoCaracteristicaList _caracts = new ActivoCaracteristicaList();
            try
            {
                activo = new ActivosFijos.Reglas.Activo(mOperadorDatosList[0], mCodigoBarra);
            }
            catch 
            {
                activo = new ActivosFijos.Reglas.Activo(mOperadorDatosList[0], true);
                activo.Activo_CodigoBarra = mCodigoBarra;
            }
            
            Activo result = new Activo();
            result.esNuevo = activo.EsNuevo;
            result.Activo_Codigo = activo.Activo_Codigo;
            result.Activo_CodigoBarra = activo.Activo_CodigoBarra;
            result.Activo_CodigoAux = activo.Activo_CodigoAux;
            result.Activo_Serie = activo.Activo_Serie;
            result.Parame_ClaseActivo = activo.Parame_ClaseActivo;
            result.Pardet_ClaseActivo = activo.Pardet_ClaseActivo;
            result.Activo_Descripcion = activo.Activo_Descripcion;
            result.Parame_Marca = activo.Parame_Marca;
            result.Pardet_Marca = activo.Pardet_Marca;
            result.Activo_Modelo = activo.Activo_Modelo;
            result.Activo_Observacion = activo.Activo_Observacion;
            result.Parame_EstadoDepreciacion = activo.Parame_EstadoDepreciacion;
            result.Pardet_EstadoDepreciacion = activo.Pardet_EstadoDepreciacion;
            result.Parame_EstadoActivo = activo.Parame_EstadoActivo;
            result.Pardet_EstadoActivo = activo.Pardet_EstadoActivo;
            result.Activo_ResponsableMantenimiento = activo.Activo_ResponsableMantenimiento;
            result.Activo_FechaIngreso = activo.Activo_FechaIngreso;
            result.Activo_FechaCompra = activo.Activo_FechaCompra;
            result.Activo_FechaUso = activo.Activo_FechaUso;
            result.Parame_CentroCosto = activo.Parame_CentroCosto;
            result.Pardet_CentroCosto = activo.Pardet_CentroCosto;
            result.Factura_Codigo = activo.Factura_Codigo;
            result.Activo_FechaBaja = activo.Activo_FechaBaja;
            result.Parame_TipoBajaActivo = activo.Parame_TipoBajaActivo;
            result.Pardet_TipoBajaActivo = activo.Pardet_TipoBajaActivo;
            result.Caracteristicas = new Caracteristica[activo.Caracteristicas.Count];
            int i = 0;
            foreach(ActivoCaracteristica actcaract in activo.Caracteristicas){
                Caracteristica caract = new Caracteristica();

                caract.Parame_Caracteristica = actcaract.Parame_Caracteristica;
                caract.Pardet_Caracteristica = actcaract.Pardet_Caracteristica;
                caract.CaracteristicaText = actcaract.CaracteristicaString;
                caract.ActCar_Descripcion = actcaract.ActCar_Descripcion;
                caract.esNuevo = actcaract.EsNuevo;
                result.Caracteristicas[i] = caract;
                i++;
            }
            
            if (activo.PardetGrupoActivo != null)
            {
                result.Pardet_Grupo = activo.PardetGrupoActivo.Pardet_Secuencia;
            }
            if (activo.PardetTipoActivo != null)
            {
                result.Pardet_Tipo = activo.PardetTipoActivo.Pardet_Secuencia;
            }
            return result;
        }

        public string GuardarInventarioDet(string mUsuario, Inventario mInventario, Activo mActivo, int mCustodio, int mParame_Ubicacion, int mPardet_Ubicacion)
        {
            ActivosFijos.Reglas.WWTSUsuario usuario;
            usuario = new ActivosFijos.Reglas.WWTSUsuario(mOperadorDatosList[0], mUsuario);
            Infoware.Reglas.General.Restriccion restric;
            restric = new Infoware.Reglas.General.Restriccion(mOperadorDatosList[0],
                new Infoware.Reglas.General.ParametroDet(mOperadorDatosList[0],
                    new Infoware.Reglas.General.Parametro(mOperadorDatosList[0], 5), 300),
                usuario);

            bool mReturn = false;
            int estadoinventario = 1; //NO INVENTARIADO
            ActivosFijos.Reglas.Activo activo;
            if (mActivo.esNuevo)
            {
                activo = new ActivosFijos.Reglas.Activo(mOperadorDatosList[0], true);
                estadoinventario = 4; //ENCONTRADO NUEVO
            }
            else
            {
                activo = new ActivosFijos.Reglas.Activo(mOperadorDatosList[0], mActivo.Activo_Codigo);
            }
            activo.Activo_CodigoBarra = mActivo.Activo_CodigoBarra;
            activo.Activo_CodigoAux = mActivo.Activo_CodigoAux;
            activo.Activo_Serie = mActivo.Activo_Serie;
            activo.Parame_ClaseActivo = mActivo.Parame_ClaseActivo;
            activo.Pardet_ClaseActivo = mActivo.Pardet_ClaseActivo;
            activo.Activo_Descripcion = mActivo.Activo_Descripcion;
            activo.Parame_Marca = mActivo.Parame_Marca;
            activo.Pardet_Marca = mActivo.Pardet_Marca;
            activo.Activo_Modelo = mActivo.Activo_Modelo;
            activo.Activo_Observacion = mActivo.Activo_Observacion;
            activo.Parame_EstadoDepreciacion = mActivo.Parame_EstadoDepreciacion;
            activo.Pardet_EstadoDepreciacion = mActivo.Pardet_EstadoDepreciacion;
            activo.Parame_EstadoActivo = mActivo.Parame_EstadoActivo;
            activo.Pardet_EstadoActivo = mActivo.Pardet_EstadoActivo;
            activo.Activo_ResponsableMantenimiento = mActivo.Activo_ResponsableMantenimiento;
            activo.Activo_FechaIngreso = mActivo.Activo_FechaIngreso;
            activo.Activo_FechaCompra = mActivo.Activo_FechaCompra;
            activo.Activo_FechaUso = mActivo.Activo_FechaUso;
            activo.Parame_CentroCosto = mActivo.Parame_CentroCosto;
            activo.Pardet_CentroCosto = mActivo.Pardet_CentroCosto;
            activo.Factura_Codigo = mActivo.Factura_Codigo;
            activo.Activo_FechaBaja = mActivo.Activo_FechaBaja;
            activo.Parame_TipoBajaActivo = mActivo.Parame_TipoBajaActivo;
            activo.Pardet_TipoBajaActivo = mActivo.Pardet_TipoBajaActivo;

            mReturn = activo.Guardar();
            if (mReturn)
            {
                Infoware.Reglas.General.Auditoria.Registrar_Auditoria(restric,
                    mActivo.esNuevo ? Infoware.Reglas.General.Auditoria.enumTipoAccion.Adicion : 
                        Infoware.Reglas.General.Auditoria.enumTipoAccion.Modificacion, 
                    "Actualización activo " + activo.Descripcion);

                ActivosFijos.Reglas.InventarioDet invdet;
                try
                {
                    invdet = new ActivosFijos.Reglas.InventarioDet(mOperadorDatosList[0], mInventario.Parame_Ubicacion,
                        mInventario.Pardet_Ubicacion, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario,
                        mActivo.Activo_Codigo);
                    estadoinventario = 2; //INVENTARIADO
                }
                catch
                {
                    invdet = new ActivosFijos.Reglas.InventarioDet(mOperadorDatosList[0], true);
                    invdet.Parame_Ubicacion = mInventario.Parame_Ubicacion;
                    invdet.Pardet_Ubicacion = mInventario.Pardet_Ubicacion;
                    invdet.Parame_PeriodoInventario = mInventario.Parame_PeriodoInventario;
                    invdet.Pardet_PeriodoInventario = mInventario.Pardet_PeriodoInventario;
                    invdet.Activo_Codigo = mActivo.Activo_Codigo;
                    estadoinventario = 3; //ENCONTRADO EXISTENTE
                }
                invdet.Parame_EstadoInventario = 10110;
                invdet.Pardet_EstadoInventario = estadoinventario;
                bool esnuevo = invdet.EsNuevo;
                mReturn = invdet.Guardar(mCustodio, mParame_Ubicacion, mPardet_Ubicacion);
                if (mReturn)
                {
                    Infoware.Reglas.General.Auditoria.Registrar_Auditoria(restric,
                        esnuevo ? Infoware.Reglas.General.Auditoria.enumTipoAccion.Adicion :
                            Infoware.Reglas.General.Auditoria.enumTipoAccion.Modificacion,
                        "Registro de inventario " + activo.Descripcion);
                }
            }
            if (!mReturn)
            {
                return "Error " + mOperadorDatosList[0].MsgError;
            }
            else
            {
                return "";
            }
        }

        public bool IniciarSesion(string mUsuario, string mContrasena)
        {
            bool result=false;
            ActivosFijos.Reglas.WWTSUsuario usuario;
            try
            {
                usuario = new ActivosFijos.Reglas.WWTSUsuario(mOperadorDatosList[0], mUsuario);
                result = usuario.VerificarPassword(mContrasena);
                Infoware.Reglas.General.ParametroDet opcion;
                opcion = new Infoware.Reglas.General.ParametroDet(mOperadorDatosList[0], 5, 300);
                Infoware.Reglas.General.Restriccion restric;
                restric = new Infoware.Reglas.General.Restriccion(mOperadorDatosList[0],
                    opcion,
                    new Infoware.Reglas.General.Usuario(mOperadorDatosList[0], usuario.Usuari_Codigo));
                result = restric.Restri_Modificacion;
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
