using System;
using System.Collections.Generic;

namespace SerializationHelper
{
	[Serializable]
	public class ListSerializationWrap<T>
	{
		public List<T> items;
	}

	[Serializable]
	public class KeyValuePairWrap<T, K>
	{
		public T key;
		public K value;
	}
}