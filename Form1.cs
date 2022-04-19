using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaturitníČetba
{
    public partial class Form1 : Form
    {

        List<Panel> listePanel = new List<Panel>();
        int i;

        public Form1()
        {
            //Inicializace
            InitializeComponent();
            dgvDila.DataSource = Databaze.Dila; // Zdroj dat pro DataGridView Díla
            dgvStudenti.DataSource = Databaze.Studenti; // Zdroj dat pro DataGridView Studenti
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tento řádek načte data do tabulky 'names1DataSet.Table1'.
            this.table1TableAdapter.Fill(this.names1DataSet.Table1);

            //Přidají se 2 panely
            listePanel.Add(panel1);
            listePanel.Add(panel2);
            listePanel[i].BringToFront(); //Panel číslo x se posune do popředí
        }
        //Následující metody jsou pro překlikávání mezi 2 panely.
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (i < listePanel.Count - 1)
            {
                listePanel[++i].BringToFront();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                listePanel[--i].BringToFront();
            }
        }
        //Konec metod pro překlikávání
        
        //Propojení DataGridView s údaji z Databaze.cs
        private void dgvStudenti_SelectionChanged(object sender, EventArgs e)
        {
            int indS = dgvStudenti.CurrentCell.RowIndex;
            dgvPrecteno.DataSource = Databaze.Studenti[indS].PrectenaDila; //DataGridView Přečteno bude mít obsah listu PrectenaDila
            dgvBudeCist.DataSource = Databaze.Studenti[indS].BudeCist; //DataGridView BudeČíst bude mít obsah listu BudeCist
        }

        //Tlačítkem Přečteno se ke konkrétném studentovi s indexem indS přidá Dílo s indexem indD
        private void btnPrecteno_Click(object sender, EventArgs e)
        {
            int indS = dgvStudenti.CurrentCell.RowIndex;
            int indD = dgvDila.CurrentCell.RowIndex;

            Databaze.Studenti[indS].PrectenaDila.Add(Databaze.Dila[indD]);
        }


        //Tlačítkem BudeČíst se ke konkrétném studentovi s indexem indS přidá Dílo s indexem indD
        private void btnBudeCist_Click(object sender, EventArgs e)
        {
            int indS = dgvStudenti.CurrentCell.RowIndex;
            int indD = dgvDila.CurrentCell.RowIndex;

            Databaze.Studenti[indS].BudeCist.Add(Databaze.Dila[indD]);

        }

        //Mazání řádku v DataGridView pro přečtená díla
        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if (this.dgvPrecteno.SelectedRows.Count > 0)
            {
                dgvPrecteno.Rows.RemoveAt(this.dgvPrecteno.SelectedRows[0].Index);
            }
        }

        //Mazání řádku v DataGridView pro díla, které student bude číst
        private void btnSmazat1_Click(object sender, EventArgs e)
        {
            if (this.dgvBudeCist.SelectedRows.Count > 0)
            {
                dgvBudeCist.Rows.RemoveAt(this.dgvBudeCist.SelectedRows[0].Index);
            }
        }


        //Metoda pro počítání kolik děl má student přečtených
        public void Count()
        {
            label10.Text = "Celkem přečteno: " + dgvPrecteno.Rows.Count.ToString();
        }

        //Tlačítko pro aktualizaci počtu přečtených knih, v případě 10+ ukáže msgbox
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            label10.Update();
            Count();

            if (dgvPrecteno.Rows.Count > 10)
                MessageBox.Show("Už má přečteno přes 10 knih, stačí!");
        }

        //Panel2 pro přidávání studentů
        //Tlačítko přidání řádku
        private void btnPridat_Click(object sender, EventArgs e)
        {
            table1BindingSource.AddNew();
        }

        //Tlačítko pro uložení údajů nového studenta
        private void btnUlozit_Click(object sender, EventArgs e)
        {
            table1BindingSource.EndEdit();
            table1TableAdapter.Update(names1DataSet.Table1);

        }

        //Tlačítko mazání řádku
        private void btnDelete_Click(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();
        }

    












        //Pro sebe: Snažila jsem se o propojení SQL Query s kódem

        //private void btnConnect_Click(object sender, EventArgs e)
        //{
        /*//Setting connection string for the local database
        string connectionString = "Data Source=GAYFACTORY;Initial Catalog = names1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //Wrapping the connection, connection se zavre automaticky
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from dbo.Table1", sqlConnection);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dgvSeznamStudentu.DataSource = dataTable;
        }*/
        //}
    }
}
