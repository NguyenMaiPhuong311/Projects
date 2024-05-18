using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterRandom : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    [SerializeField] private int xmin;
    [SerializeField] private int xmax;
    [SerializeField] private int zmin;
    [SerializeField] private int zmax;

    [SerializeField] private int xPos;
    [SerializeField] private int zPos;
    [SerializeField] private int yPos;
    public int MonsterCount;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MonsterDrop());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator MonsterDrop()
    {
        while (MonsterCount < 20)
        {
            xPos = Random.Range(xmin, xmax);
            zPos = Random.Range(zmin, zmax);
            Instantiate(monster, new Vector3(xPos, yPos, zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            MonsterCount++;
        }
    }
}
