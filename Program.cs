using System.Text.RegularExpressions;
namespace desafio1;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Escreva o que quiseres: ");
        var text = Console.ReadLine();

        Console.Write($"> {ContarPalavras(text)} palavras, {ContadorLetras(text)} caracteres");
    }

    static int ContarPalavras(string texto)
    {
        char[] delimitador = { ',', ' ', '.', ':' };
        var textoLimpo = Regex.Replace(texto.Trim(), @"\s", string.Empty);
        var palavras = textoLimpo.Split(delimitador);
        foreach (var lt in palavras)
            Console.WriteLine(lt);
        return palavras.Count();
    }

    static int ContadorLetras(string texto)
    {
        var letra = texto.Replace(" ", "").Replace(",", "").Replace(".", "").Replace(":", "");
        return letra.Count();
    }

}
