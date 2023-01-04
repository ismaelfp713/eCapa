using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace eCapa.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment env)
        {
            _environment = env;
        }
        public async Task UploadAsync(IFileListEntry fileEntry,string capa)
        {           
           
            var rootPath = Path.Combine(_environment.WebRootPath, "Upload");
            Directory.CreateDirectory(Path.Combine(rootPath, capa));
            var path = Path.Combine(_environment.WebRootPath, "Upload",capa, fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
        public void DeleteFile(string capa, string filename)
        {
            var rootPath = Path.Combine(_environment.WebRootPath, "Upload");
            var path = Path.Combine(_environment.WebRootPath, "Upload", capa, filename);
            if(File.Exists(path))
            {
                File.Delete(path);
            }

        }

        public void DeleteFileWhenNotSaved(string filename)
        {
            var rootPath = Path.Combine(_environment.WebRootPath, "Upload");
            var path = Path.Combine(_environment.WebRootPath, "Upload", filename);
            if (Directory.Exists(path))
            {
                Directory.Delete(path,true);
            }
        }
    }
}