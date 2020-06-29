using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_SCO
{
    public static class Connection
    {
        public static MySqlConnection connection { get; set; }
    }
}
