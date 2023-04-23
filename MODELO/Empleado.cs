using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCT_RH.MODELO
{
    class Empleado
    {
        private int edad;
        private String RFC, nombresE, apellidoPatE, apellidoMatE;
        private DateTime fechaIngreso, fechaBaja;

        // Estructura del modelo de empleado


        public Empleado() { }

        /// <summary>
        /// Método constructor del objeto Empleado.
        /// </summary>
        /// <param name="RFC"></param>
        /// <param name="edad"></param>
        /// <param name="nombresE"></param>                                                                                                                          
        /// <param name="apellidoPatE"></param>
        /// <param name="apellidoMatE"></param>
        /// <param name="lugarNac"></param>
        /// <param name="direccionP"></param>
        /// <param name="fechaIngreso"></param>
      


        public Empleado(String RFC, int edad, String nombresE, String apellidoPatE, String apellidoMatE,  DateTime fechaIngreso)
        {
            this.RFC = RFC;
            this.nombresE = nombresE;
            this.apellidoPatE = apellidoPatE;
            this.apellidoMatE = apellidoMatE;
            this.edad = edad;
            this.fechaIngreso = fechaIngreso;
        }
        // Métodos setters del modelo de Empleado

        /// <summary>
        /// Método que settea el identificador del Empleado. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="RFC"></param>
        public void setRFC(string RFC)
        {
            this.RFC = RFC;
        }

        /// <summary>
        /// Método que settea el identificador del Empleado. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="nombresE"></param>
        public void setnombresE(string nombresE)
        {
            this.nombresE = nombresE;
        }

        /// <summary>
        /// Método que settea el identificador del Empleado. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="nombresE"></param>
        public void setapellidoPatE(string apellidoPatE)
        {
            this.apellidoPatE = apellidoPatE;
        }

        /// <summary>
        /// Método que settea el identificador del Empleado. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="apellidoMatE"></param>
        public void setapellidoMatE(string apellidoMatE)
        {
            this.apellidoMatE = apellidoMatE;
        }

        /// <summary>
        /// Método que settea el identificador del Empleado. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="apellidoMatE"></param>
        public void setedad(int  edad)
        {
            this.edad = edad;
        }

        /// <summary>
        /// Método que settea el identificador del Empleado. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="fechaIngreso"></param>
        public void setfechaIngreso(DateTime fechaIngreso)
        {
            this.fechaIngreso = fechaIngreso;
        }

        // Métodos getters del modelo de Empleados

        /// <summary>
        /// Obtiene el identficador de la Empleado.
        /// </summary>
        /// <returns></returns>
        public string getRFC()
        {
            return RFC;
        }

        /// <summary>
        /// Obtiene el nombre del Empleado.
        /// </summary>
        /// <returns></returns>
        public String getNombresE()
        {
            return nombresE;
        }

        /// <summary>
        /// Obtiene el apellido paterno del Empleado.
        /// </summary>
        /// <returns></returns>
        public String getApellidoPatE()
        {
            return apellidoPatE;
        }

        /// <summary>
        /// Obtiene el apellido materno del Empleado.
        /// </summary>
        /// <returns></returns>
        public String getApellidoMatE()
        {
            return apellidoMatE;
        }
        
        /// <summary>
        /// Obtiene la fecha de ingreso del Empleado.
        /// </summary>
        /// <returns></returns>
        public DateTime getFechaIngreso()
        {
            return fechaIngreso;
        }
    }
}
