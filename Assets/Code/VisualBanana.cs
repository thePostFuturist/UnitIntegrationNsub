using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VisualBanana : MonoBehaviour {

	[SerializeField]
	Button button;

	[SerializeField]
	Image image;

	void OnEnable()
	{
		button.onClick.AddListener(ShowBanana);
	}

	void ShowBanana()
	{
		image.enabled = true;
	}

}
