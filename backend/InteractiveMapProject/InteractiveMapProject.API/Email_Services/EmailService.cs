using InteractiveMapProject.API.Email;
using MailKit.Net.Smtp;
using MimeKit;

namespace InteractiveMapProject.API.Email_Services;
internal class EmailService : IEmailService
{
    private readonly EmailConfiguration _emailConfig;
    public EmailService(EmailConfiguration emailConfig) => _emailConfig = emailConfig;

    public void SendEmail(Email.Message m)
    {
        var email = createEmail(m);
       // var sendTestEmail = new SendTestEmail(emailTo);
       // apiInstance.SendTestTemplate(templateId, sendTestEmail);
        SendEmail(email);

    }

    private MimeMessage createEmail(Email.Message m)
    {
        var email_Message = new MimeMessage();
        // Get sender's email adresse from EmailConfiguration
        email_Message.From.Add(new MailboxAddress("email", _emailConfig.From));
        email_Message.To.AddRange(m.To);
        email_Message.Subject = m.Subject;
        email_Message.Body = new TextPart(MimeKit.Text.TextFormat.Text)
        { Text = m.Content };
        return email_Message;
    }

    private void SendEmail(MimeMessage mimeMsg)
    {
        using var client = new SmtpClient();
        try
        {
            client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, true);
            client.AuthenticationMechanisms.Remove("XOAUTH2");
            client.Authenticate(_emailConfig.UserName, _emailConfig.Password);
            client.Send(mimeMsg);
        }
        catch (Exception ex) { throw; }
        finally
        {
            client.Disconnect(true);
            client.Dispose();
        }


    }
}
    
