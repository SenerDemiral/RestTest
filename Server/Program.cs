using System;
using Starcounter;

namespace Server
{
	class Program
	{
		static void Main()
		{
			Handle.GET("/Server/test", () => {
				return "Test OK";
			});
		}
	}
}