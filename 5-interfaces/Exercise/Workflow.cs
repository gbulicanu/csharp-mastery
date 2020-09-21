using System.Collections.Generic;

namespace Exercise
{
    public class Workflow
    {
        public List<IActivity> Activities { get; private set; }

        public Workflow()
        {
            this.Activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity) 
        {
            this.Activities.Add(activity);
        }
        
    }
}