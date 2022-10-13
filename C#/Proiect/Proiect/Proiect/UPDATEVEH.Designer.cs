namespace Proiect
{
    partial class UPDATEVEH
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
            this.txtTipVeh = new System.Windows.Forms.TextBox();
            this.txtComb = new System.Windows.Forms.TextBox();
            this.txtNrLoc = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtss = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(357, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "UPDATE";
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
            this.dataGridView1.Location = new System.Drawing.Point(390, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(565, 367);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(454, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.add_to_database_100px;
            this.pictureBox1.Location = new System.Drawing.Point(417, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtTipVeh
            // 
            this.txtTipVeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTipVeh.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipVeh.Location = new System.Drawing.Point(87, 269);
            this.txtTipVeh.Multiline = true;
            this.txtTipVeh.Name = "txtTipVeh";
            this.txtTipVeh.Size = new System.Drawing.Size(205, 25);
            this.txtTipVeh.TabIndex = 19;
            this.txtTipVeh.Text = "Tip Vehicul";
            this.txtTipVeh.Enter += new System.EventHandler(this.txtTipVeh_Enter);
            this.txtTipVeh.Leave += new System.EventHandler(this.txtTipVeh_Leave_1);
            // 
            // txtComb
            // 
            this.txtComb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtComb.ForeColor = System.Drawing.Color.DimGray;
            this.txtComb.Location = new System.Drawing.Point(87, 329);
            this.txtComb.Multiline = true;
            this.txtComb.Name = "txtComb";
            this.txtComb.Size = new System.Drawing.Size(205, 25);
            this.txtComb.TabIndex = 19;
            this.txtComb.Text = "Combustibil";
            this.txtComb.Enter += new System.EventHandler(this.txtComb_Enter);
            this.txtComb.Leave += new System.EventHandler(this.txtComb_Leave);
            // 
            // txtNrLoc
            // 
            this.txtNrLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNrLoc.ForeColor = System.Drawing.Color.DimGray;
            this.txtNrLoc.Location = new System.Drawing.Point(87, 384);
            this.txtNrLoc.Multiline = true;
            this.txtNrLoc.Name = "txtNrLoc";
            this.txtNrLoc.Size = new System.Drawing.Size(205, 25);
            this.txtNrLoc.TabIndex = 19;
            this.txtNrLoc.Text = "Număr Locuri";
            this.txtNrLoc.Enter += new System.EventHandler(this.txtNrLoc_Enter);
            this.txtNrLoc.Leave += new System.EventHandler(this.txtNrLoc_Leave);
            // 
            // txtCuloare
            // 
            this.txtCuloare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuloare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCuloare.ForeColor = System.Drawing.Color.DimGray;
            this.txtCuloare.Location = new System.Drawing.Point(87, 438);
            this.txtCuloare.Multiline = true;
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(205, 25);
            this.txtCuloare.TabIndex = 19;
            this.txtCuloare.Text = "Culoare";
            this.txtCuloare.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCuloare.Leave += new System.EventHandler(this.txtCuloare_Leave);
            // 
            // txtss
            // 
            this.txtss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtss.ForeColor = System.Drawing.Color.DimGray;
            this.txtss.Location = new System.Drawing.Point(87, 213);
            this.txtss.Multiline = true;
            this.txtss.Name = "txtss";
            this.txtss.Size = new System.Drawing.Size(205, 25);
            this.txtss.TabIndex = 20;
            this.txtss.Text = "*Serie Șasiu";
            this.txtss.Enter += new System.EventHandler(this.txtss_Enter_1);
            this.txtss.Leave += new System.EventHandler(this.txtss_Leave);
            // 
            // UPDATEVEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 637);
            this.Controls.Add(this.txtss);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.txtNrLoc);
            this.Controls.Add(this.txtComb);
            this.Controls.Add(this.txtTipVeh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPDATEVEH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATEVEH";
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
        private TextBox txtTipVeh;
        private TextBox txtComb;
        private TextBox txtNrLoc;
        private TextBox txtCuloare;
        private TextBox txtss;
    }
}