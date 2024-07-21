namespace PDMSystem
{
    internal class TestSecurityCheck
    {
        public static void ConnectToAws()
        {
            string awsAccessKeyId = "AKIAIOSFODNN7EXAMPLE"; // Example AWS Access Key ID
            string awsSecretAccessKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY"; // Example AWS Secret Access Key

            Console.WriteLine("Attempting to use the following AWS credentials:");
            Console.WriteLine($"AWS Access Key ID: {awsAccessKeyId}");
            Console.WriteLine($"AWS Secret Access Key: {awsSecretAccessKey}");

            // Simulate using the AWS credentials
            UseAwsCredentials(awsAccessKeyId, awsSecretAccessKey);
        }

        static void UseAwsCredentials(string accessKeyId, string secretAccessKey)
        {
            // Dummy method to simulate using AWS credentials
            Console.WriteLine("Using AWS credentials...");
        }

        public static void ConnectToAzure()
        {
            string azureStorageAccountName = "exampleaccountname"; // Example Azure Storage Account Name
            string azureStorageAccountKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY"; // Example Azure Storage Account Key

            Console.WriteLine("Attempting to use the following Azure credentials:");
            Console.WriteLine($"Azure Storage Account Name: {azureStorageAccountName}");
            Console.WriteLine($"Azure Storage Account Key: {azureStorageAccountKey}");

            // Simulate using the Azure credentials
            UseAzureCredentials(azureStorageAccountName, azureStorageAccountKey);
        }

        static void UseAzureCredentials(string accountName, string accountKey)
        {
            // Dummy method to simulate using Azure credentials
            Console.WriteLine("Using Azure credentials...");
        }
    }
}
