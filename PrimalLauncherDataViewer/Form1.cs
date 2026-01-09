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
            InitializeComponent();

            //DataTable commandTable = GameDataFile.GetGameData("command");
            //DataRow[] commandRows = commandTable.Select("(id > 0 AND id < 23000) OR (id > 24000 AND id < 26000)");

            searchContains.Checked = true;

            foreach (var item in GameDataFile.Index.OrderBy(x => x.Key))
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
                DataGridView dg = GetDataGridView(selected);

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

        private DataGridView GetDataGridView(string gameDataName, string searchString = null)
        {
            DataTable dt = GameDataFile.GetGameData(gameDataName);

            if (!string.IsNullOrEmpty(searchString))
            {
                try
                {
                    DataTable searchResult = dt.Clone();

                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (var col in row.ItemArray)
                        {
                            string colText = col.ToString().ToLower();

                            if (searchContains.Checked == true)
                            {
                                if (colText.Contains(searchString.ToLower()))
                                {
                                    searchResult.ImportRow(row);
                                    break;
                                }
                            }
                            else
                            {
                                if (colText == searchString)
                                {
                                    searchResult.ImportRow(row);
                                    break;
                                }
                            }
                        }
                    }

                    dt = searchResult;
                }
                catch
                {

                }

            }

            DataGridView dg = new DataGridView
            {
                DataSource = dt,
                ReadOnly = false,
                Dock = DockStyle.Fill,
                ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
            };

            // Double buffering can make DGV slow in remote desktop
            if (!SystemInformation.TerminalServerSession)
            {
                Type dgvType = dg.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dg, true, null);
            }

            return dg;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tcMainGrid.TabPages.Count > 0)
            {
                DataGridView dataGrid = (DataGridView)tcMainGrid.SelectedTab.Controls[0];
                string searchValue = txtSearch.Text;

                try
                {
                    DataGridView searchResults = GetDataGridView(tcMainGrid.SelectedTab.Text, searchValue);
                    tcMainGrid.SelectedTab.Controls.Remove(tcMainGrid.SelectedTab.Controls[0]);
                    tcMainGrid.SelectedTab.Controls.Add(searchResults);

                    if (searchResults.RowCount <= 0)
                        MessageBox.Show("'" + searchValue + "' not found in this table.", "Not found");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                //MessageBox.Show("No data section opened.", "Error");
            }



        }

        private void SearchAllSheets()
        {
            tcMainGrid.TabPages.Clear();

            foreach (var item in lbSheets.Items)
            {
                string sheetName = item.ToString();
                DataGridView dg = GetDataGridView(sheetName, txtSearch.Text);

                dg.Refresh();

                if (((DataTable)dg.DataSource).Rows.Count > 0)
                {
                    TabPage newTab = new TabPage
                    {
                        Name = sheetName.Replace("/", ""),
                        Text = sheetName,
                        Dock = DockStyle.Fill
                    };
                    newTab.Controls.Add(dg);                    

                    tcMainGrid.TabPages.Add(newTab);
                    tcMainGrid.SelectedTab = newTab;
                }
            }

            MessageBox.Show("Finished searching all files.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
                SearchAllSheets();
        }
    }
}
