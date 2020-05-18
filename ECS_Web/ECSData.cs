using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECS_Web
{
    public class ECSData
    {
        public int Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public float Temperature { get; set; }
        public float TemperatureThreshold { get; set; }
        public float Humidity { get; set; }
        public float HumidityThreshold { get; set; }
        public float LightIntensity { get; set; }
        public float LightIntensityThreshold { get; set; }
        public bool FanControl { get; set; }
        public bool LampControl { get; set; }
        public bool Selected { get; set; }

        public ECSData() { }
        public ECSData(int id, DateTime lastUpdated, string lastName, string firstName,
                       float temperature, float humidity, float lightIntensity,
                       bool fanControl, bool lampControl)
        {
            Id = id;
            LastUpdated = lastUpdated;
            Lastname = lastName;
            Firstname = firstName;
            Temperature = temperature;
            Humidity = humidity;
            LightIntensity = lightIntensity;
            FanControl = fanControl;
            LampControl = lampControl;
        }
    }
}