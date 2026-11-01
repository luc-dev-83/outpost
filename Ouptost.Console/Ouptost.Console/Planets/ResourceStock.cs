using System.Collections.Generic;

namespace OutpostConsole.Planets;

public class ResourceStock
{
    private readonly Dictionary<ResourceType, int> _resources = new();
    
    public int this[ResourceType resource]
    {
        get => _resources.GetValueOrDefault(resource, 0);
        set => _resources[resource] = value;
    }
    
    public void Add(ResourceType type, int amount) 
    {
        _resources.TryAdd(type, 0);
        _resources[type] += amount;
    }
    
    public void Consume(ResourceType type, int amount) => _resources[type] -= amount;

    public int Get(ResourceType type) => _resources.GetValueOrDefault(type,  0);
}