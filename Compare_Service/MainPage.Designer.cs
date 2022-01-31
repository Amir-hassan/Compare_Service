namespace Compare_Service
{
    partial class MainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn_FilesPath_Second = new System.Windows.Forms.Button();
            this.txt_FolderPath_Dest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FolderPath_Src = new System.Windows.Forms.TextBox();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_FilesPath_shaskam = new System.Windows.Forms.Button();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.CB2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_H1 = new System.Windows.Forms.CheckBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_G = new System.Windows.Forms.Label();
            this.LB_S = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btn_FilesPath_print = new System.Windows.Forms.Button();
            this.Txt_Print = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_FilesPath_Second
            // 
            this.btn_FilesPath_Second.BackColor = System.Drawing.Color.White;
            this.btn_FilesPath_Second.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FilesPath_Second.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilesPath_Second.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_FilesPath_Second.Location = new System.Drawing.Point(591, 63);
            this.btn_FilesPath_Second.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FilesPath_Second.Name = "btn_FilesPath_Second";
            this.btn_FilesPath_Second.Size = new System.Drawing.Size(43, 24);
            this.btn_FilesPath_Second.TabIndex = 76;
            this.btn_FilesPath_Second.Text = ". . .";
            this.btn_FilesPath_Second.UseVisualStyleBackColor = false;
            this.btn_FilesPath_Second.Click += new System.EventHandler(this.Btn_FilesPath_Second_Click);
            // 
            // txt_FolderPath_Dest
            // 
            this.txt_FolderPath_Dest.Location = new System.Drawing.Point(95, 65);
            this.txt_FolderPath_Dest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FolderPath_Dest.Name = "txt_FolderPath_Dest";
            this.txt_FolderPath_Dest.ReadOnly = true;
            this.txt_FolderPath_Dest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FolderPath_Dest.Size = new System.Drawing.Size(490, 22);
            this.txt_FolderPath_Dest.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Second Doc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "First Doc :";
            // 
            // txt_FolderPath_Src
            // 
            this.txt_FolderPath_Src.Location = new System.Drawing.Point(95, 32);
            this.txt_FolderPath_Src.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FolderPath_Src.Name = "txt_FolderPath_Src";
            this.txt_FolderPath_Src.ReadOnly = true;
            this.txt_FolderPath_Src.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FolderPath_Src.Size = new System.Drawing.Size(490, 22);
            this.txt_FolderPath_Src.TabIndex = 72;
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.BackColor = System.Drawing.Color.White;
            this.btn_LoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_LoadFile.ForeColor = System.Drawing.Color.Black;
            this.btn_LoadFile.Location = new System.Drawing.Point(6, 21);
            this.btn_LoadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(130, 24);
            this.btn_LoadFile.TabIndex = 71;
            this.btn_LoadFile.Text = "Start Compere";
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.Btn_LoadFile_Click);
            // 
            // btn_FilesPath_shaskam
            // 
            this.btn_FilesPath_shaskam.BackColor = System.Drawing.Color.White;
            this.btn_FilesPath_shaskam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FilesPath_shaskam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilesPath_shaskam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_FilesPath_shaskam.Location = new System.Drawing.Point(591, 30);
            this.btn_FilesPath_shaskam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FilesPath_shaskam.Name = "btn_FilesPath_shaskam";
            this.btn_FilesPath_shaskam.Size = new System.Drawing.Size(43, 24);
            this.btn_FilesPath_shaskam.TabIndex = 69;
            this.btn_FilesPath_shaskam.Text = ". . .";
            this.btn_FilesPath_shaskam.UseVisualStyleBackColor = false;
            this.btn_FilesPath_shaskam.Click += new System.EventHandler(this.Btn_FilesPath_shaskam_Click);
            // 
            // CB1
            // 
            this.CB1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CB1.FormattingEnabled = true;
            this.CB1.Location = new System.Drawing.Point(748, 30);
            this.CB1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(212, 24);
            this.CB1.TabIndex = 77;
            this.CB1.SelectionChangeCommitted += new System.EventHandler(this.CB1_SelectionChangeCommitted);
            // 
            // CB2
            // 
            this.CB2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CB2.FormattingEnabled = true;
            this.CB2.Location = new System.Drawing.Point(750, 63);
            this.CB2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(210, 24);
            this.CB2.TabIndex = 78;
            this.CB2.SelectionChangeCommitted += new System.EventHandler(this.CB2_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(662, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Which field";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(662, 71);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Which field";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 285);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 524);
            this.dataGridView1.TabIndex = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_H1);
            this.groupBox1.Controls.Add(this.lb_2);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_FilesPath_shaskam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_FolderPath_Src);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB2);
            this.groupBox1.Controls.Add(this.txt_FolderPath_Dest);
            this.groupBox1.Controls.Add(this.CB1);
            this.groupBox1.Controls.Add(this.btn_FilesPath_Second);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 112);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload File";
            // 
            // CB_H1
            // 
            this.CB_H1.AutoSize = true;
            this.CB_H1.Checked = true;
            this.CB_H1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_H1.Location = new System.Drawing.Point(966, 36);
            this.CB_H1.Name = "CB_H1";
            this.CB_H1.Size = new System.Drawing.Size(148, 18);
            this.CB_H1.TabIndex = 90;
            this.CB_H1.Text = "Includes column name";
            this.CB_H1.UseVisualStyleBackColor = true;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_2.ForeColor = System.Drawing.Color.Snow;
            this.lb_2.Location = new System.Drawing.Point(1275, 71);
            this.lb_2.Name = "lb_2";
            this.lb_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_2.Size = new System.Drawing.Size(14, 16);
            this.lb_2.TabIndex = 84;
            this.lb_2.Text = "0";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_1.ForeColor = System.Drawing.Color.Snow;
            this.lb_1.Location = new System.Drawing.Point(1275, 38);
            this.lb_1.Name = "lb_1";
            this.lb_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_1.Size = new System.Drawing.Size(14, 16);
            this.lb_1.TabIndex = 83;
            this.lb_1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(1120, 71);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Number of records";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1120, 38);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "Number of records";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(1160, 21);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 24);
            this.btn_cancel.TabIndex = 71;
            this.btn_cancel.Text = "Cancel Compere";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(1101, 31);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(14, 14);
            this.resultLabel.TabIndex = 83;
            this.resultLabel.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(953, 23);
            this.progressBar1.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(464, 249);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "Number of record";
            // 
            // lb_G
            // 
            this.lb_G.AutoSize = true;
            this.lb_G.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_G.ForeColor = System.Drawing.Color.Snow;
            this.lb_G.Location = new System.Drawing.Point(600, 249);
            this.lb_G.Name = "lb_G";
            this.lb_G.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_G.Size = new System.Drawing.Size(14, 16);
            this.lb_G.TabIndex = 85;
            this.lb_G.Text = "0";
            // 
            // LB_S
            // 
            this.LB_S.AutoSize = true;
            this.LB_S.Location = new System.Drawing.Point(618, 91);
            this.LB_S.Name = "LB_S";
            this.LB_S.Size = new System.Drawing.Size(0, 14);
            this.LB_S.TabIndex = 86;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Enabled = false;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_print.ForeColor = System.Drawing.Color.Black;
            this.btn_print.Location = new System.Drawing.Point(820, 14);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(102, 24);
            this.btn_print.TabIndex = 87;
            this.btn_print.Text = "OutPut File";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.Btn_print_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LoadFile);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.LB_S);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.resultLabel);
            this.groupBox2.Location = new System.Drawing.Point(11, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1322, 62);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proccess";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.btn_FilesPath_print);
            this.groupBox3.Controls.Add(this.Txt_Print);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1321, 54);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output File";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(966, 15);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(323, 23);
            this.progressBar2.TabIndex = 87;
            // 
            // btn_FilesPath_print
            // 
            this.btn_FilesPath_print.BackColor = System.Drawing.Color.White;
            this.btn_FilesPath_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FilesPath_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilesPath_print.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_FilesPath_print.Location = new System.Drawing.Point(620, 14);
            this.btn_FilesPath_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FilesPath_print.Name = "btn_FilesPath_print";
            this.btn_FilesPath_print.Size = new System.Drawing.Size(43, 24);
            this.btn_FilesPath_print.TabIndex = 85;
            this.btn_FilesPath_print.Text = ". . .";
            this.btn_FilesPath_print.UseVisualStyleBackColor = false;
            this.btn_FilesPath_print.Click += new System.EventHandler(this.Btn_FilesPath_print_Click);
            // 
            // Txt_Print
            // 
            this.Txt_Print.Location = new System.Drawing.Point(95, 16);
            this.Txt_Print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Print.Name = "Txt_Print";
            this.Txt_Print.ReadOnly = true;
            this.Txt_Print.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Print.Size = new System.Drawing.Size(516, 22);
            this.Txt_Print.TabIndex = 85;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker2_RunWorkerCompleted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 88;
            this.label8.Text = "Output Path :";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1345, 807);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_G);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.Text = "Compere Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_FilesPath_Second;
        private System.Windows.Forms.TextBox txt_FolderPath_Dest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FolderPath_Src;
        internal System.Windows.Forms.Button btn_LoadFile;
        internal System.Windows.Forms.Button btn_FilesPath_shaskam;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.ComboBox CB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_G;
        private System.Windows.Forms.Label LB_S;
        internal System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btn_FilesPath_print;
        private System.Windows.Forms.TextBox Txt_Print;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.CheckBox CB_H1;
        private System.Windows.Forms.Label label8;
    }
}

