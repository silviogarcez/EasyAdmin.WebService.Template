using EasyAdmin.Connection.Abstractions.Interfaces;

namespace EasyAdmin.WebService.Template.Repository.Abstractions.Interfaces
{
    public interface IEasyAdminContext
    {
        IMyConnection Connection { get; }
    }
}