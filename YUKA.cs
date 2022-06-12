using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YUKA : MonoBehaviour
{
    public static int C_select = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (C_select == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;//色を変更
            //色変更
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
