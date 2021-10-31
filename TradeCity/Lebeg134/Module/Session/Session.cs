/**
 * @(#) Session.cs
 */

namespace Lebeg134.Module.Session
{
	using TimeManager = Lebeg134.Module.TimeManager;
	
	public class Session : TimeManager.ITickable
	{
		Lebeg134.Module.Market.Market market;
		
		Player players;
		
		Lebeg134.Module.Map.Map map;
		
		TimeManager.Clock clock;
		
		public void load( String path )
		{
			
		}
		
		public void save( String path )
		{
			
		}
		
		public void login( Player player )
		{
			
		}
		
		public void logout( Player player )
		{
			
		}
		
		public void deletePlayer( Player player )
		{
			
		}
		
	}
	
}
