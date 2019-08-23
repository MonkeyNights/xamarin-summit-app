using System;
using System.Net.Http;
using Prism.Ioc;
using Refit;

namespace EventApp.XamarinSummit.Factories
{
    public static class RepositoryFactory
    {
        public static T For<T>(IContainerProvider container)
        => RestService.For<T>(container.Resolve<HttpClient>());
    }
}
