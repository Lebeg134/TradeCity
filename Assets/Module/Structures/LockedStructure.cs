using System;
/**
* @(#) LockedStructure.cs
*/
namespace Lebeg134.Module.Structures
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
		public static LockedStructure Wrap( Structure subject )
		{
			return new LockedStructure(subject);
		}
		public Structure Unwrap()
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

        public override string GetName()
        {
			return "Locked";
        }
    }
	
}
