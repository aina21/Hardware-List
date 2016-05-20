namespace fatemeh_HardWare
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEquType = new System.Windows.Forms.ComboBox();
            this.txtEquCode = new System.Windows.Forms.TextBox();
            this.txtEquSystem = new System.Windows.Forms.TextBox();
            this.txtEquModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEquOk = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPerEquipment = new System.Windows.Forms.ComboBox();
            this.txtPerCode = new System.Windows.Forms.TextBox();
            this.btnPerOk = new System.Windows.Forms.Button();
            this.cmbPerGroup = new System.Windows.Forms.ComboBox();
            this.cmbPerBuild = new System.Windows.Forms.ComboBox();
            this.txtPerDakheli = new System.Windows.Forms.TextBox();
            this.txtPerName = new System.Windows.Forms.TextBox();
            this.txtPerLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnUser);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnSystem);
            this.groupBox1.Controls.Add(this.btnEquipment);
            this.groupBox1.Controls.Add(this.btnPerson);
            this.groupBox1.Location = new System.Drawing.Point(609, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::fatemeh_HardWare.Properties.Resources.gnome_application_exit;
            this.btnExit.Location = new System.Drawing.Point(6, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 58);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = global::fatemeh_HardWare.Properties.Resources.user;
            this.btnUser.Location = new System.Drawing.Point(6, 335);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(76, 58);
            this.btnUser.TabIndex = 4;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReport
            // 
            this.btnReport.Enabled = false;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::fatemeh_HardWare.Properties.Resources.reports_icon;
            this.btnReport.Location = new System.Drawing.Point(6, 263);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(76, 58);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnSystem
            // 
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnSystem.Image")));
            this.btnSystem.Location = new System.Drawing.Point(6, 191);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(76, 58);
            this.btnSystem.TabIndex = 2;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.Image = global::fatemeh_HardWare.Properties.Resources.Chip1;
            this.btnEquipment.Location = new System.Drawing.Point(6, 119);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(76, 58);
            this.btnEquipment.TabIndex = 1;
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Image = global::fatemeh_HardWare.Properties.Resources.user_group_icon;
            this.btnPerson.Location = new System.Drawing.Point(6, 39);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(76, 66);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.cmbEquType);
            this.tabPage2.Controls.Add(this.txtEquCode);
            this.tabPage2.Controls.Add(this.txtEquSystem);
            this.tabPage2.Controls.Add(this.txtEquModel);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnEquOk);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سابقه قطعه";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTozihat);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(19, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 206);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(6, 53);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeftLayout = true;
            this.txtDate.Size = new System.Drawing.Size(467, 32);
            this.txtDate.TabIndex = 39;
            this.txtDate.Value = new System.DateTime(2013, 9, 9, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "توضیحات";
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(6, 118);
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.ReadOnly = true;
            this.txtTozihat.Size = new System.Drawing.Size(518, 32);
            this.txtTozihat.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "تاریخ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "وضعیت تا کنون";
            // 
            // cmbEquType
            // 
            this.cmbEquType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquType.FormattingEnabled = true;
            this.cmbEquType.Location = new System.Drawing.Point(17, 64);
            this.cmbEquType.Name = "cmbEquType";
            this.cmbEquType.Size = new System.Drawing.Size(475, 32);
            this.cmbEquType.TabIndex = 32;
            // 
            // txtEquCode
            // 
            this.txtEquCode.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEquCode.Location = new System.Drawing.Point(369, 17);
            this.txtEquCode.Name = "txtEquCode";
            this.txtEquCode.Size = new System.Drawing.Size(123, 30);
            this.txtEquCode.TabIndex = 30;
            // 
            // txtEquSystem
            // 
            this.txtEquSystem.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEquSystem.Location = new System.Drawing.Point(17, 153);
            this.txtEquSystem.Name = "txtEquSystem";
            this.txtEquSystem.ReadOnly = true;
            this.txtEquSystem.Size = new System.Drawing.Size(475, 30);
            this.txtEquSystem.TabIndex = 25;
            // 
            // txtEquModel
            // 
            this.txtEquModel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEquModel.Location = new System.Drawing.Point(17, 107);
            this.txtEquModel.Name = "txtEquModel";
            this.txtEquModel.ReadOnly = true;
            this.txtEquModel.Size = new System.Drawing.Size(475, 30);
            this.txtEquModel.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(498, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = " سیستم ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(507, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "مدل";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(507, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "نوع";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(498, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "کد قطعه";
            // 
            // btnEquOk
            // 
            this.btnEquOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquOk.Image = global::fatemeh_HardWare.Properties.Resources.search;
            this.btnEquOk.Location = new System.Drawing.Point(332, 16);
            this.btnEquOk.Name = "btnEquOk";
            this.btnEquOk.Size = new System.Drawing.Size(31, 30);
            this.btnEquOk.TabIndex = 31;
            this.btnEquOk.UseVisualStyleBackColor = true;
            this.btnEquOk.Click += new System.EventHandler(this.btnEquOk_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.txtPerCode);
            this.tabPage1.Controls.Add(this.btnPerOk);
            this.tabPage1.Controls.Add(this.cmbPerGroup);
            this.tabPage1.Controls.Add(this.cmbPerBuild);
            this.tabPage1.Controls.Add(this.txtPerDakheli);
            this.tabPage1.Controls.Add(this.txtPerName);
            this.tabPage1.Controls.Add(this.txtPerLastName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "سابقه پرسنل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbPerEquipment);
            this.groupBox2.Location = new System.Drawing.Point(25, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 110);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "لیست قطعه های قبلی";
            // 
            // cmbPerEquipment
            // 
            this.cmbPerEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerEquipment.FormattingEnabled = true;
            this.cmbPerEquipment.Location = new System.Drawing.Point(6, 56);
            this.cmbPerEquipment.Name = "cmbPerEquipment";
            this.cmbPerEquipment.Size = new System.Drawing.Size(518, 32);
            this.cmbPerEquipment.TabIndex = 0;
            // 
            // txtPerCode
            // 
            this.txtPerCode.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPerCode.Location = new System.Drawing.Point(377, 17);
            this.txtPerCode.Name = "txtPerCode";
            this.txtPerCode.Size = new System.Drawing.Size(123, 30);
            this.txtPerCode.TabIndex = 32;
            // 
            // btnPerOk
            // 
            this.btnPerOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerOk.Image = global::fatemeh_HardWare.Properties.Resources.search;
            this.btnPerOk.Location = new System.Drawing.Point(340, 16);
            this.btnPerOk.Name = "btnPerOk";
            this.btnPerOk.Size = new System.Drawing.Size(31, 30);
            this.btnPerOk.TabIndex = 33;
            this.btnPerOk.UseVisualStyleBackColor = true;
            this.btnPerOk.Click += new System.EventHandler(this.btnPerOk_Click);
            // 
            // cmbPerGroup
            // 
            this.cmbPerGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerGroup.FormattingEnabled = true;
            this.cmbPerGroup.Location = new System.Drawing.Point(25, 236);
            this.cmbPerGroup.Name = "cmbPerGroup";
            this.cmbPerGroup.Size = new System.Drawing.Size(475, 32);
            this.cmbPerGroup.TabIndex = 15;
            // 
            // cmbPerBuild
            // 
            this.cmbPerBuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerBuild.FormattingEnabled = true;
            this.cmbPerBuild.Location = new System.Drawing.Point(25, 190);
            this.cmbPerBuild.Name = "cmbPerBuild";
            this.cmbPerBuild.Size = new System.Drawing.Size(475, 32);
            this.cmbPerBuild.TabIndex = 14;
            // 
            // txtPerDakheli
            // 
            this.txtPerDakheli.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPerDakheli.Location = new System.Drawing.Point(25, 146);
            this.txtPerDakheli.Name = "txtPerDakheli";
            this.txtPerDakheli.ReadOnly = true;
            this.txtPerDakheli.Size = new System.Drawing.Size(475, 30);
            this.txtPerDakheli.TabIndex = 9;
            // 
            // txtPerName
            // 
            this.txtPerName.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPerName.Location = new System.Drawing.Point(25, 58);
            this.txtPerName.Name = "txtPerName";
            this.txtPerName.ReadOnly = true;
            this.txtPerName.Size = new System.Drawing.Size(475, 30);
            this.txtPerName.TabIndex = 8;
            // 
            // txtPerLastName
            // 
            this.txtPerLastName.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPerLastName.Location = new System.Drawing.Point(25, 102);
            this.txtPerLastName.Name = "txtPerLastName";
            this.txtPerLastName.ReadOnly = true;
            this.txtPerLastName.Size = new System.Drawing.Size(475, 30);
            this.txtPerLastName.TabIndex = 7;
            this.txtPerLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "گروه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "ساختمان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "داخلی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام خانوادگی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد پرسنل";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 472);
            this.tabControl1.TabIndex = 1;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(708, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonel";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEquOk;
        private System.Windows.Forms.TextBox txtEquCode;
        private System.Windows.Forms.TextBox txtEquSystem;
        private System.Windows.Forms.TextBox txtEquModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbPerGroup;
        private System.Windows.Forms.ComboBox cmbPerBuild;
        private System.Windows.Forms.TextBox txtPerDakheli;
        private System.Windows.Forms.TextBox txtPerName;
        private System.Windows.Forms.TextBox txtPerLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPerEquipment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEquType;
        private System.Windows.Forms.TextBox txtPerCode;
        private System.Windows.Forms.Button btnPerOk;
        private System.Windows.Forms.DateTimePicker txtDate;
    }
}