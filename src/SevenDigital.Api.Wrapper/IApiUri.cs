namespace SevenDigital.Api.Wrapper
{
	public interface IApiUri<T>
	{
		string Uri { get; }
		string SecureUri { get; }
	}
}