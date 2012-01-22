using NUnit.Framework;

namespace SpecificationForExample.Utils
{
	public abstract class Specification
	{
		[SetUp]
		public void BaseSetUp()
		{
			SetupParameters();
			SetupDependencies();
			InitializeClassUnderTest();
			Because();
		}

		[TearDown]
		public void BaseTearDown()
		{
			DisposeContext();
		}

		protected virtual void SetupParameters() { }
		protected virtual void SetupDependencies() { }
		protected virtual void InitializeClassUnderTest() { }
		protected virtual void Because() { }
		protected virtual void DisposeContext() { }
	}
}