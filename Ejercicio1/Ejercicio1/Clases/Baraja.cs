namespace Ejercicio1.Clases
{
    public class Baraja
    {
        #region Propiedades
        private Naipe[] naipes = new Naipe[48];
        #endregion
        #region Metodos
        public void Inicializar()
        {
            int index = 0;
            string[] palos = { "oros", "copas", "espadas", "bastos" };

            foreach (var palo in palos)
            {
                for (int numero = 1; numero <= 12; numero++)
                {
                    naipes[index] = new Naipe(palo, numero);

                    index += 1;
                }
            }
        }
        public void Barajar()
        {
            int n = naipes.Length;

            Random random = new Random();

            while (n > 1)
            {
                n--;

                int k = random.Next(n + 1);

                Naipe value = naipes[k];
                naipes[k] = naipes[n];
                naipes[n] = value;
            }
        }
        public void Imprimir()
        {
            int length = naipes.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Posición {i + 1} - {naipes[i].Numero} de {naipes[i].Palo}");
            }
        }
        public void Ordenar()
        {
            Array.Sort(naipes, 0, 48, Comparer<Naipe>.Create((n1, n2) =>
                {
                    int result = n1.Palo.CompareTo(n2.Palo);

                    if (result != 0)
                    {
                        return result;
                    }

                    return n1.Numero.CompareTo(n2.Numero);
                }));
        }
        #endregion
    }
}