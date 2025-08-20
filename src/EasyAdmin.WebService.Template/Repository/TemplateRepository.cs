using EasyAdmin.WebService.Template.Domain.Abstractions;
using EasyAdmin.WebService.Template.Repository.Abstractions.Interfaces;

namespace EasyAdmin.WebService.Template.Repository
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly IEasyAdminContext context;

        public TemplateRepository(IEasyAdminContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEasyAdminContext EasyAdminContext => throw new NotImplementedException();

        public int Add(TemplateDomain obj)
        {
            throw new NotImplementedException();
        }

        public List<TemplateDomain> Get()
        {
            throw new NotImplementedException();
        }

        public TemplateDomain? Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(TemplateDomain obj)
        {
            throw new NotImplementedException();
        }
    }
}
