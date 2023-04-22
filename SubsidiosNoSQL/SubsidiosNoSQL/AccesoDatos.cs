using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using Subsidios.Modelos;

namespace SubsidiosNoSQL
{
    public class AccesoDatos
    {
        public static SubsidiosDatabaseSettings ObtenerDBSettings()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration miConfiguracion = builder.Build();

            SubsidiosDatabaseSettings miConfigDB = new SubsidiosDatabaseSettings()
            {
                ConnectionString = miConfiguracion["SubsidiosDatabase:ConnectionString"]!,
                DatabaseName = miConfiguracion["SubsidiosDatabase:DatabaseName"]!,
                beneficiariosCollectionName = miConfiguracion["SubsidiosDatabase:beneficiariosCollectionName"]!,
                departamentosCollectionName = miConfiguracion["SubsidiosDatabase:departamentosCollectionName"]!,
                municipiosCollectionName = miConfiguracion["SubsidiosDatabase:municipiosCollectionName"]!,
                programasCollectionName = miConfiguracion["SubsidiosDatabase:programasCollectionName"]!,
                subsidiosCollectionName = miConfiguracion["SubsidiosDatabase:subsidiosCollectionName"]!
            };

            return miConfigDB;
        }
        static SubsidiosDatabaseSettings configDB = ObtenerDBSettings();


        public static List<string> ObtenerListaDepartamentos()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.departamentosCollectionName;

            var listaDepartamentos = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(new BsonDocument())
                //.SortBy(departo => dpto.nombre)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Departamento unDepartamento in listaDepartamentos)
                listaNombres.Add(unDepartamento.nombre!);
            
            return listaNombres;
        }
        //TODO departamento, meses, años, programas, con eso sacar cantidad de beneficiario y valor

        //public static List<string> ObtenerListaMunicipios()
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string sentenciaSQL = "select NOMBREMUNICIPIO from municipios ORDER by NOMBREMUNICIPIO";
        //        var resultadoMunicipios = cxnDB.Query<string>(sentenciaSQL, new DynamicParameters());
        //        return resultadoMunicipios.AsList();
        //    }
        //}
        //public static List<string> ObtenerListaIdMunicipios()
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string sentenciaSQL = "select ID from municipios";
        //        var resultadoMunicipios = cxnDB.Query<string>(sentenciaSQL, new DynamicParameters());
        //        return resultadoMunicipios.AsList();
        //    }
        //}
        //public static List<string> ObtenerListaBeneficiarios()
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string sentenciaSQL = "SELECT ID FROM beneficiarios ORDER BY ID";
        //        var resultadoBeneficiarios = cxnDB.Query<string>(sentenciaSQL, new DynamicParameters());
        //        return resultadoBeneficiarios.AsList();
        //    }
        //}
        //public static List<string> ObtenerListaSubsidios()
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string sentenciaSQL = "SELECT ID FROM subsidios ORDER BY ID";
        //        var resultadoDepartamentos = cxnDB.Query<string>(sentenciaSQL, new DynamicParameters());
        //        return resultadoDepartamentos.AsList();
        //    }
        //}
        
        public static List<string> ObtenerListaMeses()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(new BsonDocument())
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios) {
                if (!listaNombres.Contains(unSubsidio.mes.ToString())){
                    listaNombres.Add(unSubsidio.mes!.ToString());
                }
            }
            return listaNombres;
        }

        //public static void ActualizarProgramas(string programa,string actualizacion)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string actualizaProgramasSql = $"UPDATE programas SET nombre = '{actualizacion}' " +
        //                                                $"WHERE nombre = '{programa}'";

        //        int cantidadFilas = cxnDB.Execute(actualizaProgramasSql);
        //    }
        //}

        //public static void ActualizarMunicipios(string municipio, string actualizacion)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string actualizamunicipiosSql = $"UPDATE municipios SET NOMBREMUNICIPIO = '{actualizacion}' " +
        //                                                $"WHERE NOMBREMUNICIPIO = '{municipio}'";

        //        int cantidadFilas = cxnDB.Execute(actualizamunicipiosSql);
        //    }
        //}

        //public static void ActualizarDepartamentos(string departamento, string actualizacion)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string actualizaDepartamentoSql = $"UPDATE departamentos SET NOMBREDEPARTAMENTO = '{actualizacion}' " +
        //                                                $"WHERE NOMBREDEPARTAMENTO = '{departamento}'";

        //        int cantidadFilas = cxnDB.Execute(actualizaDepartamentoSql);
        //    }
        //}

        //public static void ActualizarBeneficiarios(string beneficiario, string actualizacion)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
                
        //        string actualizaProgramasSql = $"UPDATE beneficiarios SET id = {actualizacion} " +
        //                                                $"WHERE id = {beneficiario}";

        //        int cantidadFilas = cxnDB.Execute(actualizaProgramasSql);
        //    }
        //}

        //public static bool ExisteBeneficiario(string beneficiario)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idBeneficiario", beneficiario,
        //            DbType.String, ParameterDirection.Input);

        //        string cantidadBeneficiarios = cxnDB.Query<string>("select count(id) from beneficiarios where id = @idBeneficiario", parametrosSentencia).FirstOrDefault();
        //        if (cantidadBeneficiarios.Equals("0"))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }

        //    }
        //}


        //public static void ActualizarSubsidios(string programa, string año, string mes, string id, string valor,string beneficiario)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        programa = ObtenerIdPrograma(programa);
        //        string actualizaProgramasSql = $"UPDATE subsidios SET programa = {programa}, " +
        //            $"AÑO = {año},mes={mes},[VALOR ASIGNADO]={valor},BENEFICIARIO = {beneficiario} "+
        //                                                $"WHERE id = '{id}'";

        //        int cantidadFilas = cxnDB.Execute(actualizaProgramasSql);
        //    }
        //}

        //public static void AñadirSubsidios(string programa, string año, string mes, string valor, string beneficiario)
        //{
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        programa = ObtenerIdPrograma(programa);
        //        string subsidioFinal = ObtenerListaSubsidios().Last();
               
        //        string añadeProgramasSql = $"INSERT INTO subsidios (programa,beneficiario,mes,AÑO," +
        //            $"[VALOR ASIGNADO],id)  VALUES ({programa},{beneficiario},{mes},{año},{valor},{Convert.ToInt32(subsidioFinal) + 1})";

        //        int cantidadFilas = cxnDB.Execute(añadeProgramasSql);
        //    }
        //}
        //public static bool AñadirProgramas(string programa)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string programaFinal = ObtenerListaProgramas().Last();
        //        string idFinal = ObtenerIdPrograma(programaFinal);
        //        bool programaYaExiste = ObtenerListaProgramas().Contains(programa);
   
        //        if (programaYaExiste){
        //            success = false;
        //        }
        //        else
        //        {
        //            success = true;
        //            string añadeProgramasSql = $"INSERT INTO PROGRAMAS(ID,NOMBRE) values ({Convert.ToInt32(idFinal)+1},'{programa}')";
        //            int cantidadFilas = cxnDB.Execute(añadeProgramasSql);
        //        }
        //        return success;
            
        //    }
        //}

        //public static bool AñadirMunicipio(string idMunicipio,string municipio,string departamento)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
             
                
        //        bool idMunicipioYaExiste = ObtenerListaIdMunicipios().Contains(idMunicipio);
        //        bool municipioYaExiste = ObtenerListaMunicipios().Contains(municipio);

        //        if (idMunicipioYaExiste || municipioYaExiste)
        //        {
        //            success = false;
        //        }
        //        else
        //        {
        //            success = true;
        //            string añadeProgramasSql = $"INSERT INTO MUNICIPIOS(ID,NOMBREMUNICIPIO,DEPARTAMENTO) values ({idMunicipio},'{municipio}',{ObtenerIdDepartamento(departamento)})";
        //            int cantidadFilas = cxnDB.Execute(añadeProgramasSql);
        //        }
        //        return success;

        //    }
        //}

        //public static bool AñadirDepartamento(string departamento)
        //{
        //    bool success = true;
        //    int lastId;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();

        //        lastId = cxnDB.Query<int>("select id from DEPARTAMENTOS order by id DESC LIMIT 1", parametrosSentencia).FirstOrDefault();
        //        bool departamentoYaExiste = ObtenerListaDepartamentos().Contains(departamento);
        //        if (departamentoYaExiste)
        //        {
        //            success = false;
        //        }
        //        else
        //        {
        //            success = true;
        //            string añadeDepartamentosSql = $"INSERT INTO DEPARTAMENTOS(ID,NOMBREDEPARTAMENTO) values ({lastId+1},'{departamento}')";
        //            int cantidadFilas = cxnDB.Execute(añadeDepartamentosSql);
        //        }
        //        return success;

        //    }
        //}

        //public static bool AñadirBeneficiarios(string idBeneficiario,string municipio)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
               
        //        bool beneficiarioYaExiste = ObtenerListaBeneficiarios().Contains(idBeneficiario);

        //        if (beneficiarioYaExiste)
        //        {
        //            success = false;
        //        }
        //        else
        //        {
        //            success = true;
        //            string añadeBeneficiarioSql = $"INSERT INTO BENEFICIARIOS(ID,MUNICIPIO) values ({idBeneficiario},'{municipio}')";
        //            int cantidadFilas = cxnDB.Execute(añadeBeneficiarioSql);
        //        }
        //        return success;

        //    }
        //}

        //public static bool validarProgramaTieneSubsidios(string programa)
        //{
        //    int cantidadSubsidios;
        //    bool tiene = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_programa", programa,
        //            DbType.String, ParameterDirection.Input);

        //        cantidadSubsidios = cxnDB.Query<int>("SELECT count(programa) from SUBSIDIOS inner join PROGRAMAS on PROGRAMAS.ID = SUBSIDIOS.PROGRAMA where nombre = @nombre_programa", parametrosSentencia).FirstOrDefault();

        //    }
        //    if (cantidadSubsidios.Equals(0)){
        //        tiene = false;
        //    }
        //    return tiene;

        //}

        //public static bool validarBeneficiarioTieneSubsidios(string beneficiario)
        //{
        //    int cantidadSubsidios;
        //    bool tiene = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idBeneficiario", beneficiario,
        //            DbType.String, ParameterDirection.Input);

        //        cantidadSubsidios = cxnDB.Query<int>("SELECT count(programa) from SUBSIDIOS inner join PROGRAMAS on PROGRAMAS.ID = SUBSIDIOS.PROGRAMA where beneficiario = @idBeneficiario", parametrosSentencia).FirstOrDefault();

        //    }
        //    if (cantidadSubsidios.Equals(0))
        //    {
        //        tiene = false;
        //    }
        //    return tiene;

        //}
        //public static bool validarMunicipioTieneSubsidios(string municipio)
        //{
        //    int cantidadSubsidios;
        //    bool tiene = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_municipio", municipio,
        //            DbType.String, ParameterDirection.Input);

        //        cantidadSubsidios = cxnDB.Query<int>("SELECT count(programa) from SUBSIDIOS inner join BENEFICIARIOS on SUBSIDIOS.BENEFICIARIO= BENEFICIARIOS.ID inner join MUNICIPIOS on MUNICIPIOS.ID = BENEFICIARIOS.MUNICIPIO where NOMBREMUNICIPIO = @nombre_municipio", parametrosSentencia).FirstOrDefault();

        //    }
        //    if (cantidadSubsidios.Equals(0))
        //    {
        //        tiene = false;
        //    }
        //    return tiene;
        //}

        //public static bool validarDepartamentoTieneSubsidios(string departamento)
        //{
        //    int cantidadSubsidios;
        //    bool tiene = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_departamento", departamento,
        //            DbType.String, ParameterDirection.Input);

        //        cantidadSubsidios = cxnDB.Query<int>("SELECT count(programa) from SUBSIDIOS inner join BENEFICIARIOS on SUBSIDIOS.BENEFICIARIO= BENEFICIARIOS.ID inner join MUNICIPIOS on MUNICIPIOS.ID = BENEFICIARIOS.MUNICIPIO INNER JOIN DEPARTAMENTOS on DEPARTAMENTOS.ID=MUNICIPIOS.DEPARTAMENTO where NOMBREDEPARTAMENTO = @nombre_departamento", parametrosSentencia).FirstOrDefault();

        //    }
        //    if (cantidadSubsidios.Equals(0))
        //    {
        //        tiene = false;
        //    }
        //    return tiene;
        //}


        //public static bool BorrarPrograma(string programa)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        bool programaExiste = ObtenerListaProgramas().Contains(programa);
        //        bool programaTieneSubsidios = validarProgramaTieneSubsidios(programa);
        //        if (programaExiste & !programaTieneSubsidios) {
        //            string borraProgramasSql = $"DELETE FROM PROGRAMAS WHERE NOMBRE = '{programa}'";
        //            try {cxnDB.Execute(borraProgramasSql); }catch(Exception ex) { success = false; }
        //        }
        //        else {  success = false;}
        //    }
        //    return success;
        //}

        //public static bool BorrarMunicipio(string municipio)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        bool municipioTieneSubsidios = validarMunicipioTieneSubsidios(municipio);
        //        if (!municipioTieneSubsidios)
        //        {
        //            string borraProgramasSql = $"DELETE FROM MUNICIPIOS WHERE NOMBREMUNICIPIO = '{municipio}'";
        //            try { cxnDB.Execute(borraProgramasSql); } catch (Exception ex) { success = false; }
        //        }
        //        else { success = false; }
        //    }
        //    return success;
        //}

        //public static bool BorrarDepartamento(string departamento)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        bool departamentoTieneSubsidios = validarDepartamentoTieneSubsidios(departamento);
        //        if (!departamentoTieneSubsidios)
        //        {
        //            string borraProgramasSql = $"DELETE FROM DEPARTAMENTOS WHERE NOMBREDEPARTAMENTO = '{departamento}'";
        //            try { cxnDB.Execute(borraProgramasSql); } catch (Exception ex) { success = false; }
        //        }
        //        else { success = false; }
        //    }
        //    return success;
        //}
        //public static bool BorrarBeneficiario(string beneficiario)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        bool beneficiarioTieneSubsidios = validarBeneficiarioTieneSubsidios(beneficiario);
        //        if (!beneficiarioTieneSubsidios)
        //        {
        //            string borraBeneficiarioSql = $"DELETE FROM BENEFICIARIOS WHERE ID = {beneficiario}";
        //            try { cxnDB.Execute(borraBeneficiarioSql); } catch (Exception ex) { success = false; }
        //        }
        //        else { success = false; }
        //    }
        //    return success;
        //}

        //public static void BorrarSubsidio(string idSubsidio)
        //{
        //    bool success = true;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        string borraSubsidiosSql = $"DELETE FROM SUBSIDIOS WHERE ID = '{idSubsidio}'";
        //        cxnDB.Execute(borraSubsidiosSql);
        //    }
        //}
        public static List<string> ObtenerListaAño()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(new BsonDocument())
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios)
            {
                if (!listaNombres.Contains(unSubsidio.año.ToString()))
                {
                    listaNombres.Add(unSubsidio.año!.ToString());
                }
            }
            return listaNombres;
        }

        public static List<string> ObtenerListaProgramas()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionProgramas = configDB.programasCollectionName;

            var listaProgramas = miDB.GetCollection<Programa>(coleccionProgramas)
                .Find(new BsonDocument())
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Programa unPrograma in listaProgramas)
            {
                if (!listaNombres.Contains(unPrograma.Nombre))
                {
                    listaNombres.Add(unPrograma.Nombre);
                }
            }
            return listaNombres;
        }

        //public static int ObtenerCantidadBeneficiarios(string programa,int mes, int año, string departamento)
        //{
        //    int cantidadBeneficiarios = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_año", año,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_mes", mes,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_departamento", departamento,
        //            DbType.String, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_programa", programa,
        //            DbType.String, ParameterDirection.Input);

        //        cantidadBeneficiarios = cxnDB.Query<int>("select COUNT(PROGRAMA) from SUBSIDIOS"+
        //            " INNER JOIN PROGRAMAS on SUBSIDIOS.PROGRAMA = PROGRAMAS.ID INNER JOIN BENEFICIARIOS"+
        //            " ON SUBSIDIOS.BENEFICIARIO = BENEFICIARIOS.ID INNER JOIN MUNICIPIOS ON"+
        //            " BENEFICIARIOS.MUNICIPIO = MUNICIPIOS.ID INNER JOIN DEPARTAMENTOS ON MUNICIPIOS.DEPARTAMENTO = DEPARTAMENTOS.ID WHERE NOMBRE = @nombre_programa AND NOMBREDEPARTAMENTO = @nombre_departamento"+
        //            " and AÑO = @nombre_año and mes = @nombre_mes", parametrosSentencia).FirstOrDefault();
        //    }
        //    return cantidadBeneficiarios;
        //}

        //public static int ObtenerCantidadBeneficiarios2(string programa, int mes, int año, string municipio)
        //{
        //    int cantidadBeneficiarios = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_año", año,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_mes", mes,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_municipio", municipio,
        //            DbType.String, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_programa", programa,
        //            DbType.String, ParameterDirection.Input);

        //        cantidadBeneficiarios = cxnDB.Query<int>("select COUNT(PROGRAMA) from SUBSIDIOS" +
        //            " INNER JOIN PROGRAMAS on SUBSIDIOS.PROGRAMA = PROGRAMAS.ID INNER JOIN BENEFICIARIOS" +
        //            " ON SUBSIDIOS.BENEFICIARIO = BENEFICIARIOS.ID INNER JOIN MUNICIPIOS ON" +
        //            " BENEFICIARIOS.MUNICIPIO = MUNICIPIOS.ID WHERE NOMBRE = @nombre_programa AND NOMBREMUNICIPIO = @nombre_municipio" +
        //            " and AÑO = @nombre_año and mes = @nombre_mes", parametrosSentencia).FirstOrDefault();
        //    }
        //    return cantidadBeneficiarios;
        //}

        //public static int ObtenerCantidadBeneficiarios(string idSubsidio)
        //{
        //    int cantidadBeneficiarios = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idSubsidio", idSubsidio,
        //        DbType.String, ParameterDirection.Input);
             

        //        cantidadBeneficiarios = cxnDB.Query<int>("SELECT COUNT(PROGRAMA) FROM SUBSIDIOS WHERE ID = @idSubsidio", parametrosSentencia).FirstOrDefault();
        //    }
        //    return cantidadBeneficiarios;
        //}

        //public static int ObtenerValor(string idSubsidio)
        //{
        //    int cvalor = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idSubsidio", idSubsidio,
        //        DbType.String, ParameterDirection.Input);


        //        cvalor = cxnDB.Query<int>("SELECT [VALOR ASIGNADO] FROM SUBSIDIOS WHERE ID = @idSubsidio", parametrosSentencia).FirstOrDefault();
        //    }
        //    return cvalor;
        //}

        //public static int ObtenerMes(string idSubsidio)
        //{
        //    int mes = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idSubsidio", idSubsidio,
        //        DbType.String, ParameterDirection.Input);


        //        mes = cxnDB.Query<int>("SELECT mes FROM SUBSIDIOS WHERE ID = @idSubsidio", parametrosSentencia).FirstOrDefault();
        //    }
        //    return mes;
        //}
        //public static string ObtenerIdPrograma(string programa)
        //{
            
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_programa", programa,
        //        DbType.String, ParameterDirection.Input);


        //        programa = cxnDB.Query<string>("SELECT id FROM programas WHERE NOMBRE = @nombre_programa", parametrosSentencia).FirstOrDefault();
        //    }
        //    return programa;
        //}

        //public static int ObtenerIdDepartamento(string departamento)
        //{
        //    int departamentoId;

        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_departamento", departamento,
        //        DbType.String, ParameterDirection.Input);


        //        departamentoId = cxnDB.Query<int>("SELECT id FROM departamentos WHERE NOMBREDEPARTAMENTO = @nombre_departamento", parametrosSentencia).FirstOrDefault();
        //    }
        //    return departamentoId;
        //}



        //public static int ObtenerAño(string idSubsidio)
        //{
        //    int año = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idSubsidio", idSubsidio,
        //        DbType.String, ParameterDirection.Input);


        //        año = cxnDB.Query<int>("SELECT AÑO FROM SUBSIDIOS WHERE ID = @idSubsidio", parametrosSentencia).FirstOrDefault();
        //    }
        //    return año;
        //}

        //public static string ObtenerPrograma(string idSubsidio)
        //{
        //    string programa;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idSubsidio", idSubsidio,
        //        DbType.String, ParameterDirection.Input);


        //        programa = cxnDB.Query<string>("SELECT PROGRAMA FROM SUBSIDIOS WHERE ID = @idSubsidio", parametrosSentencia).FirstOrDefault();
        //    }
        //    return programa;
        //}

        //public static List<string> ObtenerMesesBeneficiario(string idBeneficiarios)
        //{
        //    List<string> meses;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idBeneficiario", idBeneficiarios,
        //        DbType.String, ParameterDirection.Input);


        //        meses = cxnDB.Query<string>("SELECT MES FROM SUBSIDIOS WHERE BENEFICIARIO = @idBeneficiario", parametrosSentencia).AsList();
        //    }
        //    return meses;
        //}

        //public static List<string> ObtenerAñosBeneficiario(string idBeneficiarios)
        //{
        //    List<string> años;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idBeneficiario", idBeneficiarios,
        //        DbType.String, ParameterDirection.Input);


        //        años = cxnDB.Query<string>("SELECT AÑO FROM SUBSIDIOS WHERE BENEFICIARIO = @idBeneficiario", parametrosSentencia).AsList();
        //    }
        //    return años;
        //}

        //public static List<string> ObtenerProgramasBeneficiario(string idBeneficiarios)
        //{
        //    List<string> programas;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idBeneficiario", idBeneficiarios,
        //        DbType.String, ParameterDirection.Input);


        //        programas = cxnDB.Query<string>("SELECT PROGRAMA FROM SUBSIDIOS WHERE BENEFICIARIO = @idBeneficiario", parametrosSentencia).AsList();
        //    }
        //    return programas;
        //}


        //public static string ObtenerValorBeneficiario(string idBeneficiarios)
        //{
        //    string valor;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@idBeneficiario", idBeneficiarios,
        //        DbType.String, ParameterDirection.Input);


        //        valor = cxnDB.Query<string>("SELECT SUM([VALOR ASIGNADO]) FROM SUBSIDIOS WHERE BENEFICIARIO = @idBeneficiario", parametrosSentencia).LastOrDefault();
        //    }
        //    return valor;
        //}

        //public static int ObtenerValor(string programa, int mes, int año, string departamento)
        //{
        //    int valor = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_año", año,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_mes", mes,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_departamento", departamento,
        //            DbType.String, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_programa", programa,
        //            DbType.String, ParameterDirection.Input);
        //        try
        //        {

        //            valor = cxnDB.Query<int>("select sum([VALOR ASIGNADO]) from SUBSIDIOS"+
        //            " INNER JOIN PROGRAMAS on SUBSIDIOS.PROGRAMA = PROGRAMAS.ID INNER JOIN BENEFICIARIOS" +
        //            " ON SUBSIDIOS.BENEFICIARIO = BENEFICIARIOS.ID INNER JOIN MUNICIPIOS ON" +
        //            " BENEFICIARIOS.MUNICIPIO = MUNICIPIOS.ID INNER JOIN DEPARTAMENTOS ON MUNICIPIOS.DEPARTAMENTO = DEPARTAMENTOS.ID WHERE NOMBRE = @nombre_programa AND NOMBREDEPARTAMENTO = @nombre_departamento" +
        //            " and AÑO = @nombre_año and mes = @nombre_mes", parametrosSentencia).FirstOrDefault();
        //        }
                

        //        catch (Exception ex)
        //        {
        //            valor = 0;
        //        }
        //    }
        //    return valor;
        //}

        //public static int ObtenerValor2(string programa, int mes, int año, string municipio)
        //{
        //    int valor = 0;
        //    using (IDbConnection cxnDB = new SQLiteConnection(ObtenerCadenaConexion()))
        //    {
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre_año", año,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_mes", mes,
        //            DbType.Int32, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_municipio", municipio,
        //            DbType.String, ParameterDirection.Input);
        //        parametrosSentencia.Add("@nombre_programa", programa,
        //            DbType.String, ParameterDirection.Input);
        //        try
        //        {

        //            valor = cxnDB.Query<int>("select sum([VALOR ASIGNADO]) from SUBSIDIOS" +
        //            " INNER JOIN PROGRAMAS on SUBSIDIOS.PROGRAMA = PROGRAMAS.ID INNER JOIN BENEFICIARIOS" +
        //            " ON SUBSIDIOS.BENEFICIARIO = BENEFICIARIOS.ID INNER JOIN MUNICIPIOS ON" +
        //            " BENEFICIARIOS.MUNICIPIO = MUNICIPIOS.ID WHERE NOMBRE = @nombre_programa AND NOMBREMUNICIPIO = @nombre_municipio" +
        //            " and AÑO = @nombre_año and mes = @nombre_mes", parametrosSentencia).FirstOrDefault();
        //        }


        //        catch (Exception ex)
        //        {
        //            valor = 0;
        //        }
        //    }
        //    return valor;
        //}
    }
}
