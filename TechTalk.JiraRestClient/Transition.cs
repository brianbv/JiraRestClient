﻿using System;

namespace TechTalk.JiraRestClient
{
    public class Transition
    {
        public string id { get; set; }
        public string name { get; set; }

        public object fields { get; set; }
    }
}
