using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scens : MonoBehaviour
{
    public void menuuu()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void Exitgame()
    {
        Application.Quit();
    }

    public void YouTube()
    {
        Application.OpenURL("https://youtube.com/@MormyshkaS?si=CvTTAjQfXJUciy-I");
    }

    public void Diskord()
    {
    }
}
