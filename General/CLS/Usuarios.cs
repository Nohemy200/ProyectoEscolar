using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Usuarios
    {
        String _IdUsuario;
        String _Usuario;
        String _Contraseña;
        String _IdRol;
        String _IdDocente;

        public string IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string IdRol { get => _IdRol; set => _IdRol = value; }
        public string IdDocente { get => _IdDocente; set => _IdDocente = value; }

        public (Boolean, Boolean)  Insertar()
        {
            Boolean resultadoInsercion = false;
            Boolean resultadoBusqueda = false;
            DataManager.DBOperacion op = new DataManager.DBOperacion();

            try
            {
                DataTable resultado = new DataTable();
                string sentenciaConsulta = "SELECT * FROM usuarios WHERE iddocente =  '" + _IdDocente + "';";

                resultado = op.Consultar(sentenciaConsulta);

                if (resultado.Rows.Count > 0)
                {
                    resultadoBusqueda = true;
                    resultadoInsercion = false;
                }
                else
                {
                    string sentencia = @"INSERT INTO usuarios(usuario, password, idRol, iddocente) " + 
                        " VALUES ('" + _Usuario + "', sha1(md5('" + _Contraseña + @"')), '" + _IdRol + "', '" + _IdDocente + "');";
                    Int32 filasInsertadas = 0;
                    filasInsertadas = op.EjecutarSentencia(sentencia);

                    if (filasInsertadas > 0)
                    {
                        resultadoBusqueda = false;
                        resultadoInsercion = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return (resultadoBusqueda, resultadoInsercion);
        }
        public Boolean Actualizar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE Usuarios SET usuario = '" + _Usuario + "', password = sha1(md5('" + _Contraseña + "')), idrol = '" +
                _IdRol + "', iddocente = '" + _IdDocente + "' WHERE id = " + _IdUsuario + ";";

            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasActualizadas = 0;
                filasActualizadas = op.EjecutarSentencia(sentencia);
                if (filasActualizadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Boolean Eliminar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"DELETE FROM Usuarios " +
                "WHERE id = " + _IdUsuario + ";";
            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasEliminadas = 0;
                filasEliminadas = op.EjecutarSentencia(sentencia);
                if (filasEliminadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
    }
}
    