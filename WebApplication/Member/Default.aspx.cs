﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Auth;

namespace WebApplication.Member
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Auth.Auth auth = new Auth.Auth(Server.MapPath("~/Members.xml"));
            if (!User.Identity.IsAuthenticated || auth.GetRole(User.Identity.Name) != "Member")
            {
                Response.Redirect("~/Auth/Login");
            }
        }

        public void FilterWords(object sender, EventArgs e)
        {
            WordFilter.WordFilterServiceClient client = new WordFilter.WordFilterServiceClient();

            string filteredWords = client.WordFilter(WordFilterInput.Text);
            WordFilterOutput.Text = filteredWords;
        }

        public void GetWeather(object sender, EventArgs e)
        {
            Weather5day.WeatherServiceClient client = new Weather5day.WeatherServiceClient();

            try
            {
                string[] forecast = client.Weather5day(WeatherServiceInput.Text);

                WeatherServiceOutput1.Text = forecast[0];
                WeatherServiceOutput2.Text = forecast[1];
                WeatherServiceOutput3.Text = forecast[2];
                WeatherServiceOutput4.Text = forecast[3];
                WeatherServiceOutput5.Text = forecast[4];
            } catch
            {
                System.Diagnostics.Debug.WriteLine("fail");
            }
 
        }
    }
}