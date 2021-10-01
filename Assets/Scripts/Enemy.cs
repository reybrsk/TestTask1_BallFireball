using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag($"Bullet"))
        {
            Debug.Log("hit");
            other.GetComponent<Bulle>().Boom();
            DestroyGameObject();
                    
        }

        if (other.gameObject.CompareTag($"Player"))
        {
            Destroy(other.gameObject);
            Debug.Log($"!!!You DIE!!!!");
        }
    }
        
}
