using System;
namespace Calc1
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("A Base ou a Altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}
namespace Calc2
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("A Base ou a Altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}

class Aula54
{
    static void Main()
    {

        float area = 0, area1=0;

        try
        {
            area = Calc1.Area.Quad(2F, 5F);
            area1 = Calc2.Area.Quad(2F, 5F);
            Console.WriteLine("Area do Quadrado: {0}", area);
            Console.WriteLine("Area do Quadrado: {0}", area1);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERRO:{0}", e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do Processo");
        }

    }
}