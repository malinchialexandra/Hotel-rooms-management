
namespace Malinchi_Alexandra_Bianca_1053D_Proiect
{
    partial class PrimaPagina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actiune = new System.Windows.Forms.ComboBox();
            this.b_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(179, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "BINE ATI VENIT!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "CE DORITI SA FACETI?";
            // 
            // actiune
            // 
            this.actiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actiune.FormattingEnabled = true;
            this.actiune.Items.AddRange(new object[] {
            "Public anunt",
            "Rezerv camere"});
            this.actiune.Location = new System.Drawing.Point(250, 182);
            this.actiune.Name = "actiune";
            this.actiune.Size = new System.Drawing.Size(238, 28);
            this.actiune.TabIndex = 11;
            this.actiune.Text = "Selecteaza actiunea";
            this.actiune.SelectedIndexChanged += new System.EventHandler(this.categorie_SelectedIndexChanged);
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.Location = new System.Drawing.Point(240, 259);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(258, 109);
            this.b_start.TabIndex = 12;
            this.b_start.Text = "START";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // PrimaPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.actiune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrimaPagina";
            this.Text = "PrimaPagina";
            this.Load += new System.EventHandler(this.PrimaPagina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox actiune;
        private System.Windows.Forms.Button b_start;
    }
}