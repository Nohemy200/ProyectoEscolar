using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Docentes
    {
        String _IdDocente;
        String _NombresDocente;
        String _ApellidosDocente;
        String _Dui;
        String _Telefono;
        String _FechaNacimiento;
        String _IdGenero;
        String _IdEstado;
        String _IdEspecialidad;
        String _IdDireccion;

        public string IdDocente { get => _IdDocente; set => _IdDocente = value; }
        public string NombresDocente { get => _NombresDocente; set => _NombresDocente = value; }
        public string ApellidosDocente { get => _ApellidosDocente; set => _ApellidosDocente = value; }
        public string Dui { get => _Dui; set => _Dui = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string IdGenero { get => _IdGenero; set => _IdGenero = value; }
        public string IdEstado { get => _IdEstado; set => _IdEstado = value; }
        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }
        public string IdEspecialidad { get => _IdEspecialidad; set => _IdEspecialidad = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO docentes(nombresdocente, apellidosdocente, dui, telefono, fechanacimiento, idgenero, idestado,idespecialidad,direccion) VALUES('" + _NombresDocente+ "', '" + _ApellidosDocente + "', '" + _Dui + "', '" + _Telefono + "', '" + _FechaNacimiento + "', " + _IdGenero + ", " + _IdEstado + "," +IdEspecialidad  + ",'" + IdDireccion + "');";
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

                Sentencia = @"UPDATE docentes SET nombresdocente = '" + _NombresDocente + "', apellidosdocente = '" + _ApellidosDocente + "', dui = '" + _Dui + "', telefono = '" + _Telefono + "', fechanacimiento = '" + _FechaNacimiento + "', idgenero = " + _IdGenero + ", idestado = " + _IdEstado + ", idespecialidad = " + IdEspecialidad + ",direccion = '" + _IdDireccion + "' " +
                "WHERE iddocente=" + _IdDocente + ";";
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
                Sentencia = @"DELETE FROM docentes WHERE iddocente=" + _IdDocente + ";";
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
