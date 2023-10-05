using Microsoft.AspNetCore.Components;
using Spark.Library.Logging;
using ILogger = Spark.Library.Logging.ILogger;

namespace ielts.Pages;

public partial class Reading
{
    [Inject]
    public ILogger Logger { get; set; } = default!;

   
}