using NUnit.Framework;
using NSubstitute;

namespace bananas.tests
{
	public class BananaNsubstitutionTests  {

		[Test]
		public void BananaNotReceivedStub()
		{
			DummyConditioner dummy_conditioner = new DummyConditioner();

			Assert.AreEqual(dummy_conditioner.GetBanana(), false);
		}

		[Test]
		public void BananaNotReceivedSub()
		{
			var nsub = Substitute.For<IConditioner>();

			nsub.GetBanana().Returns(false);

			Assert.AreEqual(nsub.GetBanana(), false);
		}
	}

	public class DummyConditioner : IConditioner
	{
		#region IConditioner implementation
		public bool GetBanana ()
		{
			return false;
		}
		#endregion
	}

	public interface IConditioner
	{
		bool GetBanana();
	}

}