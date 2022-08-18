using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertButton : MonoBehaviour
{

    public GameObject alert;

    public void Yes()
    {
        Time.timeScale = 1;
    }
    public void No()
    {
        alert.SetActive(false);
    }

    public void Exit()
    {
        alert.SetActive(true);
    }
    //private void test()




}
