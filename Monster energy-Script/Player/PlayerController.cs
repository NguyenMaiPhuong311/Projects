using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Slider HealthBar;
    [SerializeField] private float Health;
    [SerializeField] GameObject Endgame;

    // Start is called before the first frame update
    void Start()
    {
       HealthBar.value = Health;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "A")
        {
            Health -= 10;
            HealthBar.value = Health;
            if (Health == 0)
            {
                Endgame.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    

}
