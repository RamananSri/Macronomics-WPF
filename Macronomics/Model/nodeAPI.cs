using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Macronomics.Model
{
    class nodeAPI
    {
        HttpClient client;
        string nodeUrl; 

        public nodeAPI()
        {
            client = new HttpClient();
            nodeUrl = "http://localhost:3000/";
        }

        //public string createUrl(string route)
        //{
        //    switch (route)
        //    {
        //        case "User":
        //            return 
        //    }
        //}

        //public string constructURL(object t)
        //{
        //    if (typeof(t) == typeof(User))
        //    {
        //        User u = (User)t;

        //        return nodeUrl + "users/" + u.Id;
        //    }

        //    return null;
        //}

        //public T GET<T>(T t)
        //{
        //    string url = constructURL<T>(t) + t.id;
        //    var tToJSON = JsonConvert.SerializeObject(t);

        //    return t

        //}


    }
}
