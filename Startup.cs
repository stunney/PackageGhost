using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(ArcticWolf.Samples.Startup))]

namespace ArcticWolf.Samples;

//For this file, all usings go up top!

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        try
        {
            //Nothing to do here.
        }
        catch(Exception ex)
        {
            throw new ApplicationException("Got it at Startup: " + ex.Message, ex);
        }
    }
}