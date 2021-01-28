using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TalentPool
{
	public partial class FrMain : Form
	{
		SqlConnection connection;
		string connectionString;

		public FrMain()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["TalentPool.Properties.Settings.TalentPoolConnectionString"].ConnectionString;
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			PopulateUsers();
			

		}
		private void PopulateUsers()
		{
			using (connection = new SqlConnection(connectionString))
			using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM USERS", connection))
			{

				DataTable usersTable = new DataTable();
				adapter.Fill(usersTable);

				lstUsers.DisplayMember = "Name";
				lstUsers.ValueMember = "Id";
				lstUsers.DataSource = usersTable;

			}
		}

		private void PopulateSkills()
		{
			string query = "SELECT a.Name FROM Skills a " +
				"INNER JOIN UserSkills b ON a.Id = b.SkillsId" +
				"WHERE b.UserId = @UserId";
			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				command.Parameters.AddWithValue("@UserId", lstUsers.SelectedValue);

				DataTable skillsTable = new DataTable();
				adapter.Fill(skillsTable);

				lstSkills.DisplayMember = "Name";
				lstSkills.ValueMember = "Id";
				lstSkills.DataSource = skillsTable;

			}
		}


		private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			PopulateSkills();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
	}

