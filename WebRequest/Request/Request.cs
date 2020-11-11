using System;

namespace WebRequest
{
    // This abstract class represents request!
    public abstract class Request
    {
        // Attribut declaration  -  Uri stand for Universal Resource Identifier!
        public Uri input;

        // abstract method with empty body!
        public abstract Uri GetUserRequest(Uri input);
    }
}
