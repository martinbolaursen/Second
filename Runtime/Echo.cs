using UnityEngine;

namespace Second.Runtime
{
    public static class Echo
    {
        public static string Now(string s)
        {
            var output = "Second:" + First.Runtime.Echo.Now(s);
            return output;
        }
    }
}
