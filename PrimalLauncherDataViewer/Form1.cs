using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PrimalLauncherDataViewer
{
    public partial class Form1 : Form
    {
        GameDataFile GameDataFile { get; } = new GameDataFile();
        

        public Form1()
        {
            InitializeComponent();;           

            foreach (var item in GameDataFile.Index.OrderBy(x=>x.Key))
                lbSheets.Items.Add(item.Key);

            
        }

        private void lbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = lbSheets.SelectedItem.ToString();

            if (tcMainGrid.TabPages.ContainsKey(selected))
            {
                tcMainGrid.SelectedTab = tcMainGrid.TabPages[selected];
            }
            else
            {
                DataTable dt = GameDataFile.GetGameData(selected);

                DataGridView dg = new DataGridView
                {
                    DataSource = dt,
                    ReadOnly = false,
                    Dock = DockStyle.Fill
                };

                // Double buffering can make DGV slow in remote desktop
                if (!SystemInformation.TerminalServerSession)
                {
                    Type dgvType = dg.GetType();
                    PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
                    pi.SetValue(dg, true, null);
                }

                TabPage newTab = new TabPage
                {
                    Name = selected.Replace("/", ""),
                    Text = selected,
                    Dock = DockStyle.Fill
                };
                newTab.Controls.Add(dg);

                tcMainGrid.TabPages.Add(newTab);
                tcMainGrid.SelectedTab = newTab;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tcMainGrid.TabPages.Count > 0)
            {
                DataGridView dataGrid =  (DataGridView)tcMainGrid.SelectedTab.Controls[0];
                int firstSelected = -1;
                string searchValue = txtSearch.Text.ToLower();
                dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {

                            int rowIndex = row.Index;
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(searchValue))
                            {
                                if (firstSelected < 0)
                                    firstSelected = row.Index;

                               
                                dataGrid.Rows[rowIndex].Selected = true;
                                break;
                            }
                            else
                            {
                                //dataGrid.Rows[rowIndex].Visible = false;
                            }
                        }
                    }

                    if (firstSelected < 0)
                        MessageBox.Show("'" + searchValue + "' not found in this table.", "Not found");
                    else
                        dataGrid.FirstDisplayedScrollingRowIndex = firstSelected;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("No data section opened.", "Error");
            }
           

            
        }
    }
}
