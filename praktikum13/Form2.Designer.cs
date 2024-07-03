namespace praktikum13
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnadd = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.NIM = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbiaya = new System.Windows.Forms.TextBox();
            this.tsks = new System.Windows.Forms.TextBox();
            this.tSisa = new System.Windows.Forms.TextBox();
            this.tKar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBukti = new System.Windows.Forms.TextBox();
            this.informasiMhsDataSet = new praktikum13.informasiMhsDataSet();
            this.kRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRSTableAdapter = new praktikum13.informasiMhsDataSetTableAdapters.KRSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informasiMhsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // bttnadd
            // 
            this.bttnadd.Location = new System.Drawing.Point(465, 561);
            this.bttnadd.Name = "bttnadd";
            this.bttnadd.Size = new System.Drawing.Size(75, 23);
            this.bttnadd.TabIndex = 1;
            this.bttnadd.Text = "Tambah";
            this.bttnadd.UseVisualStyleBackColor = true;
            this.bttnadd.Click += new System.EventHandler(this.bttnadd_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(557, 561);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 2;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(661, 561);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // NIM
            // 
            this.NIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kRSBindingSource, "NIM", true));
            this.NIM.Location = new System.Drawing.Point(325, 32);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(100, 22);
            this.NIM.TabIndex = 4;
            this.NIM.TextChanged += new System.EventHandler(this.NIM_TextChanged);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(325, 60);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(100, 22);
            this.Nama.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // cbMK
            // 
            this.cbMK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informasiMhsDataSet, "MK.namaMK", true));
            this.cbMK.FormattingEnabled = true;
            this.cbMK.Location = new System.Drawing.Point(325, 88);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(121, 24);
            this.cbMK.TabIndex = 7;
            this.cbMK.SelectedIndexChanged += new System.EventHandler(this.cbMK_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mata Kuliah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mata Kuliah Sudah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Biaya";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total SKS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bukti Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sisa Pembayaran";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Penerima";
            // 
            // tbiaya
            // 
            this.tbiaya.Location = new System.Drawing.Point(300, 189);
            this.tbiaya.Name = "tbiaya";
            this.tbiaya.Size = new System.Drawing.Size(100, 22);
            this.tbiaya.TabIndex = 17;
            // 
            // tsks
            // 
            this.tsks.Location = new System.Drawing.Point(300, 217);
            this.tsks.Name = "tsks";
            this.tsks.Size = new System.Drawing.Size(100, 22);
            this.tsks.TabIndex = 18;
            // 
            // tSisa
            // 
            this.tSisa.Location = new System.Drawing.Point(300, 240);
            this.tSisa.Name = "tSisa";
            this.tSisa.Size = new System.Drawing.Size(100, 22);
            this.tSisa.TabIndex = 19;
            // 
            // tKar
            // 
            this.tKar.Location = new System.Drawing.Point(300, 333);
            this.tKar.Name = "tKar";
            this.tKar.Size = new System.Drawing.Size(100, 22);
            this.tKar.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(117, 69);
            this.dataGridView1.TabIndex = 21;
            // 
            // tBukti
            // 
            this.tBukti.Location = new System.Drawing.Point(300, 277);
            this.tBukti.Name = "tBukti";
            this.tBukti.Size = new System.Drawing.Size(100, 22);
            this.tBukti.TabIndex = 22;
            // 
            // informasiMhsDataSet
            // 
            this.informasiMhsDataSet.DataSetName = "informasiMhsDataSet";
            this.informasiMhsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kRSBindingSource
            // 
            this.kRSBindingSource.DataMember = "KRS";
            this.kRSBindingSource.DataSource = this.informasiMhsDataSet;
            // 
            // kRSTableAdapter
            // 
            this.kRSTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 696);
            this.Controls.Add(this.tBukti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tKar);
            this.Controls.Add(this.tSisa);
            this.Controls.Add(this.tsks);
            this.Controls.Add(this.tbiaya);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMK);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.bttnadd);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informasiMhsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnadd;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox NIM;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbiaya;
        private System.Windows.Forms.TextBox tsks;
        private System.Windows.Forms.TextBox tSisa;
        private System.Windows.Forms.TextBox tKar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBukti;
        private informasiMhsDataSet informasiMhsDataSet;
        private System.Windows.Forms.BindingSource kRSBindingSource;
        private informasiMhsDataSetTableAdapters.KRSTableAdapter kRSTableAdapter;
    }
}