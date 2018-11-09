using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //从当前位置运行到X放
        //transform.DOMoveX(5,1);
        //默认是从当前位置运行到目标位置，加上From()方法以后表示从目标位置移动到当前位置
        //transform.DOMoveX(5, 1).From();

        transform.DOMoveX(5, 2).From(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
