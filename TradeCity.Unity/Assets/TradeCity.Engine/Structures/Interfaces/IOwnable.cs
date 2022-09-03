/**
* @(#) IOwnable.cs
*/
using Lebeg134.Module.Session;
namespace Lebeg134.Module.Structures
{
    public interface IOwnable
    {
        Player Owner { get; }
        void Acquire(Player by);
    }
}
