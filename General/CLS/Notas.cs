using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Notas
    {
        String _IdNota;
        String _IDMateria;
        String _Nota;
        String _IdPeriodo;
        String _IdMatricula;
        

        public string IdNota { get => _IdNota; set => _IdNota = value; }
        public string IdMatricula { get => _IdMatricula; set => _IdMatricula = value; }
        public string IDMateria { get => _IDMateria; set => _IDMateria = value; }
        public string IdPeriodo { get => _IdPeriodo; set => _IdPeriodo = value; }
        public string Nota { get => _Nota; set => _Nota = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO notas(idmatricula, idmateria, idperiodo, nota) VALUES(" + _IdMatricula + ", " + _IDMateria + ", "+ _IdPeriodo + ", " + _Nota + ");";
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

                Sentencia = @"UPDATE notas SET nota = " + _Nota + " " +
                "WHERE idnota=" + _IdNota + ";";
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
                Sentencia = @"DELETE FROM notas WHERE idnota=" + _IdNota + ";";
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
