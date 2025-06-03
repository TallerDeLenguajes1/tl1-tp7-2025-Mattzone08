namespace EspacioEmpleado
{
    public class Empleado
    {
        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargo cargo;

        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - fechaNacimiento.Year;
                if (DateTime.Today < fechaNacimiento.AddYears(edad)) edad--;
                return edad;
            }
        }

        public int Antiguedad
        {
            get
            {
                int antiguedad = DateTime.Today.Year - fechaIngreso.Year;
                if (fechaIngreso.Date > DateTime.Today.AddYears(-antiguedad)) antiguedad--;
                return antiguedad;
            }
        }

        public int AniosParaJubilarse
        {
            get
            {
                int faltan = 65 - Edad;
                return faltan > 0 ? faltan : 0;
            }
        }       

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldo, Cargo cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }




        
    }


}