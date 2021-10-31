/**
 * @(#) IProducer.cs
 */
using Lebeg134.Module.Resources;
using System.Collections.Generic;
using Lebeg134.Module.TimeManager;
namespace Lebeg134.Module.Structures
{
	public interface IProducer : ITickable
	{
		List<Resource> getProduce();
		void Produce();
	}

}
