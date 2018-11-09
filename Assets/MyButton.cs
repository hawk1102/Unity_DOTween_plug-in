using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyButton : MonoBehaviour {

    public RectTransform panelTransform;

    public bool isIn = false;

    private void Start()
    {
        //默认动画播放完就会被销毁
        Tweener tweener = panelTransform.DOLocalMove(new Vector3(0, 0, 0), 1);
        //Tweener对象保存这个动画的信息，每次调用do类型的方法都会创建一个tween对象，这个对象是dotween对象来管理的
        tweener.SetAutoKill(false); //把autokill自动设置为false
        tweener.Pause();
    }

    public void OnClick()
    {
           //点击第一次时让RectTransform进入屏幕当中
        if (isIn == false)
        {
            panelTransform.DOPlayForward();
            isIn = true;
        }
        else
        {
            //让RectTransform离开屏幕
            panelTransform.DOPlayBackwards();
            isIn = false;
        }

    }
}
