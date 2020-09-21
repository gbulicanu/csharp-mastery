using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var workflow = new Workflow();
            workflow.AddActivity(new UploadActivity());
            workflowEngine.Run(workflow);
        }
    }
}
