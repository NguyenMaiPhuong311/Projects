using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager1 : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private MeshRenderer bgRenderer;

    // Start is called before the first frame update
     void Start()
    {
        ScaleBackground();

    }
    
    // Update is called once per frame
    void Update()
    {
        Scrollackground();
    }
    
    void ScaleBackground()
    {
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Camera.main.aspect * 3f;
        Debug.Log(height + "---" + width);
        transform.localScale = new Vector3( width, height, 1f);
    }
    void Scrollackground()
    {
        bgRenderer.material.mainTextureOffset = new Vector2(Time.time * scrollSpeed, 0f);
    }
}
