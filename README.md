# BlobQucikstartV12
A simple console application demonstrating how to use Azure Blob storage for uploading, listing and downloading content. It follows this tutorial [https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet).

## Configuration
In order for this sample to work you need a Storage Account setup in Azure.
After this is done copy the connection string from key1 under 'Access Keys'.
Add this to your system configuration by running this in a teminal

```
setx AZURE_STORAGE_CONNECTION_STRING "<yourconnectionstring>"
```

Restart Visaul Studio / VS Code after this.