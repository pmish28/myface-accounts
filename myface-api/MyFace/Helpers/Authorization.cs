using System;
using System.Text;

namespace MyFace.Helpers;

public class Authorization
{
    public static string  IsUserAuthorized()
    {
        string authorizationHeader = "Basic +WFcomveowkO/MGpYVFlzzI9vYfb8gqdh3NDqg8IL/w=";
        // byte[] data = Convert.FromBase64String(authorizationHeader.Split(' ')[1]);
        
        string decodedAuthorizationHeader = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(authorizationHeader.Split(' ')[1]));
        Console.WriteLine(decodedAuthorizationHeader);
        return decodedAuthorizationHeader;  
    }
}
