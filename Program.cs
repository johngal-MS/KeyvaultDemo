//using Azure.Identity;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        string keyVaultName = "johngal-fbi";
        string secretName = "secret1";

        var client = new SecretClient(new Uri($"https://{keyVaultName}.vault.azure.net/"), new DefaultAzureCredential());

        KeyVaultSecret secret = client.GetSecret(secretName);

        Console.WriteLine($"Secret Name: {secret.Name}");
        Console.WriteLine($"Secret Value: {secret.Value}");
    }
}