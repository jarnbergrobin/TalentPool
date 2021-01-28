
namespace TalentPool
{
	partial class FrMain
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
			this.lbUsers = new System.Windows.Forms.Label();
			this.lstUsers = new System.Windows.Forms.ListBox();
			this.lstSkills = new System.Windows.Forms.ListBox();
			this.lbUserSkill = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbUsers
			// 
			this.lbUsers.AutoSize = true;
			this.lbUsers.Location = new System.Drawing.Point(13, 13);
			this.lbUsers.Name = "lbUsers";
			this.lbUsers.Size = new System.Drawing.Size(34, 13);
			this.lbUsers.TabIndex = 0;
			this.lbUsers.Text = "Users";
			// 
			// lstUsers
			// 
			this.lstUsers.FormattingEnabled = true;
			this.lstUsers.Location = new System.Drawing.Point(12, 29);
			this.lstUsers.Name = "lstUsers";
			this.lstUsers.Size = new System.Drawing.Size(120, 147);
			this.lstUsers.TabIndex = 1;
			this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
			// 
			// lstSkills
			// 
			this.lstSkills.FormattingEnabled = true;
			this.lstSkills.Location = new System.Drawing.Point(175, 29);
			this.lstSkills.Name = "lstSkills";
			this.lstSkills.Size = new System.Drawing.Size(120, 147);
			this.lstSkills.TabIndex = 3;
			// 
			// lbUserSkill
			// 
			this.lbUserSkill.AutoSize = true;
			this.lbUserSkill.Location = new System.Drawing.Point(176, 13);
			this.lbUserSkill.Name = "lbUserSkill";
			this.lbUserSkill.Size = new System.Drawing.Size(63, 13);
			this.lbUserSkill.TabIndex = 2;
			this.lbUserSkill.Text = "User\'s Skills";
			this.lbUserSkill.Click += new System.EventHandler(this.label1_Click);
			// 
			// FrMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 450);
			this.Controls.Add(this.lstSkills);
			this.Controls.Add(this.lbUserSkill);
			this.Controls.Add(this.lstUsers);
			this.Controls.Add(this.lbUsers);
			this.Name = "FrMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbUsers;
		private System.Windows.Forms.ListBox lstUsers;
		private System.Windows.Forms.ListBox lstSkills;
		private System.Windows.Forms.Label lbUserSkill;
	}
}

