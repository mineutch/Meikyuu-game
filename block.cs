using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    int center = 10;
    public GameObject GoalText;

    // Start is called before the first frame update
    void Start()
    {
        GoalText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Transform myTransform = this.transform;//自分自身のポジション
        // 座標を取得
        Vector3 pos = myTransform.position;
        int x = (int)pos.x/5+center;
        int z = (int)pos.z/5+center;
        
        if (blockmap.array[x,z] == 2)
        {   //ゴール処理
            pos.y += 8;    // y座標へ2加算
            myTransform.position = pos;  // 座標を設定
            Debug.Log("Goal"); // ログを表示する
            GoalText.SetActive(true);//ゴール画面表示
            Timer.timecount_ok = 2;//終了
            gameObject.GetComponent<Renderer>().material.color = Color.red;//色を変更

        }
        
    }

}
