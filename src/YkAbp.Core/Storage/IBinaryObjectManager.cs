using System;
using System.Threading.Tasks;

namespace YkAbp.Core.Storage
{
    public interface IBinaryObjectManager
    {
        Task<BinaryObject> GetOrNullAsync(Guid id);
        
        Task SaveAsync(BinaryObject file);
        
        Task DeleteAsync(Guid id);
    }
}