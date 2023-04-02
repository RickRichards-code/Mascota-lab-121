using System;

namespace Mascota
{
    public class Mascota
    {
        private string tipo, nombre, raza, color;
        private int edad;
        // a) constructores de diferente manera
        public Mascota(string tipo, string nombre, string raza, string color, int edad)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.raza = raza;
            this.color = color;
            this.edad = edad;
        }

        public Mascota()
        {
            this.tipo = "perro";
            this.nombre = "scooby";
            this.raza = "grandanes";
            this.color = "cafe";
            this.edad = 8;
        }

        public Mascota(String tipo)
        {
            this.tipo = tipo;
            this.nombre = "scooby";
            this.raza = "grandanes";
            this.color = "cafe";
            this.edad = 8;
        }
        public Mascota(String tipo, int edad)
        {
            this.tipo = tipo;
            this.nombre = "scooby";
            this.raza = "grandanes";
            this.color = "cafe";
            this.edad = edad;
        }

        // getters y setters con esteroides
        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Raza
        {
            get => raza;
            set => raza = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public void mostrar()
        {
            Console.WriteLine("----- Mascota ----");
            Console.WriteLine("tipo: "+ tipo);
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("raza: "+ color);
            Console.WriteLine("color: "+ color);
            Console.WriteLine("edad: "+ edad);
        }
        // SOBRECARGA a) Verificar si existe el “Perro”, de raza “Pastor Alemán”.
        public bool verificar(Mascota b, Mascota c, Mascota d, String razaX)
        {
            Console.WriteLine("---SOBRECARGA  A) Verificar si existe el “Perro”, de raza “Pastor Alemán”. ---");
            if (raza.Equals(razaX))
                return true;
            else if (b.raza.Equals(razaX))
                return true;
            else if (c.raza.Equals(razaX))
                return true;
            else if (d.raza.Equals(razaX))
                return true;
            else
                return false;
        }
        // SOBRECARGA b) Cuántas mascotas de tipo “gato” existen.
        public int verificar(Mascota b, Mascota c, Mascota d)
        {
            Console.WriteLine("--- SOBRECARGA B) Cuántas mascotas de tipo “gato” existen. ---");
            Console.Write("ingrese un el tipo: ");
            String mascotaX = Console.ReadLine();
            return mascotaTipo(mascotaX) + b.mascotaTipo(mascotaX) + c.mascotaTipo(mascotaX) + d.mascotaTipo(mascotaX);
        }
                
        public int mascotaTipo(String mascotaX) 
        {
            if (tipo.Equals("gato"))
                return 1;
            return 0;
        }
        // POO c) Verificar si existen 2 mascotas con el mismo nombre y si existen imprimir de que tipo son cada una.
        // public void verificar2mascotas(Mascota b)
        // {
        //     Console.WriteLine("--- d) Verificar si existen 2 mascotas con el mismo nombre y si existen imprimir de que tipo son cada una. --- ");
        //     if (nombre.Equals(b.nombre))
        //     {
        //         Console.WriteLine("-- mascota 1 --");
        //         Console.WriteLine("nombre: "+nombre+" tipo: "+tipo);
        //         Console.WriteLine("-- mascota 2 --");
        //         Console.WriteLine("nombre: "+b.nombre+" tipo: "+b.tipo);
        //     }
        //     else
        //     {
        //         Console.WriteLine("no son del mismo tipo");
        //     }
        // }
        //SOBRECARGA c) Verificar si existen 2 mascotas con el mismo nombre y si existen imprimir de que tipo son cada una.
        public static String operator /(Mascota a, Mascota b)
        {
            Console.WriteLine("--- SOBRECARGA C) Verificar si existen 2 mascotas con el mismo nombre y si existen imprimir de que tipo son cada una. --- ");
            if (a.nombre.Equals(b.nombre))
            {
                return ("-- mascota 1 -- \n " + "nombre: " + a.nombre + "\ntipo: " + a.tipo+"\n-- mascota 2 -- \n " + "nombre: " + b.nombre + "\ntipo: " + b.tipo);
                // Console.WriteLine("-- mascota 1 --");
                // Console.WriteLine("nombre: "+a.nombre+" tipo: "+a.tipo);
                // Console.WriteLine("-- mascota 2 --");
                // Console.WriteLine("nombre: "+b.nombre+" tipo: "+b.tipo);
            }
            else
            {
                return ("no son del mismo tipo");
            }           
        }
        // SOBRECARGA d) Mostrar las mascotas de menor a mayor según edad
        public static String operator *(Mascota a, Mascota b)
        {
            Console.WriteLine("--- SOBRECARGA D) Mostrar las mascotas de menor a mayor según edad --- ");
            if (a.edad > b.edad)
            {
                b.mostrar();
                Console.WriteLine("menor");
                a.mostrar();
                return "mayor";

            }
            else
            {
                a.mostrar();
                Console.WriteLine("menor");
                b.mostrar();
                return "mayor";
            }            
            
        }
    }
}