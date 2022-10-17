using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    public enum RecipePriority
    {
        Highest,
        High,
        Medium,
        Low
    }

    [Serializable]
    public abstract class Recipe
    {
        protected List<Resource> _input;
        protected List<Resource> _output;

        protected Recipe(int limit)
        {
            _input = new List<Resource>();
            _output = new List<Resource>();
            Limit = limit;
        }

        public string Name { get; set; }
        public int Limit { get; set; }
        public RecipePriority InputPriority { get; set; }
        public List<Resource> Input => _input;

        /// <summary>
        ///     Method subtracts maximum amount from given resource to produce with full capacity
        /// </summary>
        /// <param name="resource">Resource to be subtracted from</param>
        public abstract int AddResource(Resource resource);

        protected abstract void Process();

        public List<Resource> Produce()
        {
            foreach (var resource in _input) //TODO Potential error if custom ticks are implemented
                resource.Tick();
            Process();
            return _output;
        }
    }
}