/**
 * @(#) ITickable.cs
 */

namespace Lebeg134.Module.TimeManager
{
	public interface ITickable
	{
		void tick(  );
		
		void reigsterClock( Clock clock );
		
	}
	
}
