namespace Ejercicio2.Clases
{
    public class Esqueleto
    {
        #region Propiedades
        private int huesosCargados = 0;
        private Hueso[] huesos = new Hueso[206];
        #endregion
        #region Metodos
        public void CargarHuesos(Hueso[] huesosArray)
        {
            if (huesosArray.Length > huesos.Length)
            {
                Console.WriteLine("Error: La longitud del array de huesos excede la capacidad del esqueleto.");
                return;
            }

            huesosCargados = huesosArray.Length;

            Array.Copy(huesosArray, huesos, huesosArray.Length);
        }
        public void Imprimir()
        {
            for (int i = 0; i < huesosCargados; i++)
            {
                Console.WriteLine($"{huesos[i].Nombre} - Peso: {huesos[i].Peso}, Densidad: {huesos[i].Densidad}, Longitud: {huesos[i].Longitud}, Diámetro: {huesos[i].Diametro}");
            }
        }
        public void Ordenar(string criterio)
        {
            switch (criterio)
            {
                case "Nombre":
                    Array.Sort(huesos, 0, huesosCargados);
                    break;

                case "Peso":
                    Array.Sort(huesos, 0, huesosCargados, Comparer<Hueso>.Create((h1, h2) => h1.Peso.CompareTo(h2.Peso)));
                    break;

                case "Densidad":
                    Array.Sort(huesos, 0, huesosCargados, Comparer<Hueso>.Create((h1, h2) => h1.Densidad.CompareTo(h2.Densidad)));
                    break;

                case "Longitud":
                    Array.Sort(huesos, 0, huesosCargados, Comparer<Hueso>.Create((h1, h2) => h1.Longitud.CompareTo(h2.Longitud)));
                    break;

                case "Diametro":
                    Array.Sort(huesos, 0, huesosCargados, Comparer<Hueso>.Create((h1, h2) => h1.Diametro.CompareTo(h2.Diametro)));
                    break;

                default:
                    Console.WriteLine("Critero inexistente. Ordenando por nombre.");
                    Array.Sort(huesos, 0, huesosCargados);
                    break;
            }
        }
        #endregion
    }
}