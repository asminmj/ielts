﻿using ielts.Application.Events.Listeners;
using ielts.Application.Events;
using Coravel.Events.Interfaces;
using Coravel;

namespace ielts.Application.Startup;

public static class Events
{
    public static IServiceProvider RegisterEvents(this IServiceProvider services)
    {
        IEventRegistration registration = services.ConfigureEvents();

        // add events and listeners here
        registration
            .Register<UserCreated>()
            .Subscribe<EmailNewUser>();

        return services;
    }
}
