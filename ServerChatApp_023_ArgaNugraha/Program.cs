﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService_2Way_20190140023;


namespace ServerChatApp_023_ArgaNugraha
{
    class Program
    {
       
        
            static void Main(string[] args)
            {
                ServiceHost hostObjek = null;
                try
                {
                    hostObjek = new ServiceHost(typeof(ServiceCallback));
                    hostObjek.Open();

                    Console.WriteLine("Server On, Ready to use");
                    Console.ReadLine();

                    hostObjek.Close();
                }
                catch (Exception ex)
                {
                    hostObjek = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        
    }
}
