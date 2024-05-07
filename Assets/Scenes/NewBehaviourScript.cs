using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void AbsolutamenteCinema(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void VaEmbora()
    {
        Debug.Log("va embora seu fudido");
        Application.Quit();     


    }





}
