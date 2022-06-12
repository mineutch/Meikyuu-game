using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go3D : MonoBehaviour
{
    
    Rigidbody rb;
    int direction=0;
    int speed = 10;
    int p = 0;
    int w = 0;//回転用
    float speedR = 4f;
    float step;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ここで移動を行う0,1,2,3で処理

        if (direction % 4 == 0|| direction % 4 == 2)
        {
            if (direction % 4 == 2)
            {//後ろ
                //rb.AddForce(-speed * p, 0, 0);
                transform.position += new Vector3(-speed * p * Time.deltaTime, 0, 0);
            }
            else
            {//前
                //rb.AddForce(speed * p, 0, 0);
                transform.position += new Vector3(speed * p * Time.deltaTime, 0, 0);
            }
        }else if (direction % 4 == 1 || direction % 4 == 3)
        {
            if (direction % 4 == 1)
            {//後ろ
                //rb.AddForce(0,0,-speed * p);
                transform.position += new Vector3(0, 0, -speed * p * Time.deltaTime);
            }
            else
            {//前
                //rb.AddForce(0,0,speed * p);
                transform.position += new Vector3(0, 0, speed * p * Time.deltaTime);
            }

        }

        if (w == 1)
        {
            step = speedR * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,(direction%4)*90f, 0), step);
        }

    }
    public void forwardButtonDown()
    {
        p = 1;
    }
    public void forwardButtonUp()
    {
        p = 0;
    }

    public void backButtonDown()
    {
        p = -1;
    }

    public void backButtonUp()
    {
        p = 0;
    }
    public void rightButton()
    {
        if (direction == 4) direction = 0;
        direction +=1;
        w = 1;
    }
    public void leftButton()
    {
        if (direction == 0) direction = 4;
        direction -= 1;
        w = 1;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hitcube"); // ログを表示する
    }

}
