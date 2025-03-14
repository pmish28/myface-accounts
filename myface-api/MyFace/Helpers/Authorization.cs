using System;
using System.Text;

namespace MyFace.Helpers;

public class Authorization
{
    public static string  IsUserAuthorized()
    {
        string authorizationHeader;// = "+WFcomveowkO/MGpYVFlzzI9vYfb8gqdh3NDqg8IL/w=";
        var textBytes = System.Text.Encoding.UTF8.GetBytes("password123");
        authorizationHeader = System.Convert.ToBase64String(textBytes);
        // byte[] data = Convert.FromBase64String(authorizationHeader.Split(' ')[1]);
        //authorizationHeader.Split(' ')[1]
        string decodedAuthorizationHeader = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationHeader));
        Console.WriteLine(decodedAuthorizationHeader);
        return decodedAuthorizationHeader;  
    }
}
