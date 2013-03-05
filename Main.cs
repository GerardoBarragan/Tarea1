using System;

namespace Tarea1
{
	public class Persona 
	{
		public string nombre;
		public string face;
		public string domicilio;
		public int numero;

		public Persona (){
		}

		public static void Main (string[] args)
		{
			Persona persona = new Persona ();

			Console.WriteLine("Cual es tu nombre?");
			persona.nombre = Console.ReadLine();
			Console.WriteLine("Cual es tu facebook?");
			persona.face = Console.ReadLine();
			Console.WriteLine("Cual es tu domicilio?");
			persona.domicilio = Console.ReadLine();
			Console.WriteLine("cual es tu numero?");
			persona.numero = int.Parse(Console.ReadLine() ) ;

			Console.WriteLine();
			Console.WriteLine("nombre: "+persona.nombre);
			Console.WriteLine();
			Console.WriteLine("face: "+persona.face);
			Console.WriteLine();
			Console.WriteLine("domicilio: "+persona.domicilio);
			Console.WriteLine();
			Console.WriteLine("numero: "+persona.numero);
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
