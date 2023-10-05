using Microsoft.AspNetCore.Components;
using Spark.Library.Logging;
using ILogger = Spark.Library.Logging.ILogger;

namespace ielts.Pages;

public partial class Listenting
{
    [Inject]
    public ILogger Logger { get; set; } = default!;

   
}