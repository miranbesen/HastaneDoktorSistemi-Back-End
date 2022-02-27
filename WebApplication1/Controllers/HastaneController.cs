using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HastaneController : ApiController
    {

        public HttpResponseMessage Get()
        {
            string query = @"
                select Id,Adi from dbo.Hastane 
             ";

            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);

        }


        public string Post(Hastane has)
        {

            try
            {
                string query = @"
            insert into dbo.Hastane values ('" + has.Adi + @"')";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Added Seccesfully!!";

            }

            catch (Exception)
            {
                return "Failed to Add";

            }
        }

        public string Put(Hastane has)
        {

            try
            {
                string query = @"
                update dbo.Hastane set Adi='" + has.Adi + @"'
                where Id="+has.Id+@" 
                ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Updated Seccesfully!!";

            }

            catch (Exception)
            {
                return "Failed to Update";

            }
        }

        public string Delete(int id)
        {

            try
            {
                string query = @"
                delete from dbo.Hastane 
                where Id=" + id + @" 
                ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Delete Seccesfully!!";

            }

            catch (Exception)
            {
                return "Failed to Delete";

            }
        }

    }
}


