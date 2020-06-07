using System.Collections.Generic;
using TeduShop.Data.Infrastucture;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int page, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        IEnumerable<Post> IPostRepository.GetAllByTag(string tag, int page, int pageSize, out int totalRow)
        {
            throw new System.NotImplementedException();
        }
    }
}