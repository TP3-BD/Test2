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
    public partial class ModifierEtSupprimer : Form
    {
        public OracleConnection conn;
        public DataSet monDataSet;
        public ModifierEtSupprimer()
        {
            InitializeComponent();
        }

        private void modifier_Load(object sender, EventArgs e)
        {

        }
        private void ModifierEtSupprimer_Load_1(object sender, EventArgs e)
        {
            BTN_Annuler.Select();
            Afficher();
            BTN_Modifier.Enabled = false;
            BTN_Supprimer.Enabled = false;
        }

        //méthodes
        private void Supprimer()
        {
            try
            {
                string SQLDelete = "Delete from Disques where TitreDisque = '" + LB_Album.SelectedItem + "'";
                OracleCommand Insert = new OracleCommand(SQLDelete, conn);
                Insert.ExecuteNonQuery();
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }
        private void Afficher()
        {
            try
            {
                LB_Album.Items.Clear();
                string SQLSelect = "Select TitreDisque from Disques";
                OracleCommand Select = new OracleCommand(SQLSelect, conn);
                OracleDataReader OraRead = Select.ExecuteReader();
                while (OraRead.Read())
                {
                    LB_Album.Items.Add(OraRead.GetString(0));
                }
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }
        //BTN click
          

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
            Afficher();
            MessageBox.Show("album supprimé");
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            modifier ModifierAlbum = new modifier();
            ModifierAlbum.conn = conn;
            ModifierAlbum.monDataSet = monDataSet;
            ModifierAlbum.TitreDisque = LB_Album.SelectedItem.ToString();
            if (ModifierAlbum.ShowDialog() == DialogResult.OK)
            {}
        }

        private void LB_Album_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_Modifier.Enabled = true;
            BTN_Supprimer.Enabled = true;
        }

       
    }
}