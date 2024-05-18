using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private float timer,y;
    [SerializeField] private float hoverDistance, hoverSpeed,force;
    private Rigidbody2D rb;

    AudioManager1 audioManager;

    private void Awake() {
        audioManager = GameObject.FindWithTag("Audio").GetComponent<AudioManager1>();
    }




    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isStart) {    
        timer += Time.deltaTime;
        y = hoverDistance * Mathf.Sin(timer * hoverSpeed);
        transform.localPosition = new Vector3(transform.position.x,y,transform.position.z);
            }
    }

    private void LateUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * force);// day nhan vat
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point")
        {
            audioManager.PlayClip(audioManager.newplayer);
            Destroy(other.gameObject);
            GameManager.Instance.UpdateScore();
           
        }else if (other.gameObject.tag == "Obstacle")
        {
            audioManager.PlayClip(audioManager.barr);
            GameManager.Instance.EndGame();
            SceneManager.LoadScene(2);
        }
    }


}
