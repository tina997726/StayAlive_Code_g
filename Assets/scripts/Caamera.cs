using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caamera : MonoBehaviour
{
    public Transform lookAt;//the player
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        //this is to check if we are inside the bounds on the x axis
        float deltaX = lookAt.position.x - transform.position.x;//trans=middle point of the camera
        if (deltaX > boundX || deltaX < -boundX)
        {
            if (transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }
        //this is to check if we are inside the bounds on the y axis
        float deltaY = lookAt.position.y - transform.position.y;//trans=middle point of the camera
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
