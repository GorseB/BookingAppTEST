using System;
using System.Data;
using System.Windows.Forms;

namespace BookingAppTEST
{
    public partial class Form1 : Form
    {
        private Database DB;

        public Form1()
        {
            InitializeComponent();
            while (TestDatabase() == false)
            {
                string CS = TryDB();
                DB = new Database(CS);
            }
            TryCBX();
        }

        private bool TestDatabase()
        {
            try
            {
                DataTable DT = DB.Fill();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private string TryDB()
        {
            string Output = null;
            var DR = new DialogResult();
            var Password_Input = new PasswordInput();
            DR = Password_Input.ShowDialog();
            if (DR == DialogResult.OK)
            {
                string ResultFromForm = Password_Input.txt_NewPassword.Text;
                //Output = string.Format("Data Source=dsedtest.database.windows.net;Initial Catalog=DSED_Booking;Integrated Security=False;User ID=dsedtestlogin;Password={0};Connect Timeout=15;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", ResultFromForm);
                Output = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            }
            return Output;
        }

        private void TryCBX()
        {
            DataTable DT;
            DT = DB.Fill();
            foreach (DataRow DR in DT.Rows)
            {
                CBX1.Items.Add(DR[0].ToString());
            }
            if (CBX1.Items.Count > 0)
            {
                CBX1.SelectedIndex = 0;
                dataGridView1.DataSource = DB.Get_Data(CBX1.Items[0].ToString());
            }
            else
            {
                MessageBox.Show("Could Not Find Items!");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void CBX1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Get_Data(CBX1.SelectedItem.ToString());
        }

        private void btn_Create_Table_Click(object sender, EventArgs e)
        {
            var DR = new DialogResult();
            var Create_Table_Form = new Table_Create();
            DR = Create_Table_Form.ShowDialog();
        }
    }
}