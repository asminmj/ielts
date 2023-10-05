using Microsoft.AspNetCore.Components;
using ielts.Application.Models;
using ielts.Pages.Shared;

namespace ielts.Pages;

public partial class Dashboard
{
    [CascadingParameter]
    public MainLayout Layout { get; set; }
    private User user => Layout.User;
}
