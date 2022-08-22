// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Amazon.OpenSearchService;
using Amazon.OpenSearchService.Model;

Console.WriteLine("Hello, World!");
var c = new AmazonOpenSearchServiceClient();

var r = await c.DescribeDomainAsync(new DescribeDomainRequest
{
    DomainName = "dev-logging-es"
});

         c.Paginators.
Console.WriteLine();