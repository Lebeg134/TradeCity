/**
 * @(#) IPlayerStrategy.cs
 */

namespace Lebeg134.Module.Session
{
	public interface IPlayerStrategy
	{
		void tick(  );
		
		void freeze(  );
		
		void unFreeze(  );
		
		bool isFrozen(  );
		
		void goBankrupt(  );
		
	}
	
}
