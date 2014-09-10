﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using L3.Cargo.Communications.Dashboard.Display.Host;
using System.ServiceModel;
using L3.Cargo.Communications.Dashboard.Display.Interfaces;
using L3.Cargo.Communications.Common;
using System.Net;

namespace L3.Cargo.Subsystem.DataAccessCore
{
    public delegate void DashboardUpdateRequestHandler ();

    public delegate void DashboardControlUpdateHandler (string name, int value);

    public class SubsystemDisplayAccess : IDisposable
    {
        private WidgetRequestHost _WidgetRequestHost;

        private ServiceHost _ServiceHost;

        public event DashboardUpdateRequestHandler DisplayUpdateRequest;

        public event DashboardControlUpdateHandler ControlUpdateRequest;

        public SubsystemDisplayAccess ()
        {
            _WidgetRequestHost = new WidgetRequestHost();
            _WidgetRequestHost.SendUpdateEvent += new SendUpdateHandler(SendUpdate);
            _WidgetRequestHost.ControlUpdateEvent += new ControlUpdateHandler(ControlUpdate);

            string port = (String)ConfigurationManager.AppSettings["SubsystemPort"];
            string alias = ConfigurationManager.AppSettings["Alias"];
            string uri = string.Format("net.tcp://{0}:{1}/{2}Comm/", Dns.GetHostName(), port, alias);
            _ServiceHost = new ServiceHost(_WidgetRequestHost, new Uri[] { new Uri(uri) });
            _ServiceHost.AddServiceEndpoint(typeof(IWidgetRequest), new TCPBinding(), uri);
            _ServiceHost.Open();
        }

        private void ControlUpdate (string name, int value)
        {
            if (ControlUpdateRequest != null)
            {
                ControlUpdateRequest(name, value);
            }
        }

        private void SendUpdate ()
        {
            if (DisplayUpdateRequest != null)
            {
                DisplayUpdateRequest();
            }
        }

        public void Dispose ()
        {
            _WidgetRequestHost.SendUpdateEvent -= new SendUpdateHandler(SendUpdate);
            _WidgetRequestHost.ControlUpdateEvent -= new ControlUpdateHandler(ControlUpdate); 
            _ServiceHost.Close();
        }
    }
}
