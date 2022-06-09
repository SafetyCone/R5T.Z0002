using System;

using R5T.T0131;


namespace R5T.Z0002
{
	[ValuesMarker]
	public interface ITabCounts : IValuesMarker
	{
		public int ForTypeDeclaration => 1;
	}
}