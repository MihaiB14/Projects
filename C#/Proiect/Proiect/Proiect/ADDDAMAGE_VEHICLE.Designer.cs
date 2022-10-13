namespace Proiect
{
    partial class INSERTVEHDAUN
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVehiculID = new System.Windows.Forms.TextBox();
            this.txtDauneID = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(354, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 347);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(452, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.car_insurance_52px;
            this.pictureBox1.Location = new System.Drawing.Point(452, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtVehiculID
            // 
            this.txtVehiculID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehiculID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtVehiculID.ForeColor = System.Drawing.Color.DimGray;
            this.txtVehiculID.Location = new System.Drawing.Point(78, 205);
            this.txtVehiculID.Multiline = true;
            this.txtVehiculID.Name = "txtVehiculID";
            this.txtVehiculID.Size = new System.Drawing.Size(205, 25);
            this.txtVehiculID.TabIndex = 19;
            this.txtVehiculID.Text = "*Vehicul ID";
            this.txtVehiculID.Enter += new System.EventHandler(this.txtVehiculID_Enter);
            this.txtVehiculID.Leave += new System.EventHandler(this.txtVehiculID_Leave);
            // 
            // txtDauneID
            // 
            this.txtDauneID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDauneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDauneID.ForeColor = System.Drawing.Color.DimGray;
            this.txtDauneID.Location = new System.Drawing.Point(78, 280);
            this.txtDauneID.Multiline = true;
            this.txtDauneID.Name = "txtDauneID";
            this.txtDauneID.Size = new System.Drawing.Size(205, 25);
            this.txtDauneID.TabIndex = 19;
            this.txtDauneID.Text = "*Daune ID";
            this.txtDauneID.Enter += new System.EventHandler(this.txtDauneID_Enter);
            this.txtDauneID.Leave += new System.EventHandler(this.txtDauneID_Leave);
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.DimGray;
            this.txtData.Location = new System.Drawing.Point(78, 357);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(205, 25);
            this.txtData.TabIndex = 19;
            this.txtData.Text = "*Data";
            this.txtData.Enter += new System.EventHandler(this.txtData_Enter);
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // INSERTVEHDAUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 588);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtDauneID);
            this.Controls.Add(this.txtVehiculID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTVEHDAUN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtVehiculID;
        private TextBox txtDauneID;
        private TextBox txtData;
    }
}