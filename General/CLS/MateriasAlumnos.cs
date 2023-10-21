using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class MateriasAlumnos
    {
        String _IdMateriaAlumno;
        String _IdMateria;
        String _IdAlumno;

        public string IdMateriaAlumno { get => _IdMateriaAlumno; set => _IdMateriaAlumno = value; }
        public string IdMateria { get => _IdMateria; set => _IdMateria = value; }
        public string IdAlumno { get => _IdAlumno; set => _IdAlumno = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO materias_alumnos(idalumno, idmateria) VALUES(" + _IdAlumno + ", " + _IdMateria + ");";
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
                Sentencia = @"UPDATE materias_alumnos SET idmateria=" + _IdMateria + ", idalumno = " + _IdAlumno + " " +
                "WHERE idmateriasalumnos=" + _IdMateriaAlumno + ";";
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
                Sentencia = @"DELETE FROM materias_alumnos WHERE idmateriasalumnos=" + _IdMateriaAlumno + ";";
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
