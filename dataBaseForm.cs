﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Trials_Script_Launcher
{
    public partial class dataBaseForm : Form
    {
        private string _dataBaseFormText;
        public dataBaseForm(string dataBaseFormText)
        {
            InitializeComponent();
            _dataBaseFormText = dataBaseFormText;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cheklistSaveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                // Set the initial directory and default file name
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Sets default dir as user documents
                sfd.FileName = "STCM_Department_Checklist.csv"; // Set a default file name
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                // User made a selection
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers to CSV file
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(dataGridView1.Columns[i].HeaderText);
                            if (i < dataGridView1.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Write data to CSV file
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // Skip the new row placeholder
                            if (row.IsNewRow) continue;

                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < row.Cells.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                }
                // else display error message
                else
                {
                    MessageBox.Show("No file was selected to save table entries");
                }
            }
        }

        private void loadCKLBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Set the initial directory to the user's Documents folder
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // Set the default filename to STCM_Department_Checklist.csv
                ofd.FileName = "STCM_Department_Checklist.csv";
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                // User made a selection
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line;

                        // Clear existing columns and rows
                        dataGridView1.Columns.Clear();
                        dataGridView1.Rows.Clear();

                        string[] headers = sr.ReadLine().Split(',');
                        foreach (string header in headers)
                        {
                            dataGridView1.Columns.Add(header, header);
                        }

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] rows = line.Split(',');
                            dataGridView1.Rows.Add(rows);
                        }
                    }
                }
                // else display an error message
                else
                {
                    MessageBox.Show("No file selected.");
                }
            }
        }
        private void Checklist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //Check if user is closing the form
            {
                //Prompt to save work
                DialogResult result = MessageBox.Show("Please save any new data before closing the form.\nDo you want to close the form?", "Close Form", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                //if user selects No
                if (result == DialogResult.No)
                {
                    //Stop form closing
                    e.Cancel = true;
                }
            }
        }
    }
}
