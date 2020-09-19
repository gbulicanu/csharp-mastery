using System;
using System.Collections.Generic;

namespace Classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            this.dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return this.dictionary[key]; }
            set { this.dictionary[key] = value; }
        }
    }

}
