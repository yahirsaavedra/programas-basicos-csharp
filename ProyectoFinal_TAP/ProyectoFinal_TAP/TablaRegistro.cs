using System;
using System.Windows.Forms;

namespace ProyectoFinal_TAP
{
    public partial class TablaRegistro : Form
    {
        public TablaRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgr = new DataGridViewRow();
            dgr.CreateCells(DGV);

            dgr.Cells[0].Value = tb1.Text;
            dgr.Cells[1].Value = tb2.Text;
            dgr.Cells[2].Value = tb3.Text;
            dgr.Cells[3].Value = tb4.Text;

            DGV.Rows.Add(dgr);

            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AppRegistro R = new AppRegistro();
            this.Hide();

            R.FormClosed += (s, args) => this.Close();
            R.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV.SelectedRows.Count; i++) {
                DGV.Rows.RemoveAt(DGV.SelectedRows[i].Index);
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
