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

        public double Salario
        {
            get
            {
                double adicional = 0;

                // 1% por año de antiguedad hasta 20 años
                int anos = Antiguedad;
                if (anos > 20)
                    anos = 20;

                adicional = sueldo * 0.01 * anos;

                // Si antiguedad > 20, adicional fijo en 25% del sueldo básico
                if (Antiguedad > 20)
                {
                    adicional = sueldo * 0.25;
                }

                // Incremento 50% si cargo es Ingeniero o Especialista
                if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
                {
                    adicional *= 1.5;
                }

                // Si está casado, suma $150.000 al adicional
                if (estadoCivil == 'C' || estadoCivil == 'c') 
                {
                    adicional += 150000;
                }

                // Salario = sueldo básico + adicional
                return sueldo + adicional;
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

        public void MostrarDatos()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Nombre: {apellido}, {nombre}");
            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento:dd/MM/yyyy}");
            Console.WriteLine($"Cargo: {cargo}"); 
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Antigüedad: {Antiguedad} años");
            Console.WriteLine($"Años para jubilarse: {AniosParaJubilarse}");
            Console.WriteLine($"Sueldo básico: ${sueldo:N2}");
            Console.WriteLine($"Salario total: ${Salario:N2}");
            Console.WriteLine("--------------------------------------");
        }


        
    }


}