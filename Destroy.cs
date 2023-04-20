using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float lifeTime=3f;

    private Rigidbody2D rb;
    
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }
}
