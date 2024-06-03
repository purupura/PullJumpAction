using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour
{
    [SerializeField]
    private Image arrowImage;
    private Vector3 clickPostion;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Vector3 clickPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            //ベクトルの長さを算出
            float size=dist.magnitude;
            //ベクトルから角度（弧度法）を算出
            float angleRed=Mathf.Atan2(dist.y, dist.x);
            //矢印の画像をクリックした場所に移動
            arrowImage.rectTransform.position = clickPosition;
            //矢印の画像をベクトルから算出した角度の弧度法に変換してZ軸回転
            arrowImage.rectTransform.rotation =
                Quaternion.Euler(0, 0, angleRed * Mathf.Rad2Deg);
            //矢印の画像の大きさをドラッグした距離に合わせる
            arrowImage.rectTransform.sizeDelta=new Vector2(size, size);
        
        }
    }

   
    
      

}
