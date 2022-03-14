using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",2f,2f);
        
    }

    private void SpawnEnemy()
    {
        Vector3 positions = new Vector3(transform.position.x,transform.position.y,0f);
        Instantiate(enemyPrefab,positions,Quaternion.identity);
    }
}
