using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace bananas.tests
{
	public class BananaUnitTests {

		GameObject game_object_banana;
		Image image_banana;

		[SetUp]
		public void SetUp()
		{
			// Arrange
			game_object_banana = new GameObject();
			image_banana = game_object_banana.AddComponent<Image>();
		}

		[Test]
		public void TestIfImageComponentNotActive()
		{
			// Act
			image_banana.enabled = false;

			// Assert
			Assert.AreEqual(image_banana.IsActive(), false);
		}

		[TearDown]
		public void TearDown()
		{
			Object.DestroyImmediate(game_object_banana);
		}

		[Test]
		[Ignore]
		public void IntCompare()
		{
			// Arrange
			int a = 3;
			int b = 5;

			// Act
			a = b;

			// Assert
			Assert.AreEqual(b, a);

		}

	}
}
