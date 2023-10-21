using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Matriculas
    {
        String _IdMatricula;
        String _FechaMatricula;
        String _IdGrado;
        String _IdAlumno;
        String _IdSeccion;
        String _Anio;

        public string IdMatricula { get => _IdMatricula; set => _IdMatricula = value; }
        public string FechaMatricula { get => _FechaMatricula; set => _FechaMatricula = value; }
        public string IdGrado { get => _IdGrado; set => _IdGrado = value; }
        public string IdAlumno { get => _IdAlumno; set => _IdAlumno = value; }
        public string IdSeccion { get => _IdSeccion; set => _IdSeccion = value; }
        public string Anio { get => _Anio; set => _Anio = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO matriculas(fechamatricula, idgrado, idalumno, idseccion, anio) VALUES('" + _FechaMatricula + "', " + _IdGrado + ", " + _IdAlumno + ", " + _IdSeccion + ", '" + _Anio + "');";
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
                Sentencia = @"UPDATE matriculas SET fechamatricula = '" + _FechaMatricula + "', idgrado = " + _IdGrado + ", idalumno = " + _IdAlumno + ", idseccion = " + _IdSeccion + ", anio = '" + _Anio + "' " +
                "WHERE idmatricula=" + _IdMatricula + ";";
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
                Sentencia = @"DELETE FROM matriculas WHERE idmatricula = " + _IdMatricula + ";";
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
