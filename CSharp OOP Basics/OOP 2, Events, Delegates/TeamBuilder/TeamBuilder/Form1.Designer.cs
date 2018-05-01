namespace TeamBuilder
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
			this.lb_heroes = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_heroName = new System.Windows.Forms.TextBox();
			this.tb_heroDps = new System.Windows.Forms.TextBox();
			this.tb_heroHealth = new System.Windows.Forms.TextBox();
			this.cb_roles = new System.Windows.Forms.ComboBox();
			this.btn_addHero = new System.Windows.Forms.Button();
			this.cb_resource = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_heroes
			// 
			this.lb_heroes.FormattingEnabled = true;
			this.lb_heroes.Location = new System.Drawing.Point(12, 12);
			this.lb_heroes.Name = "lb_heroes";
			this.lb_heroes.Size = new System.Drawing.Size(162, 251);
			this.lb_heroes.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(182, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hero Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(212, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "DPS:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(203, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Health:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(182, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Team Role:";
			// 
			// tb_heroName
			// 
			this.tb_heroName.Location = new System.Drawing.Point(250, 9);
			this.tb_heroName.Name = "tb_heroName";
			this.tb_heroName.Size = new System.Drawing.Size(100, 20);
			this.tb_heroName.TabIndex = 5;
			// 
			// tb_heroDps
			// 
			this.tb_heroDps.Location = new System.Drawing.Point(250, 35);
			this.tb_heroDps.Name = "tb_heroDps";
			this.tb_heroDps.Size = new System.Drawing.Size(100, 20);
			this.tb_heroDps.TabIndex = 6;
			// 
			// tb_heroHealth
			// 
			this.tb_heroHealth.Location = new System.Drawing.Point(250, 61);
			this.tb_heroHealth.Name = "tb_heroHealth";
			this.tb_heroHealth.Size = new System.Drawing.Size(100, 20);
			this.tb_heroHealth.TabIndex = 7;
			// 
			// cb_roles
			// 
			this.cb_roles.FormattingEnabled = true;
			this.cb_roles.Location = new System.Drawing.Point(250, 115);
			this.cb_roles.Name = "cb_roles";
			this.cb_roles.Size = new System.Drawing.Size(100, 21);
			this.cb_roles.TabIndex = 8;
			// 
			// btn_addHero
			// 
			this.btn_addHero.Location = new System.Drawing.Point(185, 240);
			this.btn_addHero.Name = "btn_addHero";
			this.btn_addHero.Size = new System.Drawing.Size(175, 23);
			this.btn_addHero.TabIndex = 9;
			this.btn_addHero.Text = "Add Hero";
			this.btn_addHero.UseVisualStyleBackColor = true;
			this.btn_addHero.Click += new System.EventHandler(this.btn_addHero_Click);
			// 
			// cb_resource
			// 
			this.cb_resource.FormattingEnabled = true;
			this.cb_resource.Location = new System.Drawing.Point(250, 87);
			this.cb_resource.Name = "cb_resource";
			this.cb_resource.Size = new System.Drawing.Size(100, 21);
			this.cb_resource.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(188, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Resource:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 276);
			this.Controls.Add(this.cb_resource);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_addHero);
			this.Controls.Add(this.cb_roles);
			this.Controls.Add(this.tb_heroHealth);
			this.Controls.Add(this.tb_heroDps);
			this.Controls.Add(this.tb_heroName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_heroes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lb_heroes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_heroName;
		private System.Windows.Forms.TextBox tb_heroDps;
		private System.Windows.Forms.TextBox tb_heroHealth;
		private System.Windows.Forms.ComboBox cb_roles;
		private System.Windows.Forms.Button btn_addHero;
		private System.Windows.Forms.ComboBox cb_resource;
		private System.Windows.Forms.Label label5;
	}
}

