using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BazaDSoftBlue
{
    public partial class Indukcyjne : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Indukcyjne()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Elektronika2.accdb;Persist Security Info=False;";
        }
        private void Indukcyjne_Load(object sender, EventArgs e)
        {
            OdswiezButton_Click(sender, e);
        }

        private void OdswiezButton_Click(object sender, EventArgs e)
        {
            WartoscTextBox.Text = "";
            ObudowaTextBox.Text = "";
            TolerancjaTextBox.Text = "";
            PradTextBox.Text = "";
            RezystancjaTextBox.Text = "";
            ProducentTextBox.Text = "";
            LokalizacjaTextBox.Text = "";
            IloscNumeric.Value = 0;
            DostawcaTextBox.Text = "";
            CenaTextBox.Text = "";

            WartoscComboBox.Items.Clear();
            ObudowaComboBox.Items.Clear();
            TolerancjaComboBox.Items.Clear();
            PradComboBox.Items.Clear();
            RezystancjaComboBox.Items.Clear();
            ProducentComboBox.Items.Clear();
            LokalizacjaComboBox.Items.Clear();
            DostawcaComboBox.Items.Clear();
            CenaComboBox.Items.Clear();
            IndexComboBox.Items.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator, Wartość, Obudowa, Tolerancja, Prąd, Rezystancja, Producent, Lokalizacja, Ilość, Dostawca, Cena from Elektronika where Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connectionChecker.Text = "Połączono";
                connection.Close();
            }
            catch (Exception ex)
            { connectionChecker.Text = "Nie Połączono"; }
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Wartość, Obudowa, Tolerancja, Prąd, Rezystancja, Producent, Lokalizacja, Ilość, Dostawca, Cena, Identyfikator from Elektronika where Element = 'cewka'";
                command.CommandText = querry;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!WartoscComboBox.Items.Contains(reader[0]))
                        WartoscComboBox.Items.Add(reader[0]).ToString();
                    if (!ObudowaComboBox.Items.Contains(reader[1]))
                        ObudowaComboBox.Items.Add(reader[1]).ToString();
                    if (!TolerancjaComboBox.Items.Contains(reader[2]))
                        TolerancjaComboBox.Items.Add(reader[2]).ToString();
                    if (!PradComboBox.Items.Contains(reader[3]))
                        PradComboBox.Items.Add(reader[3]).ToString();
                    if (!RezystancjaComboBox.Items.Contains(reader[4]))
                        RezystancjaComboBox.Items.Add(reader[4]).ToString();
                    if (!ProducentComboBox.Items.Contains(reader[5]))
                        ProducentComboBox.Items.Add(reader[5]).ToString();
                    if (!LokalizacjaComboBox.Items.Contains(reader[6]))
                        LokalizacjaComboBox.Items.Add(reader[6]).ToString();
                    if (!DostawcaComboBox.Items.Contains(reader[8]))
                        DostawcaComboBox.Items.Add(reader[8]).ToString();
                    if (!CenaComboBox.Items.Contains(reader[9]))
                        CenaComboBox.Items.Add(reader[9]).ToString();
                    if (!IndexComboBox.Items.Contains(reader[10]))
                        IndexComboBox.Items.Add(reader[10]).ToString();
                }
                connection.Close();
            }
            catch (Exception)
            { MessageBox.Show("nieznany błąd odświeżania"); }
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Elektronika (Element,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena) values('cewka','" + WartoscTextBox.Text + "','" + ObudowaTextBox.Text + "','" + TolerancjaTextBox.Text + "','" + PradTextBox.Text + "','" + RezystancjaTextBox.Text + "','" + ProducentTextBox.Text + "','" + LokalizacjaTextBox.Text + "','" + IloscNumeric.Value + "','" + DostawcaTextBox.Text + "','" + CenaTextBox.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Dane zapisane");

                connection.Close();
                OdswiezButton_Click(sender, e);
            }
            catch (Exception ex) { }
        }

        private void EdytujButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "update Elektronika set Wartość='" + WartoscTextBox.Text + "', Obudowa='" + ObudowaTextBox.Text + "', Tolerancja='" + TolerancjaTextBox.Text + "', Prąd='" + PradTextBox.Text + "', Rezystancja='" + RezystancjaTextBox.Text + "', Producent='" + ProducentTextBox.Text + "', Lokalizacja='" + LokalizacjaTextBox.Text + "', Ilość=" + IloscNumeric.Value + ", Dostawca='" + DostawcaTextBox.Text + "', Cena='" + CenaTextBox.Text + "' where Identyfikator=" + IndexComboBox.Text + "";
                command.CommandText = querry;

                command.ExecuteNonQuery();
                MessageBox.Show("Wyedytowano");

                connection.Close();
                OdswiezButton_Click(sender, e);
            }
            catch (Exception ex) { }
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "delete from Elektronika where Identyfikator=" + IndexComboBox.Text + "";
                command.CommandText = querry;

                command.ExecuteNonQuery();
                MessageBox.Show("usunięto");

                connection.Close();
                OdswiezButton_Click(sender, e);
            }
            catch (Exception)
            { MessageBox.Show("Nie usunięto"); }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void rezystory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void WartoscComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = WartoscComboBox.Text;
            OdswiezButton_Click(sender, e);
            WartoscTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void ObudowaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = ObudowaComboBox.Text;
            OdswiezButton_Click(sender, e);
            ObudowaTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void TolerancjaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = TolerancjaComboBox.Text;
            OdswiezButton_Click(sender, e);
            TolerancjaTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void PradComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = PradComboBox.Text;
            OdswiezButton_Click(sender, e);
            PradTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void RezystancjaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = RezystancjaComboBox.Text;
            OdswiezButton_Click(sender, e);
            RezystancjaTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void ProducentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = ProducentComboBox.Text;
            OdswiezButton_Click(sender, e);
            ProducentTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void LokalizacjaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = LokalizacjaComboBox.Text;
            OdswiezButton_Click(sender, e);
            LokalizacjaTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void DostawcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = DostawcaComboBox.Text;
            OdswiezButton_Click(sender, e);
            DostawcaTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void CenaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Buffor = CenaComboBox.Text;
            OdswiezButton_Click(sender, e);
            CenaTextBox.Text = Buffor;
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Identyfikator,Wartość,Obudowa,Tolerancja,Prąd,Rezystancja,Producent,Lokalizacja,Ilość,Dostawca,Cena from Elektronika where Wartość='" + Buffor + "' and Element='cewka'";
                command.CommandText = querry;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTableGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("nie połączyło"); }
        }

        private void IndexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connectionChecker.Text = "Połączono";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "select Wartość, Obudowa, Tolerancja, Prąd, Rezystancja, Producent, Lokalizacja, Ilość, Dostawca, Cena, Identyfikator from Elektronika where Identyfikator =" + IndexComboBox.Text + "";
                command.CommandText = querry;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    WartoscTextBox.Text = reader["Wartość"].ToString();
                    ObudowaTextBox.Text = reader["Obudowa"].ToString();
                    TolerancjaTextBox.Text = reader["Tolerancja"].ToString();
                    PradTextBox.Text = reader["Prąd"].ToString();
                    RezystancjaTextBox.Text = reader["Rezystancja"].ToString();
                    ProducentTextBox.Text = reader["Producent"].ToString();
                    LokalizacjaTextBox.Text = reader["Lokalizacja"].ToString();
                    DostawcaTextBox.Text = reader["Dostawca"].ToString();
                    IloscNumeric.Value = Convert.ToInt32(reader["Ilość"].ToString());
                    CenaTextBox.Text = reader["Cena"].ToString();
                }
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
