using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using HastaneDoktor.Business.Abstract;

namespace WebApplication1.Controllers
{
 
    public class DoktorController : ApiController
    {
        private IDoktorService _doktorService;

        public DoktorController()
        {
            _doktorService = new DoktorManager();

        }

        //public HttpResponseMessage Get()
        //{                      
        //    //string query = @" 
        //    //    select Id,Adi,Soyadi,Uzmanligi from dbo.Doktor
        //    //";

        //    //DataTable table = new DataTable();
        //    //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
        //    //using (var cmd = new SqlCommand(query, con))
        //    //using (var da = new SqlDataAdapter(cmd))
        //    //{
        //    //    cmd.CommandType = CommandType.Text;
        //    //    da.Fill(table);
        //    //}

        //    //return Request.CreateResponse(HttpStatusCode.OK, table);

        //}


        //public string Post(Doktor dok)
        //{

        //    //try
        //    //{
        //    //string query = @"
        //    //insert into dbo.Doktor values 
        //    //('" + dok.Adi + @"'
        //    // ,'" + dok.Soyadi + @"'
        //    // ,'" + dok.Uzmanligi + @"'   
        //    //)
        //    //";

        //    //    DataTable table = new DataTable();
        //    //    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
        //    //    using (var cmd = new SqlCommand(query, con))
        //    //    using (var da = new SqlDataAdapter(cmd))
        //    //    {
        //    //        cmd.CommandType = CommandType.Text;
        //    //        da.Fill(table);
        //    //    }

        //    //    return "Added Seccesfully!!";

        //    //}

        //    //catch (Exception)
        //    //{
        //    //    return "Failed to Add";

        //    //}
        //}

        //public string Put(Doktor dok)
        //{

        //    //try
        //    //{
        //    //    string query = @"
        //    //    update dbo.Doktor set 
        //    //    Adi='" + dok.Adi + @"'
        //    //    ,Soyadi='" + dok.Soyadi + @"'
        //    //    ,Uzmanligi='" + dok.Uzmanligi + @"'
        //    //    where Id=" + dok.Id + @" 
        //    //    ";

        //    //    DataTable table = new DataTable();
        //    //    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
        //    //    using (var cmd = new SqlCommand(query, con))
        //    //    using (var da = new SqlDataAdapter(cmd))
        //    //    {
        //    //        cmd.CommandType = CommandType.Text;
        //    //        da.Fill(table);
        //    //    }

        //    //    return "Updated Seccesfully!!";

        //    //}

        //    //catch (Exception)
        //    //{
        //    //    return "Failed to Update";

        //    //}
        //}

        //public string Delete(int id)
        //{

        //    //try
        //    //{
        //    //    string query = @"
        //    //    delete from dbo.Doktor
        //    //    where Id=" + id + @" 
        //    //    ";

        //    //    DataTable table = new DataTable();
        //    //    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
        //    //    using (var cmd = new SqlCommand(query, con))
        //    //    using (var da = new SqlDataAdapter(cmd))
        //    //    {
        //    //        cmd.CommandType = CommandType.Text;
        //    //        da.Fill(table);
        //    //    }

        //    //    return "Delete Seccesfully!!";

        //    //}

        //    //catch (Exception)
        //    //{
        //    //    return "Failed to Delete";

        //    //}
        //}
        
        //[Route("api/Doktor/GetAllHastaneNames")]
        //[HttpGet]
        //public HttpResponseMessage GetAllHastaneNames()
        //{
        ////    string query = @"
        ////        select Adi from dbo.Hastane ";


        ////    DataTable table = new DataTable();
        ////    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDB"].ConnectionString))
        ////    using (var cmd = new SqlCommand(query, con))
        ////    using (var da = new SqlDataAdapter(cmd))
        ////    {
        ////        cmd.CommandType = CommandType.Text;
        ////        da.Fill(table);
        ////    }

        ////    return Request.CreateResponse(HttpStatusCode.OK,table);

        //}

    }

  
}
