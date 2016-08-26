using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    log.Info($"Hello World at {now}");    
}
