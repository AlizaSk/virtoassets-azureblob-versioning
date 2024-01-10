using System;

namespace VirtoCommerce.Module.Core.Models.AzureBlob
{
    public class AzureBlobClient
    {
        public string StorageAccountName { get; set; }
        public string BlobContainerName { get; set; }
        public string BlobName { get; set; }
        public Uri Uri { get; set; }
    }
}
