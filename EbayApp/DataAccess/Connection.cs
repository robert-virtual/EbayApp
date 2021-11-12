using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace EbayApp.DataAccess
{
    public class Connection
    {
        protected SqlConnection ConnectDb() => new SqlConnection(ConfigurationManager.ConnectionStrings["Ebay"].ConnectionString);
    }
}
