/**
 * @(#) IProducer.cs
 */
using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System.Collections.Generic;
namespace Lebeg134.Module.Structures
{
    public interface IProducer : ITickable
    {
        List<Resource> GetProduce();
        List<Resource> GetUpkeep();
        void Produce();
    }

}
