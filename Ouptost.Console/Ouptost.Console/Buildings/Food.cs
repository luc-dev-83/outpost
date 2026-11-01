namespace OutpostConsole.Buildings;

using OutpostConsole.Planets;

public class Food : Building
{
    private readonly Dictionary<ResourceType, int> _logistique = new()
    {
        { ResourceType.Energy, -1 },
        { ResourceType.Food, 5 }
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