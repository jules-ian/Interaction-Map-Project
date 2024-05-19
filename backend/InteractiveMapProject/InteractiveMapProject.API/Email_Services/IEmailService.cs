
using InteractiveMapProject.API.Email;

namespace InteractiveMapProject.API.Email_Services;
public interface IEmailService
{
    void SendEmail(Message m);
}

