using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Grados
    {
        String _IdGrado;
        String _Grado;
        String _IdAula;
        String _IdDocente;

        public string IdGrado { get => _IdGrado; set => _IdGrado = value; }
        public string Grado { get => _Grado; set => _Grado = value; }
        public string IdAula { get => _IdAula; set => _IdAula = value; }
        public string IdDocente { get => _IdDocente; set => _IdDocente = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO grados(grado, idaula, iddocente) VALUES('" + _Grado + "', '" + _IdAula + "', '" + _IdDocente + "');";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {

                Sentencia = @"UPDATE grados SET grado = '" + _Grado + "', idaula = '" + _IdAula + "', iddocente = '" + _IdDocente + "' " +
                "WHERE idgrado=" + _IdGrado + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = @"DELETE FROM grados WHERE idgrado=" + _IdGrado + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
