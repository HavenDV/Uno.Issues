using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace object_instead_staticresource.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new object_instead_staticresource.App(), args);
		host.Run();
	}
}
}
