using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

class Program
    {
        static void Main(string[] args)
        {
        int port = 8080;
        string playerName = "Player";

        //Creating the client
        TcpClientChannel channel = new TcpClientChannel();
        ChannelServices.RegisterChannel(channel, false);

        string playerURL = "tcp://localhost:" + port + "/" + playerName;
        Player player = (Player)Activator.GetObject(typeof(Player), playerURL);

        while (true)
        {
            Console.Write("Type a message to the server or type 'quit' to exit\n");
            string text = Console.ReadLine();

            if (text == "quit")
            {
                break;
            }
            //RPC: Call function on server
            player.SayHello(text);
        }
        }
    }
