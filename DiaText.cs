using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiaText : MonoBehaviour
{

    private int dia=0; //deathCount
    private TextMeshProUGUI textocontador; //deathCountText


    private void Awake()
    {
        textocontador=this.GetComponent<TextMeshProUGUI>();
    }

    private void OnDiaPasa()//OnPlayerDeath
    {
        dia++;
    }

    private void Update(){
        textocontador.text="" + dia;
    }
}
