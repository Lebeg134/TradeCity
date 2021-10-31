/**
 * @(#) ISellable.cs
 */

namespace Lebeg134.Module.Market
{
	public interface ISellable
	{
		double gerValue(  );
		
		void simulatePrice(  );
		
		void reportListing( Listing listing );
		
	}
	
}
