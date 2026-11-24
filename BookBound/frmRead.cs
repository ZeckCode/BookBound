using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBound
{
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost; User ID=root; Password=''; Database=bookbound;";
        string content = "";
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRead_Load(object sender, EventArgs e)
        {
            LoadText();
        }
        private void LoadText()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection is open.");

                        // Create a command to retrieve a single LNNAME from lntest table
                        string query = "SELECT * FROM chapters where chapter_number = @ID and book_id = @bookid;"; // Adjust to ensure you only get one row
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
 
                            cmd.Parameters.AddWithValue("@ID", Stored.chapId);
                            cmd.Parameters.AddWithValue("@bookid", Stored.id);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                   
                                    string chapt = reader["Chapter_number"].ToString();
                                    label2.Text = $"Chapter {chapt}";
                                    label1.Text = reader["chapter_Title"].ToString();   
                                    rtxtContent.Text = reader["content"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No data found.");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection failed to open.");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stored.chapId = null;
            Console.WriteLine("baka to error back btn" + Stored.chapId);
           
            frmPage fr = new frmPage();
            fr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Next Button - Increases the chapter number
        private void button3_Click(object sender, EventArgs e)
        {
            int chapnum = Convert.ToInt32(Stored.chapId);
            chapnum++;  // Move to the next chapter

            Stored.chapId = chapnum.ToString();  // Update the Stored chapter ID

            // Debugging: Check the value of chapnum and Stored.chapId
            Console.WriteLine($"Next Button clicked, chapnum = {chapnum}, Stored.chapId = {Stored.chapId}");

            // Hide button4 if we're at the first chapter
            if (chapnum > 1)
            {
                button4.Visible = true;
            }

            chapters(chapnum);  // Update the UI with the new chapter
        }

        // Preview Button - Decreases the chapter number
        private void button4_Click(object sender, EventArgs e)
        {
            int chapnum = Convert.ToInt32(Stored.chapId);

            if (chapnum > 1)  
            {
                chapnum--; 
                Stored.chapId = chapnum.ToString();  

                // Debugging: Check the value of chapnum and Stored.chapId
                Console.WriteLine($"Preview Button clicked, chapnum = {chapnum}, Stored.chapId = {Stored.chapId}");

                
                if (chapnum == 1)
                {
                    button4.Visible = false;
                }

                chapters(chapnum);  // Update the UI with the new chapter
            }
            else
            {
                MessageBox.Show("No previous chapter.");
            }
        }

       
        public void chapters(int chapnum)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        // Create a command to retrieve the chapter based on chapter_id and book_id
                        string query = "SELECT * FROM chapters WHERE chapter_number = @ID AND book_id = @bookid;";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", Stored.chapId);  // Use chapnum directly here
                            cmd.Parameters.AddWithValue("@bookid", Stored.id);  // Use Stored.id for the book_id

                            // Debugging: Check the SQL query parameters
                            Console.WriteLine($"Query: {query}, Parameters: chapnum = {chapnum}, book_id = {Stored.id}");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Display the chapter information
                                    string chapt = reader["Chapter_number"].ToString();
                                    label2.Text = $"Chapter {chapt}";
                                    label1.Text = reader["chapter_Title"].ToString();
                                    rtxtContent.Text = reader["content"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No data found for this chapter.");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to open connection.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    }

    
}

