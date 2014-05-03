using System;

namespace OOP
{
	class BaseClass
	{
		public BaseClass()
		{
		}
	}

	class DerivedClass:BaseClass{}

	//This class cannot be used as a base class
	public sealed class A{}

	//this class can only be used as a base class and cannot be instantiated
	public abstract class B{}
}

