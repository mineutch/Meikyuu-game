using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン切替

public class Timer : MonoBehaviour
{

	float countTime = 0;
	public static int timecount_ok = 0;
	public static float goaltime = 0;

	void Update()
	{
        if (timecount_ok==1)
        {
			countTime += Time.deltaTime; //スタートしてからの秒数を格納
			GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示
		}
		else if(timecount_ok == 2)
        {//ゴール時点でのタイムを記録
			goaltime = countTime;
			timecount_ok = 3;
		}else if(timecount_ok == 3)
        {
			countTime += Time.deltaTime; //スタートしてからの秒数を格納
			if(countTime- goaltime > 5)
            {
				//画面遷移
				SceneManager.LoadScene("Score");
			}

		}

		
		
	}

	
}
