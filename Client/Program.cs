using System;
using Starcounter;

namespace Client
{
	class Program
	{
		private static Node serverNode = new Node("127.0.0.1", 80, 10);

		static void Main()
		{
			Handle.GET("/Client/test", () => {

				Response res = serverNode.GET("/server");
				return res.Body;
			});
		}
	}
}