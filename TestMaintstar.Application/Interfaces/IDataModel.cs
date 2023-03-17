using Microsoft.AspNetCore.Http;

namespace TestMaintstar.Application.Interfaces
{
    public interface IDataModel<T> where T : class
    {
        Task<IEnumerable<T>> GetImages();
        Task<T> GetImageById(int id);
        Task AddImage(T image);
        Task UpdateImage(T image);
        Task DeleteImage(int id);
    }
}
