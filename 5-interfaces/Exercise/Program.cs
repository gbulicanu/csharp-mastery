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
            workflow.AddActivity(new CallThirdPartyWebServiceActivity());
            workflow.AddActivity(new SendEmailActivity());
            workflow.AddActivity(new UpdateStatusActivity());
            workflowEngine.Run(workflow);
        }
    }
}
