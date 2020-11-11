using System;
using System.IO;
using System.Net;

namespace WebRequest
{
    // This class represents Http!
    class HTTP : Request
    {
        public override Uri GetUserRequest(Uri input)
        {
            // Create a request for the URL. 
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(input);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);

                // Read the content.
                string responseFromUserInput = reader.ReadToEnd();

                // Display the content.
                Console.WriteLine(responseFromUserInput);

                // CleanUp streams.
                reader.Close();
                dataStream.Close();
            }
            // Close the response.
            response.Close();
            return input;
        }
    }
}
