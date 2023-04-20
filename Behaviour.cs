using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = System.Random;

public class Behaviour : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D myRigidbody;
    [SerializeField] Collider2D pointA;

    public bool moving;

    public int n1;
    public int n2;
    public int contador=0;
    

    void Start()
    {
        myRigidbody=GetComponent<Rigidbody2D>();
        moving=true;
        leer();
    }


    void Update()
    {
        if(IsFacingRight())
        {
            myRigidbody.velocity=new Vector2(moveSpeed, 0f);
        }
        else
        {
            if(moving){
                myRigidbody.velocity=new Vector2(-moveSpeed, 0f);
            }else{
                myRigidbody.velocity=new Vector2(0f, 0f);
            }
            
        }
        if(Input.GetMouseButtonDown(0)&&!moving){
            isMoving();
            comparar();
        }
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x>Mathf.Epsilon;
    }

    void isMoving(){
        moving=!moving;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.name=="PointA")
        {
            Destroy(gameObject);
            moving=true;
        } 
        else
        {
            moving=false;
            //PAUSA
            transform.localScale=new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)),transform.localScale.y);
        }
    }

    public void comparar(){
        if(n1==n2){
            contador++;
        }
        Debug.Log(contador);
    }

    public void leer(){
        Random random=new Random();
        n1=random.Next(0,2);
        n2=random.Next(0,2);
        Debug.Log(n1);
        Debug.Log(n2);
    }
}
