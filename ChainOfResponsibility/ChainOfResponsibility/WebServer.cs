﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class WebServer
    {
        private Handler handler;
        public WebServer(Handler handler)
        {
            this.handler = handler;
        }
        public void Handle(HttpRequest request)
        {
            this.handler.Handle(request);
        }
    }
}
