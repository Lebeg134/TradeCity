/**
* @(#) ISellable.cs
*/
using Lebeg134.Module.Resources;
using System.Collections.Generic;
namespace Lebeg134.Module.MarketNS
{
    public interface ISellable : IEqualityComparer<ISellable>
    {
        double GetValue();
        void SimulatePrice();
        Resource GetNewResource(int amount);
        int Amount();
    }
}
