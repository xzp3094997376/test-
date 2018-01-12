using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//按比例缩放
//game的显示是由相机视野决定的
//相机高度大小由此决定
//宽度或高度较小,扩大相机视野
public class TestCamera : MonoBehaviour {
    float devHeight = 9.6f;
    float devWidth = 6.4f;
	// Use this for initialization
	void OnEnable () {
        float screenHeight = Screen.height;
        Debug.Log(screenHeight);
        float orthsize = this.GetComponent<Camera>().orthographicSize;//得到相机正交属性值大小
        float aspectRatio = Screen.width * 1.0f / Screen.height;//得到当前设备宽高比
        //实际的宽高比和摄像机的orthographicSize值来计算摄像机的宽度值
        float cameraWidth = orthsize * 2 * aspectRatio;//
        if (cameraWidth < devWidth)//目标屏幕高度大，上下有黑边，两边溢出
        {
            orthsize = devWidth / (2 * aspectRatio);//屏幕变小，相机视野宽度放大，两边不留黑边
            this.GetComponent<Camera>().orthographicSize = orthsize;
        }
        else//目标屏幕大，画面两边宽度留黑边
        {

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
