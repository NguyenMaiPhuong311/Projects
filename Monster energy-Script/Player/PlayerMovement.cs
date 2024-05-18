using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float zMoveSpeed;
   

    PlayerAnimation playerAnim;
    Rigidbody rb;
    float h, v;
    Vector3 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponentInChildren<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw(Axis.HORIZONTAL);
        v= Input.GetAxisRaw(Axis.VERTICAL);
        PlayerAnimWalk();
        
    }
    private void FixedUpdate()
    {
        PlayerMove(h, v);
        Turning();
    }
    void PlayerMove(float h, float v)
    {
        rb.velocity= new Vector3(h* moveSpeed, rb.velocity.y, v* zMoveSpeed);
    }
    void PlayerAnimWalk()
    {
        bool isWalking = h != 0 || v != 0;
       
            playerAnim.Walk(isWalking);
        
    }
   

     void Turning()
    {
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            Vector3 playerToMouse= hit.point-transform.position;
            playerToMouse.y = 0;

            var rotation = Quaternion.LookRotation(playerToMouse);
            rb.MoveRotation(rotation);
        }
    }
}
