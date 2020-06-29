using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project
{
    internal static class Connection
    {
        public static MySqlConnection conn { get; set; }
    }
}