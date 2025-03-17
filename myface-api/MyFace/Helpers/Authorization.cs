using System;
using System.Text;

namespace MyFace.Helpers;

public class Authorization
{
    public static string  DecodeAuthorizationHeader(string authorizationHeader)
    {
        string decodedAuthorizationHeader = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationHeader.Split(' ')[1]));
        return decodedAuthorizationHeader;  
    }
}
