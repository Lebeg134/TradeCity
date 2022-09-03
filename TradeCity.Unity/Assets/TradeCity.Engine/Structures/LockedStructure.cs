using System;
using TradeCity.Units;

/**
* @(#) LockedStructure.cs
*/
namespace TradeCity.Engine.Structures
{
    [Serializable]
    public class LockedStructure : Structure
    {
        private readonly Structure subject;

        private LockedStructure(Structure subject)
        {
            subject.Off();
            this.subject = subject;
        }
        public static LockedStructure Wrap(Structure subject)
        {
            return new LockedStructure(subject);
        }
        public Structure Unwrap()
        {
            subject.On();
            return subject;
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
            return "Locked " + subject.GetName();
        }

        public override Branches GetBranch()
        {
            throw new NotImplementedException();
        }
    }

}
