//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).

using GroupDocs.Classification.Cloud.Sdk.Api;
using GroupDocs.Classification.Cloud.Sdk.Model;
using GroupDocs.Classification.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Classification.Cloud.Examples.CSharp
{
    // Get All Supported Formats
    class Get_All_Supported_Formats
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
                var request = new GetSupportedFileFormatsRequest();

                // Get supported file formats results
                FormatCollection response = apiInstance.GetSupportedFileFormats(request);

                foreach (Format formatval in response.Formats)
                {
                    Console.WriteLine("FileFormat: " + formatval.FileFormat + "  Ext: " + formatval.Extension);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling ClassificationApi: " + e.Message);
            }
        }
    }
}