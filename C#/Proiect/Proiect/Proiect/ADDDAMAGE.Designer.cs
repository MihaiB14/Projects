namespace Proiect
{
    partial class INSERTDAUN
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
            this.txtDauneID = new System.Windows.Forms.TextBox();
            this.txtFrontal = new System.Windows.Forms.TextBox();
            this.txtLateralDr = new System.Windows.Forms.TextBox();
            this.txtLateralSt = new System.Windows.Forms.TextBox();
            this.txtPosterior = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(305, 498);
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
            this.dataGridView1.Location = new System.Drawing.Point(292, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(499, 302);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(398, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect.Properties.Resources.traffic_accident_48px;
            this.pictureBox1.Location = new System.Drawing.Point(387, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 51);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtDauneID
            // 
            this.txtDauneID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDauneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDauneID.ForeColor = System.Drawing.Color.DimGray;
            this.txtDauneID.Location = new System.Drawing.Point(46, 173);
            this.txtDauneID.Multiline = true;
            this.txtDauneID.Name = "txtDauneID";
            this.txtDauneID.Size = new System.Drawing.Size(205, 25);
            this.txtDauneID.TabIndex = 20;
            this.txtDauneID.Text = "*Daune ID";
            this.txtDauneID.Enter += new System.EventHandler(this.txtDauneID_Enter);
            this.txtDauneID.Leave += new System.EventHandler(this.txtDauneID_Leave);
            // 
            // txtFrontal
            // 
            this.txtFrontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFrontal.ForeColor = System.Drawing.Color.DimGray;
            this.txtFrontal.Location = new System.Drawing.Point(46, 226);
            this.txtFrontal.Multiline = true;
            this.txtFrontal.Name = "txtFrontal";
            this.txtFrontal.Size = new System.Drawing.Size(205, 25);
            this.txtFrontal.TabIndex = 20;
            this.txtFrontal.Text = "Frontal";
            this.txtFrontal.Enter += new System.EventHandler(this.txtFrontal_Enter);
            this.txtFrontal.Leave += new System.EventHandler(this.txtFrontal_Leave);
            // 
            // txtLateralDr
            // 
            this.txtLateralDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLateralDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLateralDr.ForeColor = System.Drawing.Color.DimGray;
            this.txtLateralDr.Location = new System.Drawing.Point(46, 282);
            this.txtLateralDr.Multiline = true;
            this.txtLateralDr.Name = "txtLateralDr";
            this.txtLateralDr.Size = new System.Drawing.Size(205, 25);
            this.txtLateralDr.TabIndex = 20;
            this.txtLateralDr.Text = "Lateral Dreapta";
            this.txtLateralDr.Enter += new System.EventHandler(this.txtLateralDr_Enter);
            this.txtLateralDr.Leave += new System.EventHandler(this.txtLateralDr_Leave);
            // 
            // txtLateralSt
            // 
            this.txtLateralSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLateralSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLateralSt.ForeColor = System.Drawing.Color.DimGray;
            this.txtLateralSt.Location = new System.Drawing.Point(46, 337);
            this.txtLateralSt.Multiline = true;
            this.txtLateralSt.Name = "txtLateralSt";
            this.txtLateralSt.Size = new System.Drawing.Size(205, 25);
            this.txtLateralSt.TabIndex = 20;
            this.txtLateralSt.Text = "Lateral Stânga";
            this.txtLateralSt.Enter += new System.EventHandler(this.txtLateralSt_Enter);
            this.txtLateralSt.Leave += new System.EventHandler(this.txtLateralSt_Leave);
            // 
            // txtPosterior
            // 
            this.txtPosterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPosterior.ForeColor = System.Drawing.Color.DimGray;
            this.txtPosterior.Location = new System.Drawing.Point(46, 395);
            this.txtPosterior.Multiline = true;
            this.txtPosterior.Name = "txtPosterior";
            this.txtPosterior.Size = new System.Drawing.Size(205, 25);
            this.txtPosterior.TabIndex = 20;
            this.txtPosterior.Text = "Posterior";
            this.txtPosterior.Enter += new System.EventHandler(this.txtPosterior_Enter);
            this.txtPosterior.Leave += new System.EventHandler(this.txtPosterior_Leave);
            // 
            // INSERTDAUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 571);
            this.Controls.Add(this.txtPosterior);
            this.Controls.Add(this.txtLateralSt);
            this.Controls.Add(this.txtLateralDr);
            this.Controls.Add(this.txtFrontal);
            this.Controls.Add(this.txtDauneID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTDAUN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
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
        private TextBox txtDauneID;
        private TextBox txtFrontal;
        private TextBox txtLateralDr;
        private TextBox txtLateralSt;
        private TextBox txtPosterior;
    }
}