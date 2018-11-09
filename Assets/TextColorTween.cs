using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextColorTween : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();

        //设置文字动画,渐变时间2s
        text.DOColor(Color.red,2);

        //设置文字透明度,渐变时间3s
        text.DOFade(0,3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
