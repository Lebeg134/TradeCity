/**
 * @(#) StandardPlayerStrategy.cs
 */
using System.Collections.Generic;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;

namespace JHP4SD.Lebeg134.Module.Session
{
    public partial class Player
    {
        public class StandardPlayerStrategy : PlayerStrategyBase
        {
            public StandardPlayerStrategy(Player subject) : base(subject) { }
            public override void tick()
            {
                System.Console.WriteLine("Ticked"); //DEBUG
                Produce();
            }
            private void Produce()
            {
                List<Resource> previousState = new List<Resource>();
                foreach (Resource cntRes in player.ownedResources.Values)
                {
                    if (cntRes is ContinousResource)
                    {
                        previousState.Add(cntRes.getNewResource(cntRes.amount()));
                        System.Console.WriteLine("cntRes: " + cntRes); //DEBUG
                    }
                }
                foreach (IProducer producer in player.owned)
                {
                    producer.Produce();
                }
                player.subRes(previousState);
            }
        }
    }
}
