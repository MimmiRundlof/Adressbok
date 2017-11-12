using Adressbok.DA;
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



namespace Adressbok
{
    public partial class Adressbok : Form
    {
        
        public Adressbok()
        {

            InitializeComponent();
            LoadAddressbook();
        }

    
        private void LoadAddressbook()
        {
            var dataAccess = new DataAccess();
            string query = "SELECT p.PersonID, p.Namn, t.Telefonnummer, p.Epost, a.Gatuadress, a.Postnummer, " +
                "a.Postort, p.Kontakttyp FROM Person p inner join Adress a on p.PersonID = a.PersonID" +
                " inner join Telefon t on p.PersonID = t.PersonID";

            var dataSet = dataAccess.GetDataFromDB(query);

            AdressbokDataGridView.DataSource = dataSet.Tables[0];
        }

    
        private void CreateNewPersonButton_Click(object sender, EventArgs e)
        {
            var dataAccess = new DataAccess();

            string query = "Declare @PersonID int" +
                " insert into Person " +
                "values('" + tbNamn.Text + "','" + tbEpost.Text + "','" + cmbKontakttyp.Text + "') " +
                "set @PersonID = SCOPE_IDENTITY()" +
                " insert into Adress values('" + tbGatuadress.Text + "','" + tbPostnummer.Text + "','" + tbPostort.Text + "', @PersonID)" + 
               " insert into Telefon values(@PersonID, '" + tbTelefon.Text + "')";

            var personData = dataAccess.SaveData(query);

            ClearTextBox();
        }



        private void Search_Click(object sender, EventArgs e)
        {

            var da = new DataAccess();




            string query = "declare @search varchar(50) = '" + tbSok.Text + "' " +
                "SELECT p.PersonID, p.Namn, t.Telefonnummer, p.Epost, a.Gatuadress, a.Postnummer, " +
                "a.Postort, p.Kontakttyp from" +
                " Person p inner join Adress a on p.PersonID = a.PersonID " +
                "inner join Telefon t on p.PersonID = t.PersonID" +
                " where p.Namn like '%' + @search + '%' or p.Kontakttyp like '%' + @search + '%' or a.Postort like '%' + @search + '%'";

            var sökresultat = da.SearchData(query);
            AdressbokDataGridView.DataSource = sökresultat.Tables[0];
            
           
        }



        private void Updatebutton_Click(object sender, EventArgs e)
        {
            LoadAddressbook();
        }


        private void AdressbokDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var da = new DataAccess();

            int row = AdressbokDataGridView.CurrentCell.RowIndex;

            var tesr = AdressbokDataGridView.CurrentRow.Cells[0].Value.ToString();

        

            for (int i = 0; i < AdressbokDataGridView.Rows.Count - 1; i++)
            {

                tbNamn.Text = AdressbokDataGridView.Rows[row].Cells[1].Value.ToString();
                tbTelefon.Text = AdressbokDataGridView.Rows[row].Cells[2].Value.ToString();
                tbEpost.Text = AdressbokDataGridView.Rows[row].Cells[3].Value.ToString();
                tbGatuadress.Text = AdressbokDataGridView.Rows[row].Cells[4].Value.ToString();
                tbPostnummer.Text = AdressbokDataGridView.Rows[row].Cells[5].Value.ToString();
                tbPostort.Text = AdressbokDataGridView.Rows[row].Cells[6].Value.ToString();
                cmbKontakttyp.Text = AdressbokDataGridView.Rows[row].Cells[7].Value.ToString();


            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {

            var tabellID = AdressbokDataGridView.CurrentRow.Cells[0].Value.ToString();
    
            var da = new DataAccess();




            string query = "update Person " +
                    "set Namn = '" + tbNamn.Text + "', Epost = '" + tbEpost.Text + "', Kontakttyp ='" + cmbKontakttyp.Text + "'" +
                    " where Person.PersonID =" + tabellID +
                    " update adress" +
                    " set Gatuadress = '" + tbGatuadress.Text + "', Postnummer = '" + tbPostnummer.Text + "', Postort ='" + tbPostort.Text + "" +
                    "' where Adress.PersonID =" + tabellID +
                    " update Telefon set Telefonnummer = '" + tbTelefon.Text + "' where Telefon.PersonID = " + tabellID;
                  


            var ändring = da.EditData(query);
            ClearTextBox();


        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            var tabellID = AdressbokDataGridView.CurrentRow.Cells[0].Value.ToString();

            var da = new DataAccess();

            string query = "delete from Person " +
                "where Person.PersonID =" + tabellID;
                   


            var ändring = da.DeleteData(query);
            ClearTextBox();

        }


        public void ClearTextBox()
        {

            tbNamn.Clear();
            tbEpost.Clear();
            tbTelefon.Clear();
            tbGatuadress.Clear();
            tbPostnummer.Clear();
            tbPostort.Clear();
           
        }

    }


}
