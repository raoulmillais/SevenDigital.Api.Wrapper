namespace SevenDigital.Api.Wrapper.ExampleUsage
{
	public class ApiUri<T> : IApiUri<T>
	{
		public string Uri 
		{
			get { return "http://api.7digital.com/1.2"; }
		}

		public string SecureUri
		{
			get { return "https://api.7digital.com/1.2"; }
		}
	}
}