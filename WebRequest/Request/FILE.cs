using System;
using System.IO;
using System.Net;
using System.Text;

namespace WebRequest
{
    // This class represents file!
    class FILE : Request
    {
        public override Uri GetUserRequest(Uri input)
        {
            // Create a request for the local filepath (ex. C:/Users/joxx01812/source/repos/sqlFile.csv). 
            FileWebRequest request = (FileWebRequest)FileWebRequest.Create(input);

            // Get the response.
            FileWebResponse response = (FileWebResponse)request.GetResponse();

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
