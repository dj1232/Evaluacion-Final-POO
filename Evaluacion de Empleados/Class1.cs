using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion_de_Empleados
{
    class Empleado
    {
        //atributos
        private string nombres;
        private string apellidos;
        private int dui;
        private int cel;
        private double sueldo_base;
        private double tasa_isss;
        private double tasa_renta;
        private DateTime fecha_contrato;
        private DateTime fecha_nacimiento;

        //metodos
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public int Cel
        {
            get { return cel; }
            set { cel = value; }
        }
        public double Sueldo
        {
            get { return sueldo_base; }
            set { sueldo_base = value; }
        }
        public double Tasa_isss
        {
            get { return tasa_isss; }
            set { tasa_isss = value; }
        }
        public double Tasa_renta
        {
            get { return tasa_renta; }
            set { tasa_renta = value; }
        }
        public DateTime Fecha_contrato
        {
            get { return fecha_contrato; }
            set { fecha_contrato = value; }
        }
        public DateTime Fecha_nac
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }


    }
}
