/**
 * @(#) Player.cs
 */

namespace Lebeg134.Module.Session
{
	using TimeManager = Lebeg134.Module.TimeManager;
	
	public class Player : TimeManager.ITickable
	{
		Session session;
		
		Lebeg134.Module.Structures.Building ownedBuildings;
		
		Lebeg134.Module.Structures.Land ownedLands;
		
		Lebeg134.Module.Resources.Resource ownedResources;
		
		IPlayerStrategy playerStrategy;
		
		void simResources(  )
		{
			
		}
		
		void goBankrupt(  )
		{
			
		}
		
		public bool hasStructure( Lebeg134.Module.Structures.IOwnable structure )
		{
			return null;
		}
		
		public void giveStructure( Lebeg134.Module.Structures.IOwnable structure )
		{
			
		}
		
		public bool hasRes( Lebeg134.Module.Resources.Resource res )
		{
			return null;
		}
		
		public void subRes( Lebeg134.Module.Resources.Resource res )
		{
			
		}
		
		public int getRes( Lebeg134.Module.Resources.Resource resource )
		{
			return null;
		}
		
		public void giveRes( Lebeg134.Module.Resources.Resource resource )
		{
			
		}
		
		public void freeze(  )
		{
			
		}
		
		public void unFreeze(  )
		{
			
		}
		
		public bool isFrozen(  )
		{
			return null;
		}
		
		public void tick(  )
		{
			
		}
		
		public Lebeg134.Module.Resources.Resource getProduces(  )
		{
			return null;
		}
		
	}
	
}
