﻿using System;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighilishtOperation());
        }
    }
}
