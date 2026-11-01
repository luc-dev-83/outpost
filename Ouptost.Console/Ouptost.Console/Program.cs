namespace OutpostConsole;

using OutpostConsole.Buildings;
using OutpostConsole.Planets;
using OutpostConsole.Simulation;

class Program
{
    public static void Main()
    {
        Planet planet = new();
        SimulationEngine engine = new();

        planet.AddBuilding(new Mine());
        planet.AddBuilding(new Generator());
        planet.AddBuilding(new Food());
        planet.AddBuilding(new Laboratory());
        
        engine.AddPlanet(planet);
        
        for (var day = 1; day <= 10; day++)
        {
            engine.Tick();

            Console.WriteLine(
                $"Day {day} : " +
                $"Ore={planet.Resources.Get(ResourceType.Ore)}, " +
                $"Energy={planet.Resources.Get(ResourceType.Energy)}, " +
                $"Food={planet.Resources.Get(ResourceType.Food)}, " +
                $"Science={planet.Resources.Get(ResourceType.Science)}"
            );
        }
        
    }
}




