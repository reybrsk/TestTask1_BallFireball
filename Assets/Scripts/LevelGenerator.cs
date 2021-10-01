using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int enemyInstanse;
    [SerializeField] private GameObject enemyGO;
    

        // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyInstanse; i++)
        {
            var pos = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
            Object.Instantiate(enemyGO, transform.position + pos,Quaternion.identity);
        }
    }

  
}
