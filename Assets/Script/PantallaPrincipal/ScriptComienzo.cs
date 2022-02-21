using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptComienzo : MonoBehaviour
{
    public void comenzar()
    {
        SceneManager.LoadScene("VuforiaEscaneo", LoadSceneMode.Single);
    }

    public void salir()
    {
        Application.Quit();
    }
}
