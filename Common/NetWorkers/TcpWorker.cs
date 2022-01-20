﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Common.Abstractions;

namespace Common.NetWorkers
{
    public class TcpWorker : INetWorkWrapper
    {
        private TcpListener _tcpWorker;


        public TcpWorker(IPAddress ipAddress, int port)
        {
            _tcpWorker = new TcpListener(ipAddress, port);
        }

        public Socket Accept()
        {
            return _tcpWorker.AcceptSocket();
        }

        public void Bind(IPEndPoint localEndpoint)
        {
            _tcpWorker = new TcpListener(localEndpoint);
        }

        public void Listen(int backlog)
        {
            _tcpWorker.Start(backlog);
        }

        public int Receive(byte[] dataToReceive)
        {
            throw new NotImplementedException();
        }

        public void Send(byte[] dataToSend)
        {
            throw new NotImplementedException();
        }
    }
}
