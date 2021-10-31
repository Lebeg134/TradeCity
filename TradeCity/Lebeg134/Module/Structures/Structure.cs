/**
 * @(#) Structure.cs
 */

namespace Lebeg134.Module.Structures
{
	public abstract class Structure
	{
		protected bool state; //true = on, false = off
		public virtual void On()
        {
			state = true;
        }
		public virtual void Off()
        {
			state = false;
        }
		public bool GetState()
        {
			return state;
        }
	}
}
