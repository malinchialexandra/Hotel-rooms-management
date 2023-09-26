
namespace Malinchi_Alexandra_Bianca_1053D_Proiect
{
    partial class RezervaCamere
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adaugare = new System.Windows.Forms.Button();
            this.factura_dgv = new System.Windows.Forms.DataGridView();
            this.dgv_rezervare = new System.Windows.Forms.DataGridView();
            this.b_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_checkout = new System.Windows.Forms.Button();
            this.pret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCamere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numeHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume_hote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCamere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totallbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rezervare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.totallbl);
            this.panel1.Controls.Add(this.adaugare);
            this.panel1.Controls.Add(this.factura_dgv);
            this.panel1.Controls.Add(this.dgv_rezervare);
            this.panel1.Controls.Add(this.b_refresh);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.b_checkout);
            this.panel1.Controls.Add(this.pret);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.totalCamere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numeHotel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.idFactura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(182, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 842);
            this.panel1.TabIndex = 2;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // adaugare
            // 
            this.adaugare.BackColor = System.Drawing.Color.DarkOrchid;
            this.adaugare.FlatAppearance.BorderSize = 0;
            this.adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adaugare.Location = new System.Drawing.Point(26, 273);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(140, 59);
            this.adaugare.TabIndex = 23;
            this.adaugare.Text = "ADAUGA";
            this.adaugare.UseVisualStyleBackColor = false;
            this.adaugare.Click += new System.EventHandler(this.adaugare_Click);
            // 
            // factura_dgv
            // 
            this.factura_dgv.AllowUserToOrderColumns = true;
            this.factura_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.factura_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factura_dgv.GridColor = System.Drawing.SystemColors.ControlText;
            this.factura_dgv.Location = new System.Drawing.Point(721, 338);
            this.factura_dgv.Name = "factura_dgv";
            this.factura_dgv.RowHeadersWidth = 51;
            this.factura_dgv.RowTemplate.Height = 24;
            this.factura_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.factura_dgv.Size = new System.Drawing.Size(445, 417);
            this.factura_dgv.TabIndex = 22;
            // 
            // dgv_rezervare
            // 
            this.dgv_rezervare.AllowUserToOrderColumns = true;
            this.dgv_rezervare.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_rezervare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rezervare.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_rezervare.Location = new System.Drawing.Point(25, 369);
            this.dgv_rezervare.Name = "dgv_rezervare";
            this.dgv_rezervare.RowHeadersWidth = 51;
            this.dgv_rezervare.RowTemplate.Height = 24;
            this.dgv_rezervare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rezervare.Size = new System.Drawing.Size(613, 321);
            this.dgv_rezervare.TabIndex = 21;
            this.dgv_rezervare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rezervare_CellContentClick);
            // 
            // b_refresh
            // 
            this.b_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.b_refresh.FlatAppearance.BorderSize = 0;
            this.b_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_refresh.Location = new System.Drawing.Point(840, 56);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(141, 28);
            this.b_refresh.TabIndex = 16;
            this.b_refresh.Text = "Refresh";
            this.b_refresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHotel,
            this.Nume_hote,
            this.nrCamere,
            this.pretCamera,
            this.pretTotal});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(426, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 127);
            this.dataGridView1.TabIndex = 14;
            // 
            // b_checkout
            // 
            this.b_checkout.BackColor = System.Drawing.Color.DarkOrchid;
            this.b_checkout.FlatAppearance.BorderSize = 0;
            this.b_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_checkout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_checkout.Location = new System.Drawing.Point(874, 250);
            this.b_checkout.Name = "b_checkout";
            this.b_checkout.Size = new System.Drawing.Size(140, 59);
            this.b_checkout.TabIndex = 11;
            this.b_checkout.Text = "CHECKOUT";
            this.b_checkout.UseVisualStyleBackColor = false;
            this.b_checkout.Click += new System.EventHandler(this.b_checkout_Click);
            // 
            // pret
            // 
            this.pret.Location = new System.Drawing.Point(246, 210);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(129, 22);
            this.pret.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRET";
            // 
            // totalCamere
            // 
            this.totalCamere.Location = new System.Drawing.Point(246, 150);
            this.totalCamere.Name = "totalCamere";
            this.totalCamere.Size = new System.Drawing.Size(129, 22);
            this.totalCamere.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "NUMAR CAMERE";
            // 
            // numeHotel
            // 
            this.numeHotel.Location = new System.Drawing.Point(246, 90);
            this.numeHotel.Name = "numeHotel";
            this.numeHotel.Size = new System.Drawing.Size(129, 22);
            this.numeHotel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "NUME HOTEL";
            // 
            // idFactura
            // 
            this.idFactura.Location = new System.Drawing.Point(246, 37);
            this.idFactura.Name = "idFactura";
            this.idFactura.Size = new System.Drawing.Size(129, 22);
            this.idFactura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID FACTURA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(505, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "REZERVA CAMERE";
            // 
            // idHotel
            // 
            this.idHotel.HeaderText = "ID";
            this.idHotel.MinimumWidth = 6;
            this.idHotel.Name = "idHotel";
            this.idHotel.Width = 125;
            // 
            // Nume_hote
            // 
            this.Nume_hote.HeaderText = "NumeHotel";
            this.Nume_hote.MinimumWidth = 6;
            this.Nume_hote.Name = "Nume_hote";
            this.Nume_hote.Width = 125;
            // 
            // nrCamere
            // 
            this.nrCamere.HeaderText = "NrCamere";
            this.nrCamere.MinimumWidth = 6;
            this.nrCamere.Name = "nrCamere";
            this.nrCamere.Width = 125;
            // 
            // pretCamera
            // 
            this.pretCamera.HeaderText = "PretCamera";
            this.pretCamera.MinimumWidth = 6;
            this.pretCamera.Name = "pretCamera";
            this.pretCamera.Width = 125;
            // 
            // pretTotal
            // 
            this.pretTotal.HeaderText = "PretTotal";
            this.pretTotal.MinimumWidth = 6;
            this.pretTotal.Name = "pretTotal";
            this.pretTotal.Width = 125;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(574, 239);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(84, 25);
            this.totallbl.TabIndex = 24;
            this.totallbl.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "TOTAL";
            // 
            // RezervaCamere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 942);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RezervaCamere";
            this.Text = "RezervaCamere";
            this.Load += new System.EventHandler(this.RezervaCamere_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rezervare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_checkout;
        private System.Windows.Forms.TextBox pret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalCamere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.DataGridView factura_dgv;
        private System.Windows.Forms.DataGridView dgv_rezervare;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_hote;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCamere;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretTotal;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label label6;
    }
}