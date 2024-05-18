using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManage : MonoBehaviour
{
    public void ChangeScence()
    {
        StartCoroutine(StartGame());
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(1);
    }
}
