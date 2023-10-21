using System;

namespace General.CLS
{
    public class MateriasGrados
    {
        String _IdMateriaGrado;
        String _IdMateria;
        string _IdGrado;

        public string IdMateriaGrado { get => _IdMateriaGrado; set => _IdMateriaGrado = value; }
        public string IdMateria { get => _IdMateria; set => _IdMateria = value; }
        public string IdGrado { get => _IdGrado; set => _IdGrado = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO materias_grados(idmateria, idgrado) VALUES(" + _IdMateria + ", " + _IdGrado + ");";
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

                Sentencia = @"UPDATE materias_grados SET idmateria=" + _IdMateria + ", idgrado=" + _IdGrado + " " +
                "WHERE idmateriasgrados=" + _IdMateriaGrado + ";";
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
                Sentencia = @"DELETE FROM materias_grados WHERE idmateriasgrados=" + _IdMateriaGrado + ";";
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