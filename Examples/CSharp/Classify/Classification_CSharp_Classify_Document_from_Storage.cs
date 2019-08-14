//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).

using GroupDocs.Classification.Cloud.Sdk.Api;
using GroupDocs.Classification.Cloud.Sdk.Model;
using GroupDocs.Classification.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Classification.Cloud.Examples.CSharp
{
    // Classify Document from Storage
    class Classify_Document_from_Storage
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
                var request = new ClassifyRequest(new BaseRequest()
                {
                    Document = new FileInfo()
                    {
                        Name = "one-page.docx",
                        Folder = ""
                    },
                },
                bestClassesCount: "3");

                // Get classification results
                ClassificationResponse response = apiInstance.Classify(request);
                Console.WriteLine(response.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ClassificationApi: " + e.Message);
            }
        }
    }
}