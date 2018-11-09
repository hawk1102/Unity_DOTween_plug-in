using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MyText : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = this.GetComponent<Text>();
        text.DOText("大家好，我叫Gary!!!",2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
