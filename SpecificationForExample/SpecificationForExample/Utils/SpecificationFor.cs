namespace SpecificationForExample.Utils
{
	public abstract class SpecificationFor<TClassUnderTest> : Specification
	{
		protected override void InitializeClassUnderTest()
		{
			ClassUnderTest = CreateClassUnderTest();
		}

		protected abstract TClassUnderTest CreateClassUnderTest();

		protected TClassUnderTest ClassUnderTest { get; private set; }
	}
}