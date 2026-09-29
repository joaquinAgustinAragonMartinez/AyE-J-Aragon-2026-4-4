namespace recuperatorio_structs
{
    public class Program
    {
        static Stack<mago> hechizosquetiro = new Stack<mago>();

        static void VolverEnElTiempo()
        {
            if(hechizosquetiro.Count > 1)
            {
                mago lugaratras = hechizosquetiro.Pop();

                Console.WriteLine("el hechizo mas reciente borrado es: "+ lugaratras.UltimoHechizo);
            }

        }
        static void Golpear()
        {
            mago ultimopersonaje = hechizosquetiro.Peek();

            mago personajegolpeado = new mago(100, ultimopersonaje.VidaActual - 20, "espinas");

            Console.WriteLine("la vida total es: " + personajegolpeado.VidaTotal + " la vida actual es: " + personajegolpeado.VidaActual + " y el ultimo hechizo es: " + personajegolpeado.UltimoHechizo);
        }

        static void Main(string[] args)
        {
            mago mago1 = new mago(100, 100, "bola de fuego");
            mago mago2 = new mago(100, 100, "hechizo de hielo");
            mago mago3 = new mago(100, 100, "descarga electrica");

            hechizosquetiro.Push(mago1);
            hechizosquetiro.Push(mago2);
            hechizosquetiro.Push(mago3);

            Console.Write("los personajes: ");

            foreach (mago magos in hechizosquetiro)
            {
                Console.WriteLine("la vida total es: "+magos.VidaTotal+ " la vida actual es: "+magos.VidaActual+ " y el ultimo hechizo es: "+ magos.UltimoHechizo);
            }
            Console.WriteLine();

            VolverEnElTiempo();

            Console.WriteLine();

            Console.WriteLine("los personajes despues de haber sido golpeados: ");

            Golpear();

            foreach (mago magos in hechizosquetiro)
            {
                Golpear();
            }
            Console.WriteLine();

        }
    }
}
