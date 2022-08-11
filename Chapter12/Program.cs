using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

// var blobAccessClient = new BlobContainerClient(new Uri("https://storageaccounthands904c.blob.core.windows.net/blobaccess"));
var containerAccessClient = new BlobContainerClient(new Uri("https://storageaccounthands904c.blob.core.windows.net/containeraccess"));
var listOfFiles = new List<string>();


// try
// {
//     await foreach (BlobItem blobItem in blobAccessClient.GetBlobsAsync())
//     {
//         listOfFiles.Add(blobItem.Name);
//     }
// }
// catch (Exception)
// {
//     Console.WriteLine("Failed to read blob dues to access");
// }

try
{
    await foreach (BlobItem blobItem in containerAccessClient.GetBlobsAsync())
    {
        listOfFiles.Add(blobItem.Name);
    }
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}

foreach(var file in listOfFiles)
{
    Console.WriteLine(file);
}