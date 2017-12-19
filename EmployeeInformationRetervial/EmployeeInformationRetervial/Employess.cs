using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; //For WebRequest
using System.IO;
using System.Windows.Forms;

namespace EmployeeInformationRetervial
{
    public class Employees
    {
        public string EmployeeID;
        public string Employee_F_Name;
        public string Employee_L_Name;
        public string Employee_Address;
        public string Employee_Address2;
        public string Employee_City;
        public string Employee_State;
        public string Employee_ZipCode;
        public string Employee_Phone;
        public string Employee_Email;
        public string Employee_DOB;
        public string Employee_HireDate;
        public string Employee_JobTitle;
        public string Employee_Status;
        public string Employee_Marital_Status;
        public string Employee_Num_Dependents;
        public string Employee_Fed_Tax;
        public string Employee_State_Tax;
        public string Employee_PayRate;
        public string Employee_ReportTo;
        public string Employee_Password;
    }

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; } //For enum
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestClient() //Constructor
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint, httpVerb method, string postData)
        {
            endPoint = endpoint;
            httpMethod = method;
            ContentType = "text/xml";
            PostData = postData;
        }
        public RestClient(string endpoint, httpVerb method)
        {
            endPoint = endpoint;
            httpMethod = method;
            ContentType = "text/xml";
            PostData = "";
        }
        public string makeRequest()
        {
            return makeRequest("");
        }
        public string makeRequest(string parameters)
        {
            string strResponse = string.Empty;

            //Needs to be casted because WebRequest is deprecated
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint + parameters);

            request.Method = httpMethod.ToString();
            request.ContentLength = 0;
            request.ContentType = ContentType;

            try
            {
                if (!string.IsNullOrEmpty(PostData) && httpMethod == httpVerb.POST)
                {
                    var encoding = new UTF8Encoding();
                    var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                    request.ContentLength = bytes.Length;

                    using (var writeStream = request.GetRequestStream())
                    {
                        writeStream.Write(bytes, 0, bytes.Length);
                    }
                }

                //Get the http web response
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    //If response is not valid, throw an exeption code
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Error Code: " + response.StatusCode.ToString());
                    }
                    //If response is okay, process it
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        //Check if data is being passed back
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponse = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return strResponse;
        }
    }
}
