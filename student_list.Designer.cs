namespace faculty
{
    partial class student_list
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
            this.dtg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_searsh = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ddl = new System.Windows.Forms.ComboBox();
            this.faultyDataSet = new faculty.faultyDataSet();
            this.debartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debartmentsTableAdapter = new faculty.faultyDataSetTableAdapters.debartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(-3, 95);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(607, 249);
            this.dtg.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_searsh
            // 
            this.txt_searsh.Location = new System.Drawing.Point(169, 24);
            this.txt_searsh.Name = "txt_searsh";
            this.txt_searsh.Size = new System.Drawing.Size(233, 20);
            this.txt_searsh.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(464, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "searsh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ddl
            // 
            this.ddl.DataSource = this.debartmentsBindingSource;
            this.ddl.DisplayMember = "name";
            this.ddl.FormattingEnabled = true;
            this.ddl.Location = new System.Drawing.Point(334, 61);
            this.ddl.Name = "ddl";
            this.ddl.Size = new System.Drawing.Size(121, 21);
            this.ddl.TabIndex = 11;
            this.ddl.ValueMember = "id";
            this.ddl.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // faultyDataSet
            // 
            this.faultyDataSet.DataSetName = "faultyDataSet";
            this.faultyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debartmentsBindingSource
            // 
            this.debartmentsBindingSource.DataMember = "debartments";
            this.debartmentsBindingSource.DataSource = this.faultyDataSet;
            // 
            // debartmentsTableAdapter
            // 
            this.debartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 343);
            this.Controls.Add(this.ddl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_searsh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg);
            this.Name = "student_list";
            this.Text = " ";
            this.Load += new System.EventHandler(this.student_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_searsh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ddl;
        private faultyDataSet faultyDataSet;
        private System.Windows.Forms.BindingSource debartmentsBindingSource;
        private faultyDataSetTableAdapters.debartmentsTableAdapter debartmentsTableAdapter;
    }
}