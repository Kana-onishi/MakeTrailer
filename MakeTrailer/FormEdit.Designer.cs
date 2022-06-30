namespace MakeTrailer
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Content1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButton,
            this.Content1,
            this.Content2,
            this.Content3});
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(702, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "削除";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Text = "削除";
            this.DeleteButton.Width = 70;
            // 
            // Content1
            // 
            this.Content1.HeaderText = "内容1";
            this.Content1.Name = "Content1";
            this.Content1.Width = 350;
            // 
            // Content2
            // 
            this.Content2.HeaderText = "内容2";
            this.Content2.Name = "Content2";
            this.Content2.Width = 120;
            // 
            // Content3
            // 
            this.Content3.HeaderText = "内容3";
            this.Content3.Name = "Content3";
            this.Content3.Width = 120;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(316, 183);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(67, 19);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(389, 183);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(66, 19);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 214);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEdit";
            this.Text = "予告の追加・編集・削除";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}