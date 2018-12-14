using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace aponet
{
    public partial class Form1 : Form
    {
        public OracleConnection conn = new OracleConnection();
        string SqlCommit = "commit";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            INIT_UI();
        }

        private void INIT_UI()
        {
            BTN_Modifiersupprimer.Enabled = false;
            BTN_Ajouter.Enabled = false;
            BTN_Search.Enabled = false;
            
        }
        private void initier_Liste_Categorie(ComboBox CBB)
        {
            try
            {
                CBB.Items.Clear();
                string sql3 = "Select NomCategorie from categories";
                OracleCommand Requete3 = new OracleCommand(sql3, conn);
                OracleDataReader reader3 = Requete3.ExecuteReader();

                while (reader3.Read())
                {
                    CBB.Items.Add(reader3.GetString(0));
                }
                reader3.Close();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }

        private void UPDATE_UI()
        {
            afficherDGV();
        }
        private void BTN_Connection_Click(object sender, EventArgs e) //connection
        {
            try
            {
                string dsource = "(DESCRIPTION="
                     + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                     + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                     + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

                string ChaineDeConnection = "Data Source = " + dsource + "; User Id = bourgeoc; password = ORACLE1";
                conn.ConnectionString = ChaineDeConnection;
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception sqlConn)
            {
                MessageBox.Show(sqlConn.Message.ToString());
            }
            BTN_Ajouter.Enabled = true;
            BTN_Search.Enabled = true;
            BTN_Modifiersupprimer.Enabled = true;
            UPDATE_UI();
            initier_Liste_Categorie(CB_ChoixCatégorie1);
            initier_Liste_Categorie(CB_ChoixCatégorie);
            CB_ChoixCatégorie.SelectedIndex = 0;
            CB_ChoixCatégorie1.SelectedIndex = 0;
            RBTN_TousLesAlbums.Select();
            CB_ChoixCatégorie.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_ChoixCatégorie1.DropDownStyle = ComboBoxStyle.DropDownList;
            afficherDGV();
        }
        private void BTN_Deconnection_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }

        //Méthodes
        private void Inserer() //AjoutDisque
        {
            try
            {
                string SQLInsert = "insert into Disques(NoDisque ,TitreDisque,NomArtiste,AnneeDisque,CodeCategorie) values(NoDisquesequence.nextval,'" + TB_TitreDisque.Text + "','" + TB_NomArtiste.Text + "'," + TB_AnnéDisque.Text + "," + "(select CodeCategorie from Categories where NomCategorie ='" + CB_ChoixCatégorie.SelectedItem.ToString() + "'))";
                OracleCommand Insert = new OracleCommand(SQLInsert, conn);
                OracleCommand commit = new OracleCommand(SqlCommit, conn);
                Insert.ExecuteNonQuery();
                commit.ExecuteNonQuery();
                MessageBox.Show("Album ajoutés");
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Inserer();
            TB_NomArtiste.Clear();
            TB_TitreDisque.Clear();
            CB_ChoixCatégorie1.SelectedIndex = 0;
            TB_AnnéDisque.Clear();
            UPDATE_UI();
        }

        private void BTN_Modifiersupprimer_Click(object sender, EventArgs e)
        {
            ModifierEtSupprimer Modifier = new ModifierEtSupprimer();
            Modifier.conn = conn;
            Modifier.monDataSet = monDataSet;
            if (Modifier.ShowDialog() == DialogResult.OK)
            {
               
            }
            UPDATE_UI();
          
        }

        private void AfficherParNom(string NomDisque)
        {
            try
            { 
                string sql3 = "Select TitreDisque,NomArtiste,AnneeDisque,NomCategorie from Disques d inner join categories c on d.CodeCategorie = c.CodeCategorie where TitreDisque ='" + NomDisque + "'";
                OracleDataAdapter Adapter1 = new OracleDataAdapter(sql3, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeDisque"))
                {
                    monDataSet.Tables["ListeDisque"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeDisque");
                Adapter1.Dispose();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }
        private void AfficherParCategorie(String categorie)
        {
            try
            {
                string sql3 = "Select TitreDisque,NomArtiste,AnneeDisque,NomCategorie from Disques d inner join categories c on d.CodeCategorie = c.CodeCategorie where NomCategorie ='" + categorie + "'";
                OracleDataAdapter Adapter1 = new OracleDataAdapter(sql3, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeDisque"))
                {
                    monDataSet.Tables["ListeDisque"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeDisque");
                Adapter1.Dispose();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }
        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (RBTN_TousLesAlbums.Checked == true)
            {
                afficherDGV();
            }
            else if (RBTN_ParNom.Checked == true)
            {
                AfficherParNom(TBX_ParNom.Text);
            }
            else if (RBTN_ParCategorie.Checked == true)
            {
                AfficherParCategorie(CB_ChoixCatégorie.SelectedItem.ToString());
            }
        }

        private void TBX_ParNom_MouseClick(object sender, MouseEventArgs e)
        {
            RBTN_ParNom.Checked = true;
        }
        
        private void CB_ChoixCatégorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            RBTN_ParCategorie.Checked = true;
        }

        private void TB_AnnéDisque_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //DataSet
        private DataSet monDataSet = new DataSet();
        private void afficherDGV()
        {
            try
            {
                string Tomastatar = "Select TitreDisque,NomArtiste,AnneeDisque,NomCategorie from Disques d inner join categories c on d.CodeCategorie = c.CodeCategorie";
                OracleDataAdapter Adapter1 = new OracleDataAdapter(Tomastatar, conn);
                // On vérifie que le DataSet ne contient pas de Data Table de nom "ListeEtudiants"
                if (monDataSet.Tables.Contains("ListeDisque"))
                {
                    monDataSet.Tables["ListeDisque"].Clear();
                }
                // on rempli le DataSet
                Adapter1.Fill(monDataSet, "ListeDisque");
                Adapter1.Dispose();
                //on fait une liaison des données entre le DGV et le DataSet pour ListeEtudiants
                BindingSource maSource;
                maSource = new BindingSource(monDataSet, "ListeDisque");
                DGV_Album.DataSource = maSource;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
