using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TestMaintstar.Application.Interfaces;
using TestMaintstar.Application.Models.DB;
using TestMaintstar.Application.Models.Entities;
using TestMaintstar.Application.Models.ViewModels;

namespace TestMaintstar.Application.Models.Repositories
{
    public class PictureRepository : IDataModel<Picture>
    {
        private readonly ApplicationDbContext _context;

        public PictureRepository(ApplicationDbContext context) => _context = context;

        public async Task<IEnumerable<Picture>> GetImages() =>
            await _context.Pictures.ToListAsync();

        public async Task<Picture> GetImageById(int id) =>
            await _context.Pictures.FirstOrDefaultAsync(x => x.Id.Equals(id));

        public async Task AddImage(Picture picture)
        {
            picture.PublicationDate = DateTime.Now;
            await _context.Pictures.AddAsync(picture);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateImage(Picture picture)
        {
            var imageFromDb = await _context.Pictures.FirstOrDefaultAsync(x => x.Id == picture.Id);

            if (imageFromDb is null) return;

            imageFromDb.Name = picture.Name;
            imageFromDb.Description = picture.Description;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteImage(int id)
        {
            var image = await _context.Pictures.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if (image is null) return;

            _context.Pictures.Remove(image);

            await _context.SaveChangesAsync();
        }
    }
}
