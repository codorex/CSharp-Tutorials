using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamBuilder.Data;

namespace TeamBuilder.Views
{
    public partial class CreateHeroView : Form
    {
        private Builder teamBuilder;

        public CreateHeroView(Builder teamBuilder)
        {
            InitializeComponent();

            this.teamBuilder = teamBuilder;
        }
    }
}
