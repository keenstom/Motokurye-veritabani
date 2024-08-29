namespace Motokurye
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hedef_Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motorkuryeDataSet4 = new Motokurye.MotorkuryeDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.motorkuryeDataSet3 = new Motokurye.MotorkuryeDataSet3();
            this.kuryelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuryelerTableAdapter = new Motokurye.MotorkuryeDataSet3TableAdapters.KuryelerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kuryelerTableAdapter1 = new Motokurye.MotorkuryeDataSet4TableAdapters.KuryelerTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter = new Motokurye.MotorkuryeDataSet4TableAdapters.siparisTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.kuryeAdiDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.Hedef_Adres});
            this.dataGridView1.DataSource = this.kuryelerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kuryeAdiDataGridViewTextBoxColumn
            // 
            this.kuryeAdiDataGridViewTextBoxColumn.DataPropertyName = "Kurye_Adi";
            this.kuryeAdiDataGridViewTextBoxColumn.HeaderText = "Kurye_Adi";
            this.kuryeAdiDataGridViewTextBoxColumn.Name = "kuryeAdiDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // Hedef_Adres
            // 
            this.Hedef_Adres.DataPropertyName = "Hedef_Adres";
            this.Hedef_Adres.HeaderText = "Hedef_Adres";
            this.Hedef_Adres.Name = "Hedef_Adres";
            // 
            // kuryelerBindingSource1
            // 
            this.kuryelerBindingSource1.DataMember = "Kuryeler";
            this.kuryelerBindingSource1.DataSource = this.motorkuryeDataSet4;
            // 
            // motorkuryeDataSet4
            // 
            this.motorkuryeDataSet4.DataSetName = "MotorkuryeDataSet4";
            this.motorkuryeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kuryeler";
            // 
            // motorkuryeDataSet3
            // 
            this.motorkuryeDataSet3.DataSetName = "MotorkuryeDataSet3";
            this.motorkuryeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kuryelerBindingSource
            // 
            this.kuryelerBindingSource.DataMember = "Kuryeler";
            this.kuryelerBindingSource.DataSource = this.motorkuryeDataSet3;
            // 
            // kuryelerTableAdapter
            // 
            this.kuryelerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(525, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "<= Siparişi Bitir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(525, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kuryelerTableAdapter1
            // 
            this.kuryelerTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gelen Sipariş";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.menuDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.siparisBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // menuDataGridViewTextBoxColumn
            // 
            this.menuDataGridViewTextBoxColumn.DataPropertyName = "menu";
            this.menuDataGridViewTextBoxColumn.HeaderText = "menu";
            this.menuDataGridViewTextBoxColumn.Name = "menuDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "siparis";
            this.siparisBindingSource.DataSource = this.motorkuryeDataSet4;
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(525, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adres Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 86);
            this.textBox1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(525, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "Adres Aktar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(525, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 43);
            this.button5.TabIndex = 15;
            this.button5.Text = "Sipariş Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private MotorkuryeDataSet3 motorkuryeDataSet3;
        private System.Windows.Forms.BindingSource kuryelerBindingSource;
        private MotorkuryeDataSet3TableAdapters.KuryelerTableAdapter kuryelerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MotorkuryeDataSet4 motorkuryeDataSet4;
        private System.Windows.Forms.BindingSource kuryelerBindingSource1;
        private MotorkuryeDataSet4TableAdapters.KuryelerTableAdapter kuryelerTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private MotorkuryeDataSet4TableAdapters.siparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hedef_Adres;
    }
}