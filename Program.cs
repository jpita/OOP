using System;

namespace OOP
{
	class Principal
	{
		public static void Main (string[] args)
		{
			//Publisher publisher = new Publisher ();
			//publisher.RaiseSampleEvent ();
			SampleClass sampleObject = new SampleClass();
			//set a property method
			sampleObject.SampleProperty = 0;
			Console.WriteLine ("sampleObject property = {0}", sampleObject.SampleProperty);
			//call a method
			sampleObject.sampleMethod (1);

			SampleClass sampleObject2 = new SampleClass{ SampleProperty = 2 };
			Console.WriteLine ("sampleObject property = {0} & sampleObject2 property = {1}", sampleObject.SampleProperty, sampleObject2.SampleProperty);
			Console.WriteLine (StaticClass.StaticString);

			//anonymous objects
			var anonymousObject = new {FirstProperty = "A"};
			Console.WriteLine (anonymousObject.FirstProperty);

			Console.ReadLine ();
		}
	}

	static class StaticClass
	{
		public static string StaticString = "Static String";
	}

	class SampleClass
	{
		//internal property
		private int _sample;

		public SampleClass()
		{
			//constructor
		}

		//getter and setter for internal property accessible from outside of the class
		public int SampleProperty { 
			get {
				return _sample;
			}
			set
			{ 
				_sample = value; 
			}				
		}

		public int sampleMethod(string sampleParam)
		{
			return 0;
		}

		//override method of the previous one
		public int sampleMethod(int sampleParam) 
		{
			return 1;
		}

	}

	class Container
	{
		//nested class of container class
		//in order to use it:
		//Container.Nested nestedInstance = new Container.Nested()
		class Nested
		{
			// Add code here.
		}
	}



}
