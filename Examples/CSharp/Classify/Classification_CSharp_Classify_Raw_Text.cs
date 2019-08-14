//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).

using GroupDocs.Classification.Cloud.Sdk.Api;
using GroupDocs.Classification.Cloud.Sdk.Model;
using GroupDocs.Classification.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Classification.Cloud.Examples.CSharp
{
    // Classify Raw Text
    class Classify_Raw_Text
    {
        public static void Run()
        {
            var configuration = new Configuration
            {
                AppSid = Common.MyAppSid,
                AppKey = Common.MyAppKey
            };

            var apiInstance = new ClassificationApi(configuration);

            try
            {
                var request = new ClassifyRequest(new BaseRequest() { Description = "Try Text classification using GroupDocs.Classification Cloud API" }, "3");

                // Get classification results
                var response = apiInstance.Classify(request);
                Console.WriteLine(response.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ClassificationApi: " + e.Message);
            }
        }
    }
}