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
using System.Drawing;

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
                .SortBy(dpto => dpto.nombre)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Departamento unDepartamento in listaDepartamentos)
                listaNombres.Add(unDepartamento.nombre!);

            return listaNombres;
        }


        public static List<string> ObtenerListaMunicipios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;

            var listaMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(municipio => municipio.nombre)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Municipio unMunicipio in listaMunicipios)
                listaNombres.Add(unMunicipio.nombre!);

            return listaNombres;
        }
        public static List<string> ObtenerListaIdMunicipios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;

            var listaMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(municipio => municipio.codigo)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Municipio unMunicipio in listaMunicipios)
                listaNombres.Add(unMunicipio.codigo!.ToString());

            return listaNombres;
        }

        public static List<string> ObtenerListaIdDepartamentos()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.departamentosCollectionName;

            var listaDepartamentos = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(new BsonDocument())
                .SortBy(dpto => dpto.codigo)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Departamento unDepartamento in listaDepartamentos)
                listaNombres.Add(unDepartamento.codigo!.ToString());

            return listaNombres;
        }
        public static List<string> ObtenerListaBeneficiarios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;

            var listaBeneficiarios = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios)
                .Find(new BsonDocument())
                .SortBy(beneficiario => beneficiario.codigo)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Beneficiario unBeneficiario in listaBeneficiarios)
                listaNombres.Add(unBeneficiario.codigo!.ToString());

            return listaNombres;
        }
        public static List<string> ObtenerListaSubsidios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(new BsonDocument())
                .SortBy(sdo => sdo.codigo)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios)
            {
                listaNombres.Add(unSubsidio.codigo.ToString());
            }
            return listaNombres;

        }

        public static List<string> ObtenerListaMeses()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(new BsonDocument())
                .SortBy (sdo => sdo.mes)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios) {
                if (!listaNombres.Contains(unSubsidio.mes.ToString())) {
                    listaNombres.Add(unSubsidio.mes!.ToString());
                }
            }
            return listaNombres;
        }

        public static void ActualizarProgramas(string programa, string actualizacion)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionProgramas = configDB.programasCollectionName;
            Programa unPrograma = new Programa();
            unPrograma.Id = ObtenerObjectIdPrograma(programa);
            unPrograma.Nombre = actualizacion;
            unPrograma.Codigo = Convert.ToInt32(ObtenerIdPrograma(programa));

            var miColeccion = miDB.GetCollection<Programa>(coleccionProgramas);
            var resultadoActualizacion = miColeccion.ReplaceOne(documento => documento.Nombre == programa,
                unPrograma);

        }

        public static void ActualizarMunicipios(string municipio, string actualizacion)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            Municipio unMunicipio = new Municipio();
            unMunicipio.Id = ObtenerObjectIdMunicipio(municipio);
            unMunicipio.codigo = Convert.ToDouble(ObtenerIdMunicipio(municipio));
            unMunicipio.nombre = actualizacion;
            unMunicipio.departamento = Convert.ToInt32(ObtenerDepartamentoMunicipio(municipio));

            var miColeccion = miDB.GetCollection<Municipio>(coleccionMunicipios);
            var resultadoActualizacion = miColeccion.ReplaceOne(documento => documento.nombre == municipio,
                unMunicipio);
        }

        public static string ObtenerObjectIdMunicipio(string municipio)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            var filtro = new BsonDocument { { "NOMBREMUNICIPIO", municipio } };

            Municipio mpo = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return mpo.Id!;
        }

        public static string ObtenerIdMunicipio(string municipio)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            var filtro = new BsonDocument { { "NOMBREMUNICIPIO", municipio } };

            Municipio mpo = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return mpo.codigo!.ToString();
        }

        public static string ObtenerDepartamentoMunicipio(string municipio)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            var filtro = new BsonDocument { { "NOMBREMUNICIPIO", municipio } };

            Municipio mpo = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return mpo.departamento!.ToString();
        }



        public static void ActualizarDepartamentos(string departamento, string actualizacion)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.departamentosCollectionName;
            Departamento unDepartamento = new Departamento();
            unDepartamento.Id = ObtenerObjectIdDepartamento(departamento);
            unDepartamento.codigo = ObtenerIdDepartamento(departamento);
            unDepartamento.nombre = actualizacion;


            var miColeccion = miDB.GetCollection<Departamento>(coleccionDepartamentos);
            var resultadoActualizacion = miColeccion.ReplaceOne(documento => documento.nombre == departamento,
                unDepartamento);
        }

        public static void ActualizarBeneficiarios(string beneficiario, string actualizacion)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            Beneficiario unBeneficiario = new Beneficiario();
            unBeneficiario.Id = ObtenerObjectIdBeneficiario(beneficiario);
            unBeneficiario.codigo = Convert.ToInt32(actualizacion);
            unBeneficiario.municipio = Convert.ToDouble(ObtenerMunicipioBeneficiario(beneficiario));



            var miColeccion = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios);
            var resultadoActualizacion = miColeccion.ReplaceOne(documento => documento.codigo == Convert.ToInt32(beneficiario),
                unBeneficiario);
        }

        public static bool ExisteBeneficiario(string beneficiario)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToDouble(beneficiario) } };

            var listaBeneficiarios = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios)
                .Find(filtro)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Beneficiario unBeneficiario in listaBeneficiarios)
                listaNombres.Add(unBeneficiario.codigo!.ToString());

            return !(listaNombres.Count == 0);

        }



        public static void ActualizarSubsidios(string programa, string año, string mes, string id, string valor, string beneficiario)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            Subsidio unSubsidio = new Subsidio();
            unSubsidio.Id = ObtenerObjectIdSubsidio(id);
            unSubsidio.codigo = Convert.ToInt32(id);
            unSubsidio.programa = Convert.ToInt32(ObtenerIdPrograma(programa));
            unSubsidio.beneficiario = Convert.ToInt32(beneficiario);
            unSubsidio.mes = Convert.ToInt32(mes);
            unSubsidio.año = Convert.ToInt32(año);
            unSubsidio.valorAsignado = Convert.ToInt32(valor);



            var miColeccion = miDB.GetCollection<Subsidio>(coleccionSubsidios);
            var resultadoActualizacion = miColeccion.ReplaceOne(documento => documento.codigo == Convert.ToInt32(id),
                unSubsidio);
        }

        public static void AñadirSubsidios(string programa, string año, string mes, string valor, string beneficiario)
        {
            string subsidioFinal = ObtenerListaSubsidios().Last();
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            Subsidio unSubsidio = new Subsidio();
            unSubsidio.año = Convert.ToInt32(año);
            unSubsidio.mes = Convert.ToInt32(mes);
            unSubsidio.valorAsignado = Convert.ToInt32(valor);
            unSubsidio.programa = Convert.ToInt32(ObtenerIdPrograma(programa));
            unSubsidio.beneficiario = Convert.ToInt32(beneficiario);
            unSubsidio.codigo = Convert.ToInt32(subsidioFinal) + 1;
            var miColeccion = miDB.GetCollection<Subsidio>(coleccionSubsidios);
            miColeccion.InsertOne(unSubsidio);
        }
        public static bool AñadirProgramas(string programa)
        {
            bool success = true;
            string programaFinal = ObtenerListaProgramas().Last();
            string idFinal = ObtenerIdPrograma(programaFinal);
            bool programaYaExiste = ObtenerListaProgramas().Contains(programa);
            if (programaYaExiste)
            {
                success = false;
            }
            else
            {
                success = true;
                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionProgramas = configDB.programasCollectionName;
                var miColeccion = miDB.GetCollection<Programa>(coleccionProgramas);
                Programa unPrograma = new Programa
                {
                    Codigo = Convert.ToInt32(idFinal) + 1,
                    Nombre = programa
                };
                miColeccion.InsertOne(unPrograma);
            }
            return success;

        }

        public static bool AñadirMunicipio(string idMunicipio, string municipio, string departamento)
        {
            bool success = true;
            bool idMunicipioYaExiste = ObtenerListaIdMunicipios().Contains(idMunicipio);
            bool municipioYaExiste = ObtenerListaMunicipios().Contains(municipio);
            if (idMunicipioYaExiste || municipioYaExiste)
            {
                success = false;
            }
            else
            {
                success = true;
                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.municipiosCollectionName;
                var miColeccion = miDB.GetCollection<Municipio>(coleccionMunicipios);
                Municipio unMunicipio = new Municipio
                {
                    codigo = Convert.ToDouble(idMunicipio),
                    nombre = municipio,
                    departamento = ObtenerIdDepartamento(departamento)
                };
                miColeccion.InsertOne(unMunicipio);
            }
            return success;
        }

        public static bool AñadirDepartamento(string departamento)
        {

            bool success = true;
            int lastId = Convert.ToInt32(ObtenerListaIdDepartamentos().Last());
            bool departamentoYaExiste = ObtenerListaDepartamentos().Contains(departamento);
            if (departamentoYaExiste)
            {
                success = false;
            }
            else
            {
                success = true;
                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionDepartamentos = configDB.departamentosCollectionName;
                var miColeccion = miDB.GetCollection<Departamento>(coleccionDepartamentos);
                Departamento unDepartamento = new Departamento
                {
                    codigo = lastId + 1,
                    nombre = departamento
                };
                miColeccion.InsertOne(unDepartamento);

            }
            return success;
        }

        public static bool AñadirBeneficiarios(string idBeneficiario, string municipioa)
        {
            bool success = true;
            bool beneficiarioYaExiste = ObtenerListaBeneficiarios().Contains(idBeneficiario);
            if (beneficiarioYaExiste)
            {
                success = false;
            }
            else
            {
                success = true;
                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
                var miColeccion = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios);
                Beneficiario unBeneficiario = new Beneficiario
                {
                    codigo = Convert.ToInt32(idBeneficiario),
                    municipio = Convert.ToDouble(ObtenerIdMunicipio(municipioa))
                };
                miColeccion.InsertOne(unBeneficiario);

            }
            return success;

        }

        public static bool validarProgramaTieneSubsidios(string programa)
        {
            int cantidadSubsidios;
            bool tiene = true;
            int idPrograma = Convert.ToInt32(ObtenerIdPrograma(programa));
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "PROGRAMA", Convert.ToInt32(idPrograma) } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();
            if(listaSubsidios.Count.Equals(0))
            {
                tiene = false;
            }
            return tiene;

        }

        public static bool validarBeneficiarioTieneSubsidios(string beneficiario)
        {
          
            int cantidadSubsidios;
            bool tiene = true;
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "BENEFICIARIO", Convert.ToDouble(beneficiario) } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();
            if (listaSubsidios.Count.Equals(0))
            {
                tiene = false;
            }
            return tiene;


        }
        public static bool validarMunicipioTieneSubsidios(string municipio)
        {
            
            int cantidadSubsidios = 0;
           
            string id = ObtenerIdMunicipio(municipio);
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            var filtro = new BsonDocument { { "MUNICIPIO", Convert.ToDouble(id) } };

            var listaBeneficiarios= miDB.GetCollection<Beneficiario>(coleccionBeneficiarios)
                .Find(filtro)
                .ToList();
            foreach(Beneficiario unBeneficiario in listaBeneficiarios)
            {
                if (validarBeneficiarioTieneSubsidios(unBeneficiario.codigo.ToString()))
                {
                    cantidadSubsidios++;
                }
            }
            return !cantidadSubsidios.Equals(0);




        }

        public static bool validarDepartamentoTieneSubsidios(string departamento)
        {

            int cantidadSubsidios = 0;
            bool tiene = true;
            int idDepartamento = ObtenerIdDepartamento(departamento);
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            var filtro = new BsonDocument { { "DEPARTAMENTO", idDepartamento } };

            var listaMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtro)
                .ToList();
            foreach (Municipio unMunicipio in listaMunicipios)
            {
                if (validarMunicipioTieneSubsidios(unMunicipio.nombre))
                {
                    cantidadSubsidios++;
                }
            }
            return !cantidadSubsidios.Equals(0);

        }


    public static bool BorrarPrograma(string programa)
        {
           
            bool success = true;
            bool programaExiste = ObtenerListaProgramas().Contains(programa);
            bool programaTieneSubsidios = validarProgramaTieneSubsidios(programa);
            if (programaExiste & !programaTieneSubsidios)
            {
                try
                {
                    var clienteDB = new MongoClient(configDB.ConnectionString);
                    var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                    var coleccionProgramas = configDB.programasCollectionName;

                    var miColeccion = miDB.GetCollection<Programa>(coleccionProgramas);
                    var resultadoEliminacion = miColeccion.DeleteOne(documento => documento.Nombre == programa);

                }
                catch (Exception ex)
                {
                    success = false;
                }
            }
            else
            {
                success = false;
            }
            return success;
        }

        public static bool BorrarMunicipio(string municipio)
        {
            bool success = true;
            bool municipioTieneSubsidios = validarMunicipioTieneSubsidios(municipio);
            if (!municipioTieneSubsidios)
            {
                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.municipiosCollectionName;

                var miColeccion = miDB.GetCollection<Municipio>(coleccionMunicipios);
                var resultadoEliminacion = miColeccion.DeleteOne(documento => documento.nombre == municipio);
            }
            else
            {
                success = false;
            }
            return success;
        }

        public static bool BorrarDepartamento(string departamento)
        {

            bool success = true;
            bool departamentoTieneSubsidios = validarDepartamentoTieneSubsidios(departamento);
            if (!departamentoTieneSubsidios)
            {
                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionDepartamentos = configDB.departamentosCollectionName;

                var miColeccion = miDB.GetCollection<Departamento>(coleccionDepartamentos);
                var resultadoEliminacion = miColeccion.DeleteOne(documento => documento.nombre == departamento);
            }
            else
            {
                success = false;
            }
            return success;



        }
        public static bool BorrarBeneficiario(string beneficiario)
        {
            bool success = true;
            bool beneficiarioTieneSubsidios = validarBeneficiarioTieneSubsidios(beneficiario);
            if (!beneficiarioTieneSubsidios)
            {
                try
                {
                    var clienteDB = new MongoClient(configDB.ConnectionString);
                    var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                    var coleccionBeneficiarios = configDB.beneficiariosCollectionName;

                    var miColeccion = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios);
                    var resultadoEliminacion = miColeccion.DeleteOne(documento => documento.codigo == Convert.ToInt32(beneficiario));

                }
                catch (Exception ex)
                {
                    success = false;
                }
            }
            return success;
        }

        public static void BorrarSubsidio(string idSubsidio)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;

            var miColeccion = miDB.GetCollection<Subsidio>(coleccionSubsidios);
            var resultadoEliminacion = miColeccion.DeleteOne(documento => documento.codigo == Convert.ToInt32(idSubsidio));

        }
        public static List<string> ObtenerListaAño()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(new BsonDocument())
                .SortBy(sdo => sdo.año)
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

        public static int ObtenerCantidadBeneficiarios(string programa, int mes, int año, string departamento)
        {
          
            int cantidadBeneficiarios = 0;
            int programaA = Convert.ToInt32(ObtenerIdPrograma(programa));
            int idDepartamento = ObtenerIdDepartamento(departamento);
            var clienteDB = new MongoClient(configDB.ConnectionString);
            //obtener los municipios de ese departamento
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            var filtro = new BsonDocument { { "DEPARTAMENTO", Convert.ToInt32(idDepartamento) } };
            var listaMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtro)
                .ToList();
            //obtener los beneficiarios de los subsidios que cuentan con ese programa, mes y año

            var clienteData = new MongoClient(configDB.ConnectionString);
            var miData = clienteData.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtroData = new BsonDocument { { "PROGRAMA", programaA }, { "MES", Convert.ToInt32(mes) }, { "AÑO", Convert.ToInt32(año) } };

            var listaSubsidios = miData.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtroData)
                .ToList();

            var listaBeneficiariosSubsidios = new List<long>();
            foreach(Subsidio unSubsidio in listaSubsidios)
            {
                listaBeneficiariosSubsidios.Add(unSubsidio.beneficiario);
            }
            
            //por cada municipio de ese departamento se saca los beneficiarios
            foreach(Municipio unMunicipio in listaMunicipios)
            {
                var clienteDB2 = new MongoClient(configDB.ConnectionString);
                var miDB2 = clienteDB2.GetDatabase(configDB.DatabaseName);
                var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
                var filtro2 = new BsonDocument { { "MUNICIPIO", unMunicipio.codigo } };

                var listaBeneficiarios = miDB2.GetCollection<Beneficiario>(coleccionBeneficiarios)
                    .Find(filtro2)
                    .ToList();
                //por cada beneficiario de ese municipio, si está en los beneficiarios ya sacados, se suma a la cantidad de
                //beneficiarios
                foreach(Beneficiario unBeneficiario in listaBeneficiarios)
                {
                    if (listaBeneficiariosSubsidios.Contains(unBeneficiario.codigo))
                    {
                        cantidadBeneficiarios= cantidadBeneficiarios+1;
                    }
                }
            }
            return cantidadBeneficiarios;

        }

        public static int ObtenerCantidadBeneficiarios2(string programa, int mes, int año, string municipio)
        {
            int cantidadBeneficiarios = 0;
            string programaA = ObtenerIdPrograma(programa);
            var clienteDB = new MongoClient(configDB.ConnectionString);
           
            //obtener los beneficiarios de los subsidios que cuentan con ese programa, mes y año

            var clienteData = new MongoClient(configDB.ConnectionString);
            var miData = clienteData.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtroData = new BsonDocument { { "PROGRAMA", Convert.ToInt32(programaA) }, { "MES", Convert.ToInt32(mes) }, { "AÑO", Convert.ToInt32(año) } };

            var listaSubsidios = miData.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtroData)
                .ToList();

            var listaBeneficiariosSubsidios = new List<long>();
            foreach (Subsidio unSubsidio in listaSubsidios)
            {
                listaBeneficiariosSubsidios.Add(unSubsidio.beneficiario);
            }

            
            var clienteDB2 = new MongoClient(configDB.ConnectionString);
            var miDB2 = clienteDB2.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            var filtro2 = new BsonDocument { { "MUNICIPIO", Convert.ToDouble(ObtenerIdMunicipio(municipio)) } };

            var listaBeneficiarios = miDB2.GetCollection<Beneficiario>(coleccionBeneficiarios)
                    .Find(filtro2)
                    .ToList();
                //por cada beneficiario de ese municipio, si está en los beneficiarios ya sacados, se suma a la cantidad de
                //beneficiarios
            foreach (Beneficiario unBeneficiario in listaBeneficiarios)
            {
                    if (listaBeneficiariosSubsidios.Contains(unBeneficiario.codigo))
                    {
                        cantidadBeneficiarios = cantidadBeneficiarios + 1;
                    }
            }
            
            return cantidadBeneficiarios;
        }

public static int ObtenerCantidadBeneficiarios(string idSubsidio)
        {
            int cantidadBeneficiarios = 0;

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { {"ID",Convert.ToInt32(idSubsidio) } };

            cantidadBeneficiarios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList()
                .Count;
            return cantidadBeneficiarios;
        }

        public static int ObtenerValor(string idSubsidio)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToInt32(idSubsidio) } };

            Subsidio sdo = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return sdo.valorAsignado;
        }

        public static int ObtenerMes(string idSubsidio)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToInt32(idSubsidio) } };

            Subsidio sdo = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return sdo.mes;
        }
        public static string ObtenerIdPrograma(string programa)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionProgramas = configDB.programasCollectionName;
            var filtro = new BsonDocument { { "NOMBRE", programa } };

            Programa pgm = miDB.GetCollection<Programa>(coleccionProgramas)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return pgm.Codigo.ToString();
        }

        public static string ObtenerObjectIdBeneficiario(string beneficiario)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToDouble(beneficiario) } };

            Beneficiario bro = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return bro.Id!;
        }

        public static string ObtenerObjectIdSubsidio(string id)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToInt32(id) } };

            Subsidio sdo = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return sdo.Id!;
        }

        

        public static string ObtenerMunicipioBeneficiario(string beneficiario)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToDouble(beneficiario) } };

            Beneficiario bro = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return bro.municipio!.ToString();
        }
        public static string ObtenerObjectIdPrograma(string programa)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionProgramas = configDB.programasCollectionName;
            var filtro = new BsonDocument { { "NOMBRE", programa } };

            Programa pgm = miDB.GetCollection<Programa>(coleccionProgramas)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return pgm.Id!;
        }

        public static int ObtenerIdDepartamento(string departamento)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.departamentosCollectionName;
            var filtro = new BsonDocument { { "NOMBREDEPARTAMENTO", departamento } };

            Departamento dpto = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return dpto.codigo;
        }

        public static string ObtenerObjectIdDepartamento(string departamento)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.departamentosCollectionName;
            var filtro = new BsonDocument { { "NOMBREDEPARTAMENTO", departamento } };

            Departamento dpto = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return dpto.Id!;
        }



        public static int ObtenerAño(string idSubsidio)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToInt32(idSubsidio) } };

            Subsidio sdo = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return sdo.año;
        }

        public static string ObtenerPrograma(string idSubsidio)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "ID", Convert.ToInt32(idSubsidio) } };

            Subsidio sdo = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList()
                .FirstOrDefault();
            return sdo.programa.ToString();
        }

        public static List<string> ObtenerMesesBeneficiario(string idBeneficiarios)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "BENEFICIARIO", Convert.ToDouble(idBeneficiarios) } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();

            List<string> listaMeses = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios)
                listaMeses.Add(unSubsidio.mes!.ToString());

            return listaMeses;
        }

        public static List<string> ObtenerAñosBeneficiario(string idBeneficiarios)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "BENEFICIARIO", Convert.ToDouble(idBeneficiarios) } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();

            List<string> listaMeses = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios)
                listaMeses.Add(unSubsidio.año!.ToString());

            return listaMeses;
        }

        public static List<string> ObtenerProgramasBeneficiario(string idBeneficiarios)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "BENEFICIARIO", Convert.ToDouble(idBeneficiarios) } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();

            List<string> listaMeses = new List<string>();

            foreach (Subsidio unSubsidio in listaSubsidios)
                listaMeses.Add(unSubsidio.programa!.ToString());

            return listaMeses;
        }


        public static string ObtenerValorBeneficiario(long idBeneficiarios, int programa, int mes, int año)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "BENEFICIARIO", idBeneficiarios }, { "PROGRAMA",programa},{"MES",mes},{ "AÑO", año } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();

            int valorAsignado= 0;

            foreach (Subsidio unSubsidio in listaSubsidios)
                valorAsignado += unSubsidio.valorAsignado;
            return valorAsignado.ToString();
        }

        public static string ObtenerValorBeneficiario(string idBeneficiarios)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtro = new BsonDocument { { "BENEFICIARIO", Convert.ToDouble(idBeneficiarios) } };

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtro)
                .ToList();

            int valorAsignado = 0;

            foreach (Subsidio unSubsidio in listaSubsidios)
                valorAsignado += unSubsidio.valorAsignado;
            return valorAsignado.ToString();
        }

        public static int ObtenerValor(string programa, int mes, int año, string departamento)
        {
            int valor = 0;
            int programaA = Convert.ToInt32(ObtenerIdPrograma(programa));
            int idDepartamento = ObtenerIdDepartamento(departamento);
            var clienteDB = new MongoClient(configDB.ConnectionString);
            //obtener los municipios de ese departamento
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.municipiosCollectionName;
            var filtro = new BsonDocument { { "DEPARTAMENTO", idDepartamento } };
            var listaMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtro)
                .ToList();
            //obtener los beneficiarios de los subsidios que cuentan con ese programa, mes y año

            var clienteData = new MongoClient(configDB.ConnectionString);
            var miData = clienteData.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtroData = new BsonDocument { { "PROGRAMA", programaA }, { "MES", Convert.ToInt32(mes) }, { "AÑO", Convert.ToInt32(año) } };

            var listaSubsidios = miData.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtroData)
                .ToList();

            var listaBeneficiariosSubsidios = new List<long>();
                foreach(Subsidio unSubsidio in listaSubsidios)
                {
                    listaBeneficiariosSubsidios.Add(unSubsidio.beneficiario);
                }
            
                //por cada municipio de ese departamento se saca los beneficiarios
                foreach(Municipio unMunicipio in listaMunicipios)
                {
                    var clienteDB2 = new MongoClient(configDB.ConnectionString);
                    var miDB2 = clienteDB2.GetDatabase(configDB.DatabaseName);
                    var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
                    var filtro2 = new BsonDocument { { "MUNICIPIO", unMunicipio.codigo } };

                    var listaBeneficiarios = miDB2.GetCollection<Beneficiario>(coleccionBeneficiarios)
                        .Find(filtro2)
                        .ToList();
                    //por cada beneficiario de ese municipio, si está en los beneficiarios ya sacados, se suma a la cantidad de
                    //valor
                    foreach(Beneficiario unBeneficiario in listaBeneficiarios)
                        {
                            if (listaBeneficiariosSubsidios.Contains(unBeneficiario.codigo))
                            {
                                valor= valor+Convert.ToInt32(ObtenerValorBeneficiario(unBeneficiario.codigo,programaA,Convert.ToInt32(mes),Convert.ToInt32(año)));
                            }
                        }
                }
                return valor;
       
        }

        public static int ObtenerValor2(string programa, int mes, int año, string municipio)
        {
            int valor = 0;
            int programaA = Convert.ToInt32(ObtenerIdPrograma(programa));

            //obtener los beneficiarios de los subsidios que cuentan con ese programa, mes y año

            var clienteData = new MongoClient(configDB.ConnectionString);
            var miData = clienteData.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.subsidiosCollectionName;
            var filtroData = new BsonDocument { { "PROGRAMA", programaA }, { "MES", mes }, { "AÑO", año } };

            var listaSubsidios = miData.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(filtroData)
                .ToList();

            var listaBeneficiariosSubsidios = new List<long>();
            foreach (Subsidio unSubsidio in listaSubsidios)
            {
                listaBeneficiariosSubsidios.Add(unSubsidio.beneficiario);
            }


            var clienteDB2 = new MongoClient(configDB.ConnectionString);
            var miDB2 = clienteDB2.GetDatabase(configDB.DatabaseName);
            var coleccionBeneficiarios = configDB.beneficiariosCollectionName;
            var filtro2 = new BsonDocument { { "MUNICIPIO", Convert.ToDouble(ObtenerIdMunicipio(municipio)) } };

            var listaBeneficiarios = miDB2.GetCollection<Beneficiario>(coleccionBeneficiarios)
                    .Find(filtro2)
                    .ToList();
            //por cada beneficiario de ese municipio, si está en los beneficiarios ya sacados, se suma a la cantidad de
            //valor
            foreach (Beneficiario unBeneficiario in listaBeneficiarios)
            {
                if (listaBeneficiariosSubsidios.Contains(unBeneficiario.codigo))
                {
                    valor = valor + Convert.ToInt32(ObtenerValorBeneficiario(unBeneficiario.codigo,programaA,mes,año));
                }
            }

            return valor;

        }
    }
}
