using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Data.Enumerations;
using TeamBuilder.Data.Events.HeroCreated;
using TeamBuilder.Data.Models.Hero;

namespace TeamBuilder.Data.Factories
{
    public delegate void OnHeroCreatedEventHandler(HeroCreatedEventArgs eventArgs);

    public static class HeroFactory
    {
        private const double MAXIMUM_MANA_CAPACITY = 800;
        private const double MANA_REGEN_RATE = 5.5;

        private const double MAXIMUM_ENERGY_CAPACITY = 200;
        private const double ENERGY_REGEN_RATE = 20;

        public static event OnHeroCreatedEventHandler HeroCreated = null;

        public static Hero Create(ResourceType resourceType, string name = "", double dps = 0, double health = 0)
        {
            Hero hero = null;

            switch (resourceType)
            {
                case ResourceType.Unassigned:
                    hero = new ManaHero(name, dps, health, new Hero.AbilityResource(ResourceType.Mana, MAXIMUM_MANA_CAPACITY, MANA_REGEN_RATE));
                    break;
                case ResourceType.Mana:
                    hero = new ManaHero(name, dps, health, new Hero.AbilityResource(ResourceType.Mana, MAXIMUM_MANA_CAPACITY, MANA_REGEN_RATE));
                    break;
                case ResourceType.Energy:
                    hero = new EnergyHero(name, dps, health, new Hero.AbilityResource(ResourceType.Energy, MAXIMUM_ENERGY_CAPACITY, ENERGY_REGEN_RATE));
                    break;
                case ResourceType.Health:
                    hero = new HealthHero(name, dps, health, new Hero.AbilityResource(ResourceType.Health, health, 0));
                    break;
                default:
                    throw new NotImplementedException();
            }

            if (hero != null)
            {
                HeroCreated?.Invoke(new HeroCreatedEventArgs(hero, DateTime.Now, MAXIMUM_MANA_CAPACITY));
            }

            return hero;
        }
    }
}
