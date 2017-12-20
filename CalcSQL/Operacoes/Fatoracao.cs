using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSQL.Operacoes
{
    class Fatoracao
    {
        public void Fatorar()
        {
            try
            {
                Console.Write(Layout());
                Console.Write("Digite o 1º valor: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write(Resultado(a));
                Console.Write(Layout());
                ExeSQL(a);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //Console.ReadKey();
            }
        }
        private string Layout()
        {
            var l = new String('-', 25);
            return String.Format("#{0}#\n", l);
        }
        private double FatM(double a)
        {
            int r = Convert.ToInt32(a);
            for (int b = r - 1; b > 0; b--)
            {
                r *= b;
            }
            return r;
        }
        private string Resultado(double a)
        {
            return String.Format("O resultado fatorial de {0} é {1}\n", a, FatM(a));
        }
        private void ExeSQL(double a)
        {
            SQL sql = new SQL();
            if (sql.SelectFat(a))
            {
                sql.FatInsert(a, FatM(a));
                Console.WriteLine("Valores adicionados a tabela");
            }
            else
            {
                Console.WriteLine("Valores já existem na tabela");
            }
        }
    }
}
