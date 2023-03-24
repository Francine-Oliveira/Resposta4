namespace Ex4_Porcentagem;
class Program
{
    static void Main(string[] args)
    {
        string str = new string('=', 37);
        Console.WriteLine(str);
        Console.WriteLine("  Porcentagem de Faturamento Mensal  ");
        Console.WriteLine(str);

        double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53;
        double soma = sp + rj + mg + es + outros;
        double psp = (sp / soma) * 100, prj = (rj / soma) * 100, pmg = (mg / soma) * 100, pes = (es / soma) * 100, poutros = (outros / soma) * 100;

        Console.WriteLine("A porcentagem do estado de São Paulo foi de {0:0.00}%.", psp);
        Console.WriteLine("A porcentagem do estado do Rio de Janeiro foi de {0:0.00}%.", prj);
        Console.WriteLine("A porcentagem do estado de Minas Gerais foi de {0:0.00}%.", pmg);
        Console.WriteLine("A porcentagem do estado do Espírito Santo foi de {0:0.00}%.", pes);
        Console.WriteLine("A porcentagem dos ouros estados foi de {0:0.00}%.", poutros);

        Console.ReadKey();
    }
}

