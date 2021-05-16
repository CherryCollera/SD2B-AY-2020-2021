using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Activity9
{
    public partial class Form1 : Form
    {

        private OleDbConnection subcon;
        private OleDbCommand oleDbCMD = new OleDbCommand();
        //private string subpar = @"Provider=Microsoft.ACE.OLEDB.12.0;
        //Data Source=C:\Users\Kenneth\Desktop\Assigment Khem\2nd Sem\Assignment and Modules\OBJECT ORIENTED PROGRAMMING\Assignment\Program\Activity9\database\book3.accdb; Persist Security Info=False";

        private string subpar = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Kenneth\Desktop\Assigment Khem\2nd Sem\Assignment and Modules\OBJECT ORIENTED PROGRAMMING\Assignment\Program\Activity9\database\book3.mdb";

        public Form1()
        {
            subcon = new OleDbConnection(subpar);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book3DataSet2.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter1.Fill(this.book3DataSet2.bookrecords);
            // TODO: This line of code loads data into the 'book3DataSet1.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter.Fill(this.book3DataSet1.bookrecords);
        }

        private void addRecords_Click(object sender, EventArgs e)
        {

            subcon.Open();
            oleDbCMD.Connection = subcon;
            oleDbCMD.CommandText = "Insert into bookrecords (booktitle, description)" + " " + " values ('" + this.booktitletext.Text + "', '" + this.DescriptionText.Text + "');";

            int temp = oleDbCMD.ExecuteNonQuery();

            if(temp > 0){

                booktitletext.Text = null;
                DescriptionText.Text = null;
                MessageBox.Show("Record Succesfully Added");

            }else{

                MessageBox.Show("Failed to Add a Record");

            }

            subcon.Close();

        }

        private void Show_Click(object sender, EventArgs e)
        {
            Data.DataSource = null;
            Data.Rows.Clear();
            Data.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("Select * FROM bookrecords", subpar);
            OleDbDataAdapter dAdapter1 = new OleDbDataAdapter("Select * FROM bookrecords", subpar);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Data.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
            }
        }
    }
 }
    
