/**
 * @(#) ITickable.cs
 */

namespace Lebeg134.Module.TimeManager
{
	public interface ITickable
	{
		void Tick();
		void Register();
	}
}
