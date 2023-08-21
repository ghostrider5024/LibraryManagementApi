using LibraryManagementApi.Repository.Entity;
using LibraryManagementApi.Repository.IRepository;
using LibraryManagementApi.Service.IService;

namespace LibraryManagementApi.Service
{
    public class TitleService : ITitleService
    {
        private readonly ITitleRepository _TitleRepository;

        public TitleService(ITitleRepository TitleRepository)
        {
            _TitleRepository = TitleRepository;
        }

        public async Task<TitleEntity?> AddObjectAsync(TitleEntity obj)
        {
            obj.Id = Guid.NewGuid().ToString();
            return await _TitleRepository.AddObjectAsync(obj);
        }

        public async Task<TitleEntity?> DeleteObjectSync(params object[] id)
        {
            return await _TitleRepository.DeleteObjectSync(id);
        }

        public async Task<List<TitleEntity>> GetAllObjectAsync(int pageNumber = -1, int pageSize = -1)
        {
            return await _TitleRepository.GetAllObjectAsync(pageNumber, pageSize);
        }

        public Task<TitleEntity?> GetObjectAsync(params object[] id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TitleEntity>> SearchObjectAsync(string query = "", int pageNumber = -1, int pageSize = -1)
        {
            return await _TitleRepository.SearchObjectAsync(query, pageNumber, pageSize);
        }

        public async Task<TitleEntity?> UpdateObjectAsync(TitleEntity obj)
        {
            return await _TitleRepository.UpdateObjectAsync(obj);
        }
    }
}
