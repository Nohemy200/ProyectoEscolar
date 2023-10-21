using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable USUARIOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.id, a.usuario, a.password, b.idrol, b.rol, c.iddocente, c.nombresdocente
                                from usuarios a, roles b, docentes c
                                where a.idrol=b.idrol and a.iddocente=c.iddocente order by id;;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }

        public static DataTable BUSCAR_MATERIAS_POR_ALUMNO(String nie)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT m.idmatricula, m.fechamatricula, m.turno, m.idgrado, a.idalumno, ma.idmateria, g.grado, mat.materia, a.nombres as nombre, a.apellidos
                                FROM matriculas m, alumnos a, materias_alumnos ma, materias mat, grados g
                                WHERE a.idalumno=m.idalumno AND ma.idalumno=a.idalumno AND mat.idmateria=ma.idmateria
                                AND m.idgrado=g.idgrado AND a.nie='" + nie + "';";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CONSULTA_GRADOS_POR_CICLO(String ciclo)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT c.idgrado, c.idciclo, c.ciclo, g.grado FROM ciclos c, 
                               grados g WHERE c.idgrado=g.idgrado AND ciclo = '"+ciclo+"';";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CONSULTA_CICLO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT ciclo FROM ciclos group by ciclo";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CONSULTA_SECCION_POR_GRADO(string text)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT s.idseccion, s.seccion FROM secciones s
                                WHERE s.idgrado = " + text + ";";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable PERMISOS(String pidRol)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT a.idopcion, a.opcion, 
            a.idclasificasion, b.clasificasion,
            IFNULL((SELECT idpermiso FROM permisos z 
            WHERE z.idRol=" + pidRol + @" AND z.idopcion=a.idopcion ),0) idpermiso,
            IF(IFNULL((SELECT idpermiso FROM permisos z 
            WHERE z.idRol=" + pidRol + @" AND z.idopcion=a.idopcion ),0)>0,1,0) Asignado
            FROM opciones a, clasificasiones b 
            WHERE a.idclasificasion=b.idclasificasion;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable BUSCAR_ALUMNOS_ASIGNAR_NOTAS(string idPeriodo, string idGrado, string idMateria, string idSeccion, string anio)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT a.idalumno, CONCAT(a.nombres, ' ', a.apellidos) nombres, ma.idmateria, ma.materia, mt.idmatricula, anio, idnota, n.nota, p.idperiodo, p.periodo 
                                 FROM matriculas mt, notas n, materias ma, periodos p, alumnos a
                                WHERE mt.idmatricula = n.idmatricula
                                AND a.idalumno = mt.idalumno
                                AND n.idmateria = ma.idmateria
                                AND p.idperiodo = n.idperiodo
                                AND p.idperiodo = " + idPeriodo + @"
                                AND idgrado = " + idGrado + @"
                                AND ma.idmateria = " + idMateria + @"
                                AND idseccion = " + idSeccion + @"
                                AND anio = '" + anio + "'; ";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CONSULTA_APODERADO_POR_ALUMNO(int id)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT ap.idapoderado, ap.dui, ap.nombresapoderado FROM alumnos al, apoderado ap
                                WHERE ap.idapoderado=al.idapoderado AND al.idalumno = " + id +";";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static object MATERIAS_GRADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT mg.idmateriasgrados, m.idmateria, m.materia, g.idgrado, g.grado FROM materias_grados mg, materias m, grados g
                                WHERE mg.idmateria=m.idmateria AND mg.idgrado=g.idgrado;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable REGISTRO_MATERIA_GRADO(String idmateria, String idgrado)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idmateriasgrados, idmateria, idgrado FROM materias_grados
WHERE idgrado = " + idgrado + " AND idmateria = " + idmateria + ";";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static object ALUMNOS_INACTIVOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idalumno, a.nie, a.nombres, a.apellidos, a.fechanacimiento, a.telefono , b.idgenero, b.genero, c.idestado, c.estado, d.idapoderado, d.nombresapoderado, a.direccion 
                                from alumnos a, genero b, estado c, apoderado d
                                where a.idgenero = b.idgenero and a.idestado=c.idestado and a.idapoderado=d.idapoderado and a.idestado=2  order by idalumno;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static object ALUMNOS_ACTIVOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idalumno, a.nie, a.nombres, a.apellidos, a.fechanacimiento, a.telefono , b.idgenero, b.genero, c.idestado, c.estado, d.idapoderado, d.nombresapoderado, a.direccion 
                                from alumnos a, genero b, estado c, apoderado d
                                where a.idgenero = b.idgenero and a.idestado=c.idestado and a.idapoderado=d.idapoderado and a.idestado=1  order by idalumno;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CONSULTA_ULTIMA_MATRICULA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idmatricula FROM matriculas order by idmatricula desc limit 1;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static object NOTAS_POR_ALUMNO_EN_PERIODO(String idalumno, String idperiodo)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT m.idmateria, n.idnota, n.idalumno, n.idperiodo,  m.materia, n.nota, p.periodo
                                FROM materias m
                                INNER JOIN notas n ON m.idmateria = n.idmateria
                                INNER JOIN periodos p ON p.idperiodo = n.idperiodo
                                WHERE n.idalumno = "+idalumno+" AND n.idperiodo = "+idperiodo+";";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable Generos()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idgenero, genero FROM genero;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }

        public static DataTable CONSULTA_PERIODOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idperiodo, periodo FROM periodos;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CONSULTA_MATERIAS(String id, String pe)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT m.materia, m.idmateria
                                FROM materias m
                                LEFT JOIN (
                                  SELECT ma.idmateria, ma.idalumno
                                  FROM materias_alumnos ma
                                  LEFT JOIN notas n ON ma.idmateria = n.idmateria AND ma.idalumno = n.idalumno AND n.idperiodo = " + pe + @"
                                  WHERE n.idnota IS NULL OR n.idperiodo IS NULL
                                    OR (n.idalumno IS NULL AND n.idperiodo = " + pe + @")
                                    OR (n.idperiodo IS NULL AND n.idalumno = " + id + @")
                                    OR (n.idalumno IS NULL AND n.idperiodo IS NULL)
                                  GROUP BY ma.idmateria, ma.idalumno
                                ) n ON m.idmateria = n.idmateria
                                WHERE n.idmateria IS NOT NULL AND n.idalumno = " + id + ";";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ALUMNOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idalumno, a.nie, a.nombres, a.apellidos, a.fechanacimiento, a.telefono , b.idgenero, b.genero, c.idestado, c.estado, d.idapoderado, d.nombresapoderado, a.direccion 
            from alumnos a, genero b, estado c, apoderado d
            where a.idgenero = b.idgenero and a.idestado=c.idestado and a.idapoderado=d.idapoderado  order by idalumno;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }

        public static DataTable NOTAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idnota, b.idalumno, b.nombres, c.idmateria, c.materia, a.nota1 , a.nota2, a.nota3, a.nota4, a.nota5, a.promediofinal
            from notas a, alumnos b, materias c 
            where a.idalumno = b.idalumno and a.idmateria=c.idmateria  order by idalumno;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }

        public static DataTable CONSULTA_MATERIAS_GRADOS(string id)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT mg.idmateriasgrados, m.idmateria, g.idgrado, m.materia, g.grado 
                                FROM materias_grados mg, materias m, grados g
                                WHERE mg.idmateria=m.idmateria AND mg.idgrado=g.idgrado 
                                AND g.idgrado=" + id + ";";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable DOCENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.iddocente, a.nombresdocente, a.apellidosdocente, a.dui, a.telefono, a.fechanacimiento , b.idgenero, b.genero, a.direccion,
            c.idestado, c.estado, d.idespecialidad, d.especialidad
            from docentes a, genero b, estado c, especialidad d where a.idgenero = b.idgenero and a.idestado=c.idestado 
            and a.idespecialidad=d.idespecialidad order by iddocente;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }

        public static DataTable APODERADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idapoderado, a.dui,a.fechanacimiento, a.tiporelacion, a.nombresapoderado, a.apellidos, a.telefono, a.direccion, c.idgenero, c.genero
            from apoderado a, genero c
            where a.idgenero = c.idgenero order by idapoderado;;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }

        public static DataTable CONSULTA_GRADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idgrado, a.grado, b.idaula, b.numeroaula, c.iddocente, c.nombresdocente
            from grados a, aulas b, docentes c where a.idaula=b.idaula and a.iddocente=c.iddocente order by idgrado;;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;

        }


        public static DataTable VALIDAR_USUARIO(String pUsuario,String pClave)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT 
            a.id,a.usuario, a.IDRol,
            c.Rol
            FROM usuarios a, roles c
            WHERE a.usuario='" + pUsuario + @"' 
            AND a.password=SHA1(MD5('" + pClave + @"')) 
            AND a.idRol=c.idRol;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }


    public static DataTable IniciarSesion(string pUsuario, string pClave)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT 
            a.id,a.usuario, a.IDRol,
            c.Rol  
            FROM usuarios a, roles c
            WHERE a.usuario='" + pUsuario + @"' 
            AND a.password=SHA1(MD5('" + pClave + @"')) 
            AND a.idRol=c.idRol;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }
           


        public static DataTable ROLES ()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idRol, rol FROM roles;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable AULAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idAula, numeroaula FROM aulas;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable DIRECCION()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT iddireccion, direccion FROM direccion;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ESTADO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idestado, estado FROM estado;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable MATERIAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idmateria, materia FROM materias;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ESPECIALIDAD()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idespecialidad, especialidad FROM especialidad;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable GENERO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idgenero, genero FROM genero;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable MATRICULAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idmatricula, idgrado FROM matriculas;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable REPORTAULAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idAula, numeroaula FROM aulas;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable REPORTE_ALUMNOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idalumno, a.nie, a.nombres, a.apellidos, a.fechanacimiento, a.telefono , b.idgenero, b.genero, c.idestado, c.estado, d.idapoderado, d.nombresapoderado, a.direccion 
            from alumnos a, genero b, estado c, apoderado d
            where a.idgenero = b.idgenero and a.idestado=c.idestado and a.idapoderado=d.idapoderado  order by idalumno;;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable REPORTE_ALUMNOS_ACTIVOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @" select a.idalumno, a.nie, a.nombres, a.apellidos, a.fechanacimiento, a.telefono , b.idgenero, b.genero, c.idestado, c.estado, d.idapoderado, d.nombresapoderado, a.direccion
                 from alumnos a, genero b, estado c, apoderado d
                 where a.idgenero = b.idgenero and a.idestado= c.idestado and a.idapoderado= d.idapoderado and a.idestado= 1  order by idalumno;;;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable REPORTE_MATRICULAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @" SELECT a.idmatricula, b.idgrado, b.grado, c.idalumno, c.nombres, c.apellidos FROM matriculas a,grados b, alumnos c 
            where a.idgrado = b.idgrado  and a.idalumno = c.idalumno order by idmatricula;;;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
