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
      this.button1 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.tb_heroName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tb_heroDps = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tb_heroHealth = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tb_heroMana = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tb_heroRole = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(233, 188);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(135, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(12, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(170, 199);
      this.listBox1.TabIndex = 1;
      // 
      // tb_heroName
      // 
      this.tb_heroName.Location = new System.Drawing.Point(268, 12);
      this.tb_heroName.Name = "tb_heroName";
      this.tb_heroName.Size = new System.Drawing.Size(100, 20);
      this.tb_heroName.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(198, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Hero Name:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(230, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "DPS:";
      // 
      // tb_heroDps
      // 
      this.tb_heroDps.Location = new System.Drawing.Point(268, 40);
      this.tb_heroDps.Name = "tb_heroDps";
      this.tb_heroDps.Size = new System.Drawing.Size(100, 20);
      this.tb_heroDps.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(221, 69);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Health:";
      // 
      // tb_heroHealth
      // 
      this.tb_heroHealth.Location = new System.Drawing.Point(268, 66);
      this.tb_heroHealth.Name = "tb_heroHealth";
      this.tb_heroHealth.Size = new System.Drawing.Size(100, 20);
      this.tb_heroHealth.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(221, 96);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Mana:";
      // 
      // tb_heroMana
      // 
      this.tb_heroMana.Location = new System.Drawing.Point(268, 92);
      this.tb_heroMana.Name = "tb_heroMana";
      this.tb_heroMana.Size = new System.Drawing.Size(100, 20);
      this.tb_heroMana.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(230, 144);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(32, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Role:";
      // 
      // tb_heroRole
      // 
      this.tb_heroRole.Location = new System.Drawing.Point(268, 141);
      this.tb_heroRole.Name = "tb_heroRole";
      this.tb_heroRole.Size = new System.Drawing.Size(100, 20);
      this.tb_heroRole.TabIndex = 11;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(394, 228);
      this.Controls.Add(this.tb_heroRole);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.tb_heroMana);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tb_heroHealth);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tb_heroDps);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tb_heroName);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox tb_heroName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb_heroDps;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tb_heroHealth;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tb_heroMana;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tb_heroRole;
  }
}