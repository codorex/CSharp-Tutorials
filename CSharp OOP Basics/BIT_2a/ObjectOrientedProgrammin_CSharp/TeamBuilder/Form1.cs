using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamBuilder.Models;

namespace TeamBuilder
{
  public partial class Form1 : Form
  {
    Builder teamBuilder;
    public Form1()
    {
      InitializeComponent();

      teamBuilder = new Builder();
    }

    private bool ValidateField(string fieldValue)
    {
      return String.IsNullOrEmpty(fieldValue);
    }

    private bool ValidateNumericField(string fieldValue)
    {
      int value;
      return Int32.TryParse(fieldValue, out value);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (ValidateField(tb_heroName.Text) &&
          ValidateField(tb_heroRole.Text) &&
          ValidateNumericField(tb_heroHealth.Text) &&
          ValidateNumericField(tb_heroMana.Text) &&
          ValidateNumericField(tb_heroDps.Text)
        )
      {
        Hero hero = new Hero();
        hero.Name = tb_heroName.Text;
        hero.Health = Int32.Parse(tb_heroHealth.Text);
        hero.Mana = Int32.Parse(tb_heroMana.Text);
        hero.DPS = Int32.Parse(tb_heroDps.Text);

        try
        {
          teamBuilder.Enlist(hero, tb_heroRole.Text);
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message);
        }

        listBox1.Items.Clear();
        foreach (var item in teamBuilder.Heroes)
        {
          listBox1.Items.Add(item.Value);
        }
      }
    }
  }
}
