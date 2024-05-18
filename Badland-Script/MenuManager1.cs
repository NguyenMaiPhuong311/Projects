using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager1 : MonoBehaviour
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
    public void Reset()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(1);
    }
    public void LoadNewScene()
    {
        SceneManager.LoadScene(0);
    }

}
