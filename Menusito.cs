using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using System.IO;
using Random = System.Random;
using UnityEngine.SceneManagement;

public class Menusito : MonoBehaviour
{
    public GameObject menusito;
    public GameObject opsion;
    public GameObject ajuga;
    public AudioMixer grito;

    [SerializeField] private TMP_Dropdown resdrop;
    private Resolution[] resolusiones;
    private List<Resolution> listadas;
    private float refresco;
    private int resind;

    Random random=new Random();

    /* public TextMeshProUGUI t1;
    public TextMeshProUGUI t2;
    public TextMeshProUGUI t3; */


    // Start is called before the first frame update
    void Start()
    {
        menusito.SetActive(true);
        opsion.SetActive(false);
        ajuga.SetActive(false);
        QualitySettings.SetQualityLevel(5);

        resolusiones=Screen.resolutions;
        listadas=new List<Resolution>();
        resdrop.ClearOptions();
        refresco=Screen.currentResolution.refreshRate;
        for(int x=0;x<resolusiones.Length;x++){
            if(resolusiones[x].refreshRate==refresco) listadas.Add(resolusiones[x]);
        }
        List<string> opsionsitas=new List<string>();
        for(int x=0;x<listadas.Count;x++){
            string reso=resolusiones[x].width+"x"+resolusiones[x].height+" "+resolusiones[x].refreshRate+" Hz";
            opsionsitas.Add(reso);
            if(resolusiones[x].width==Screen.width&&resolusiones[x].height==Screen.height) resind=x;
        }
        resdrop.AddOptions(opsionsitas);
        resdrop.value=resind;
        resdrop.RefreshShownValue();
    }

    public void PonerRes(int resin)
    {
        Resolution res=resolusiones[resin];
        Screen.SetResolution(res.width,res.height,true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Pafuera()
    {
        Application.Quit();
    }

    public void ErGrito(float db)
    {
        grito.SetFloat("ElGrito", ((db-1)*80));

    }

    public void Trillhouse(int qi)
    {
        switch(qi){
            case 0: qi=5; break;
            case 1: qi=3; break;
            case 3: qi=1; break;
        }
        QualitySettings.SetQualityLevel(qi);
    }

    public void Pantallita(bool completa)
    {
        Screen.fullScreen=completa;
    }

    /* public void leer(){
        random=new Random();
        string nombre="C:\\Users\\Practicas\\Papers\\datos.csv";
        int num=random.Next(0,100);
        Debug.Log(num);
        int contador=0;
        using (StreamReader reader = new StreamReader(nombre))  
        {  
            string line;  
            // Read line by line  
            while ((line = reader.ReadLine()) != null)  
            {  
                if(contador==num){
                    Debug.Log(line.Split(',')[1]+" "+line.Split(',')[2]);
                    t1.SetText(line.Split(',')[1]);
                    t2.SetText(line.Split(',')[1]);
                } 
                contador++;
            }
            string te1;
            string te2;
            Debug.Log(t1);
            Debug.Log("a");
            te1=t1.text;
            Debug.Log(te1);
            te2=t2.text;
            Debug.Log(te2);
            if(te1==te2){
                t3.SetText("bien");
            }else{
                t3.SetText("mal");
            }
        }
    }  */ 
}
