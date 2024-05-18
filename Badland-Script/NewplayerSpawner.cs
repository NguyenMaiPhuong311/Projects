using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumySpawner : MonoBehaviour
{
    [SerializeField] private GameObject newplayer;
    
    [SerializeField] private float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemies()
    {
        float posY = Random.Range(minY, maxY);
        Vector3 temp = transform.position;
        temp.y = posY;
       
            GameObject newplayerob=Instantiate(newplayer, temp, Quaternion.identity);
            Destroy(newplayerob, 10f);
        
        Invoke("SpawnEnemies",5f);
    }
}
