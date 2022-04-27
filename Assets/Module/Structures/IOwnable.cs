/**
* @(#) IOwnable.cs
*/
using Lebeg134.Module.Session;
namespace Lebeg134.Module.Structures
{
    public interface IOwnable
    {
        void Acquire(Player by);
    }
}
