﻿namespace WinForms_Basics {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mPicture2 = new System.Windows.Forms.PictureBox();
			this.mPicture1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mPowerText1 = new System.Windows.Forms.TextBox();
			this.mDefenseText1 = new System.Windows.Forms.TextBox();
			this.mAttackText1 = new System.Windows.Forms.TextBox();
			this.mLevelText1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.mHPText1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mPowerText2 = new System.Windows.Forms.TextBox();
			this.mDefenseText2 = new System.Windows.Forms.TextBox();
			this.mAttackText2 = new System.Windows.Forms.TextBox();
			this.mLevelText2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mHPText2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.mFightBtn = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.mPicture2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mPicture1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mPicture2
			// 
			this.mPicture2.Image = ((System.Drawing.Image)(resources.GetObject("mPicture2.Image")));
			this.mPicture2.Location = new System.Drawing.Point(322, 12);
			this.mPicture2.Name = "mPicture2";
			this.mPicture2.Size = new System.Drawing.Size(200, 225);
			this.mPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.mPicture2.TabIndex = 0;
			this.mPicture2.TabStop = false;
			this.mPicture2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mPicture2_MouseDoubleClick);
			// 
			// mPicture1
			// 
			this.mPicture1.Image = ((System.Drawing.Image)(resources.GetObject("mPicture1.Image")));
			this.mPicture1.Location = new System.Drawing.Point(12, 55);
			this.mPicture1.Name = "mPicture1";
			this.mPicture1.Size = new System.Drawing.Size(250, 139);
			this.mPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.mPicture1.TabIndex = 1;
			this.mPicture1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(268, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "VS";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mPowerText1);
			this.groupBox1.Controls.Add(this.mDefenseText1);
			this.groupBox1.Controls.Add(this.mAttackText1);
			this.groupBox1.Controls.Add(this.mLevelText1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.mHPText1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 257);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(249, 161);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stats";
			// 
			// mPowerText1
			// 
			this.mPowerText1.Location = new System.Drawing.Point(68, 124);
			this.mPowerText1.Name = "mPowerText1";
			this.mPowerText1.Size = new System.Drawing.Size(100, 20);
			this.mPowerText1.TabIndex = 4;
			this.mPowerText1.Text = "75";
			this.mPowerText1.TextChanged += new System.EventHandler(this.mPowerText1_TextChanged);
			// 
			// mDefenseText1
			// 
			this.mDefenseText1.Location = new System.Drawing.Point(68, 98);
			this.mDefenseText1.Name = "mDefenseText1";
			this.mDefenseText1.Size = new System.Drawing.Size(100, 20);
			this.mDefenseText1.TabIndex = 3;
			this.mDefenseText1.Text = "115";
			this.mDefenseText1.TextChanged += new System.EventHandler(this.mDefenseText1_TextChanged);
			// 
			// mAttackText1
			// 
			this.mAttackText1.Location = new System.Drawing.Point(68, 72);
			this.mAttackText1.Name = "mAttackText1";
			this.mAttackText1.Size = new System.Drawing.Size(100, 20);
			this.mAttackText1.TabIndex = 2;
			this.mAttackText1.Text = "120";
			this.mAttackText1.TextChanged += new System.EventHandler(this.mAttackText1_TextChanged);
			// 
			// mLevelText1
			// 
			this.mLevelText1.Location = new System.Drawing.Point(68, 46);
			this.mLevelText1.Name = "mLevelText1";
			this.mLevelText1.Size = new System.Drawing.Size(100, 20);
			this.mLevelText1.TabIndex = 1;
			this.mLevelText1.Text = "100";
			this.mLevelText1.TextChanged += new System.EventHandler(this.mLevelText1_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Power:";
			// 
			// mHPText1
			// 
			this.mHPText1.Location = new System.Drawing.Point(68, 20);
			this.mHPText1.Name = "mHPText1";
			this.mHPText1.Size = new System.Drawing.Size(100, 20);
			this.mHPText1.TabIndex = 0;
			this.mHPText1.TextChanged += new System.EventHandler(this.mHPText1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Defense:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Attack:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Level:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "HP:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.mPowerText2);
			this.groupBox2.Controls.Add(this.mDefenseText2);
			this.groupBox2.Controls.Add(this.mAttackText2);
			this.groupBox2.Controls.Add(this.mLevelText2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.mHPText2);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Location = new System.Drawing.Point(322, 257);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(249, 161);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Stats";
			// 
			// mPowerText2
			// 
			this.mPowerText2.Location = new System.Drawing.Point(68, 124);
			this.mPowerText2.Name = "mPowerText2";
			this.mPowerText2.Size = new System.Drawing.Size(100, 20);
			this.mPowerText2.TabIndex = 4;
			this.mPowerText2.Text = "100";
			this.mPowerText2.TextChanged += new System.EventHandler(this.mPowerText2_TextChanged);
			// 
			// mDefenseText2
			// 
			this.mDefenseText2.Location = new System.Drawing.Point(68, 98);
			this.mDefenseText2.Name = "mDefenseText2";
			this.mDefenseText2.Size = new System.Drawing.Size(100, 20);
			this.mDefenseText2.TabIndex = 3;
			this.mDefenseText2.Text = "50";
			this.mDefenseText2.TextChanged += new System.EventHandler(this.mDefenseText2_TextChanged);
			// 
			// mAttackText2
			// 
			this.mAttackText2.Location = new System.Drawing.Point(68, 72);
			this.mAttackText2.Name = "mAttackText2";
			this.mAttackText2.Size = new System.Drawing.Size(100, 20);
			this.mAttackText2.TabIndex = 2;
			this.mAttackText2.Text = "60";
			this.mAttackText2.TextChanged += new System.EventHandler(this.mAttackText2_TextChanged);
			// 
			// mLevelText2
			// 
			this.mLevelText2.Location = new System.Drawing.Point(68, 46);
			this.mLevelText2.Name = "mLevelText2";
			this.mLevelText2.Size = new System.Drawing.Size(100, 20);
			this.mLevelText2.TabIndex = 1;
			this.mLevelText2.Text = "100";
			this.mLevelText2.TextChanged += new System.EventHandler(this.mLevelText2_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Power:";
			// 
			// mHPText2
			// 
			this.mHPText2.Location = new System.Drawing.Point(68, 20);
			this.mHPText2.Name = "mHPText2";
			this.mHPText2.Size = new System.Drawing.Size(100, 20);
			this.mHPText2.TabIndex = 0;
			this.mHPText2.Text = "39";
			this.mHPText2.TextChanged += new System.EventHandler(this.mHPText2_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Defense:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Attack:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(36, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Level:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(25, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "HP:";
			// 
			// mFightBtn
			// 
			this.mFightBtn.AutoSize = true;
			this.mFightBtn.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mFightBtn.Location = new System.Drawing.Point(240, 441);
			this.mFightBtn.Name = "mFightBtn";
			this.mFightBtn.Size = new System.Drawing.Size(104, 41);
			this.mFightBtn.TabIndex = 14;
			this.mFightBtn.Text = "FIGHT";
			this.mFightBtn.UseVisualStyleBackColor = true;
			this.mFightBtn.Click += new System.EventHandler(this.mFightBtn_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(240, 316);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(85, 17);
			this.radioButton1.TabIndex = 15;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(390, 464);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 17);
			this.radioButton2.TabIndex = 16;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "radioButton2";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 495);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.mFightBtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mPicture1);
			this.Controls.Add(this.mPicture2);
			this.Name = "Form1";
			this.Text = "Plz Don\'t Sue Me Nintendo";
			((System.ComponentModel.ISupportInitialize)(this.mPicture2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mPicture1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox mPicture2;
		private System.Windows.Forms.PictureBox mPicture1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox mPowerText1;
		private System.Windows.Forms.TextBox mDefenseText1;
		private System.Windows.Forms.TextBox mAttackText1;
		private System.Windows.Forms.TextBox mLevelText1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox mHPText1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox mPowerText2;
		private System.Windows.Forms.TextBox mDefenseText2;
		private System.Windows.Forms.TextBox mAttackText2;
		private System.Windows.Forms.TextBox mLevelText2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox mHPText2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button mFightBtn;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
	}
}

