/**
 * @(#) IProducer.cs
 */
using JHP4SD.Lebeg134.Module.Resources;
using System.Collections.Generic;
using JHP4SD.Lebeg134.Module.TimeManager;
namespace JHP4SD.Lebeg134.Module.Structures
{
	public interface IProducer : ITickable
	{
		List<Resource> getProduce();
		void Produce();
	}

}
