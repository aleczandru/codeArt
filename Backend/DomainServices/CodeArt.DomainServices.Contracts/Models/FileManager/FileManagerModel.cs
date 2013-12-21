using System;

namespace CodeArt.DomainServices.Contracts.Models.FileManager
{
    public class FileManagerModel
    {
        public int FileId { get; set; }
        public string OriginalFileName { get; set; }
        public string StorageFileName { get; set; }
        public string DisplayFileName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeletionDate { get; set; }
        public string CreatedBy { get; set; }
        public FileTypeModel FileTypeId { get; set; }
    }
}
