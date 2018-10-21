﻿using System.Diagnostics;
using TechTalk.SpecFlow.Tracing;

namespace Framework.SpecFlowPlugin
{
    internal class ThreadSafeTraceListener : IThreadSafeTraceListener, ITraceListener
    {
        public void WriteTestOutput(string message)
        {
            Debug.WriteLine( $"{message} from tracer");
        }

        public void WriteToolOutput(string message)
        {
            Debug.WriteLine($"{message} from tracer");
        }
    }
}