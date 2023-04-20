using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public int deathCount;
    //+ variables para + cosas a guardar

    /*
    array (vid:monedas, juego:eventos?)
    */

    /*
    public Dictionary<string, bool> coinsCollected;
    */

    //variables del constructor=por defecto
    public GameData()
    {
        this.deathCount=0;
        //inicializar
        //coinsCollected=new Dictionary<string, bool>();
    }

    //poner en el script de moneda/loquesea:
    /*
    [SerializeField] private string id;

    ContextMenu("Generate guid for id")]
    private void GenerateGuid(){
            id=System.Guid.NewGuid().ToString();
    }
    */
}
