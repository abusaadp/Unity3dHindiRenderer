using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hindiGlyph : MonoBehaviour {

	public Text hindiText;

	// Use this for initialization
	void Start () {
		hindiText.text = UnicodeToKrutidev.UnicodeToKrutiDev(hindiText.text);
	}

}
