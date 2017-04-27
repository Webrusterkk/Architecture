
using Architecture.Core.Data;
using Architecture.Core.Entities;
using Architecture.Core.Services;

namespace Architecture.Services.Services
{
    public class ContactService : BaseService<Contact>, IContactService
    {
        public ContactService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
