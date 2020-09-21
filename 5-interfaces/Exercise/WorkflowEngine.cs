namespace Exercise
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.Activities)
            {
                activity.Execute();
            }
        }
    }
}
