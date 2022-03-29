using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject IntroPanel;

    private void Start()
    {
        StartCoroutine(DelayTime(10));
    }



    IEnumerator DelayTime(float time)
    {
        yield return new WaitForSeconds(time);

        IntroPanel.SetActive(false);
        StartPanel.SetActive(true);
    }
}
