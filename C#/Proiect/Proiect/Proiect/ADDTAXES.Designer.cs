namespace Proiect
{
    partial class INSERTTAXE
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
            this.txtTaxeID = new System.Windows.Forms.TextBox();
            this.txtVehiculID = new System.Windows.Forms.TextBox();
            this.txtNrInm = new System.Windows.Forms.TextBox();
            this.txtImpozit = new System.Windows.Forms.TextBox();
            this.txtAsigurare = new System.Windows.Forms.TextBox();
            this.txtRovinieta = new System.Windows.Forms.TextBox();
            this.txtCasco = new System.Windows.Forms.TextBox();
            this.txtNumarPref = new System.Windows.Forms.TextBox();
            this.txtRural = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(347, 509);
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
            this.dataGridView1.Location = new System.Drawing.Point(347, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 367);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(447, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.ledger_60px;
            this.pictureBox1.Location = new System.Drawing.Point(432, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtTaxeID
            // 
            this.txtTaxeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTaxeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtTaxeID.Location = new System.Drawing.Point(90, 99);
            this.txtTaxeID.Multiline = true;
            this.txtTaxeID.Name = "txtTaxeID";
            this.txtTaxeID.Size = new System.Drawing.Size(205, 25);
            this.txtTaxeID.TabIndex = 19;
            this.txtTaxeID.Text = "*Taxe ID";
            this.txtTaxeID.Enter += new System.EventHandler(this.txtTaxeID_Enter);
            this.txtTaxeID.Leave += new System.EventHandler(this.txtTaxeID_Leave);
            // 
            // txtVehiculID
            // 
            this.txtVehiculID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehiculID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtVehiculID.ForeColor = System.Drawing.Color.DimGray;
            this.txtVehiculID.Location = new System.Drawing.Point(90, 139);
            this.txtVehiculID.Multiline = true;
            this.txtVehiculID.Name = "txtVehiculID";
            this.txtVehiculID.Size = new System.Drawing.Size(205, 25);
            this.txtVehiculID.TabIndex = 19;
            this.txtVehiculID.TabStop = false;
            this.txtVehiculID.Text = "*Vehicul ID";
            this.txtVehiculID.Enter += new System.EventHandler(this.txtVehiculID_Enter);
            this.txtVehiculID.Leave += new System.EventHandler(this.txtVehiculID_Leave);
            // 
            // txtNrInm
            // 
            this.txtNrInm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrInm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNrInm.ForeColor = System.Drawing.Color.DimGray;
            this.txtNrInm.Location = new System.Drawing.Point(90, 181);
            this.txtNrInm.Multiline = true;
            this.txtNrInm.Name = "txtNrInm";
            this.txtNrInm.Size = new System.Drawing.Size(205, 25);
            this.txtNrInm.TabIndex = 19;
            this.txtNrInm.Text = "*Număr Înmatriculare";
            this.txtNrInm.Enter += new System.EventHandler(this.txtNrInm_Enter);
            this.txtNrInm.Leave += new System.EventHandler(this.txtNrInm_Leave);
            // 
            // txtImpozit
            // 
            this.txtImpozit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtImpozit.ForeColor = System.Drawing.Color.DimGray;
            this.txtImpozit.Location = new System.Drawing.Point(90, 221);
            this.txtImpozit.Multiline = true;
            this.txtImpozit.Name = "txtImpozit";
            this.txtImpozit.Size = new System.Drawing.Size(205, 25);
            this.txtImpozit.TabIndex = 19;
            this.txtImpozit.Text = "*Impozit";
            this.txtImpozit.Enter += new System.EventHandler(this.txtImpozit_Enter);
            this.txtImpozit.Leave += new System.EventHandler(this.txtImpozit_Leave);
            // 
            // txtAsigurare
            // 
            this.txtAsigurare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsigurare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAsigurare.ForeColor = System.Drawing.Color.DimGray;
            this.txtAsigurare.Location = new System.Drawing.Point(90, 261);
            this.txtAsigurare.Multiline = true;
            this.txtAsigurare.Name = "txtAsigurare";
            this.txtAsigurare.Size = new System.Drawing.Size(205, 25);
            this.txtAsigurare.TabIndex = 19;
            this.txtAsigurare.Text = "*Asigurare";
            this.txtAsigurare.Enter += new System.EventHandler(this.txtAsigurare_Enter);
            this.txtAsigurare.Leave += new System.EventHandler(this.txtAsigurare_Leave);
            // 
            // txtRovinieta
            // 
            this.txtRovinieta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRovinieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRovinieta.ForeColor = System.Drawing.Color.DimGray;
            this.txtRovinieta.Location = new System.Drawing.Point(90, 305);
            this.txtRovinieta.Multiline = true;
            this.txtRovinieta.Name = "txtRovinieta";
            this.txtRovinieta.Size = new System.Drawing.Size(205, 25);
            this.txtRovinieta.TabIndex = 19;
            this.txtRovinieta.Text = "Rovinietă";
            this.txtRovinieta.Enter += new System.EventHandler(this.txtRovinieta_Enter);
            this.txtRovinieta.Leave += new System.EventHandler(this.txtRovinieta_Leave);
            // 
            // txtCasco
            // 
            this.txtCasco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCasco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCasco.ForeColor = System.Drawing.Color.DimGray;
            this.txtCasco.Location = new System.Drawing.Point(90, 353);
            this.txtCasco.Multiline = true;
            this.txtCasco.Name = "txtCasco";
            this.txtCasco.Size = new System.Drawing.Size(205, 25);
            this.txtCasco.TabIndex = 19;
            this.txtCasco.Text = "Casco";
            this.txtCasco.Enter += new System.EventHandler(this.txtCasco_Enter);
            this.txtCasco.Leave += new System.EventHandler(this.txtCasco_Leave);
            // 
            // txtNumarPref
            // 
            this.txtNumarPref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumarPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumarPref.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumarPref.Location = new System.Drawing.Point(90, 397);
            this.txtNumarPref.Multiline = true;
            this.txtNumarPref.Name = "txtNumarPref";
            this.txtNumarPref.Size = new System.Drawing.Size(205, 25);
            this.txtNumarPref.TabIndex = 19;
            this.txtNumarPref.Text = "*Număr Preferențial";
            this.txtNumarPref.Enter += new System.EventHandler(this.txtNumarPref_Enter);
            this.txtNumarPref.Leave += new System.EventHandler(this.txtNumarPref_Leave);
            // 
            // txtRural
            // 
            this.txtRural.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRural.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRural.ForeColor = System.Drawing.Color.DimGray;
            this.txtRural.Location = new System.Drawing.Point(90, 441);
            this.txtRural.Multiline = true;
            this.txtRural.Name = "txtRural";
            this.txtRural.Size = new System.Drawing.Size(205, 25);
            this.txtRural.TabIndex = 19;
            this.txtRural.Text = "Rural";
            this.txtRural.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txtRural.Enter += new System.EventHandler(this.txtRural_Enter);
            this.txtRural.Leave += new System.EventHandler(this.txtRural_Leave);
            // 
            // INSERTTAXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 588);
            this.Controls.Add(this.txtRural);
            this.Controls.Add(this.txtNumarPref);
            this.Controls.Add(this.txtCasco);
            this.Controls.Add(this.txtRovinieta);
            this.Controls.Add(this.txtAsigurare);
            this.Controls.Add(this.txtImpozit);
            this.Controls.Add(this.txtNrInm);
            this.Controls.Add(this.txtVehiculID);
            this.Controls.Add(this.txtTaxeID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTTAXE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
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
        private TextBox txtTaxeID;
        private TextBox txtVehiculID;
        private TextBox txtNrInm;
        private TextBox txtImpozit;
        private TextBox txtAsigurare;
        private TextBox txtRovinieta;
        private TextBox txtCasco;
        private TextBox txtNumarPref;
        private TextBox txtRural;
    }
}