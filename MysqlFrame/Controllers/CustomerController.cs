using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MysqlFrame.Controllers
{
    public class CustomerController : Controller
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=mysqldb");
        // GET: Customer
        public ActionResult Index()
        {
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `customer`", conn);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            return View(dt);
        }
    }
}