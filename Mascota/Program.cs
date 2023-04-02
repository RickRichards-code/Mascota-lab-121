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
      // b) Verificar si existe el “Perro”, de raza “Pastor Alemán”.
      if(m1.verificarPerro(m2, m3, m4, "pastorAleman"))
        Console.WriteLine("si existe");
      else
        Console.WriteLine("no exite");
      // c) Cuántas mascotas de tipo “gato” existen.
      Console.WriteLine(m1.macotaDeTipo(m2, m3, m4));
      // d) Verificar si existen 2 mascotas con el mismo nombre y si existen imprimir de que tipo son cada una
      m3.verificar2mascotas(m4);      
      
    }
  }
}