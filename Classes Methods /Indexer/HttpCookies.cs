using System.Collections.Generic;
using System;

namespace Indexer
{
    class HttpCookies
    {
        private readonly Dictionary<string, string> _cookies = new Dictionary<string, string>();

        // this is signature of indexr class , same like property declaration.. jsut the property name is not there yet
        // so we user this
        public string this[string key]
        {
            get { return _cookies[key]; }
            set { _cookies[key] = value; }
        }
        // if we were not using indexr then we have 2 wrtie 2 method to set and get the value

        // public string Get_itme(string key)
        // {
        //         return _cookies[key];
        // }

        // public void Set_itme(string key,string value)
        // {
        //         _cookies[key] = value;
        // }

        
    }
}
