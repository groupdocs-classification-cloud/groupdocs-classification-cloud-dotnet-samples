using System;

namespace GroupDocs.Classification.Cloud.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            //// ***********************************************************
            ////          GroupDocs.Classification Cloud API Examples
            //// ***********************************************************

            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            Common.MyAppSid = "XXXX-XXXXX-XXXX";
            Common.MyAppKey = "XXXXXXX";
            Common.StoraegeName = "XXXX";

            Console.WriteLine("\n*** Uploading sample test files from local to default storage ***");
            Common.UploadSampleTestFiles();

            Console.WriteLine("\n*** Get Supported File Formats ***");
            Get_All_Supported_Formats.Run();

            Console.WriteLine("\n*** Classify Document from Storage ***");
            Classify_Document_from_Storage.Run();

            Console.WriteLine("\n*** Classify Raw Text ***");
            Classify_Raw_Text.Run();
        }
    }
}