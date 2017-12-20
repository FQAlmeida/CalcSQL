using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSQL.Operacoes
{
    class Multiplicacao
    {
        public void Multiplicar()
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
        private double MultM(double a, double b)
        {
            return a * b;
        }
        private string Resultado(double a, double b)
        {
            return String.Format("O resultado de {0} * {1} é {2}\n", a, b, MultM(a, b));
        }
        private void ExeSQL(double a, double b)
        {
            SQL sql = new SQL();
            if (sql.SelectMult(a, b))
            {
                sql.MultInsert(a, b, MultM(a, b));
                Console.WriteLine("Valores adicionados a tabela");
            }
            else
            {
                Console.WriteLine("Valores já existem na tabela");
            }
        }
    }
}
