

namespace InteractiveMapProject.API.Email;
internal class EmailConfiguration
{
    public string From { get; set; }
    public String SmtpServer { get; set; } = null!;

    public int Port { get; set; }

    public string UserName { get; set; }
    public String Password { get; set; }


}
