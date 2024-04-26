using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectDB.BL
{

    internal class Customer : User
    {
        public int CustomerType { get; private set; }
        public DateTime Date { get; private set; }

        public Customer(DateTime date, string username, string password) : base(username, password)
        {
            Date = date;
        }
        public Customer(int customerType, DateTime date, string username, string password, int userType) : base(username, password, userType)
        {
            CustomerType = customerType;
            Date = date;
        }


        // Method to sign up 
        public void SignUp()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SignUpOfCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@UserType", 3);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("Customer signed up successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        // Method to sign in 
        public (string value, int userId) SignIn(string username, string password)
        {
            using (var con = Configuration.getInstance().getConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @Username AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0) // If count > 0, the user exists with the provided credentials
                    {
                        // Retrieve the UserID
                        string getUserIdQuery = "SELECT UserId FROM Users WHERE UserName = @Username AND password = @Password";
                        cmd = new SqlCommand(getUserIdQuery, con);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        int userId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Retrieve the value from Lookup table using the retrieved UserId
                        string lookupQuery = "SELECT value FROM Lookup WHERE id = @userid";
                        cmd = new SqlCommand(lookupQuery, con);
                        cmd.Parameters.AddWithValue("@userid", userId);
                        object result = cmd.ExecuteScalar();

                        if (result != null) // Check if a value was retrieved
                        {
                            string value = result.ToString(); // Convert the result to string
                            return (value, userId);
                        }
                        else
                        {
                            return (null, userId); // No value found for the provided user id
                        }
                    }
                    else
                    {
                        return (null, 0); // User does not exist with the provided credentials
                    }
                }
                catch (Exception ex)
                {
                    return (null, 0);
                }
            }
        }

    }


}
