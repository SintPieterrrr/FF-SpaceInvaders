using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGameRestart : MonoBehaviour
{
    public void SwitchScene(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }
}
