using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using winapp.service;
using winapp.Weather;

namespace winapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        service.WebService1SoapClient getClient = new WebService1SoapClient();
        //Weather.WeatherWebServiceSoapClient wheatherClient = new WeatherWebServiceSoapClient();
        private void btnData_Click(object sender, EventArgs e)
        {
            
            var data = getClient.HelloWorld();
            if (string.IsNullOrEmpty(data))
            {
                return;
            }
            this.txtData.Text = data;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtData.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrEmpty(txtNum2.Text))
            {
                return;
            }
            var num1 = Convert.ToInt32(txtNum1.Text);
            var num2 = Convert.ToInt32(txtNum2.Text);
            var result = getClient.Add(num1, num2);
            this.txtData.Text = result.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var city = this.txtCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                return;
            }

            //var data=wheatherClient.getWeatherbyCityName(city);
            //this.txtWeather.Text = data.ToString();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            var url = @"http://localhost:8081/WebService1.asmx";
            var data = HttpPostWebService(url,"GetData");
            List<User> list = JsonConvert.DeserializeObject<List<User>>(data);

        }
        public string HttpPostWebService(string url, string method)
        {
            string result = string.Empty;
            byte[] bytes = null;
            string param = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            param = "123";
            bytes = Encoding.UTF8.GetBytes(param);

            request = (HttpWebRequest)WebRequest.Create(url + "/" + method);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;
            
            try
            {
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                   
                }

                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (XmlTextReader sread = new XmlTextReader(responseStream))
                    {
                        sread.MoveToContent();
                        result = sread.ReadInnerXml();
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            return result;
        }

        //public string HttpPostWebService(string url, string method)
        //{
        //    string result = string.Empty;
        //    string param = string.Empty;
        //    byte[] bytes = null;

        //    Stream writer = null;
        //    HttpWebRequest request = null;
        //    HttpWebResponse response = null;
        //    param = "123";
        //    //param = HttpUtility.UrlEncode("param1") + "=" + HttpUtility.UrlEncode(num1) + "&" + HttpUtility.UrlEncode("param2") + "=" + HttpUtility.UrlEncode(num2);
        //    bytes = Encoding.UTF8.GetBytes(param);

        //    request = (HttpWebRequest)WebRequest.Create(url + "/" + method);
        //    request.Method = "POST";
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    //request.ContentLength = bytes.Length;

        //    try
        //    {
        //        writer = request.GetRequestStream();        //获取用于写入请求数据的Stream对象
        //    }
        //    catch (Exception ex)
        //    {
        //        return "";
        //    }

        //    writer.Write(bytes, 0, bytes.Length);       //把参数数据写入请求数据流
        //    writer.Close();

        //    try
        //    {
        //        response = (HttpWebResponse)request.GetResponse();      //获得响应
        //    }
        //    catch (WebException ex)
        //    {
        //        return "";
        //    }

        //    #region 这种方式读取到的是一个返回的结果字符串
        //    Stream stream = response.GetResponseStream();        //获取响应流
        //    XmlTextReader Reader = new XmlTextReader(stream);
        //    Reader.MoveToContent();
        //    result = Reader.ReadInnerXml();
        //    #endregion

        //    #region 这种方式读取到的是一个Xml格式的字符串
        //    //StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
        //    //result = reader.ReadToEnd();
        //    #endregion 

        //    response.Dispose();
        //    response.Close();

        //    //reader.Close();
        //    //reader.Dispose();

        //    Reader.Dispose();
        //    Reader.Close();

        //    stream.Dispose();
        //    stream.Close();

        //    return result;
        //}
    }
}
