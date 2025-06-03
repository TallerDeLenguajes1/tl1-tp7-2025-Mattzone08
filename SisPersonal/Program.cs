using EspacioEmpleado;

        // Arreglo de 3 empleados
        Empleado[] empleados = new Empleado[3];

        // Cargar empleados
        empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1985, 6, 3), 'C', new DateTime(2010, 4, 15), 650000, Empleado.Cargo.Ingeniero);
        empleados[1] = new Empleado("María", "Gómez", new DateTime(1990, 2, 28), 'S', new DateTime(2018, 7, 1), 480000, Empleado.Cargo.Administrativo);
        empleados[2] = new Empleado("Carlos", "Rodríguez", new DateTime(1970, 11, 12), 'C', new DateTime(2000, 1, 10), 700000, Empleado.Cargo.Especialista);

        // Mostrar información de cada empleado
        for (int i = 0; i < 3; i++)
        {
            empleados[i].MostrarDatos();
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
