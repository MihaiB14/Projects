namespace Proiect
{
    partial class INSERTPERS
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
            this.txtPersoanaID = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtStrada = new System.Windows.Forms.TextBox();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.txtOras = new System.Windows.Forms.TextBox();
            this.txtJudetSec = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.button1.Location = new System.Drawing.Point(364, 509);
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
            this.dataGridView1.Location = new System.Drawing.Point(326, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 400);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(460, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPersoanaID
            // 
            this.txtPersoanaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersoanaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPersoanaID.ForeColor = System.Drawing.Color.DimGray;
            this.txtPersoanaID.Location = new System.Drawing.Point(54, 86);
            this.txtPersoanaID.Multiline = true;
            this.txtPersoanaID.Name = "txtPersoanaID";
            this.txtPersoanaID.Size = new System.Drawing.Size(205, 25);
            this.txtPersoanaID.TabIndex = 18;
            this.txtPersoanaID.Text = "*Persoană ID";
            this.txtPersoanaID.Enter += new System.EventHandler(this.txtPersoanaID_Enter);
            this.txtPersoanaID.Leave += new System.EventHandler(this.txtPersoanaID_Leave);
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNume.ForeColor = System.Drawing.Color.DimGray;
            this.txtNume.Location = new System.Drawing.Point(54, 134);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(205, 25);
            this.txtNume.TabIndex = 18;
            this.txtNume.Text = "*Nume";
            this.txtNume.Enter += new System.EventHandler(this.txtNume_Enter);
            this.txtNume.Leave += new System.EventHandler(this.txtNume_Leave);
            // 
            // txtPrenume
            // 
            this.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrenume.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrenume.Location = new System.Drawing.Point(54, 175);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(205, 25);
            this.txtPrenume.TabIndex = 18;
            this.txtPrenume.Text = "*Prenume";
            this.txtPrenume.Enter += new System.EventHandler(this.textPrenume_Enter);
            this.txtPrenume.Leave += new System.EventHandler(this.txtPrenume_Leave);
            // 
            // txtCNP
            // 
            this.txtCNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCNP.ForeColor = System.Drawing.Color.DimGray;
            this.txtCNP.Location = new System.Drawing.Point(54, 223);
            this.txtCNP.Multiline = true;
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(205, 25);
            this.txtCNP.TabIndex = 18;
            this.txtCNP.Text = "*CNP";
            this.txtCNP.Enter += new System.EventHandler(this.txtCNP_Enter);
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // txtStrada
            // 
            this.txtStrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStrada.ForeColor = System.Drawing.Color.DimGray;
            this.txtStrada.Location = new System.Drawing.Point(54, 271);
            this.txtStrada.Multiline = true;
            this.txtStrada.Name = "txtStrada";
            this.txtStrada.Size = new System.Drawing.Size(205, 25);
            this.txtStrada.TabIndex = 18;
            this.txtStrada.Text = "*Strada";
            this.txtStrada.Enter += new System.EventHandler(this.txtStrada_Enter);
            this.txtStrada.Leave += new System.EventHandler(this.txtStrada_Leave);
            // 
            // txtNumar
            // 
            this.txtNumar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumar.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumar.Location = new System.Drawing.Point(54, 318);
            this.txtNumar.Multiline = true;
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(205, 25);
            this.txtNumar.TabIndex = 18;
            this.txtNumar.Text = "*Număr";
            this.txtNumar.Enter += new System.EventHandler(this.txtNumar_Enter);
            this.txtNumar.Leave += new System.EventHandler(this.txtNumar_Leave);
            // 
            // txtOras
            // 
            this.txtOras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOras.ForeColor = System.Drawing.Color.DimGray;
            this.txtOras.Location = new System.Drawing.Point(54, 368);
            this.txtOras.Multiline = true;
            this.txtOras.Name = "txtOras";
            this.txtOras.Size = new System.Drawing.Size(205, 25);
            this.txtOras.TabIndex = 18;
            this.txtOras.Text = "*Oraș";
            this.txtOras.Enter += new System.EventHandler(this.txtOras_Enter);
            this.txtOras.Leave += new System.EventHandler(this.txtOras_Leave);
            // 
            // txtJudetSec
            // 
            this.txtJudetSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJudetSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJudetSec.ForeColor = System.Drawing.Color.DimGray;
            this.txtJudetSec.Location = new System.Drawing.Point(54, 415);
            this.txtJudetSec.Multiline = true;
            this.txtJudetSec.Name = "txtJudetSec";
            this.txtJudetSec.Size = new System.Drawing.Size(205, 25);
            this.txtJudetSec.TabIndex = 18;
            this.txtJudetSec.Text = "Județ / Sector";
            this.txtJudetSec.Enter += new System.EventHandler(this.textBox7_Enter);
            this.txtJudetSec.Leave += new System.EventHandler(this.txtJudetSec_Leave);
            // 
            // txtSex
            // 
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSex.ForeColor = System.Drawing.Color.DimGray;
            this.txtSex.Location = new System.Drawing.Point(54, 461);
            this.txtSex.Multiline = true;
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(205, 25);
            this.txtSex.TabIndex = 18;
            this.txtSex.Text = "*Sex";
            this.txtSex.Enter += new System.EventHandler(this.txtSex_Enter);
            this.txtSex.Leave += new System.EventHandler(this.txtSex_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.add_male_user_128px;
            this.pictureBox1.Location = new System.Drawing.Point(430, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // INSERTPERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtJudetSec);
            this.Controls.Add(this.txtOras);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.txtStrada);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPersoanaID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTPERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtPersoanaID;
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtCNP;
        private TextBox txtStrada;
        private TextBox txtNumar;
        private TextBox txtOras;
        private TextBox txtJudetSec;
        private TextBox txtSex;
        private PictureBox pictureBox1;
    }
}