using System;

namespace Mascota
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // a) Instanciar al menos 4 mascotas de diferente manera. 
      Mascota m1 = new Mascota("perro","baldo","pastorAleman","negro",10);
      Mascota m2 = new Mascota("perro",100);
      Mascota m3 = new Mascota();
      Mascota m4 = new Mascota("gato");

      m1.mostrar();
      m2.mostrar();
      m3.mostrar();
      m4.mostrar();
      // SOBRECARGA A) Verificar si existe el “Perro”, de raza “Pastor Alemán”.
      if(m1.verificar(m2, m3, m4, "pastorAleman"))
        Console.WriteLine("si existe");
      else
        Console.WriteLine("no exite");
      // SOBRECARGA B) Cuántas mascotas de tipo “gato” existen.
      Console.WriteLine(m1.verificar(m2, m3, m4));
      // SOBRECARGA C) Verificar si existen 2 mascotas con el mismo nombre y si existen imprimir de que tipo son cada una
      Console.WriteLine(m3/m4);
      // SOBRECARGA d) Mostrar las mascotas de menor a mayor según edad
      Console.WriteLine(m2 * m1);
    }
  }
}