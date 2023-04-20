using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausita : MonoBehaviour
{
    public static bool PausaPalCafe=false;

    public GameObject MenusitoPausa;

    // Start is called before the first frame update
    void Start()
    {
        MenusitoPausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(PausaPalCafe) Palante();
            else QuietoParao();
        }
    }
    public void Palante()
    {
        MenusitoPausa.SetActive(false);
        Time.timeScale=1f;
        PausaPalCafe=false;
    }

    public void QuietoParao()
    {
        MenusitoPausa.SetActive(true);
        Time.timeScale=0f;
        PausaPalCafe=true;
    }

    public void Opsiones()
    {
        Debug.Log("opciones");
    }

    public void LaCarta()
    {
        Time.timeScale=1f;
        Debug.Log("menu");
    }
}
