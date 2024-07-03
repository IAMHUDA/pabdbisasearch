namespace praktikum13
{
    partial class printData
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
            this.NIM = new System.Windows.Forms.TextBox();
            this.cbSmst = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTA = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport22 = new praktikum13.CrystalReport2();
            this.CrystalReport21 = new praktikum13.CrystalReport2();
            this.informasiMhsDataSet = new praktikum13.informasiMhsDataSet();
            this.kRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRSTableAdapter = new praktikum13.informasiMhsDataSetTableAdapters.KRSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.informasiMhsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // NIM
            // 
            this.NIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kRSBindingSource, "NIM", true));
            this.NIM.Location = new System.Drawing.Point(107, 95);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(100, 22);
            this.NIM.TabIndex = 1;
            this.NIM.TextChanged += new System.EventHandler(this.NIM_TextChanged);
            // 
            // cbSmst
            // 
            this.cbSmst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kRSBindingSource, "Semester", true));
            this.cbSmst.FormattingEnabled = true;
            this.cbSmst.Location = new System.Drawing.Point(399, 93);
            this.cbSmst.Name = "cbSmst";
            this.cbSmst.Size = new System.Drawing.Size(138, 24);
            this.cbSmst.TabIndex = 2;
            this.cbSmst.SelectedIndexChanged += new System.EventHandler(this.cbSmst_SelectedIndexChanged);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(843, 92);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 27);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEMESTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "TAHUN AJAR";
            // 
            // cbTA
            // 
            this.cbTA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kRSBindingSource, "ThAjar", true));
            this.cbTA.FormattingEnabled = true;
            this.cbTA.Location = new System.Drawing.Point(688, 93);
            this.cbTA.Name = "cbTA";
            this.cbTA.Size = new System.Drawing.Size(121, 24);
            this.cbTA.TabIndex = 6;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(35, 167);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport22;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1172, 448);
            this.crystalReportViewer1.TabIndex = 7;
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
            // printData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 555);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cbTA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cbSmst);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.label1);
            this.Name = "printData";
            this.Text = "printData";
            this.Load += new System.EventHandler(this.printData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informasiMhsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NIM;
        private System.Windows.Forms.ComboBox cbSmst;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTA;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport2 CrystalReport21;
        private CrystalReport2 CrystalReport22;
        private informasiMhsDataSet informasiMhsDataSet;
        private System.Windows.Forms.BindingSource kRSBindingSource;
        private informasiMhsDataSetTableAdapters.KRSTableAdapter kRSTableAdapter;
    }
}