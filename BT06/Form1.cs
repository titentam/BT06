using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BT06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCBBLop();
            LoadData();
            LoadCBBSort();
        }
        
        private void LoadCBBLop()
        {
            using(TamDB db = new TamDB())
            {
                var lopSh = db.SVs.Select(sv => sv.Class).ToList();
                lopSh = lopSh.Distinct().ToList();
                lopSh.Insert(0, "All");
                lopSh.Sort();
                cbLopSH.DataSource = lopSh;
            }
        }

        private void LoadCBBSort()
        {
            cbSort.DataSource = new List<string>() { "ID", "Name", "GPA" };
        }
        public void LoadData()
        {
            using(var db = new TamDB()) 
            {
                var listSv = db.SVs.Select(sv => sv).ToList();
                gvTable.DataSource = listSv;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            string lop = cbLopSH.SelectedItem.ToString();
            lop = lop == "All" ? "" : lop;

            using (var db = new TamDB())
            {
                var listSv = db.SVs.Where(sv => sv.Name.Contains(name) && sv.Class.Contains(lop)).ToList();
                gvTable.DataSource = listSv;
            }
           
        }

        private void cbLopSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lop = cbLopSH.SelectedItem.ToString();
            lop = lop == "All" ? "" : lop;

            using (var db = new TamDB())
            {
                var listSv = db.SVs.Where(sv => sv.Class.Contains(lop)).ToList();
                gvTable.DataSource = listSv;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xoá không", "Xác nhận xoá", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                List<string> listId = new List<string>();
                foreach (DataGridViewRow row in gvTable.SelectedRows)
                {
                    listId.Add(row.Cells["ID"].Value.ToString());
                }

                using (var db = new TamDB())
                {
                    var listSv = db.SVs.Where(sv => listId.Contains(sv.ID));
                    db.SVs.RemoveRange(listSv);
                    db.SaveChanges();
                    btnSearch_Click(sender, e);
                }
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string option = cbSort.SelectedItem.ToString();
            using (var db = new TamDB())
            {
                List<SV> listSv = null;
                if (option == "ID")
                {
                    listSv = db.SVs.Select(sv => sv).ToList().OrderBy(sv=>sv.ID).ToList();
                }
                else if (option == "Name") {
                    listSv = db.SVs.Select(sv => sv).ToList().OrderBy(sv => sv.Name).ToList();
                }
                else
                {
                    listSv = db.SVs.Select(sv => sv).ToList().OrderBy(sv => sv.GPA).ToList();
                }
                gvTable.DataSource = listSv;
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.myDel += LoadData;
            form2.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count == 1)
            {
                string mssv = gvTable.SelectedRows[0].Cells[0].Value.ToString();
                Form2 f2 = new Form2(mssv);
                f2.myDel += LoadData;
                f2.ShowDialog();

            }
        }

       
    }
}
