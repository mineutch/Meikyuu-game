using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class blockmap : MonoBehaviour
{
    public GameObject blockPrefab;

    int size=5;
    public static int[,] array = new int[25, 25];
    public static int C_select = 0;
    int center=10;
    int high = 10;
    // Start is called before the first frame update
    void Start()
    {
       
        Vector3 placePosition3;
        Quaternion q = new Quaternion();
        q = Quaternion.identity;

        for (int i = 0; i < 20; i++)
        {//xとzを調整する
            for (int j = 0; j < 20; j++)
            {//xとzを調整する
                array[i,j] = 0;//初期化
            }
        }
        array[0,0] = 1;

        int r1;
        int r2;

        for (int i = 0; i < 45; i++)
        {//xとzを調整する
            while (true)
            {
                r1 = Random.Range(0, 20);
                r2 = Random.Range(0, 20);
                if (array[r1, r2] == 0) break;
            }
            //壁配置
            if (i != 0)
            {
                high = 10;
                placePosition3 = new Vector3((r1 - center) * size, high-2, (r2 - center) * size);
                var _obj = Instantiate(blockPrefab, placePosition3, q);
                if (C_select == 1)//色変更
                {
                    var _renderer = _obj.GetComponent<Renderer>();
                    _renderer.material.color = Color.black;
                }
            }

            array[r1, r2] = 1;//壁配置

            if (i == 0)
            {
                //1箇所色変更

                

                placePosition3 = new Vector3((r1 - center) * size, high, (r2 - center) * size);
                var _obj = Instantiate(blockPrefab, placePosition3, q);

                var _renderer = _obj.GetComponent<Renderer>();
                _renderer.material.color = Color.green;
                //色変更

                array[r1, r2] = 2;//壁配置ゴール
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void blockcheck()
    {
        

    }
}
