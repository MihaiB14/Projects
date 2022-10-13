namespace Proiect
{
    partial class INSERTCOMP
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCompanieID = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCodFiscal = new System.Windows.Forms.TextBox();
            this.txtNumarInreg = new System.Windows.Forms.TextBox();
            this.txtDataInfiint = new System.Windows.Forms.TextBox();
            this.txtStrada = new System.Windows.Forms.TextBox();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.txtOras = new System.Windows.Forms.TextBox();
            this.txtJudetSector = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(478, 651);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 367);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(381, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.add_graph_report_60px;
            this.pictureBox1.Location = new System.Drawing.Point(460, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 70);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtCompanieID
            // 
            this.txtCompanieID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCompanieID.ForeColor = System.Drawing.Color.DimGray;
            this.txtCompanieID.Location = new System.Drawing.Point(50, 164);
            this.txtCompanieID.Multiline = true;
            this.txtCompanieID.Name = "txtCompanieID";
            this.txtCompanieID.Size = new System.Drawing.Size(205, 25);
            this.txtCompanieID.TabIndex = 16;
            this.txtCompanieID.Text = "*Companie ID";
            this.txtCompanieID.TextChanged += new System.EventHandler(this.txtCompanieID_TextChanged);
            this.txtCompanieID.Enter += new System.EventHandler(this.txtCompanieID_Enter);
            this.txtCompanieID.Leave += new System.EventHandler(this.txtCompanieID_Leave);
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNume.ForeColor = System.Drawing.Color.DimGray;
            this.txtNume.Location = new System.Drawing.Point(50, 195);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(205, 25);
            this.txtNume.TabIndex = 16;
            this.txtNume.Text = "*Nume";
            this.txtNume.Enter += new System.EventHandler(this.txtNume_Enter);
            this.txtNume.Leave += new System.EventHandler(this.txtNume_Leave);
            // 
            // txtCodFiscal
            // 
            this.txtCodFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodFiscal.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodFiscal.Location = new System.Drawing.Point(50, 226);
            this.txtCodFiscal.Multiline = true;
            this.txtCodFiscal.Name = "txtCodFiscal";
            this.txtCodFiscal.Size = new System.Drawing.Size(205, 25);
            this.txtCodFiscal.TabIndex = 16;
            this.txtCodFiscal.Text = "*Cod Fiscal";
            this.txtCodFiscal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtCodFiscal.Enter += new System.EventHandler(this.txtCodFiscal_Enter);
            this.txtCodFiscal.Leave += new System.EventHandler(this.txtCodFiscal_Leave);
            // 
            // txtNumarInreg
            // 
            this.txtNumarInreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumarInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumarInreg.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumarInreg.Location = new System.Drawing.Point(50, 257);
            this.txtNumarInreg.Multiline = true;
            this.txtNumarInreg.Name = "txtNumarInreg";
            this.txtNumarInreg.Size = new System.Drawing.Size(205, 25);
            this.txtNumarInreg.TabIndex = 16;
            this.txtNumarInreg.Text = "*Număr Înregistrare";
            this.txtNumarInreg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtNumarInreg.Enter += new System.EventHandler(this.txtNumarInreg_Enter);
            this.txtNumarInreg.Leave += new System.EventHandler(this.txtNumarInreg_Leave);
            // 
            // txtDataInfiint
            // 
            this.txtDataInfiint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataInfiint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDataInfiint.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataInfiint.Location = new System.Drawing.Point(50, 288);
            this.txtDataInfiint.Multiline = true;
            this.txtDataInfiint.Name = "txtDataInfiint";
            this.txtDataInfiint.Size = new System.Drawing.Size(205, 25);
            this.txtDataInfiint.TabIndex = 16;
            this.txtDataInfiint.Text = "*Data Înființării";
            this.txtDataInfiint.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtDataInfiint.Enter += new System.EventHandler(this.txtDataInfiint_Enter);
            this.txtDataInfiint.Leave += new System.EventHandler(this.txtDataInfiint_Leave);
            // 
            // txtStrada
            // 
            this.txtStrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStrada.ForeColor = System.Drawing.Color.DimGray;
            this.txtStrada.Location = new System.Drawing.Point(50, 319);
            this.txtStrada.Multiline = true;
            this.txtStrada.Name = "txtStrada";
            this.txtStrada.Size = new System.Drawing.Size(205, 25);
            this.txtStrada.TabIndex = 16;
            this.txtStrada.Text = "*Strada";
            this.txtStrada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtStrada.Enter += new System.EventHandler(this.txtStrada_Enter);
            this.txtStrada.Leave += new System.EventHandler(this.txtStrada_Leave);
            // 
            // txtNumar
            // 
            this.txtNumar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumar.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumar.Location = new System.Drawing.Point(50, 350);
            this.txtNumar.Multiline = true;
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(205, 25);
            this.txtNumar.TabIndex = 16;
            this.txtNumar.Text = "*Număr";
            this.txtNumar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtNumar.Enter += new System.EventHandler(this.txtNumar_Enter);
            this.txtNumar.Leave += new System.EventHandler(this.txtNumar_Leave);
            // 
            // txtOras
            // 
            this.txtOras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOras.ForeColor = System.Drawing.Color.DimGray;
            this.txtOras.Location = new System.Drawing.Point(50, 381);
            this.txtOras.Multiline = true;
            this.txtOras.Name = "txtOras";
            this.txtOras.Size = new System.Drawing.Size(205, 25);
            this.txtOras.TabIndex = 16;
            this.txtOras.Text = "*Oraș";
            this.txtOras.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtOras.Enter += new System.EventHandler(this.txtOras_Enter);
            this.txtOras.Leave += new System.EventHandler(this.txtOras_Leave);
            // 
            // txtJudetSector
            // 
            this.txtJudetSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJudetSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJudetSector.ForeColor = System.Drawing.Color.DimGray;
            this.txtJudetSector.Location = new System.Drawing.Point(50, 412);
            this.txtJudetSector.Multiline = true;
            this.txtJudetSector.Name = "txtJudetSector";
            this.txtJudetSector.Size = new System.Drawing.Size(205, 25);
            this.txtJudetSector.TabIndex = 16;
            this.txtJudetSector.Text = "Județ / Sector";
            this.txtJudetSector.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtJudetSector.Enter += new System.EventHandler(this.txtJudetSector_Enter);
            this.txtJudetSector.Leave += new System.EventHandler(this.txtJudetSector_Leave);
            // 
            // txtDirector
            // 
            this.txtDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDirector.ForeColor = System.Drawing.Color.DimGray;
            this.txtDirector.Location = new System.Drawing.Point(50, 443);
            this.txtDirector.Multiline = true;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(205, 25);
            this.txtDirector.TabIndex = 16;
            this.txtDirector.Text = "*Director";
            this.txtDirector.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtDirector.Enter += new System.EventHandler(this.txtDirector_Enter);
            this.txtDirector.Leave += new System.EventHandler(this.txtDirector_Leave);
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContact.ForeColor = System.Drawing.Color.DimGray;
            this.txtContact.Location = new System.Drawing.Point(50, 474);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(205, 25);
            this.txtContact.TabIndex = 16;
            this.txtContact.Text = "Contact";
            this.txtContact.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtContact.Enter += new System.EventHandler(this.txtContact_Enter);
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // INSERTCOMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 676);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtJudetSector);
            this.Controls.Add(this.txtOras);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.txtStrada);
            this.Controls.Add(this.txtDataInfiint);
            this.Controls.Add(this.txtNumarInreg);
            this.Controls.Add(this.txtCodFiscal);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCompanieID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTCOMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERTCOMP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox txtCompanieID;
        private TextBox txtNume;
        private TextBox txtCodFiscal;
        private TextBox txtNumarInreg;
        private TextBox txtDataInfiint;
        private TextBox txtStrada;
        private TextBox txtNumar;
        private TextBox txtOras;
        private TextBox txtJudetSector;
        private TextBox txtDirector;
        private TextBox txtContact;
    }
}