using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Hrastnik_projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BeriDBPrikazi();

            lblwordlenght.Text = ime.Length.ToString();
        }

        string ime = "nič";
        string definicija = "nič";
        List<Label> labels = new List<Label>();

        public void BeriDBPrikazi()
        {
            /*Random r = new Random();
            int temp = r.Next(1, 7);*/
            using (SQLiteConnection conn = new SQLiteConnection("data source = hrastnik-projekt.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = /*"SELECT * FROM besede;"*/ "SELECT * FROM besede ORDER BY RANDOM();";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteNonQuery(); <---- deluje samo za sql stavke, ki ne vrnejo ničesar (DELETE, INSERT ...)

                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        ime = reader.GetString(1);
                        definicija = reader.GetString(2);
                        //string definicija = reader.GetString(2);

                        //string vpis = id.ToString() + "|" + ime + "|" + definicija;
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void Vstavi(string s, string d)
        {
            int temp = 0;
            using (SQLiteConnection conn = new SQLiteConnection("data source = hrastnik-projekt.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "SELECT * FROM besede;";
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        temp++;
                    }

                    reader.Close();

                    cmd.CommandText = /*"SELECT * FROM besede;"*/ "INSERT INTO besede(id, ime, definicija) VALUES("+ (temp + 1) +", '" + s +"', '"+ d +"');";
                    //SQLiteDataReader reader = cmd.ExecuteReader();
                    cmd.ExecuteNonQuery(); //<---- deluje samo za sql stavke, ki ne vrnejo ničesar (DELETE, INSERT ...)

                    /*while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        ime = reader.GetString(1);
                        definicija = reader.GetString(2);
                        //string definicija = reader.GetString(2);

                        //string vpis = id.ToString() + "|" + ime + "|" + definicija;
                    }*/
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        private void ClearAll()
        {
            for (int i = 0; i < ime.Length; i++)
            {
                labels[i].Visible = false;
                labels[i].Dispose();
            }
            labels.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e, int wordlenght)
        {
            Random r = new Random();

            char[] nov = new char[wordlenght];
                
            nov = ime.ToCharArray();

            for (int i = 0; i < wordlenght; i++)
            {
                var temp = new Label();
                temp.Location = new Point(/*r.Next(ClientRectangle.Right - 10), r.Next(ClientRectangle.Bottom - 10)*/ 10, i * 20);
                temp.Text = "";
                //temp.Visible = false;
                temp.Click += new EventHandler(Form1_Load);
                temp.Size = new Size(20, 20);

                if(i%2 != 0)
                {
                    temp.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    temp.BackColor= System.Drawing.Color.Gray;
                }

                this.Controls.Add(temp);

                //temp.Show();
                labels.Add(temp);
            }

            /*TextBox mylab = new TextBox();
            mylab.ReadOnly = true;
            mylab.Text = "GeeksforGeeks";
            mylab.Location = new Point(222, 90);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 18);
            mylab.ForeColor = Color.Green;
            mylab.Padding = new Padding(6);
            this.Controls.Add(mylab);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //btnDisplay_Click(sender, e, ime.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisplay_Click(sender, e, ime.Length);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            char[] nov = new char[ime.Length];

            int count = 0;

            nov = ime.ToCharArray();

            string guess = textBox1.Text.ToLower();

            if(ime == guess)
            {
                MessageBox.Show("uganili ste");
            }

            char[] cGuess = guess.ToCharArray();

            if (cGuess.Length != nov.Length)
            {
                MessageBox.Show($"word is {nov.Length} characters long!");
                return;
            }

            for (int i = 0; i < nov.Length; i++)
            {
                if(cGuess[i] == nov[i])
                {
                    labels[i].Text = Convert.ToString(nov[i]);
                    labels[i].Show();
                    for (int j = 0; j < nov.Length; j++)
                    {
                        if(labels[j].Text == "")
                        {
                            count++;
                        }
                    }
                    if(count == 0)
                    {
                        MessageBox.Show("uganili ste");
                        return;
                    }
                }
            }
        }

        private void btnreveal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ime.Length; i++)
            {
                labels[i].Text = Convert.ToString(ime[i]);
                labels[i].Show();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearAll();
            BeriDBPrikazi();
            btnDisplay_Click(sender, e, ime.Length);
            lblwordlenght.Text = ime.Length.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void lblwordlenght_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox2.Text = definicija.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.ShowDialog();
        }
    }
}
