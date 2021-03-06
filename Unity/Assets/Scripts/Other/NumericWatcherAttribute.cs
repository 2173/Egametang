﻿using System;

namespace Model
{
	public class NumericWatcherAttribute : Attribute
	{
		public NumericType NumericType { get; }

		public NumericWatcherAttribute(NumericType type)
		{
			this.NumericType = type;
		}
	}
}