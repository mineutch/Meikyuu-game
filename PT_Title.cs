using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン切替

public class PT_Title : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Title");
    }
}
