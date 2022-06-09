using dashboard.Application.Requests;

namespace dashboard.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}