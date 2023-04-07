/*
BONUS:
- create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
- Usando un array, dichiarate un elenco dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
*/

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

        }
    }
}