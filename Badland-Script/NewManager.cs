using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumyManager : MonoBehaviour
{
    [SerializeField] private  float speed,rotateSpeed;
    [SerializeField] private bool canRotate;
   
   
    // Start is called before the first frame update
    private void Start()
    {
       speed= Random.Range(2f,5f);
        rotateSpeed=Random.Range(rotateSpeed, rotateSpeed +20f);
    }

    // Update is called once per frame
   private  void Update()
    {
        MoveEnumy();
        RotateEnumy();
       
    }

    void MoveEnumy()
    {
        Vector3 temp = transform.position;
        temp.x -= speed* Time.deltaTime;
        transform.position = temp;

        
    }

     void RotateEnumy()
    {
        if(canRotate)
        {
            transform.Rotate(new Vector3(0f,0f,rotateSpeed* Time.deltaTime));
        }
    }

    
}
