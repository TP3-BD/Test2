using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace aponet
{
    
    public partial class modifier : Form
    {

        public string TitreDisque;
        public OracleConnection conn;
        public DataSet monDataSet;
        public modifier()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Supprimer();
            Inserer();
            this.Close();
        }

        private void modifier_Load(object sender, EventArgs e)
        {
            initier_Liste_Categorie(CB_ChoixCatégorie1);
            afficherTxt();
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

        private void afficherTxt()
        {
            string Tomastatar = "Select TitreDisque,NomArtiste,AnneeDisque,NomCategorie from Disques d inner join categories c on d.CodeCategorie = c.CodeCategorie where TitreDisque = '" + TitreDisque + "'";
            try
            {
                OracleDataAdapter Adapter2 = new OracleDataAdapter(Tomastatar, conn);
                if (monDataSet.Tables.Contains("ListeDisque"))
                {
                    monDataSet.Tables["ListeDisque"].Clear();
                }
                Adapter2.Fill(monDataSet, "ListeDisque");
                Adapter2.Dispose();
                // on apelle la fonction lier pour faire la liaison des données
                // du DataSet avec les zones de text.
                lier();
            }
            catch (Exception exsql2)
            {
                MessageBox.Show(exsql2.Message.ToString());
            }
        }
        private void lier()
        {
            TB_TitreDisque.DataBindings.Add("text", monDataSet, "ListeDisque.TitreDisque");
            TB_NomArtiste.DataBindings.Add("text", monDataSet, "ListeDisque.NomArtiste");
            TB_AnnéDisque.DataBindings.Add("text", monDataSet, "ListeDisque.AnneeDisque");
            CB_ChoixCatégorie1.DataBindings.Add("text", monDataSet, "ListeDisque.NomCategorie");
        }
        private void Supprimer()
        {
            try
            {
                string SQLDelete = "Delete from Disques where TitreDisque = '" + TB_TitreDisque.Text + "'";
                OracleCommand Insert = new OracleCommand(SQLDelete, conn);
                Insert.ExecuteNonQuery();
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }
        private void Inserer() //AjoutDisque
        {
            try
            {
                string SQLInsert = "insert into Disques(NoDisque ,TitreDisque,NomArtiste,AnneeDisque,CodeCategorie) values(NoDisquesequence.nextval,'" + TB_TitreDisque.Text + "','" + TB_NomArtiste.Text + "'," + TB_AnnéDisque.Text + "," + "(select CodeCategorie from Categories where NomCategorie ='" + CB_ChoixCatégorie1.SelectedItem.ToString() + "'))";
                OracleCommand Insert = new OracleCommand(SQLInsert, conn);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Album ajoutés");
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }
    }
}
