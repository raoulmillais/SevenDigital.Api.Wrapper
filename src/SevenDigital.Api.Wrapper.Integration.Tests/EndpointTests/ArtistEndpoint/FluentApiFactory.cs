using SevenDigital.Api.Wrapper.EndpointResolution;
using SevenDigital.Api.Wrapper.EndpointResolution.OAuth;
using SevenDigital.Api.Wrapper.Utility.Http;

namespace SevenDigital.Api.Wrapper.Integration.Tests.EndpointTests.ArtistEndpoint
{
	public static class FluentApiFactory
	{
		public static IFluentApi<T> CreateFluentApi<T>() where T : class
		{
			var apiUri = new ApiUri<T>();
			var requestCoordinator = new RequestCoordinator<T>(new HttpClient(), new UrlSigner(), new AppSettingsCredentials(), apiUri);
			return new FluentApi<T>(requestCoordinator);
		}
	}
}