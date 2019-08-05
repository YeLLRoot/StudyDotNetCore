using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        Weather.WeatherWebServiceSoapClient wheatherClient = new WeatherWebServiceSoapClient();
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

            var data=wheatherClient.getWeatherbyCityName(city);
            this.txtWeather.Text = data.ToString();
        }
    }
}
