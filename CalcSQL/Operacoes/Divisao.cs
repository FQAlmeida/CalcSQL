using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSQL.Operacoes
{
    class Divisao
    {
        public void Dividir()
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
            catch (DivideByZeroException)
            {
                throw new Exception("Impossivel dividir por zero");
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
        private double DivM(double a, double b)
        {
            return a / b;
        }
        private string Resultado(double a, double b)
        {
            return String.Format("O resultado de {0} / {1} é {2}\n", a, b, DivM(a, b));
        }
        private void ExeSQL(double a, double b)
        {
            SQL sql = new SQL();
            if (sql.SelectDiv(a, b))
            {
                sql.DivInsert(a, b, DivM(a, b));
                Console.WriteLine("Valores adicionados a tabela");
            }
            else
            {
                Console.WriteLine("Valores já existem na tabela");
            }
        }
    }
}
