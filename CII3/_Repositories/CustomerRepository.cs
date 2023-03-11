using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CII3.Models;

namespace CII3._Repositories
{
    public class CustomerRepository : BaseRepository, IRegModel
    {
        // Constructor
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }
        //Methods 
        public void Add(RegModel regModel)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandText = "insert into CII values (@id, @fnaln, @passaport, @address, @phone, @email, @jobtitle, @gender, @dateofbirth, @emergency, @maximumcover, @paymenttype, @servicefees, @insurancetype)";
                command.Parameters.Add("@id", SqlDbType.Int).Value = regModel.Id;
                command.Parameters.Add("@fnaln", SqlDbType.NVarChar).Value = regModel.Fnaln;
                command.Parameters.Add("@passaport", SqlDbType.NVarChar).Value = regModel.Passaport;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = regModel.Address;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = regModel.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = regModel.Email;
                command.Parameters.Add("@jobtitle", SqlDbType.NVarChar).Value = regModel.Jobtitle;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = regModel.Gender;
                command.Parameters.Add("@emergency", SqlDbType.NVarChar).Value = regModel.Emergency;
                command.Parameters.Add("@insurancetype", SqlDbType.NVarChar).Value = regModel.Insurancetype;
                command.Parameters.Add("@maximumcover", SqlDbType.NVarChar).Value = regModel.Paymentype;
                command.Parameters.Add("@servicefees", SqlDbType.NVarChar).Value = regModel.Maximumcover;
                command.Parameters.Add("@paymenttype", SqlDbType.NVarChar).Value = regModel.Servicefees;
                command.Parameters.Add("@dateofbirth", SqlDbType.NVarChar).Value = regModel.Dateofbirth;
                command.ExecuteNonQuery();

            }
        }
        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandText = "delete from CII where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(RegModel regModel)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandText = @"update CII set Fnaln= @fnaln, Passaport = @passaport, Address= @address,Phone=@phone,Email=@email, Jobtitle= @jobtitle, Gender= @gender, Dateofbirth=@dateofbirth, Emergency =@emergency  ,Insurancetype=@insurancetype , Paymentype=@paymenttype ,Maximumcover=@maximumcover , Servicefees= @servicefees  where Id=@id";
                command.Parameters.Add("@fnaln", SqlDbType.NVarChar).Value = regModel.Fnaln;
                command.Parameters.Add("@passaport", SqlDbType.NVarChar).Value = regModel.Passaport;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = regModel.Address;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = regModel.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = regModel.Email;
                command.Parameters.Add("@jobtitle", SqlDbType.NVarChar).Value = regModel.Jobtitle;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = regModel.Gender;
                command.Parameters.Add("@dateofbirth", SqlDbType.NVarChar).Value = regModel.Dateofbirth;
                command.Parameters.Add("@id", SqlDbType.Int).Value = regModel.Id;
                command.Parameters.Add("@emergency", SqlDbType.NVarChar).Value = regModel.Emergency;
                command.Parameters.Add("@insurancetype", SqlDbType.NVarChar).Value = regModel.Insurancetype;
                command.Parameters.Add("@maximumcover", SqlDbType.NVarChar).Value = regModel.Paymentype;
                command.Parameters.Add("@servicefees", SqlDbType.NVarChar).Value = regModel.Maximumcover;
                command.Parameters.Add("@paymenttype", SqlDbType.NVarChar).Value = regModel.Servicefees;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<RegModel> GetAll()
        {
            var regList = new List<RegModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandText = "Select *from CII order by Id desc";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var regModel = new RegModel();
                        regModel.Id = (int)reader[0];
                        regModel.Address = reader[3].ToString();
                        regModel.Fnaln = reader[1].ToString();
                        regModel.Passaport = reader[2].ToString();
                        regModel.Phone = reader[4].ToString();
                        regModel.Email = reader[5].ToString();
                        regModel.Jobtitle = reader[6].ToString();
                        regModel.Gender = reader[7].ToString();
                        regModel.Dateofbirth = reader[8].ToString();
                        regModel.Emergency = reader[9].ToString();
                        regModel.Paymentype = reader[11].ToString();
                        regModel.Maximumcover = reader[13].ToString();
                        regModel.Servicefees = reader[12].ToString();
                        regModel.Insurancetype = reader[10].ToString();          
                        regList.Add(regModel);



                    }
                }
                return regList;

            }
        }

        public IEnumerable<RegModel> GetByValue(string value)
        {
            var regList = new List<RegModel>();
            int Id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string fnaln = value;
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandText = "Select *from CII where Id=@id or fnaln like @name+ '%' order by Id desc ";
                command.Parameters.Add("@id",SqlDbType.Int).Value = Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = fnaln;

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var regModel = new RegModel();
                        regModel.Id = (int)reader[0];
                        regModel.Address = reader[3].ToString();
                        regModel.Fnaln = reader[1].ToString();
                        regModel.Passaport = reader[2].ToString();
                        regModel.Phone = reader[4].ToString();
                        regModel.Email = reader[5].ToString();
                        regModel.Jobtitle = reader[6].ToString();
                        regModel.Gender = reader[7].ToString();
                        regModel.Dateofbirth = reader[8].ToString();
                        regModel.Emergency = reader[9].ToString();
                        regModel.Paymentype = reader[11].ToString();
                        regModel.Maximumcover = reader[13].ToString();
                        regModel.Servicefees = reader[12].ToString();
                        regModel.Insurancetype = reader[10].ToString();
                        regList.Add(regModel);



                    }
                }
                return regList;

            }



        }
    }
  }
