using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbsoluteScenes : MonoBehaviour
{
    public void CargarEscenita(string escenita)
    {
        SceneManager.LoadScene(escenita);
    }
}
