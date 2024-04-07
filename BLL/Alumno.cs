using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Alumno
    {
        #region Propiedades

        public int Legajo { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private DateTime fecha_Nacimiento;

        public DateTime Fecha_Nacimiento //solo escritura
        {
            //get { return fecha_Nacimiento; }
            set { fecha_Nacimiento = value; }
        }

        private DateTime fecha_Ingreso;

        public DateTime Fecha_Ingreso //solo escritura
        {
            // get { return fecha_Ingreso; }
            set { fecha_Ingreso = value; }
        }

        private int edad;

        public int Edad //solo lectura
        {
            get { return edad; }
            //set { edad = value; }
        }

        public bool Activo { get; set; }

        private int cant_Materias_Aprobadas;

        public int Cant_Materias_Aprobadas //solo escritura
        {
            //get { return cant_Materias_Aprobadas; }
            set { cant_Materias_Aprobadas = value; }
        }
        #endregion

        #region Constructores
        public Alumno() { }

        public Alumno(int legajo, string nombre, string apellido, DateTime fecha_Nacimiento, DateTime fecha_Ingreso, int edad, bool activo, int cant_Materias_Aprobadas)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nacimiento = fecha_Nacimiento;
            Fecha_Ingreso = fecha_Ingreso;
            this.edad = edad;
            Activo = activo;
            Cant_Materias_Aprobadas = cant_Materias_Aprobadas;
        }

        #endregion

        #region Métodos
        public void Antiguedad() { }

        public void Materias_No_Aprobadas() { }
        public void Edad_De_Ingreso() { }
        #endregion

    }
}