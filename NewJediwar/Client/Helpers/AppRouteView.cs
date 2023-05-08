﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;
using System.Net;
using NewJediwar.Client.Services;

namespace NewJediwar.Client.Helpers;

public class AppRouteView : RouteView
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IPlayerService PlayerService { get; set; }

    protected override void Render(RenderTreeBuilder builder)
    {
        var authorize = Attribute.GetCustomAttribute(RouteData.PageType, typeof(AuthorizeAttribute)) != null;
        if (authorize && PlayerService.Player == null)
        {
            var returnUrl = WebUtility.UrlEncode(new Uri(NavigationManager.Uri).PathAndQuery);
            NavigationManager.NavigateTo($"account/login?returnUrl={returnUrl}");
        }
        else
        {
            base.Render(builder);
        }
    }
}
