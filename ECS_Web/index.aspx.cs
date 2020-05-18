using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;

namespace ECS_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();
            ReadStatus();
        }

        private void ReadStatus()
        {
            try
            {
                //Uri urlStatus = new Uri("https://engr102.azurewebsites.net/api/ECSData/0");
                Uri urlStatus = new Uri("https://engr102.azurewebsites.net/api/ECSData");
                WebClient client = new WebClient();
                ECSData record = new ECSData();
                List<ECSData> devices = new List<ECSData>();
                client.Headers.Add("Content-Type", "application/json");
                string data = client.DownloadString(urlStatus);

                //record = JsonConvert.DeserializeObject<ECSData>(data);
                devices = JsonConvert.DeserializeObject<List<ECSData>>(data);
                int i = 0;
                dataList.Height = devices.Count * 20;
                dataList.Items.Clear();
                foreach (ECSData device in devices)
                {
                    string value = "";
                    value = String.Format("{0} {1} {2}, {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                                            device.Id,
                                            device.LastUpdated.ToString(),
                                            device.Lastname.ToString(),
                                            device.Firstname.ToString(),
                                            device.Temperature.ToString(),
                                            device.TemperatureThreshold.ToString(),
                                            device.Humidity.ToString(),
                                            device.HumidityThreshold.ToString(),
                                            device.LightIntensity.ToString(),
                                            device.LightIntensityThreshold.ToString(),
                                            device.FanControl.ToString(),
                                            device.LampControl.ToString()
                                         );
                    dataList.Items.Add(value);
                }

                message.Text = "New Records: " + DateTime.Now.ToString();

            }
            catch (Exception e)
            {
                message.Text = e.Message;
            }
        }

    }

}
