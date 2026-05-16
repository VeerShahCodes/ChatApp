using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ChatRoomApplication
{

    public class API
    {
        public static string url = "https://localhost:7141/ChatRoom";

        public void Login(string username, string password)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    //  string jsonBody = $"\"{username},{password}\"";
                    
                    string result = client.UploadString("http://localhost:7141/ChatRoom/Login", username, password);
                    Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }
    }
}
