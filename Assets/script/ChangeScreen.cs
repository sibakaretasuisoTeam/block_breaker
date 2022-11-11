using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour
{
    public static int stage = 0;

    //ぼたんごとのしょり
    public void TappedButton0()
    {
        stage = 0;

        //PlayerPrefs.SetInt("stage", stage);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void TappedButton1()
    {
        stage = 1;

        //PlayerPrefs.SetInt("stage", stage);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void TappedButton2()
    {
        stage = 2;

        //PlayerPrefs.SetInt("stage", stage);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    //タイトルへ
    public void Gotitle()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }
}
