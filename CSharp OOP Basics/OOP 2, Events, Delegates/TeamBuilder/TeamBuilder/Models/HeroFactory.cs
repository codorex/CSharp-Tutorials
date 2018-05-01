using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Events.HeroCreated;
using TeamBuilder.Models.Heroes;
using static TeamBuilder.Models.Enumerations.ModelEnumerations;

namespace TeamBuilder.Models
{
	public delegate void HeroCreatedEventHandler(HeroCreatedEventArgs e, object sender);
	public static class HeroFactory
	{
		private const double MAXIMUM_MANA_CAPACITY = 800;
		private const double MAXIMUM_ENERGY_CAPACITY = 200;

		private const double MANA_REGEN = 5.5;
		private const double ENERGY_REGEN = 20;

		public static event HeroCreatedEventHandler HeroCreated;

		public static Hero Create(ResourceType resourceType, string name = "", double dps = 0, double health = 0)
		{
			switch (resourceType)
			{
				case ResourceType.Undefined:
					var hero = new ManaUser(name, dps, health, new Hero.AbilityResource(ResourceType.Mana, MAXIMUM_MANA_CAPACITY, MANA_REGEN));
					InvokeEvent(hero);
					return hero;
				case ResourceType.Mana:
					var manaHero = new ManaUser(name, dps, health, new Hero.AbilityResource(ResourceType.Mana, MAXIMUM_MANA_CAPACITY, MANA_REGEN));
					InvokeEvent(manaHero);
					return manaHero;
				case ResourceType.Health:
					var healthHero = new HealthUser(name, dps, health, new Hero.AbilityResource(ResourceType.Health, 0, 0));
					InvokeEvent(healthHero);
					return healthHero;
				case ResourceType.Energy:
					var energyHero = new EnergyUser(name, dps, health, new Hero.AbilityResource(ResourceType.Energy, MAXIMUM_ENERGY_CAPACITY, ENERGY_REGEN));
					InvokeEvent(energyHero);
					return energyHero;
				default:
					throw new ArgumentOutOfRangeException($"Cannot create Hero of requested type {resourceType}.");
			}
		}

		public static void OnHeroCreated(HeroCreatedEventArgs e)
		{
			HeroCreated?.Invoke(e, new object());
			HeroCreated = null;
		}

		private static void InvokeEvent(Hero hero)
		{
			OnHeroCreated(new HeroCreatedEventArgs { Hero = hero });
		}
	}
}
