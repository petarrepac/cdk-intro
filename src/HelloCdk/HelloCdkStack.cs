using Amazon.CDK;
using Amazon.CDK.AWS.S3;
using Constructs;

namespace HelloCdk
{
    public class HelloCdkStack : Stack
    {
        internal HelloCdkStack(Construct scope, string id, IStackProps props = null) :
            base(scope, id, props)
        {
            new Bucket(
                scope: this,
                id: "MyFirstBucket",
                props: new BucketProps
                {
                    Versioned = true,
                    //RemovalPolicy = RemovalPolicy.DESTROY,
                    //AutoDeleteObjects = true
                }
            );

            //new CfnOutput(this, "MyFirstBucketBucketName", new CfnOutputProps
            //{
            //    Value = myFirstBucket.BucketName,
            //    Description = "Vpc Name",
            //    ExportName = $"HelloCdkStack-MyFirstBucketBucketName"
            //});
        }
    }
}