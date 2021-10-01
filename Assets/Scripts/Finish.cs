using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag($"Player"))
        {
            Destroy(other);
            Debug.Log($"!!!You WIN!!!!");
        }
    }
}
