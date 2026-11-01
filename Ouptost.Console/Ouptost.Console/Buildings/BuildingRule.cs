using System.Collections.Generic;
using OutpostConsole.Planets;

namespace OutpostConsole.Buildings;

public class BuildingRule
{
    public Dictionary<BuildingType, Dictionary<ResourceType, int>> RessourceByBuilding { get; } = new()
        {
            {
                BuildingType.Mine, new Dictionary<ResourceType, int>()
                {
                    { ResourceType.Energy, -2 },
                    { ResourceType.Ore, 10 }
                }
                
            },
            {
                BuildingType.Food, new Dictionary<ResourceType, int>()
                {
                    { ResourceType.Energy, -2 },
                    { ResourceType.Food, 10 }
                }
            },
            {
                BuildingType.Generator, new Dictionary<ResourceType, int>()
                {
                    { ResourceType.Energy, 10 }
                }
            },
            {
                BuildingType.Laboratory, new Dictionary<ResourceType, int>()
                {
                    { ResourceType.Energy, -2 }
                }
            }
        };




}