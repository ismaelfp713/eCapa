using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace eCapa.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file, string capa);
        void DeleteFile(string capa, string filename);
        void DeleteFileWhenNotSaved(string filename);
    }
}
