using MainLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class GenreForm : Form
    {
        private Genres Genre;
        private CustomerDetails currentUser;

        public GenreForm(CustomerDetails c)
        {
            InitializeComponent();
            currentUser = c;
            btnUpdateGen.Visible = false;
        }

        public GenreForm(CustomerDetails c, Genres genre)
        {
            InitializeComponent();
            currentUser = c;
            this.Genre = genre;
            TB_Name.Text = genre.Name;
            RTF_Description.Text = genre.Description;
            NUD.Value = genre.MinimumAge;

            BT_Add.Visible = false;
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                Genres genre = new Genres(1, TB_Name.Text, RTF_Description.Text, Decimal.ToInt32(NUD.Value), DateTime.Now.ToString());
                String sql = "INSERT INTO GENRES VALUES(NULL, @Name, @Description, @Age, @Time)";
                using (MySqlCommand comm = new MySqlCommand(sql, Connection.conn))
                {
                    comm.Parameters.AddWithValue("@Name", genre.Name);
                    comm.Parameters.AddWithValue("@Description", genre.Description);
                    comm.Parameters.AddWithValue("@Age", genre.MinimumAge);
                    comm.Parameters.AddWithValue("@Time", genre.UpdatedDate);
                    if (comm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfully Added");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An Error has occurred");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Ensure you have filled out all the necessary fields");
            }
        }

        private void btnUpdateGen_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                string sql = "UPDATE GENRES SET Name = @Name, Description = @description, Minimum_Age = @age, Updated_Date = @time WHERE Genre_ID = '" + Genre.GenreID + "';";
                MySqlCommand comm = new MySqlCommand(sql, Connection.conn);
                comm.Parameters.AddWithValue("@name", TB_Name.Text);
                comm.Parameters.AddWithValue("@description", RTF_Description.Text);
                comm.Parameters.AddWithValue("@age", NUD.Value);
                comm.Parameters.AddWithValue("@time", DateTime.Now.ToString());
                int i = comm.ExecuteNonQuery();
            }
            FormTools.Prompt(Color.Green, "Genre Updated Successfully", "Success", this.Name);
            this.Close();
        }

        private bool checkValidation()
        {
            if (TB_Name.Text != "" & RTF_Description.Text != "")
            {
                return true;
            }
            return false;
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            if (currentUser.AccessLevel == 0)
            {
                TB_Name.Enabled = false;
                btnUpdateGen.Visible = false;
                BT_Add.Visible = false;
                NUD.Enabled = false;
                RTF_Description.Enabled = false;
            }
        }
    }
}