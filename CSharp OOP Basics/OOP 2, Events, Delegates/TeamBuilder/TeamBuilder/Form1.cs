using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamBuilder.Events.HeroCreated;
using TeamBuilder.Exceptions;
using TeamBuilder.Models;
using TeamBuilder.Models.Heroes;
using static TeamBuilder.Models.Enumerations.ModelEnumerations;

namespace TeamBuilder
{
	public partial class Form1 : Form
	{
		private Builder builder;
		public Form1()
		{
			InitializeComponent();

			builder = new Builder();
			lb_heroes.DisplayMember = "Name";

			foreach (var role in Enum.GetValues(typeof(TeamRole)))
			{
				cb_roles.Items.Add(role);
			}

			foreach (var resource in Enum.GetValues(typeof(ResourceType)))
			{
				cb_resource.Items.Add(resource);
			}
		}

		private void btn_addHero_Click(object sender, EventArgs e)
		{
			if (ValidateField(tb_heroName) &
				ValidateNumericField(tb_heroDps) &
				ValidateNumericField(tb_heroHealth) &
				ValidateDropdown(cb_resource) &
				ValidateDropdown(cb_roles))
			{
				string heroName = tb_heroName.Text;
				double heroDps = Double.Parse(tb_heroDps.Text);
				double heroHealth = Double.Parse(tb_heroHealth.Text);

				ResourceType heroResource = (ResourceType)cb_resource.SelectedItem;
				TeamRole role = (TeamRole)cb_roles.SelectedItem;

				try
				{
					HeroFactory.HeroCreated += heroFactory_HeroCreated;

					builder.Enlist(HeroFactory.Create(heroResource, heroName, heroDps, heroHealth), role);
					RefreshHeroesList();
					ClearFields();
				}
				catch (TeamRoleTakenException ex)
				{
					MessageBox.Show($"The role \"{ex.Role}\" is already taken by {ex.Occupant.Name}");
				}
			}
		}

		private void heroFactory_HeroCreated(HeroCreatedEventArgs e, object sender)
		{
			MessageBox.Show($"Created hero {e.Hero.Name}\n -DPS: {e.Hero.DPS}\n -Health: {e.Hero.Health}\n -Resource: {e.Hero.Resource.Type}");
		}

		private bool ValidateField(TextBox field)
		{
			bool isValid = (String.IsNullOrEmpty(field.Text) == false);

			PaintControlByValidity(field, isValid);

			return isValid;
		}

		private bool ValidateNumericField(TextBox field)
		{
			double number;
			bool isValid = Double.TryParse(field.Text, out number);

			PaintControlByValidity(field, isValid);

			return isValid;
		}

		private bool ValidateDropdown(ComboBox dropdown)
		{
			bool isValid = dropdown.SelectedItem != null;

			PaintControlByValidity(dropdown, isValid);

			return isValid;
		}

		private void PaintControlByValidity(Control control, bool isValid)
		{
			if (isValid == false)
			{
				control.BackColor = Color.Red;
			}
			else
			{
				control.BackColor = Color.White;
			}
		}

		private void ClearFields()
		{
			tb_heroDps.Text = "";
			tb_heroHealth.Text = "";
			tb_heroName.Text = "";
			cb_resource.SelectedIndex = -1;
			cb_roles.SelectedIndex = -1;
		}

		private void RefreshHeroesList()
		{
			lb_heroes.Items.Clear();
			foreach (var hero in builder.TeamSlots)
			{
				lb_heroes.Items.Add(hero.Value);
			}
		}
	}
}
