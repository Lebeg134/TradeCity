/**
 * @(#) Auction.cs
 */

namespace Lebeg134.Module.Map
{
	using TimeManager = Lebeg134.Module.TimeManager;
	
	public class Auction : TimeManager.ITickable
	{
		Lebeg134.Module.Structures.Land subject;
		
		int curPrice;
		
		int minBid;
		
		Lebeg134.Module.Session.Player lastBidder;
		
		int timeRemaining;
		
		int timePerRound;
		
		public void bid( Lebeg134.Module.Session.Player by, int bid )
		{
			
		}
		
		public void finish(  )
		{
			
		}
		
	}
	
}
