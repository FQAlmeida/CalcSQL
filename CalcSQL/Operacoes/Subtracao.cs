using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSQL
{
    class Subtracao
    {
        public void Subtrair()
        {
            try
            {
                Console.Write(Layout());
                Console.Write("Digite o 1º valor: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o 2º valor: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write(Resultado(a, b));
                Console.Write(Layout());
                ExeSQL(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Console.ReadKey();
            }
        }
        private static string Layout()
        {
            var l = new String('-', 25);
            return String.Format("#{0}#\n", l);
        }
        private static double SubtM(double a, double b)
        {
            return a - b;
        }
        private static string Resultado(double a, double b)
        {
            return String.Format("O resultado de {0} - {1} é {2}\n", a, b, SubtM(a, b));
        }
        private static void ExeSQL(double a, double b)
        {
            SQL sql = new SQL();
            if (sql.SelectSubt(a, b))
            {
                sql.SubtInsert(a, b, SubtM(a, b));
                Console.WriteLine("Valores adicionados a tabela");
            }
            else
            {
                Console.WriteLine("Valores já existem na tabela");
            }
        }
    }
}