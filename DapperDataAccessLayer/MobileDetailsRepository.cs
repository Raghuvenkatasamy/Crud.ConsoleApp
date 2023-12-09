using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace DapperDataAccessLayer
{
    public class MobileDetailsRepository:IMobileDetailsRepository
    {
        public MobileDetail InsertSP(MobileDetail MD)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-23V7KHU;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                con.Execute($"exec InsertMobileDetails '{MD.Name}','{MD.ManufactureName}','{MD.DateofMaufacture.ToString("d")}',{MD.YearofMaufacture},{MD.Quantity}");

                con.Close();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
            return MD;
        }
        public IEnumerable<MobileDetail> ReadSP()
        {
            try
            {
                var connectionString = "Data source=DESKTOP-23V7KHU;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var products = con.Query<MobileDetail>($"exec ReadMobileDetails");

                con.Close();

                return products.ToList();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public MobileDetail DeleteRecordSP(long id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-23V7KHU;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var Details = con.QueryFirstOrDefault<MobileDetail>($"exec DeleteMobileDetails {id}");
                con.Close();
                return Details;

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public MobileDetail UpdateSP(long id, MobileDetail MDS)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-23V7KHU;initial catalog=Batch7;user id=sa;password=Anaiyaan@123;";
                var sql = new SqlConnection(connectionString);
                sql.Open();
                var product = sql.QueryFirstOrDefault<MobileDetail>($"exec UpdateMobileDetails {id},'{MDS.Name}','{MDS.ManufactureName}','{MDS.DateofMaufacture.ToString("d")}',{MDS.YearofMaufacture},{MDS.Quantity}");
                sql.Close();
                return product;
            }
            catch (SqlException mssql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
