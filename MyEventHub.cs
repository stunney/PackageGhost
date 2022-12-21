using System;
using System.Threading.Tasks;

using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ArcticWolf.Samples;

[Serializable]
public class MyObject {}

public class MyEventHub
{
    private readonly IServiceScopeFactory ScopeFactory;

    public MyEventHub(IServiceScopeFactory scopeFactory)
    {
        ScopeFactory = scopeFactory;
    }

    [FunctionName("EventHubGhostNuGetPackSample")]
    public void Run([EventHubTrigger("mysampleeventhub", Connection = "ADSYNC_EVENTHUBS_CONNSTR")]
                           MyObject data,
                           ILogger log)
    {

        try
        {
            log.LogInformation($"{data.ToString()}");
        }
        catch (Exception e)
        {
            log.LogError(e.Message);
        }
    }
}
