using System;
using System.Data;
using System.Windows.Forms;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace DemoSQLInjection
{
    public partial class DemoSQLInjection : Form
    {
        public DemoSQLInjection()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string ParmOutput;
            ParmOutput = SelectWithParameters(nickName.Text, lblParmaterOutput.Text);
            lblParmaterOutput.Text = ParmOutput;

            string BadOutput;
            BadOutput = BadSelect(nickName.Text, lblNoParameters.Text);
            lblNoParameters.Text = BadOutput;

        }
        public static string GetConnectionString()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json");

            IConfiguration config = configurationBuilder.Build();
            string connectionString = config["Data:DefaultConnection:ConnectionString"];
            return connectionString;
        }

        public static string SelectWithParameters(string NickName, string textStart)
        {
            string outstring = textStart + "\n";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                string sql = "SELECT [DogId],[NickName] from NickNames where [NickName] like @NickName";
                var command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("NickName", NickName);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read()) {
                    count++;
                    Int32 ID  =  reader.GetInt32(0);
                    string Name =  reader.GetString(1);
                    outstring = outstring + " " + ID + " " + Name + "\n";
                }

                if (count == 0)
                    outstring = outstring + " None Found for " + NickName;

                connection.Close();
                                  
            }
            return outstring;
        }

        public static string BadSelect(string NickName, string textStart)
        {
            string outstring = textStart + "\n";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                string sql = "SELECT [DogId],[NickName] from NickNames where [NickName] like '" + NickName+"'";
                var command = new SqlCommand(sql, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    count++;
                    Int32 ID = reader.GetInt32(0);
                    string Name = reader.GetString(1);
                    outstring = outstring + " " + ID + " " + Name + "\n";
                }

                if (count == 0)
                    outstring = outstring + " None Found for " + NickName;

                connection.Close();

            }
            return outstring;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

