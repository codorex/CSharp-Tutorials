using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamBuilder.Data;
using TeamBuilder.Data.Enumerations;
using TeamBuilder.Data.Events.HeroCreated;
using TeamBuilder.Data.Factories;
using TeamBuilder.Data.Models.Hero;
using TeamBuilder.Views;

namespace TeamBuilder
{
    public partial class Form1 : Form
    {
        private Builder teamBuilder;

        public Form1()
        {
            InitializeComponent();

            teamBuilder = new Builder();
        }

        private void heroFactory_HeroCreated(HeroCreatedEventArgs e)
        {
            MessageBox.Show($"Created Hero: {e.Hero.GetType().Name} on {e.DateCreated}");
        }

        private void lb_heroes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var createView = new CreateHeroView(teamBuilder);
            createView.ShowDialog();
        }
    }
}
