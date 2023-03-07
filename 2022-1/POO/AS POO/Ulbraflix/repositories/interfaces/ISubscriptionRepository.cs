using Ulbraflix.domain.entities;
using Ulbraflix.entities;

namespace Ulbraflix.repositories.interfaces;

public interface ISubscriptionRepository : IBaseRepository<Subscription>, IBaseAsyncRepository<Subscription>
{
    
}