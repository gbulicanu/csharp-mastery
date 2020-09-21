using System.Collections.Generic;

namespace Exercise
{
    public class Workflow
    {
        private readonly List<IActivity> activities;

        public Workflow()
        {
            this.activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity) 
        {
            this.activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities() 
        {
            return activities;
        }
        
    }
}