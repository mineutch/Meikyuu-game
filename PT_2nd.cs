using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン切替

public class PT_2nd : MonoBehaviour
{
    public void Change()
    {
        blockmap.C_select = 1;//色を黒に変更
        YUKA.C_select = 1;
        SceneManager.LoadScene("Main");
    }
}
