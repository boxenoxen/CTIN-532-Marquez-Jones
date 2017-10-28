using System;
using System.Collections.Generic;
using System.Linq;

public static partial class ListContainer
{

// SPRITE INDEX PREVIOUS==================================================
	public static T SpriteIndexPrevious<T>(this IList<T> list, T mySpriteList)
	{
		var index = list.IndexOf (mySpriteList);
		--index;

		if (index < 0) 
		{
			return list.Last ();
		}
		return  list [index];
	}

// SPRITE INDEX NEXT==================================================
	public static T SpriteIndexNext<T>(this IList<T> list, T mySpriteList)
	{
		var index = list.IndexOf (mySpriteList);
		++index;

		if (index >= list.Count) 
		{
			return list.First ();
		}
		return  list [index];
	}
}