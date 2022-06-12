using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result_time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "time: "+Timer.goaltime.ToString("F2"); //小数2桁にして表示
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
