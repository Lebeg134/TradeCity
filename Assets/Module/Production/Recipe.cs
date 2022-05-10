﻿using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Production
{
    public enum RecipePriority
    {
        HIGHEST,
        HIGH,
        MEDIUM,
        LOW,
    }
    public abstract class Recipe
    {
        public string Name { get; set; }
        private List<Resource> input;
        private List<Resource> output;
        public RecipePriority InputPriority { get; set; }
        public List<Resource>  Input => input;

        /// <summary>
        /// Method subtracts maximum amount from given resource to produce with full capacity
        /// </summary>
        /// <param name="resource">Resource to be subtracted from</param>
        public abstract int AddResource(Resource resource);
        protected abstract void Process();
        public List<Resource> Produce()
        {
            Process();
            return output;
        }
    }
}
