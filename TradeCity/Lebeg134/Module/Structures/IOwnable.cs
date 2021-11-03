/**
* @(#) IOwnable.cs
*/
using JHP4SD.Lebeg134.Module.Session;
namespace JHP4SD.Lebeg134.Module.Structures
{
    public interface IOwnable
    {
        void acquire(Player by);
    }
}
