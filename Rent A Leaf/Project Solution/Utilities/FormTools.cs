using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal class FormTools
    {
        public static string Hash(string target)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[20]);
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(target, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashSalted = new byte[40];

            for (int i = 0; i < 20; i++)
            {
                Array.Copy(salt, i, hashSalted, (i * 2), 1);
                Array.Copy(hash, i, hashSalted, ((i * 2) + 1), 1);
            }
            return Convert.ToBase64String(hashSalted);
        }

        public static void Prompt(Color c, string message, string title, string formName)
        {
            Form form = Application.OpenForms[formName];
            form.BackColor = c;
            DialogResult prompt = MessageBox.Show(message, title, MessageBoxButtons.OK);
            if (prompt == DialogResult.OK) { form.BackColor = Color.FromArgb(0, 16, 16); }
        }

        public static string SelectTargetField(string query)
        {
            string str = "";
            using (MySqlCommand command = new MySqlCommand(query, Connection.conn))
            {
                MySqlDataReader reader = command.ExecuteReader();
                int readCount = 0;
                while (reader.Read())
                {
                    str += reader.GetValue(readCount);
                    readCount++;
                }
                command.Dispose();
            }
            return str;
        }

        public static bool DBHasValue(string query)
        {
            if (SelectTargetField(query) != "" && SelectTargetField(query) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidated(string password, string target)
        {
            byte[] hashSalted = Convert.FromBase64String(password);
            byte[] hash = new byte[20];
            byte[] salt = new byte[20];

            for (int i = 0; i < 20; i++)
            {
                Array.Copy(hashSalted, (i * 2), salt, i, 1);
                Array.Copy(hashSalted, ((i * 2) + 1), hash, i, 1);
            }

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(target, salt, 10000);
            byte[] hashNew = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashNew[i] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}