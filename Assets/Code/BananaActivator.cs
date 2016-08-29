using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace bananas.tests
{
	public class BananaActivator : MonoBehaviour {

		[SerializeField]
		int wait_time;

		[SerializeField]
		Image image_banana;

		void Start()
		{
			this.onButtonPressSim += (ActivateImage);
			StartCoroutine(Wait(FireButtonPressEvent));
		}

		IEnumerator Wait(System.Action callback)
		{
			yield return new WaitForSeconds(wait_time);
			callback();
		}

		void ActivateImage()
		{
			image_banana.enabled = true;
		}

		void FireButtonPressEvent()
		{
			if (onButtonPressSim!=null)
				onButtonPressSim();
		}
	
		public event System.Action onButtonPressSim;
	}
}


// how to run multiple tests?
// how to keep things organized