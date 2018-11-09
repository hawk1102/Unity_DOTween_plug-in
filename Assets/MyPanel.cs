using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Tweener tweener = transform.DOLocalMoveX(0,2);
        tweener.SetEase(Ease.OutBounce);

        tweener.SetLoops(0);
        tweener.OnComplete(OnTweenComplete);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTweenComplete()
    {
        
    }
}
