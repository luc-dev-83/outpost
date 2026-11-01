using OutpostConsole.Planets;

namespace OutpostConsole.Simulation;

public class SimulationEngine
{
    private List<Planet> _planets = new(2); 
    public void Tick()
    {
        _planets.ForEach(p=>p.Tick());
    }
    
    public void AddPlanet(Planet planet) => _planets.Add(planet);
}