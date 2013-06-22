using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web.Script.Serialization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using System;
using System.IO;
using System.Net;
using System.Text;


    class Class1
    {
        // to sa metody do list

        // filtrowanie 

        public static List<Dictionary<string, string>> filterForPriority( List<Dictionary<string, string>> listToFilter ,string priority)
        {
            List<Dictionary<string, string>> filteredList = new List<Dictionary<string, string>>();

            for (int i = 0; i < listToFilter.Count; i++)
            {
                if (listToFilter[i]["priorityname"] == priority)
                    filteredList.Add(listToFilter[i]);

            }

            return filteredList;
        }

        public static List<Dictionary<string, string>> filterForCategory(List<Dictionary<string, string>> listToFilter, string category)
        {
            List<Dictionary<string, string>> filteredList = new List<Dictionary<string, string>>();

            for (int i = 0; i < listToFilter.Count; i++)
            {
                if (listToFilter[i]["categoryname"] == category)
                    filteredList.Add(listToFilter[i]);

            }

            return filteredList;
        }

        public static List<Dictionary<string, string>> Sort(List<Dictionary<string, string>> toSort ,string sortByWhichElement)
        {
            toSort.Sort((x,y) => x[sortByWhichElement].CompareTo(y[sortByWhichElement]));
            return toSort;

        }


        //


        //

        public static string returnUniqueId()
        {
            string idNumber = Class1.getUniqueID()[0]["currentid"];
            Class1.incrementID();
            Debug.WriteLine("CreatedUniqueID" + idNumber);
            return idNumber;

        }


        //


        public static List<Dictionary<string, string>> getPriorities()

        {
            Debug.WriteLine("getpriorities");

            string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/getPriorities";
            RestClient client = new RestClient(endPoint);
            string json = client.MakeRequest();
          

            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<dynamic>(json);

            List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

            return ValueList;

        }

        public static List<Dictionary<string, string>> getCategories()
        {

            Debug.WriteLine("getcategories");
            string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/getCategories";
            RestClient client = new RestClient(endPoint);
            string json = client.MakeRequest();
           
            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<dynamic>(json);

            List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

            return ValueList;

        
        }

        public static List<Dictionary<string, string>> getAllTasks(string user)
        {
            Debug.WriteLine("getalltasks");
            string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/GetUserTasks/"+user;
            RestClient client = new RestClient(endPoint);
            string json = client.MakeRequest();
        
            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<dynamic>(json);

            List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

            return ValueList;
        }

        public static string getJSONarray(string toParse)
        {
            string toreturn = "";
            bool doCopy = false;
            for (int i = 0; i < toParse.Length; i++)
            {
                if (toParse[i] == '[')
                    doCopy = true;
                if (toParse[i] == ']')
                    doCopy = false;

                if (doCopy)
                    toreturn += toParse[i];
            }


            return toreturn + ']';

        }

        public static string addUser(string login, string password )
        {
            Debug.WriteLine("adduser");
            HttpWebRequest httpWReq =
             (HttpWebRequest)WebRequest.Create("http://apex.oracle.com/pls/apex/listazadanuj/api/AddUser");

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "login="+login;
            postData += "&password=" + password;
           
            byte[] data = encoding.GetBytes(postData);

            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded";
            httpWReq.ContentLength = data.Length;

            using (Stream stream = httpWReq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return null;
        }

        public static List<Dictionary<string, string>> getLogin(string username, string password)
        {
            Debug.WriteLine("getlogin");
            string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/getLogin/" + username + "/" + password;
            RestClient client = new RestClient(endPoint);
            string json = client.MakeRequest();
            Debug.WriteLine(json);
            Debug.WriteLine("TEST");



            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<dynamic>(json);

            List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

            return ValueList;
        }


        public static List<Dictionary<string, string>> checkIfExists(string username)
          {
              Debug.WriteLine("checkifexists");
              string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/checkIfExists/" + username;
              RestClient client = new RestClient(endPoint);
              string json = client.MakeRequest();
              Debug.WriteLine(json);
              Debug.WriteLine("TEST");

              var jss = new JavaScriptSerializer();
              var dict = jss.Deserialize<dynamic>(json);

              List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

              return ValueList;
          }

        public static List<Dictionary<string, string>> getTasksCount()
          {
              Debug.WriteLine("gettaskcount");
              string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/tasksCount";
              RestClient client = new RestClient(endPoint);
              string json = client.MakeRequest();
              Debug.WriteLine(json);
              Debug.WriteLine("TEST");

              var jss = new JavaScriptSerializer();
              var dict = jss.Deserialize<dynamic>(json);

              List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

                Debug.WriteLine(ValueList[0]["count(*)"]);
                
              return ValueList;
              
          }

        public static List<Dictionary<string, string>> getUniqueID()
          {
              Debug.WriteLine("getuniqueide");
              string endPoint = @"http://apex.oracle.com/pls/apex/listazadanuj/api/getUniqueId";
              RestClient client = new RestClient(endPoint);
              string json = client.MakeRequest();
              Debug.WriteLine(json);
              Debug.WriteLine("TEST");

              var jss = new JavaScriptSerializer();
              var dict = jss.Deserialize<dynamic>(json);

              List<Dictionary<string, string>> ValueList = jss.Deserialize<List<Dictionary<string, string>>>(getJSONarray(json));

              return ValueList;
          }

         

          public static string incrementID()
          {
              Debug.WriteLine("incrementid");
              HttpWebRequest httpWReq =
               (HttpWebRequest)WebRequest.Create("http://apex.oracle.com/pls/apex/listazadanuj/api/incrementId");

              ASCIIEncoding encoding = new ASCIIEncoding();
            

              httpWReq.Method = "POST";
              httpWReq.ContentType = "application/x-www-form-urlencoded";
      

              HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

              string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
              return null;
          }

       
          public static string createTask(string name, string description, string usern, string category, string priority, string creationTime ,  string reminderTime ,string eventTime, string taskID)
          {
              Debug.WriteLine("createtask");
              HttpWebRequest httpWReq =
               (HttpWebRequest)WebRequest.Create("http://apex.oracle.com/pls/apex/listazadanuj/api/createTask");

              ASCIIEncoding encoding = new ASCIIEncoding();
              string postData = "name=" + name;
              postData += "&description=" + description;
              postData += "&usern=" + usern;
              postData += "&category=" + category;
              postData += "&priority=" + priority;
              postData += "&creation" + creationTime;
              postData += "&reminder=" + reminderTime;
              postData += "&taskid=" + taskID;
              postData += "&event=" + eventTime;

              byte[] data = encoding.GetBytes(postData);

              httpWReq.Method = "POST";
              httpWReq.ContentType = "application/x-www-form-urlencoded";
              httpWReq.ContentLength = data.Length;

              using (Stream stream = httpWReq.GetRequestStream())
              {
                  stream.Write(data, 0, data.Length);
              }

              HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

              string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

              return null;
          }
        
    }

