using Microsoft.AspNetCore.Components;
using ielts.Application.Models;

namespace ielts.Pages.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    public MainLayout Layout { get; set; }
    private User user => Layout?.User;
}
