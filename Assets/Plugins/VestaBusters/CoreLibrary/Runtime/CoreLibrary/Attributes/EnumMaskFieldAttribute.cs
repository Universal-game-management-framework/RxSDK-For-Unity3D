using System;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
	public class EnumMaskFieldAttribute : PropertyAttribute 
	{
		#region Properties

		public Type EnumType 
		{ 
			get; 
			private set; 
		}

		#endregion

		#region Constructors

		private EnumMaskFieldAttribute()
		{}

		public EnumMaskFieldAttribute(Type type)
		{
			EnumType	= type;
		}

		#endregion
	}
}