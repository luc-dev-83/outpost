namespace OutpostConsole.Buildings;

using OutpostConsole.Planets;

public class Laboratory : Building
{
    private readonly Dictionary<ResourceType, int> _logistique = new()
    {
        { ResourceType.Energy, -3 },
        { ResourceType.Science, 5 }
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