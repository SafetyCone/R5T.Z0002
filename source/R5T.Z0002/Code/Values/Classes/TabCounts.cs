using System;


namespace R5T.Z0002
{
	public class TabCounts : ITabCounts
	{
		#region Infrastructure

	    public static TabCounts Instance { get; } = new();

	    private TabCounts()
	    {
	    }

	    #endregion
	}
}