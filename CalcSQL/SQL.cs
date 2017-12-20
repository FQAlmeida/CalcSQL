using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace CalcSQL
{
    class SQL
    {
        private static string db = "Data Source=DESKTOP-ADCFQV1;Initial Catalog=CalcSQL;Integrated Security=True";
        SqlConnection conn = new SqlConnection(db);

        #region select
        public bool SelectSoma(double a, double b)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1, n2 from soma",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((Convert.ToDecimal(b) == reader.GetDecimal(1) && Convert.ToDecimal(a) == reader.GetDecimal(0)) || (Convert.ToDecimal(b) == reader.GetDecimal(0) && Convert.ToDecimal(a) == reader.GetDecimal(1)))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {

                conn.Close();
            }
        }

        public bool SelectSubt(double a, double b)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1, n2 from subtracao",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((Convert.ToDecimal(b) == reader.GetDecimal(1) && Convert.ToDecimal(a) == reader.GetDecimal(0)) || (Convert.ToDecimal(b) == reader.GetDecimal(0) && Convert.ToDecimal(a) == reader.GetDecimal(1)))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool SelectDiv(double a, double b)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1, n2 from divisao",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((Convert.ToDecimal(b) == reader.GetDecimal(1) && Convert.ToDecimal(a) == reader.GetDecimal(0)) || (Convert.ToDecimal(b) == reader.GetDecimal(0) && Convert.ToDecimal(a) == reader.GetDecimal(1)))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {

                conn.Close();
            }
        }
        public bool SelectMult(double a, double b)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1, n2 from multiplicacao",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((Convert.ToDecimal(b) == reader.GetDecimal(1) && Convert.ToDecimal(a) == reader.GetDecimal(0)) || (Convert.ToDecimal(b) == reader.GetDecimal(0) && Convert.ToDecimal(a) == reader.GetDecimal(1)))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {

                conn.Close();
            }
        }
        public bool SelectPot(double a, double b)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1, n2 from potenciacao",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((Convert.ToDecimal(b) == reader.GetDecimal(1) && Convert.ToDecimal(a) == reader.GetDecimal(0)) || (Convert.ToDecimal(b) == reader.GetDecimal(0) && Convert.ToDecimal(a) == reader.GetDecimal(1)))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {

                conn.Close();
            }
        }
        public bool SelectRad(double a, double b)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1, n2 from radiciacao",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((Convert.ToDecimal(b) == reader.GetDecimal(1) && Convert.ToDecimal(a) == reader.GetDecimal(0)) || (Convert.ToDecimal(b) == reader.GetDecimal(0) && Convert.ToDecimal(a) == reader.GetDecimal(1)))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {

                conn.Close();
            }
        }
        public bool SelectFat(double a)
        {
            try
            {
                bool ver = true;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select n1 from fatoracao",
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.ToDecimal(a) == reader.GetDecimal(0))
                        {
                            ver = false;
                        }
                    }
                }
                reader.Close();
                return ver;
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {

                conn.Close();
            }
        }
        #endregion
        #region Insert
        public void SomaInsert(double a, double b, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into soma (n1, n2, r) values({0:0.0#}, {1:0.0#}, {2:0.0#})", a, b, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void SubtInsert(double a, double b, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into subtracao (n1, n2, r) values({0:0.0#}, {1:0.0#}, {2:0.0#})", a, b, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DivInsert(double a, double b, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into divisao (n1, n2, r) values({0:0.0#}, {1:0.0#}, {2:0.0#})", a, b, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            //catch (Exception ex)
            //{
            //    //throw new Exception("Houve um erro no SQLModels\n" + ex.Message);
            //}
            finally
            {
                conn.Close();
            }
        }
        public void MultInsert(double a, double b, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into multiplicacao (n1, n2, r) values({0:0.0#}, {1:0.0#}, {2:0.0#})", a, b, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void FatInsert(double a, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into fatoracao (n1, r) values({0:0.0#}, {1:0.0#})", a, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void PotInsert(double a, double b, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into potenciacao (n1, n2, r) values({0:0.0#}, {1:0.0#}, {2:0.0#})", a, b, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void RadInsert(double a, double b, double r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = String.Format("insert into radiciacao (n1, n2, r) values({0:0.0#}, {1:0.0#}, {2:0.0#})", a, b, r),
                    CommandType = System.Data.CommandType.Text,
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}\nSqlError Nº: {1}", ex.Message, ex.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion
        #region Teste
        public bool Teste()
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "insert into teste values ('true')",
                    Connection = conn
                };
                conn.Open();
                cmd.ExecuteNonQuery();                
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion
    }
}