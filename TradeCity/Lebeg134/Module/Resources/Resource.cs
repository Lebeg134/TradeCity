/**
 * @(#) Resource.cs
 */

namespace Lebeg134.Module.Resources
{
	public abstract class Resource
	{
		static Integer id;
		
		Lebeg134.Module.Structures.Building building;
		
		Lebeg134.Module.Structures.IUpgradeable IUp;
		
		Lebeg134.Module.Structures.IProducer IPro;
		
		Integer amount;
		
		public void gain( Integer amount )
		{
			
		}
		
		public void spend( Integer amount )
		{
			
		}
		
	}
	
}
