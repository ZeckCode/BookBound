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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BookBound
{
    public  partial class frmPage : Form
    {
        public frmPage()
        {
            InitializeComponent();
           
        }
        public static string SelectedChapterID { get; set; }

        private void frmPage_Load(object sender, EventArgs e)
        {
            load();
            viewdata();
             pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public string WrapText(string text, int lineLength)
        {
            var words = text.Split(' ');
            var wrappedText = new StringBuilder();
            var line = new StringBuilder();

            foreach (var word in words)
            {
                // Check if adding the next word exceeds the line length
                if (line.Length + word.Length + 1 > lineLength)
                {
                    wrappedText.AppendLine(line.ToString());
                    line.Clear();
                }

                // Add the word to the line
                if (line.Length > 0)
                {
                    line.Append(" ");
                }
                line.Append(word);
            }

            // Append any remaining text in the line
            if (line.Length > 0)
            {
                wrappedText.AppendLine(line.ToString());
            }

            return wrappedText.ToString();
        }



        public void load()
        {
            try
            {
                int id = Stored.id;  
                string sqlquery = "SELECT * FROM books WHERE book_id = @ID";
               
                string connectionstring = "Server=localhost; UID=root; Password=''; Database=bookbound;";


                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                label2.Text = reader["title"] != DBNull.Value ? reader["title"].ToString() : "No title\nerror";
                                label3.Text = reader["author"] != DBNull.Value ? reader["author"].ToString() : "No author\nerror";
                               
                                label5.Text = reader["genre"] != DBNull.Value ? reader["genre"].ToString() : "No genre\nerror";
                                //label6.Text = reader["sypnosis"] != DBNull.Value ? reader["sypnosis"].ToString() : "No sypnosis\nerror";
                                //label3.Text = reader["sypnosis"] != DBNull.Value ? reader["sypnosis"].ToString() : "No sypnosis\nerror";

                                string Desc = reader["description"] != DBNull.Value ? reader["description"].ToString() : "No description\nerror";
                                string indentedParagraph = WrapText(Desc, 40);
                                label6.Text = indentedParagraph;


                                //label3.Text = reader["author"] != DBNull.Value ? reader["author"].ToString() : "No author\nerror";
                                // Uncomment and modify as needed for LNTEXT or other fields
                                // label4.Text = reader["LNTEXT"] != DBNull.Value ? reader["LNTEXT"].ToString() : "No text\nerror";
                            }
                            else
                            {
                                MessageBox.Show("No records found for the given ID.");
                            }
                        }
                    

                 
                }
                }
                // 

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            } //goods no bug

        private void BackToPreview_Click(object sender, EventArgs e)
        {
            Stored.chapId = null;
            Console.WriteLine("baka to error BTP " + Stored.chapId);
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void Chapterlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chapterlist_DoubleClick(object sender, EventArgs e)
        {
            
            func();
            
            if (!string.IsNullOrEmpty(Stored.chapId.ToString()))
            {
                frmRead form = new frmRead();
                form.Show();
                this.Hide();
                Console.WriteLine(" tang ina pagto error chaplistD" + Stored.chapId.ToString());
            }
        }
        private void func()
        {
            Stored.chapId = null;

            if (Chapterlist.SelectedIndex >= 0)
            {
                // Get the selected Chapter object
                var selectedChapter = Chapterlist.SelectedItem as Chapter;

                if (selectedChapter != null)
                {
                    // Extract ChapterID
                    Stored.chapId = selectedChapter.ChapterID;

                    // Debugging
                    Console.WriteLine($"Selected Chapter ID: {Stored.chapId}");
                }
                else
                {
                    MessageBox.Show("Error retrieving chapter details.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = !pictureBox4.Visible;
            pictureBox5.Visible = !pictureBox5.Visible;
            pictureBox6.Visible = !pictureBox6.Visible;

        }
        private class Chapter
        {
            public string ChapterID { get; set; }
            public string DisplayText { get; set; }

            // This ensures the ListBox displays the DisplayText, not the object type
            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void viewdata()
        {
            int id = Stored.id;
            string connectionstring = "Server=localhost; UID=root; Password=''; Database=bookbound;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    string sqlquery2 = "SELECT chapter_id, chapter_title, date_added, chapter_number FROM chapters WHERE book_id = @ID";

                    using (MySqlCommand command = new MySqlCommand(sqlquery2, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Chapterlist.Items.Clear();

                            while (reader.Read())
                            {
                                string chapterID = reader["chapter_id"].ToString();
                                string chapterTitle = reader["chapter_title"].ToString();
                                string chapterDate = reader["date_added"].ToString();
                                string chapterNumber = reader["chapter_number"].ToString();

                                string displayText = $"Chapter {chapterNumber}: {chapterTitle} \t{chapterDate:MM/dd/yyyy}";

                                // Add a Chapter object to the ListBox
                                Chapterlist.Items.Add(new Chapter
                                {
                                    ChapterID = chapterNumber,
                                    DisplayText = displayText
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
