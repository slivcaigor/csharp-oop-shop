namespace csharp_oop_shop
{
    public class Prodotto
    {
        // Attributo privato readonly per il codice del prodotto, che viene generato casualmente alla creazione del prodotto
        private readonly int _codice;
        // Proprietà pubblica per ottenere il codice del prodotto (solo in lettura)
        public int Codice => _codice;
        // Proprietà pubbliche per nome, descrizione, prezzo e iva del prodotto 
        public string Nome;
        public string Descrizione;
        public decimal Prezzo;
        public int Iva;

        // Creo un costruttore della classe Prodotto che prende come argomenti il nome, la descrizione, il prezzo e l'iva del prodotto
        public Prodotto(string nome, string descrizione, decimal prezzo, int iva)
        {
            // Genero in modo casuale il codice del prodotto
            _codice = new Random().Next(10000, 99999);
            // Inizializzo le proprietà nome, descrizione, prezzo e iva con i valori passati come argomento
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }

        // Creo il metodo PrezzoBase che restituisce il prezzo base del prodotto (senza iva)
        public decimal PrezzoBase()
        {
            return Prezzo;
        }

        // Creo il metodo PrezzoConIva che calcola il prezzo del prodotto comprensivo di iva
        public decimal PrezzoConIva()
        {
            // Calcolo del prezzo con iva aggiunto
            decimal prezzoConIva = Prezzo + Prezzo * Iva / 100m;
            // Arrotondamento a due cifre decimali
            return decimal.Round(prezzoConIva, 2);
        }

        // Creo il metodo NomeEsteso che restituisce il nome esteso del prodotto, ottenuto concatenando il codice del prodotto con il nome
        public string NomeEsteso()
        {
            return Codice + " - " + Nome;
        }

    }
}