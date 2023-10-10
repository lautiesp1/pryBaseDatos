using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryBaseDatos
{
    internal class clsAccesoBase
    {
        //Declaración de variable y objetos globales
        OleDbConnection ConexionBD;
        OleDbCommand comandarBD;
        OleDbDataReader BDDataReader;

        DirectoryInfo RutaProyecto = new DirectoryInfo(@"../..");

        String cadenaConexion;
        public string resultadoDatos;

        public bool estadoConexion; //verdado-conectado y si es falso-desconectado

        //constructor: cuando se crea un objeto de la clase acceso base
    }

}
