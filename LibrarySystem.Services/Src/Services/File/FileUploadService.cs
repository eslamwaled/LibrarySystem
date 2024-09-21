using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
namespace LibrarySystem.Services.Src.Services.file
{

public class FileUploadService
{
    private readonly string _storagePath;

    public FileUploadService(string storagePath)
    {
        _storagePath = storagePath;
    }

    public async Task<string> UploadFileAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("No file uploaded");

        var fileName = Path.GetFileName(file.FileName);
        var filePath = Path.Combine(_storagePath, fileName);

        Directory.CreateDirectory(Path.GetDirectoryName(filePath));

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return filePath;
    }
}
}