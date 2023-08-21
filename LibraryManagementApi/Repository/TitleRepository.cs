using LibraryManagementApi.Repository.Entity;
using LibraryManagementApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApi.Repository
{
    public class TitleRepository : BaseRepository<TitleEntity>, ITitleRepository
    {
        public async Task<TitleEntity?> AddObjectAsync(TitleEntity obj)
        {
            obj.DeleteDate = null;
            return await AddAsync(obj);
        }

        public async Task<TitleEntity?> DeleteObjectSync(params object[] id)
        {
            var obj = await GetByIdAsync(id);
            if (obj == null)
                return null;

            obj.DeleteDate = DateTimeOffset.Now;
            await UpdateObjectAsync(obj);
            return obj;
        }

        public async Task<List<TitleEntity>> GetAllObjectAsync(int pageNumber = -1, int pageSize = -1)
        {
            if (pageNumber > -1 && pageSize > -1)
                return await GetAllAsync().Result.Where(t => t.DeleteDate == null)
                    .Skip((pageNumber - 1) * pageSize).Take(pageSize).OrderByDescending(t => t.Id)
                    .Include(t => t.Publisher).ToListAsync();
            else
                return await GetAllAsync().Result.Where(t => t.DeleteDate == null).OrderByDescending(t => t.Id)
                    .Include(t => t.Publisher).ToListAsync();

        }

        public Task<TitleEntity?> GetObjectAsync(params object[] id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TitleEntity>> SearchObjectAsync(string query = "", int pageNumber = -1, int pageSize = -1)
        {
            //Expression<Func<TitleEntity, bool>> predicate =
            //    t => t.Title.Contains(query)
            //    || t.ArtistNames.Contains(query)
            //    || t.Tag.Contains(query)
            //    && t.DeleteDate == null;

            //if (pageNumber > -1 && pageSize > -1)
            //    return await GetAllAsync().Result.Where(predicate)
            //        .Skip((pageNumber - 1) * pageSize).Take(pageSize).OrderByDescending(t => t.ReleaseDate)
            //        .Include(t => t.TitleArtists).Include(t => t.TitleAlbums).ToListAsync();
            //else
            //    return await GetAllAsync().Result.Where(predicate).OrderByDescending(t => t.ReleaseDate)
            //        .Include(t => t.TitleArtists).Include(t => t.TitleAlbums).ToListAsync();

            throw new NotImplementedException();

        }

        public async Task<TitleEntity?> UpdateObjectAsync(TitleEntity obj)
        {
            return await UpdateAsync(obj);
        }
    }
}
