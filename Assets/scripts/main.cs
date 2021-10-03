using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main : MonoBehaviour
{
    //manual collision detection
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    private Vector3 place;

    //things happen when the game start
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        /*if (Gamemanager.prescene == "tinygames")
        {
            place = new Vector3(Gamemanager.player_position1x, Gamemanager.player_position1y, Gamemanager.player_position1z);
            this.GetComponent<Transform>().position  =place;
           
        }*/
    }

    //things happening every single frame 
    private void FixedUpdate()
    {
        //reset movedelta
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //moveDelta = Vector3.zero;
        moveDelta = new Vector3(x, y, 0);
        //check in console
        // Debug.Log(x);
        // Debug.Log(y);

        //swap sprite direction, whether you are going right or left

        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //make sure we can move in this direction ,by casting a box there first,if the box return null ,we are free to move
        //in y axis
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("actors", "blocking"));
        if (hit.collider == null)
        {
            // make this thing move!
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }
        //in x axis
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("actors", "blocking"));
        if (hit.collider == null)
        {
            // make this thing move!
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }
    }
}
