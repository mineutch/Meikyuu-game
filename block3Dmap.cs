using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class block3Dmap : MonoBehaviour
{
    public GameObject blockPrefab;

    int size=5;
    public static int[,,] array = new int[25, 25,25];//x,x,y(hight)
    public static int C_select = 0;
    int center=10;
    //int high = 0;//10->0 4/27
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
                for (int m = 0; m < 20; m++)
                {//xとzを調整する
                    array[i, j, m] = 0;//初期化
                }
            }
        }
        array[0,0,0] = 1;

        int r1;
        int r2;
        int r3;


        //45回

        for (int i = 0; i < 45*20; i++)
        {//xとzを調整する(yも...)
            while (true)
            {
                r1 = Random.Range(0, 20);
                r2 = Random.Range(0, 20);
                r3 = Random.Range(0, 20);//new
                if (array[r1, r2,r3] == 0) break;
            }

            //壁配置
            if (i != 0)
            {
                //high = 10;
                //placePosition3 = new Vector3((r1 - center) * size, high-2, (r2 - center) * size);
                placePosition3 = new Vector3((r1 - center) * size,r3*size, (r2 - center) * size);
                var _obj = Instantiate(blockPrefab, placePosition3, q);
                if (C_select == 1)//色変更
                {
                    var _renderer = _obj.GetComponent<Renderer>();
                    _renderer.material.color = Color.black;
                }
            }

            array[r1, r2,r3] = 1;//壁配置

            if (i == 0)
            {
                //1箇所色変更

                

                placePosition3 = new Vector3((r1 - center) * size, r3 * size, (r2 - center) * size);
                var _obj = Instantiate(blockPrefab, placePosition3, q);

                var _renderer = _obj.GetComponent<Renderer>();
                _renderer.material.color = Color.green;
                //色変更

                array[r1, r2,r3] = 2;//壁配置ゴール
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
