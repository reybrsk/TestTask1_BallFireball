using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField,Range(0,1)]private float powerSpeed;
   [SerializeField, Range(0, 10)] private float rotateSpeed;
   [SerializeField, Range(0, 10)] private float moveSpeed;
   public GameObject fireBall;
   private GameObject _targetFireBall;
   



   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           _targetFireBall = Object.Instantiate(fireBall,transform.position + transform.forward*transform.localScale.z*0.5f,Quaternion.identity);
           _targetFireBall.transform.localScale = Vector3.one * 0.001f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Scaler scaler = GetComponent<Scaler>();
            scaler.scale -= (float)(powerSpeed * Time.deltaTime);
            _targetFireBall.transform.localScale += Vector3.one * (float)(powerSpeed * Time.deltaTime);
            _targetFireBall.transform.Translate(_targetFireBall.transform.forward*Time.deltaTime);
            

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _targetFireBall.GetComponent<Bulle>().ismove = true;
        }
        
        if(Input.GetAxis("Horizontal")!=0f)
            transform.Rotate(0f,(float)rotateSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f);
        if(Input.GetAxis("Vertical")!=0f)
            transform.Translate(moveSpeed*Input.GetAxis($"Vertical")*transform.forward*Time.deltaTime);

    }
}
