using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Includes for remoting
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

    class Program
    {
        static void Main(string[] args)
        {
            //Creating the server: Use port 8080 for testing purposes, as it's usually not in use by other programs
            int port = 8080;

            TcpServerChannel channel = new TcpServerChannel(port);
            ChannelServices.RegisterChannel(channel, false);

            //Registering the Player class
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Player), "Player", WellKnownObjectMode.SingleCall);

            //Console writeLine so that our console window doesn't close straight away.
            Console.WriteLine("Listening for requests.\nPress enter to exit...\n");
            Console.ReadLine();
        }
    }
