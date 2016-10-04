using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] atr = new String[] { 
      "OnDemandServer_Value",
      "ApplicationID_Value",
      "CMDBApplicationName_Value",
      "ConnectionString-1",
                "ConnectionString-2",
                "ConnectionString-3",
    "serverUri-1_Value",
    "serverQueueName-1_Value",
    "JNDI-Username_Value",
    "password-1_Value",
    "ConnectionFactory-1_Value",

    "serverUri-2_Value",
    "serverQueueName-2_Value",
    "ConnectionFactory-2_Value",
      "username-2",
       "password-2",

    "ServerUri-3_Value",
    "ServerQueueName-3_Value",
    "Password-3_Value",
      "username-3",

    "ConnectionFactory-3_Value",
    "ServerUri-4_Value",
    "ServerQueueName-4_Value",
    "Password-4_Value",
    "ConnectionFactory-4_Value",
      "username-4",
       

    "serverUri-5_Value",
    "ServerQueueName-5_Value",
    "Password-5_Value",
    "ConnectionFactory-5_Value"};
    
    for(int i=0;i<atr.Length;i++)
    {
    Console.Write(
      "<Variable>\n"+
      "<Name>|*|"+atr[i]+"|*|</Name>\n"+
      "<Description>"+atr[i]+"</Description>\n"+
      "<Value>"+"  "+"</Value>\n"+
      "<TemplateDerivable>False</TemplateDerivable>\n"+
      "<EnvironmentName>R2HRFO</EnvironmentName>\n"+
      "</Variable>");
    }
    Console.ReadKey();

        }
    }
}
