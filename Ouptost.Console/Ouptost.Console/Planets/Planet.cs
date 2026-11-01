namespace OutpostConsole.Planets;

using OutpostConsole.Buildings;
public class Planet
{
    public ResourceStock Resources { get; } = new();
    
    private List<Building>  Buildings { get; } = new List<Building>(2);
    
    public void Tick() => Buildings.ForEach(b=>b.Tick(Resources));
 
    public void AddBuilding(Building building) => Buildings.Add(building);
    
    public void RemoveBuilding(Building building) => Buildings.Remove(building);
    
}