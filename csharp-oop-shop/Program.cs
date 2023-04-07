namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un nuovo oggetto Prodotto, specificando nome, descrizione, prezzo e iva
            Prodotto nft = new("CryptoKitty", "Un gatto digitale unico", 3200m, 22);

            // Stampo le informazioni sul prodotto utilizzando il metodo Console.WriteLine()
            Console.WriteLine($"Codice: {nft.Codice}\nNome: {nft.Nome}\nDescrizione: {nft.Descrizione}\nPrezzo Base: ${nft.PrezzoBase()}\nPrezzo Ivato: ${nft.PrezzoConIva()}\nNome Esteso: {nft.NomeEsteso()}");

            Console.WriteLine();

            // Creo un array di prodotti digitali
            Prodotto[] prodottiNFT = new Prodotto[]
            {
                new Prodotto("CryptoZombie", "Zombie digitale collezionabile", 6756m, 12),
                new Prodotto("CryptoPunk", "Personaggio punk digitale collezionabile", 5635m, 15),
                new Prodotto("Bored Ape", "Scimmia digitale collezionabile", 45623m, 20),
                new Prodotto("Art Blocks", "Opere d'arte generative digitali collezionabili", 4354m, 25),
                new Prodotto("Pudgy Penguins", "Pinguini digitali collezionabili", 1436m, 18)
            };

            // Stampo l'elenco dei prodotti
            foreach (Prodotto prodotto in prodottiNFT)
            {
                Console.WriteLine($"Codice: {prodotto.CodiceConPad()} - Nome: {prodotto.Nome}");
            }

            Console.ReadLine();


        }
    }
}