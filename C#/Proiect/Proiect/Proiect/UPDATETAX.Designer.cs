namespace Proiect
{
    partial class UPDATETAX
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
            this.txtni = new System.Windows.Forms.TextBox();
            this.txtrov = new System.Windows.Forms.TextBox();
            this.txtAsig = new System.Windows.Forms.TextBox();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.txtnni = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCas = new System.Windows.Forms.TextBox();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtni
            // 
            this.txtni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtni.ForeColor = System.Drawing.Color.DimGray;
            this.txtni.Location = new System.Drawing.Point(63, 120);
            this.txtni.Multiline = true;
            this.txtni.Name = "txtni";
            this.txtni.Size = new System.Drawing.Size(228, 25);
            this.txtni.TabIndex = 29;
            this.txtni.Text = "*Număr Înmatriculare";
            this.txtni.TextChanged += new System.EventHandler(this.txtss_TextChanged);
            this.txtni.Enter += new System.EventHandler(this.txtni_Enter);
            this.txtni.Leave += new System.EventHandler(this.txtni_Leave);
            // 
            // txtrov
            // 
            this.txtrov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtrov.ForeColor = System.Drawing.Color.DimGray;
            this.txtrov.Location = new System.Drawing.Point(63, 297);
            this.txtrov.Multiline = true;
            this.txtrov.Name = "txtrov";
            this.txtrov.Size = new System.Drawing.Size(228, 25);
            this.txtrov.TabIndex = 25;
            this.txtrov.Text = "Rovinietă";
            this.txtrov.Enter += new System.EventHandler(this.txtrov_Enter);
            this.txtrov.Leave += new System.EventHandler(this.txtrov_Leave);
            // 
            // txtAsig
            // 
            this.txtAsig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAsig.ForeColor = System.Drawing.Color.DimGray;
            this.txtAsig.Location = new System.Drawing.Point(63, 251);
            this.txtAsig.Multiline = true;
            this.txtAsig.Name = "txtAsig";
            this.txtAsig.Size = new System.Drawing.Size(228, 25);
            this.txtAsig.TabIndex = 26;
            this.txtAsig.Text = "Asigurare";
            this.txtAsig.Enter += new System.EventHandler(this.txtAsig_Enter);
            this.txtAsig.Leave += new System.EventHandler(this.txtAsig_Leave);
            // 
            // txtImp
            // 
            this.txtImp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtImp.ForeColor = System.Drawing.Color.DimGray;
            this.txtImp.Location = new System.Drawing.Point(63, 207);
            this.txtImp.Multiline = true;
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(228, 25);
            this.txtImp.TabIndex = 27;
            this.txtImp.Text = "Impozit";
            this.txtImp.Enter += new System.EventHandler(this.txtImp_Enter);
            this.txtImp.Leave += new System.EventHandler(this.txtImp_Leave);
            // 
            // txtnni
            // 
            this.txtnni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnni.ForeColor = System.Drawing.Color.DimGray;
            this.txtnni.Location = new System.Drawing.Point(63, 163);
            this.txtnni.Multiline = true;
            this.txtnni.Name = "txtnni";
            this.txtnni.Size = new System.Drawing.Size(228, 25);
            this.txtnni.TabIndex = 28;
            this.txtnni.Text = "Noul Număr de Înmatriculare";
            this.txtnni.Enter += new System.EventHandler(this.txtnni_Enter);
            this.txtnni.Leave += new System.EventHandler(this.txtnni_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.add_to_database_100px;
            this.pictureBox1.Location = new System.Drawing.Point(393, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 33);
            this.button1.TabIndex = 23;
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
            this.dataGridView1.Location = new System.Drawing.Point(366, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(565, 367);
            this.dataGridView1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(430, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCas
            // 
            this.txtCas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCas.ForeColor = System.Drawing.Color.DimGray;
            this.txtCas.Location = new System.Drawing.Point(63, 341);
            this.txtCas.Multiline = true;
            this.txtCas.Name = "txtCas";
            this.txtCas.Size = new System.Drawing.Size(228, 25);
            this.txtCas.TabIndex = 30;
            this.txtCas.Text = "Casco";
            this.txtCas.Enter += new System.EventHandler(this.txtCas_Enter);
            this.txtCas.Leave += new System.EventHandler(this.txtCas_Leave);
            // 
            // txtnp
            // 
            this.txtnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnp.ForeColor = System.Drawing.Color.DimGray;
            this.txtnp.Location = new System.Drawing.Point(63, 385);
            this.txtnp.Multiline = true;
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(228, 25);
            this.txtnp.TabIndex = 31;
            this.txtnp.Text = "Număr Preferențial";
            this.txtnp.Enter += new System.EventHandler(this.txtnp_Enter);
            this.txtnp.Leave += new System.EventHandler(this.txtnp_Leave);
            // 
            // txtr
            // 
            this.txtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtr.ForeColor = System.Drawing.Color.DimGray;
            this.txtr.Location = new System.Drawing.Point(63, 433);
            this.txtr.Multiline = true;
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(228, 25);
            this.txtr.TabIndex = 32;
            this.txtr.Text = "Rural";
            this.txtr.Enter += new System.EventHandler(this.txtr_Enter);
            this.txtr.Leave += new System.EventHandler(this.txtr_Leave);
            // 
            // UPDATETAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 598);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.txtCas);
            this.Controls.Add(this.txtni);
            this.Controls.Add(this.txtrov);
            this.Controls.Add(this.txtAsig);
            this.Controls.Add(this.txtImp);
            this.Controls.Add(this.txtnni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPDATETAX";
            this.Text = "UPDATETAX";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtni;
        private TextBox txtrov;
        private TextBox txtAsig;
        private TextBox txtImp;
        private TextBox txtnni;
        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtCas;
        private TextBox txtnp;
        private TextBox txtr;
    }
}