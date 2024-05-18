using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricadeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject barr1;
    [SerializeField] private GameObject barr2;
    [SerializeField] private float minY, maxY,waitTime;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
       
        Invoke("SpawnEnemies", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isStart)
        {
            timer += Time.deltaTime;
            if(timer > waitTime)
            {
                Instantiate(barr2 ,transform.position,Quaternion.identity);
                timer = 0;
            }
        }
    }
    void SpawnEnemies()
    {
        float posY = Random.Range(minY, maxY);
        Vector3 temp = transform.position;
        temp.y = posY;
        if (Random.Range(0, 2) > 0)
        {
            GameObject barr1ob = Instantiate(barr1, temp, Quaternion.identity);
            Destroy(barr1ob, 10f);
        }
        else 
        {
            GameObject barr2ob = Instantiate(barr2, temp, Quaternion.identity);
            Destroy(barr2ob, 10f);
        }
        Invoke("SpawnEnemies", 2f);
    }
}
