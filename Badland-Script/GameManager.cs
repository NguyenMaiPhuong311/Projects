using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject[] playerPrefabs;// Mang nhan vat co the sinh ra
    [SerializeField] private Transform playerPosition;
    [SerializeField] private  TextMeshProUGUI scoreText ;
  
    private GameObject a;
    public bool isStart;

    private int score;

    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
         a= Instantiate(playerPrefabs[Random.Range(0,playerPrefabs.Length)],playerPosition.position,Quaternion.identity
            );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isStart = true;
            a.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            a.GetComponent<Rigidbody2D>().gravityScale=1f;

        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text=score.ToString();
    }
    public void EndGame()
    {
        isStart = false;
        Time.timeScale=0;
    }
  
}
