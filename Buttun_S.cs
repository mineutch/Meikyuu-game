using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttun_S : MonoBehaviour
{
    public GameObject controler;
    public GameObject start_obj;
    // Start is called before the first frame update
    void Start()
    {
        controler.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void starton()
    {
        controler.SetActive(true);
        Timer.timecount_ok = 1;//計測オーケよ
        start_obj.SetActive(false);
    }
}
