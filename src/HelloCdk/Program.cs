using Amazon.CDK;

namespace HelloCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var environment = new Amazon.CDK.Environment
            {
                Account = System.Environment.GetEnvironmentVariable("CDK_DEFAULT_ACCOUNT"),
                Region = System.Environment.GetEnvironmentVariable("CDK_DEFAULT_REGION"),
            };

            var app = new App();
            new HelloCdkStack(
                scope: app,
                id: "HelloCdkStack",
                props: new StackProps { Env = environment }
            );
            app.Synth();
        }
    }
}