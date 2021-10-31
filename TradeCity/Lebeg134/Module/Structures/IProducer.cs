/**
 * @(#) IProducer.cs
 */

namespace Lebeg134.Module.Structures
{
	using TimeManager = Lebeg134.Module.TimeManager;
	
	public interface IProducer : TimeManager.ITickable
	{
		Lebeg134.Module.Resources.Resource getProuce(  );
		
		Lebeg134.Module.Resources.Resource produce(  );
		
	}
	
}
