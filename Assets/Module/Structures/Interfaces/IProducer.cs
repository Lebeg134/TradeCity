/**
 * @(#) IProducer.cs
 */
using Assets.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System.Collections.Generic;
namespace Lebeg134.Module.Structures
{
    public interface IProducer
    {
        List<Recipe> Recipes { get; }
        void PutResources(List<Resource> resources);
        List<Resource> GetProduce();
    }

}
