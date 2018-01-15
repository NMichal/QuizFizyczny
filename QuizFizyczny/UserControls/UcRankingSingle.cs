using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizFizyczny.Forms;
using QuizFizyczny.DataBase;

namespace QuizFizyczny.UserControls
{
    public partial class UcRankingSingle : UserControl
    {
        MenuStart _parent; 
        public UcRankingSingle(MenuStart parent)
        {
            InitializeComponent();
            Init();
            PokazDane();
            _parent = parent;
        }

        private void BtnWroc_Click(object sender, EventArgs e)
        {
            UcSingleplayer ucSingle = new UcSingleplayer(_parent);
            ucSingle.Dock = DockStyle.Fill;
            _parent.ustawPanelZTrybem(ucSingle);
        }

        private void Init()
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;

            #region Dodawnie kolumn
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "nazwaGracza";
            column.Name = "Gracz";
            dataGridView1.Columns.Add(column);

            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "punkty";
            column2.Name = "Liczba punktów";
            dataGridView1.Columns.Add(column2);
            #endregion
        }

        private void PokazDane()
        {
            List<RankingSingle> rs = ContextDb.contextDB.RankingSingle.OrderByDescending(a => a.punkty).ToList();
            dataGridView1.DataSource = rs;
        }

        /// <summary>
        /// Metoda wyliczająca procentowo szerokość kolumn do szerokości okna
        /// </summary>
        private void SkalujKolumny()
        {
            int szerokoscGridView = dataGridView1.Size.Width;
            int[] szerKol = { 48, 47 }; //szerokosc kolumn podawana w %
            for (int i = 0; i < szerKol.Count(); i++)
            {
                double szer = Math.Round((szerKol[i] * szerokoscGridView) / 100.0);
                dataGridView1.Columns[i].Width = (int)szer;
            }

        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            SkalujKolumny();
        }


        List<Uzytkownicy> uzytk = ContextDb.contextDB.Uzytkownicy.ToList();
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RankingSingle data = dataGridView1.Rows[e.RowIndex].DataBoundItem as RankingSingle;

            dataGridView1.Rows[e.RowIndex].Cells["Gracz"].Value = uzytk.Where(a => a.id == data.idGracza).FirstOrDefault().login;
        }
    }
}
