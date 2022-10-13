namespace Proiect
{
    partial class INSERTVEH
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
            this.txtCompanieID = new System.Windows.Forms.TextBox();
            this.txtPersoanaID = new System.Windows.Forms.TextBox();
            this.txtTipVeh = new System.Windows.Forms.TextBox();
            this.txtSerieSas = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCombustibil = new System.Windows.Forms.TextBox();
            this.txtCapacCil = new System.Windows.Forms.TextBox();
            this.txtPutere = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtNoxe = new System.Windows.Forms.TextBox();
            this.txtNumarLoc = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtVehiculID = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(353, 527);
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
            this.dataGridView1.Location = new System.Drawing.Point(286, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(612, 397);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(447, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.Add_car_48px;
            this.pictureBox1.Location = new System.Drawing.Point(447, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtCompanieID
            // 
            this.txtCompanieID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCompanieID.ForeColor = System.Drawing.Color.DimGray;
            this.txtCompanieID.Location = new System.Drawing.Point(55, 88);
            this.txtCompanieID.Multiline = true;
            this.txtCompanieID.Name = "txtCompanieID";
            this.txtCompanieID.Size = new System.Drawing.Size(205, 25);
            this.txtCompanieID.TabIndex = 19;
            this.txtCompanieID.Text = "Companie ID";
            this.txtCompanieID.Enter += new System.EventHandler(this.txtCompanieID_Enter);
            this.txtCompanieID.Leave += new System.EventHandler(this.txtCompanieID_Leave);
            // 
            // txtPersoanaID
            // 
            this.txtPersoanaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersoanaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPersoanaID.ForeColor = System.Drawing.Color.DimGray;
            this.txtPersoanaID.Location = new System.Drawing.Point(55, 119);
            this.txtPersoanaID.Multiline = true;
            this.txtPersoanaID.Name = "txtPersoanaID";
            this.txtPersoanaID.Size = new System.Drawing.Size(205, 25);
            this.txtPersoanaID.TabIndex = 19;
            this.txtPersoanaID.Text = "Persoana ID";
            this.txtPersoanaID.Enter += new System.EventHandler(this.txtPersoanaID_Enter);
            this.txtPersoanaID.Leave += new System.EventHandler(this.txtPersoanaID_Leave);
            // 
            // txtTipVeh
            // 
            this.txtTipVeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTipVeh.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipVeh.Location = new System.Drawing.Point(55, 150);
            this.txtTipVeh.Multiline = true;
            this.txtTipVeh.Name = "txtTipVeh";
            this.txtTipVeh.Size = new System.Drawing.Size(205, 25);
            this.txtTipVeh.TabIndex = 19;
            this.txtTipVeh.Text = "*Tip Vehicul";
            this.txtTipVeh.Enter += new System.EventHandler(this.txtTipVeh_Enter);
            this.txtTipVeh.Leave += new System.EventHandler(this.txtTipVeh_Leave);
            // 
            // txtSerieSas
            // 
            this.txtSerieSas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerieSas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSerieSas.ForeColor = System.Drawing.Color.DimGray;
            this.txtSerieSas.Location = new System.Drawing.Point(55, 181);
            this.txtSerieSas.Multiline = true;
            this.txtSerieSas.Name = "txtSerieSas";
            this.txtSerieSas.Size = new System.Drawing.Size(205, 25);
            this.txtSerieSas.TabIndex = 19;
            this.txtSerieSas.Text = "*Serie Șasiu";
            this.txtSerieSas.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtSerieSas.Enter += new System.EventHandler(this.txtSerieSas_Enter);
            this.txtSerieSas.Leave += new System.EventHandler(this.txtSerieSas_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.ForeColor = System.Drawing.Color.DimGray;
            this.txtMarca.Location = new System.Drawing.Point(55, 212);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(205, 25);
            this.txtMarca.TabIndex = 19;
            this.txtMarca.Text = "*Marca";
            this.txtMarca.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtCombustibil
            // 
            this.txtCombustibil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCombustibil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCombustibil.ForeColor = System.Drawing.Color.DimGray;
            this.txtCombustibil.Location = new System.Drawing.Point(55, 274);
            this.txtCombustibil.Multiline = true;
            this.txtCombustibil.Name = "txtCombustibil";
            this.txtCombustibil.Size = new System.Drawing.Size(205, 25);
            this.txtCombustibil.TabIndex = 19;
            this.txtCombustibil.Text = "*Combustibil";
            this.txtCombustibil.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtCombustibil.Enter += new System.EventHandler(this.txtCombustibil_Enter);
            this.txtCombustibil.Leave += new System.EventHandler(this.txtCombustibil_Leave);
            // 
            // txtCapacCil
            // 
            this.txtCapacCil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacCil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCapacCil.ForeColor = System.Drawing.Color.DimGray;
            this.txtCapacCil.Location = new System.Drawing.Point(55, 305);
            this.txtCapacCil.Multiline = true;
            this.txtCapacCil.Name = "txtCapacCil";
            this.txtCapacCil.Size = new System.Drawing.Size(205, 25);
            this.txtCapacCil.TabIndex = 19;
            this.txtCapacCil.Text = "*Capacitate Cilindrică";
            this.txtCapacCil.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtCapacCil.Enter += new System.EventHandler(this.txtCapacCil_Enter);
            this.txtCapacCil.Leave += new System.EventHandler(this.txtCapacCil_Leave);
            // 
            // txtPutere
            // 
            this.txtPutere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPutere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPutere.ForeColor = System.Drawing.Color.DimGray;
            this.txtPutere.Location = new System.Drawing.Point(55, 336);
            this.txtPutere.Multiline = true;
            this.txtPutere.Name = "txtPutere";
            this.txtPutere.Size = new System.Drawing.Size(205, 25);
            this.txtPutere.TabIndex = 19;
            this.txtPutere.Text = "*Putere";
            this.txtPutere.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtPutere.Enter += new System.EventHandler(this.txtPutere_Enter);
            this.txtPutere.Leave += new System.EventHandler(this.txtPutere_Leave);
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtModel.ForeColor = System.Drawing.Color.DimGray;
            this.txtModel.Location = new System.Drawing.Point(55, 243);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(205, 25);
            this.txtModel.TabIndex = 19;
            this.txtModel.Text = "*Model";
            this.txtModel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtModel.Enter += new System.EventHandler(this.txtModel_Enter);
            this.txtModel.Leave += new System.EventHandler(this.txtModel_Leave);
            // 
            // txtAn
            // 
            this.txtAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAn.ForeColor = System.Drawing.Color.DimGray;
            this.txtAn.Location = new System.Drawing.Point(55, 367);
            this.txtAn.Multiline = true;
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(205, 25);
            this.txtAn.TabIndex = 19;
            this.txtAn.Text = "*An Fabricație";
            this.txtAn.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtAn.Enter += new System.EventHandler(this.txtAn_Enter);
            this.txtAn.Leave += new System.EventHandler(this.txtAn_Leave);
            // 
            // txtMasa
            // 
            this.txtMasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMasa.ForeColor = System.Drawing.Color.DimGray;
            this.txtMasa.Location = new System.Drawing.Point(55, 398);
            this.txtMasa.Multiline = true;
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(205, 25);
            this.txtMasa.TabIndex = 19;
            this.txtMasa.Text = "*Masă Totală";
            this.txtMasa.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtMasa.Enter += new System.EventHandler(this.txtMasa_Enter);
            this.txtMasa.Leave += new System.EventHandler(this.txtMasa_Leave);
            // 
            // txtNoxe
            // 
            this.txtNoxe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoxe.ForeColor = System.Drawing.Color.DimGray;
            this.txtNoxe.Location = new System.Drawing.Point(55, 429);
            this.txtNoxe.Multiline = true;
            this.txtNoxe.Name = "txtNoxe";
            this.txtNoxe.Size = new System.Drawing.Size(205, 25);
            this.txtNoxe.TabIndex = 19;
            this.txtNoxe.Text = "*Noxe";
            this.txtNoxe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtNoxe.Enter += new System.EventHandler(this.txtNoxe_Enter);
            this.txtNoxe.Leave += new System.EventHandler(this.txtNoxe_Leave);
            // 
            // txtNumarLoc
            // 
            this.txtNumarLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumarLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumarLoc.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumarLoc.Location = new System.Drawing.Point(55, 460);
            this.txtNumarLoc.Multiline = true;
            this.txtNumarLoc.Name = "txtNumarLoc";
            this.txtNumarLoc.Size = new System.Drawing.Size(205, 25);
            this.txtNumarLoc.TabIndex = 19;
            this.txtNumarLoc.Text = "*Număr Locuri";
            this.txtNumarLoc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtNumarLoc.Enter += new System.EventHandler(this.txtNumarLoc_Enter);
            this.txtNumarLoc.Leave += new System.EventHandler(this.txtNumarLoc_Leave);
            // 
            // txtCuloare
            // 
            this.txtCuloare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuloare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCuloare.ForeColor = System.Drawing.Color.DimGray;
            this.txtCuloare.Location = new System.Drawing.Point(55, 491);
            this.txtCuloare.Multiline = true;
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(205, 25);
            this.txtCuloare.TabIndex = 19;
            this.txtCuloare.Text = "Culoare";
            this.txtCuloare.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtCuloare.Enter += new System.EventHandler(this.txtCuloare_Enter);
            this.txtCuloare.Leave += new System.EventHandler(this.txtCuloare_Leave);
            // 
            // txtVehiculID
            // 
            this.txtVehiculID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehiculID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtVehiculID.ForeColor = System.Drawing.Color.DimGray;
            this.txtVehiculID.Location = new System.Drawing.Point(55, 57);
            this.txtVehiculID.Multiline = true;
            this.txtVehiculID.Name = "txtVehiculID";
            this.txtVehiculID.Size = new System.Drawing.Size(205, 25);
            this.txtVehiculID.TabIndex = 19;
            this.txtVehiculID.Text = "*Vehicul ID";
            this.txtVehiculID.Enter += new System.EventHandler(this.txtVehiculID_Enter);
            this.txtVehiculID.Leave += new System.EventHandler(this.txtVehiculID_Leave);
            // 
            // INSERTVEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 599);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.txtNumarLoc);
            this.Controls.Add(this.txtNoxe);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtPutere);
            this.Controls.Add(this.txtCapacCil);
            this.Controls.Add(this.txtCombustibil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtSerieSas);
            this.Controls.Add(this.txtTipVeh);
            this.Controls.Add(this.txtPersoanaID);
            this.Controls.Add(this.txtVehiculID);
            this.Controls.Add(this.txtCompanieID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTVEH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
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
        private TextBox txtCompanieID;
        private TextBox txtPersoanaID;
        private TextBox txtTipVeh;
        private TextBox txtSerieSas;
        private TextBox txtMarca;
        private TextBox txtCombustibil;
        private TextBox txtCapacCil;
        private TextBox txtPutere;
        private TextBox txtModel;
        private TextBox txtAn;
        private TextBox txtMasa;
        private TextBox txtNoxe;
        private TextBox txtNumarLoc;
        private TextBox txtCuloare;
        private TextBox txtVehiculID;
    }
}