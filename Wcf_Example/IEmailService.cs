using System.ServiceModel;

namespace Wcf_Example
{
    [ServiceContract]
    public interface IEmailService
    {
        [OperationContract]
        bool ValidateEmail(string email);
    }

}
