using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void ResetLevel()
    {
        SceneManager.LoadScene("Woltz_Scene");
        Time.timeScale = 1;
    }
}
