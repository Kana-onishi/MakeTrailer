using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeTrailer
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            //input contents from file
            List<string> contentsList = ContentsFileIO.Read();
            if(contentsList == null)
            {
                MessageBox.Show("予告ファイルが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Divide all notices with commas and add them to DateGridView
            foreach (string s in contentsList)
            {
                if(s.IndexOf(',') != -1)
                {
                    string[] c = s.Split(',');
                    dataGridView1.Rows.Add("削除", c[0], c[1], c[2]);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Get the number of rows of DataGridView
            int count = dataGridView1.Rows.Count;

            List<string> contentsList = new List<string>();
            for (int i=0; i<count-1; i++)
            {
                //Add the values in each row to the list by connecting them separated by commas
                string c1 = (string)dataGridView1[1, i].Value;
                string c2 = (string)dataGridView1[2, i].Value;
                string c3 = (string)dataGridView1[3, i].Value;
                contentsList.Add(c1 + ',' + c2 + ',' + c3 + Environment.NewLine);
            }

            //Save the contents of DataGridView
            ContentsFileIO.Write(contentsList);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Confirmation of delete button
            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                //if OK to delete in MessageBox
                if (DialogResult.Yes == MessageBox.Show("本当に削除してもいいですか？",
                    "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //delete
                    try
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    catch(InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
