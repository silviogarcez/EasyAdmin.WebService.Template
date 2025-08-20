using EasyAdmin.Connection.Abstractions.Interfaces;
using EasyAdmin.WebService.Template.Repository.Abstractions.Interfaces;

namespace EasyAdmin.Repository.Context
{
    public class EasyAdminContext : IEasyAdminContext
    {
        public IMyConnection Connection { get; }        

        public EasyAdminContext(IMyConnection connection)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }
    }
}
