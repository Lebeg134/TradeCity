

using JHP4SD.GumRuntimes;
using System;
/**
* @(#) LockedStructure.cs
*/
namespace JHP4SD.Lebeg134.Module.Structures
{
    [Serializable]
    public class LockedStructure : Structure
	{
		Structure _subject;
		
		LockedStructure(Structure subject)
        {
			subject.Off();
			_subject = subject;
        }
		public static LockedStructure wrap( Structure subject )
		{
			return new LockedStructure(subject);
		}
		public Structure unwrap()
		{
			_subject.On();
			return _subject;
		}
        public override void On()
        {
            //Do nothing
        }
        public override void Off()
        {
            //Do nothing
        }

        public override string getName()
        {
			return "Locked";
        }

        public override SpriteRuntime GetSprite()
        {
            // TODO
            throw new System.NotImplementedException();
        }
    }
	
}