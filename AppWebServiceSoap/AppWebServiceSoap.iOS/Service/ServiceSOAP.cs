﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(AppWebServiceSoap.iOS.Service.ServiceSOAP))]
namespace AppWebServiceSoap.iOS.Service
{
    public class ServiceSOAP: IServiceSOAP
    {
        public string Somar(int num1, int num2)
        {
            var serv = new com.dneonline.www.Calculator();
            var resultado = serv.Add(num1, num2);

            return "Resultado WS SOAP (IOS): " + resultado;
        }
    }
}