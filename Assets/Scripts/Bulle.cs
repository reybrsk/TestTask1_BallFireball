using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Bulle : MonoBehaviour
{


    public bool ismove = false;
    private bool isboom = false;
    private Transform player;
    private Vector3 movevector;
    [SerializeField,Range(0f,10f)]private float bulletSpeed = 5f;
    [SerializeField, Range(0f, 1f)] private float boomDuration; 
    [SerializeField,Range(0f,10f)]private float bulletScale = 5f;
    
    
    
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ismove)
        {
            var position = transform.position;
            movevector = Vector3.Normalize(position - player.position);
            position += movevector * Time.deltaTime * bulletSpeed;
            transform.position = position;
        }

        
    }

    public void Boom()
    {

        if (!isboom)
        {
            ismove = false;
                    transform.DOScale(transform.localScale*bulletScale, boomDuration).
                        OnComplete(()=> Destroy(gameObject));
        }
        isboom = true;
    }
}
