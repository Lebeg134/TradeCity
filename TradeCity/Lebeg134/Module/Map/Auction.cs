/**
 * @(#) Auction.cs
 */

namespace Lebeg134.Module.Map
{
	using TimeManager = Lebeg134.Module.TimeManager;
	
	public class Auction : TimeManager.ITickable
	{
		Lebeg134.Module.Structures.Land subject;
		
		Integer curPrice;
		
		Integer minBid;
		
		Lebeg134.Module.Session.Player lastBidder;
		
		Integer timeRemaining;
		
		Integer timePerRound;
		
		public void bid( Lebeg134.Module.Session.Player by, Integer bid )
		{
			
		}
		
		public void finish(  )
		{
			
		}
		
	}
	
}
