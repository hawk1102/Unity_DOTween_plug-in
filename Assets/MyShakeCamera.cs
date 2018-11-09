using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyShakeCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //随机向走位移动3m的距离
        transform.DOShakePosition(3);
        //在x和y轴上震动
        //震动完后摄像机还是会回到原位
        //transform.DOShakePosition(3,new Vector3(1,1,0));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
