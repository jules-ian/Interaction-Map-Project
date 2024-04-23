
using InteractiveMapProject.API.Email;

namespace InteractiveMapProject.API.Email_Services;
internal interface IEmailService
{
    void SendEmail(Message m);
}

