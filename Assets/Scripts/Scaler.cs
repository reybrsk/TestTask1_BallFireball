using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    [Range(0f,10f)]public float scale;
    private float oldScale;


    // Start is called before the first frame update
    void Start()
    {
        Scale();
    }

    public void Scale()
    {
       var localScale =  transform.localScale;
       localScale = Vector3.one*scale;
       transform.localScale = localScale;
       oldScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localScale.x <= 1f)
        {
            Destroy(gameObject);
            Debug.Log($"!!!YOU DIE!!!");
        }
        if (Math.Abs(oldScale - scale) > 0f) Scale();
    }
}
