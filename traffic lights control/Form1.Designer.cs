namespace inal_Project_2
{
    partial class Form1
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
            this.bt_ut2 = new System.Windows.Forms.Button();
            this.bt_ut1 = new System.Windows.Forms.Button();
            this.tb_road2 = new System.Windows.Forms.TextBox();
            this.tb_road1 = new System.Windows.Forms.TextBox();
            this.tb_receive = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDPdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINALDataSet = new inal_Project_2.FINALDataSet();
            this.b_close = new System.Windows.Forms.Button();
            this.b_open = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uDP_dataTableAdapter = new inal_Project_2.FINALDataSetTableAdapters.UDP_dataTableAdapter();
            this.fINALDataSet1 = new inal_Project_2.FINALDataSet1();
            this.uDPcontrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uDP_controlTableAdapter = new inal_Project_2.FINALDataSet1TableAdapters.UDP_controlTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDPdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINALDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDPcontrolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ut2
            // 
            this.bt_ut2.Location = new System.Drawing.Point(210, 148);
            this.bt_ut2.Name = "bt_ut2";
            this.bt_ut2.Size = new System.Drawing.Size(100, 28);
            this.bt_ut2.TabIndex = 49;
            this.bt_ut2.Text = "Ưu tiên Road 2";
            this.bt_ut2.UseVisualStyleBackColor = true;
            this.bt_ut2.Click += new System.EventHandler(this.bt_ut2_Click);
            // 
            // bt_ut1
            // 
            this.bt_ut1.Location = new System.Drawing.Point(210, 102);
            this.bt_ut1.Name = "bt_ut1";
            this.bt_ut1.Size = new System.Drawing.Size(100, 28);
            this.bt_ut1.TabIndex = 48;
            this.bt_ut1.Text = "Ưu tiên Road 1";
            this.bt_ut1.UseVisualStyleBackColor = true;
            this.bt_ut1.Click += new System.EventHandler(this.bt_ut1_Click);
            // 
            // tb_road2
            // 
            this.tb_road2.Location = new System.Drawing.Point(63, 149);
            this.tb_road2.Name = "tb_road2";
            this.tb_road2.Size = new System.Drawing.Size(100, 20);
            this.tb_road2.TabIndex = 47;
            // 
            // tb_road1
            // 
            this.tb_road1.Location = new System.Drawing.Point(63, 107);
            this.tb_road1.Name = "tb_road1";
            this.tb_road1.Size = new System.Drawing.Size(100, 20);
            this.tb_road1.TabIndex = 46;
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(12, 225);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.Size = new System.Drawing.Size(378, 121);
            this.tb_receive.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iPClientDataGridViewTextBoxColumn,
            this.road1DataGridViewTextBoxColumn,
            this.road2DataGridViewTextBoxColumn,
            this.timeCreatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uDPdataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(413, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 260);
            this.dataGridView1.TabIndex = 44;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iPClientDataGridViewTextBoxColumn
            // 
            this.iPClientDataGridViewTextBoxColumn.DataPropertyName = "IPClient";
            this.iPClientDataGridViewTextBoxColumn.HeaderText = "IPClient";
            this.iPClientDataGridViewTextBoxColumn.Name = "iPClientDataGridViewTextBoxColumn";
            // 
            // road1DataGridViewTextBoxColumn
            // 
            this.road1DataGridViewTextBoxColumn.DataPropertyName = "Road1";
            this.road1DataGridViewTextBoxColumn.HeaderText = "Road1";
            this.road1DataGridViewTextBoxColumn.Name = "road1DataGridViewTextBoxColumn";
            // 
            // road2DataGridViewTextBoxColumn
            // 
            this.road2DataGridViewTextBoxColumn.DataPropertyName = "Road2";
            this.road2DataGridViewTextBoxColumn.HeaderText = "Road2";
            this.road2DataGridViewTextBoxColumn.Name = "road2DataGridViewTextBoxColumn";
            // 
            // timeCreatDataGridViewTextBoxColumn
            // 
            this.timeCreatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeCreatDataGridViewTextBoxColumn.DataPropertyName = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn.HeaderText = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn.Name = "timeCreatDataGridViewTextBoxColumn";
            // 
            // uDPdataBindingSource
            // 
            this.uDPdataBindingSource.DataMember = "UDP_data";
            this.uDPdataBindingSource.DataSource = this.fINALDataSet;
            // 
            // fINALDataSet
            // 
            this.fINALDataSet.DataSetName = "FINALDataSet";
            this.fINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(318, 29);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 23);
            this.b_close.TabIndex = 43;
            this.b_close.Text = "STOP";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(210, 26);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(75, 23);
            this.b_open.TabIndex = 42;
            this.b_open.Text = "OPEN";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(91, 57);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 20);
            this.textBox_port.TabIndex = 40;
            this.textBox_port.Text = "8080";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(91, 26);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 20);
            this.textBox_ip.TabIndex = 39;
            this.textBox_ip.Text = "192.168.0.103";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Data Receive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "IP Destination";
            // 
            // uDP_dataTableAdapter
            // 
            this.uDP_dataTableAdapter.ClearBeforeFill = true;
            // 
            // fINALDataSet1
            // 
            this.fINALDataSet1.DataSetName = "FINALDataSet1";
            this.fINALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uDPcontrolBindingSource
            // 
            this.uDPcontrolBindingSource.DataMember = "UDP_control";
            this.uDPcontrolBindingSource.DataSource = this.fINALDataSet1;
            // 
            // uDP_controlTableAdapter
            // 
            this.uDP_controlTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iPClientDataGridViewTextBoxColumn1,
            this.commandDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.timeCreatDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.uDPcontrolBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(413, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(724, 260);
            this.dataGridView2.TabIndex = 50;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // iPClientDataGridViewTextBoxColumn1
            // 
            this.iPClientDataGridViewTextBoxColumn1.DataPropertyName = "IPClient";
            this.iPClientDataGridViewTextBoxColumn1.HeaderText = "IPClient";
            this.iPClientDataGridViewTextBoxColumn1.Name = "iPClientDataGridViewTextBoxColumn1";
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Command";
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // timeCreatDataGridViewTextBoxColumn1
            // 
            this.timeCreatDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeCreatDataGridViewTextBoxColumn1.DataPropertyName = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn1.HeaderText = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn1.Name = "timeCreatDataGridViewTextBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Road 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Road 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 567);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bt_ut2);
            this.Controls.Add(this.bt_ut1);
            this.Controls.Add(this.tb_road2);
            this.Controls.Add(this.tb_road1);
            this.Controls.Add(this.tb_receive);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDPdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINALDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDPcontrolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ut2;
        private System.Windows.Forms.Button bt_ut1;
        private System.Windows.Forms.TextBox tb_road2;
        private System.Windows.Forms.TextBox tb_road1;
        private System.Windows.Forms.TextBox tb_receive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FINALDataSet fINALDataSet;
        private System.Windows.Forms.BindingSource uDPdataBindingSource;
        private FINALDataSetTableAdapters.UDP_dataTableAdapter uDP_dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn road1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn road2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatDataGridViewTextBoxColumn;
        private FINALDataSet1 fINALDataSet1;
        private System.Windows.Forms.BindingSource uDPcontrolBindingSource;
        private FINALDataSet1TableAdapters.UDP_controlTableAdapter uDP_controlTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

