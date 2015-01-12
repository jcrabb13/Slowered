using System;

namespace Mvc4CSharpRazorFx45Intranet
{
	public class Build
	{
		[BsonId]
		public ObjectID BuildID { get; set; }

		public string Name { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get;set: }

		public Build ()
		{

		}
	}
}

