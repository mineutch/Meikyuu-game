using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_data : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //読み出し
        GetComponent<Text>().text = PlayerPrefs.GetString("Data");
        //前回の削除
        PlayerPrefs.DeleteKey("Data"); // キーの値を削除
        PlayerPrefs.SetString("Data", "time: " + Timer.goaltime.ToString("F2"));
        PlayerPrefs.Save();

    }
}
