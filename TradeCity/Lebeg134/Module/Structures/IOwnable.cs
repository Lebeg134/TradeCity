/**
 * @(#) IOwnable.cs
 */

namespace Lebeg134.Module.Structures
{
	public interface IOwnable
	{
		void acquire( Lebeg134.Module.Session.Player by );
		
	}
	
}
