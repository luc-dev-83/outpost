namespace OutpostConsole.Buildings;

using OutpostConsole.Planets;

public class Mine : Building
{
    private readonly Dictionary<ResourceType, int> _logistique = new()
    {
        { ResourceType.Energy, -2 },
        { ResourceType.Ore, 10 }
    };

    override 
    public void Tick(ResourceStock resources)
    {
        foreach (var (key, value) in _logistique)
        {
            resources[key] += value;
        }
    }
}