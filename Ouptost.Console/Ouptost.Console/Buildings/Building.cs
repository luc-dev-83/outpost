using OutpostConsole.Planets;

namespace OutpostConsole.Buildings;

public abstract class Building
{
   public abstract void Tick(ResourceStock resources);
}