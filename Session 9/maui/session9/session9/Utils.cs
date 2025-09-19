using System;
namespace session9
{
	public static class Utils
	{
		public static string Repeat(this string toRepeat,int count)
		{
			string result = "";
			for (int i=0;i<count;++i)
			{
				result += toRepeat;
			}
			return result;
		}
	}
}

