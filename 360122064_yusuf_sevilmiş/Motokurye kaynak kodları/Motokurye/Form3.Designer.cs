namespace Motokurye
{
    partial class Form3
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
            this.motorkuryeDataSet1 = new Motokurye.MotorkuryeDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kuryelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motorkuryeDataSet2 = new Motokurye.MotorkuryeDataSet2();
            this.kuryelerTableAdapter = new Motokurye.MotorkuryeDataSet2TableAdapters.KuryelerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kuryelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motorkuryeDataSet3 = new Motokurye.MotorkuryeDataSet3();
            this.kuryelerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kuryelerTableAdapter1 = new Motokurye.MotorkuryeDataSet3TableAdapters.KuryelerTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuryeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // motorkuryeDataSet1
            // 
            this.motorkuryeDataSet1.DataSetName = "MotorkuryeDataSet";
            this.motorkuryeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(429, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurye Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefon No";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(245, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kuryeAdiDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kuryelerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kuryelerBindingSource
            // 
            this.kuryelerBindingSource.DataMember = "Kuryeler";
            this.kuryelerBindingSource.DataSource = this.motorkuryeDataSet2;
            // 
            // motorkuryeDataSet2
            // 
            this.motorkuryeDataSet2.DataSetName = "MotorkuryeDataSet2";
            this.motorkuryeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kuryelerTableAdapter
            // 
            this.kuryelerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(390, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(17, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 70);
            this.button3.TabIndex = 9;
            this.button3.Text = "<= Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kuryelerBindingSource1
            // 
            this.kuryelerBindingSource1.DataMember = "Kuryeler";
            this.kuryelerBindingSource1.DataSource = this.motorkuryeDataSet2;
            // 
            // motorkuryeDataSet3
            // 
            this.motorkuryeDataSet3.DataSetName = "MotorkuryeDataSet3";
            this.motorkuryeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kuryelerBindingSource2
            // 
            this.kuryelerBindingSource2.DataMember = "Kuryeler";
            this.kuryelerBindingSource2.DataSource = this.motorkuryeDataSet3;
            // 
            // kuryelerTableAdapter1
            // 
            this.kuryelerTableAdapter1.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // kuryeAdiDataGridViewTextBoxColumn
            // 
            this.kuryeAdiDataGridViewTextBoxColumn.DataPropertyName = "Kurye_Adi";
            this.kuryeAdiDataGridViewTextBoxColumn.HeaderText = "Kurye_Adi";
            this.kuryeAdiDataGridViewTextBoxColumn.Name = "kuryeAdiDataGridViewTextBoxColumn";
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorkuryeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuryelerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MotorkuryeDataSet motorkuryeDataSet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MotorkuryeDataSet2 motorkuryeDataSet2;
        private System.Windows.Forms.BindingSource kuryelerBindingSource;
        private MotorkuryeDataSet2TableAdapters.KuryelerTableAdapter kuryelerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource kuryelerBindingSource1;
        private MotorkuryeDataSet3 motorkuryeDataSet3;
        private System.Windows.Forms.BindingSource kuryelerBindingSource2;
        private MotorkuryeDataSet3TableAdapters.KuryelerTableAdapter kuryelerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuryeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
    }
}