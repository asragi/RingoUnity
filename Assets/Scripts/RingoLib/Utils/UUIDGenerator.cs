using System;
namespace RingoLib.Core.Utils
{
	public class UUIDGenerator : IIDGenerator
	{
		public string Gen() {
			var guid = Guid.NewGuid();
			return guid.ToString();
		}
	}
}
