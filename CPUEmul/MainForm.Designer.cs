﻿namespace CPUEmul
{
    partial class MainForm
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
            this.dgvMemory = new System.Windows.Forms.DataGridView();
            this.scDevice = new System.Windows.Forms.SplitContainer();
            this.scProgram = new System.Windows.Forms.SplitContainer();
            this.bClearTextProg = new System.Windows.Forms.Button();
            this.bSaveToFile = new System.Windows.Forms.Button();
            this.bLoadFromFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompiledProgram = new System.Windows.Forms.DataGridView();
            this.scCPU = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.rtbTextProgram = new System.Windows.Forms.RichTextBox();
            this.bCompile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scDevice)).BeginInit();
            this.scDevice.Panel1.SuspendLayout();
            this.scDevice.Panel2.SuspendLayout();
            this.scDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProgram)).BeginInit();
            this.scProgram.Panel1.SuspendLayout();
            this.scProgram.Panel2.SuspendLayout();
            this.scProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompiledProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scCPU)).BeginInit();
            this.scCPU.Panel1.SuspendLayout();
            this.scCPU.Panel2.SuspendLayout();
            this.scCPU.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemory
            // 
            this.dgvMemory.AllowUserToAddRows = false;
            this.dgvMemory.AllowUserToDeleteRows = false;
            this.dgvMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemory.Location = new System.Drawing.Point(3, 19);
            this.dgvMemory.Name = "dgvMemory";
            this.dgvMemory.Size = new System.Drawing.Size(532, 239);
            this.dgvMemory.TabIndex = 0;
            // 
            // scDevice
            // 
            this.scDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDevice.Location = new System.Drawing.Point(0, 0);
            this.scDevice.Name = "scDevice";
            // 
            // scDevice.Panel1
            // 
            this.scDevice.Panel1.Controls.Add(this.scProgram);
            // 
            // scDevice.Panel2
            // 
            this.scDevice.Panel2.Controls.Add(this.scCPU);
            this.scDevice.Size = new System.Drawing.Size(1008, 510);
            this.scDevice.SplitterDistance = 466;
            this.scDevice.TabIndex = 2;
            // 
            // scProgram
            // 
            this.scProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scProgram.Location = new System.Drawing.Point(0, 0);
            this.scProgram.Name = "scProgram";
            // 
            // scProgram.Panel1
            // 
            this.scProgram.Panel1.Controls.Add(this.bCompile);
            this.scProgram.Panel1.Controls.Add(this.rtbTextProgram);
            this.scProgram.Panel1.Controls.Add(this.bClearTextProg);
            this.scProgram.Panel1.Controls.Add(this.bSaveToFile);
            this.scProgram.Panel1.Controls.Add(this.bLoadFromFile);
            this.scProgram.Panel1.Controls.Add(this.label1);
            // 
            // scProgram.Panel2
            // 
            this.scProgram.Panel2.Controls.Add(this.label2);
            this.scProgram.Panel2.Controls.Add(this.dgvCompiledProgram);
            this.scProgram.Size = new System.Drawing.Size(466, 510);
            this.scProgram.SplitterDistance = 231;
            this.scProgram.TabIndex = 3;
            // 
            // bClearTextProg
            // 
            this.bClearTextProg.Location = new System.Drawing.Point(70, 24);
            this.bClearTextProg.Name = "bClearTextProg";
            this.bClearTextProg.Size = new System.Drawing.Size(23, 21);
            this.bClearTextProg.TabIndex = 5;
            this.bClearTextProg.Text = "X";
            this.bClearTextProg.UseVisualStyleBackColor = true;
            this.bClearTextProg.Click += new System.EventHandler(this.bClearTextProg_Click);
            // 
            // bSaveToFile
            // 
            this.bSaveToFile.Location = new System.Drawing.Point(41, 24);
            this.bSaveToFile.Name = "bSaveToFile";
            this.bSaveToFile.Size = new System.Drawing.Size(23, 21);
            this.bSaveToFile.TabIndex = 4;
            this.bSaveToFile.Text = "S";
            this.bSaveToFile.UseVisualStyleBackColor = true;
            this.bSaveToFile.Click += new System.EventHandler(this.bSaveToFile_Click);
            // 
            // bLoadFromFile
            // 
            this.bLoadFromFile.Location = new System.Drawing.Point(12, 24);
            this.bLoadFromFile.Name = "bLoadFromFile";
            this.bLoadFromFile.Size = new System.Drawing.Size(23, 21);
            this.bLoadFromFile.TabIndex = 3;
            this.bLoadFromFile.Text = "L";
            this.bLoadFromFile.UseVisualStyleBackColor = true;
            this.bLoadFromFile.Click += new System.EventHandler(this.bLoadFromFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст программы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Компилированная программа:";
            // 
            // dgvCompiledProgram
            // 
            this.dgvCompiledProgram.AllowUserToAddRows = false;
            this.dgvCompiledProgram.AllowUserToDeleteRows = false;
            this.dgvCompiledProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompiledProgram.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCompiledProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompiledProgram.Location = new System.Drawing.Point(5, 49);
            this.dgvCompiledProgram.Name = "dgvCompiledProgram";
            this.dgvCompiledProgram.Size = new System.Drawing.Size(223, 458);
            this.dgvCompiledProgram.TabIndex = 2;
            // 
            // scCPU
            // 
            this.scCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCPU.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scCPU.Location = new System.Drawing.Point(0, 0);
            this.scCPU.Name = "scCPU";
            this.scCPU.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCPU.Panel1
            // 
            this.scCPU.Panel1.Controls.Add(this.groupBox1);
            // 
            // scCPU.Panel2
            // 
            this.scCPU.Panel2.Controls.Add(this.label3);
            this.scCPU.Panel2.Controls.Add(this.dgvMemory);
            this.scCPU.Size = new System.Drawing.Size(538, 510);
            this.scCPU.SplitterDistance = 245;
            this.scCPU.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состояние процессора";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox15);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(7, 162);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 63);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CR";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox19);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.textBox18);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(337, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 47);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Флаги";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Location = new System.Drawing.Point(227, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ОЗУ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Location = new System.Drawing.Point(117, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 82);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "РОН";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(7, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "АЛУ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Память:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(272, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(272, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "RB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "RA";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView4);
            this.groupBox7.Location = new System.Drawing.Point(337, 134);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(189, 103);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Регистры";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 19);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(177, 81);
            this.dataGridView4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(47, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Acc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "DR";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(47, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "PDR";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(45, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(53, 20);
            this.textBox7.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "RAR";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(45, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(14, 20);
            this.textBox8.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "MDR";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(45, 19);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(53, 20);
            this.textBox9.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "MAR";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(45, 44);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(53, 20);
            this.textBox10.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "IR";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(369, 49);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(54, 20);
            this.textBox11.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(433, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "OR";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(462, 49);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(54, 20);
            this.textBox12.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(115, 26);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(14, 20);
            this.textBox13.TabIndex = 10;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(36, 26);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(42, 20);
            this.textBox14.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "TA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "COP";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(172, 26);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(39, 20);
            this.textBox15.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(139, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "ADR";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(28, 19);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(14, 20);
            this.textBox16.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "I";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(76, 19);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(18, 20);
            this.textBox17.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "OV";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(159, 19);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(14, 20);
            this.textBox18.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(139, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Z";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(119, 19);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(14, 20);
            this.textBox19.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(98, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "S";
            // 
            // rtbTextProgram
            // 
            this.rtbTextProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTextProgram.Location = new System.Drawing.Point(3, 49);
            this.rtbTextProgram.Name = "rtbTextProgram";
            this.rtbTextProgram.Size = new System.Drawing.Size(225, 458);
            this.rtbTextProgram.TabIndex = 6;
            this.rtbTextProgram.Text = "";
            // 
            // bCompile
            // 
            this.bCompile.Location = new System.Drawing.Point(100, 24);
            this.bCompile.Name = "bCompile";
            this.bCompile.Size = new System.Drawing.Size(23, 21);
            this.bCompile.TabIndex = 7;
            this.bCompile.Text = "C";
            this.bCompile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 510);
            this.Controls.Add(this.scDevice);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemory)).EndInit();
            this.scDevice.Panel1.ResumeLayout(false);
            this.scDevice.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDevice)).EndInit();
            this.scDevice.ResumeLayout(false);
            this.scProgram.Panel1.ResumeLayout(false);
            this.scProgram.Panel1.PerformLayout();
            this.scProgram.Panel2.ResumeLayout(false);
            this.scProgram.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProgram)).EndInit();
            this.scProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompiledProgram)).EndInit();
            this.scCPU.Panel1.ResumeLayout(false);
            this.scCPU.Panel2.ResumeLayout(false);
            this.scCPU.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCPU)).EndInit();
            this.scCPU.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemory;
        private System.Windows.Forms.SplitContainer scDevice;
        private System.Windows.Forms.SplitContainer scProgram;
        private System.Windows.Forms.Button bClearTextProg;
        private System.Windows.Forms.Button bSaveToFile;
        private System.Windows.Forms.Button bLoadFromFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompiledProgram;
        private System.Windows.Forms.SplitContainer scCPU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button bCompile;
        private System.Windows.Forms.RichTextBox rtbTextProgram;
    }
}

