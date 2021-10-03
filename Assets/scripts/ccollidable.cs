using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccollidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D [] hits = new Collider2D[10];
    // collect things that player hit in the frame

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        // collision work
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;
            }

            //Debug.Log(hits[i].name);
            Oncollide(hits[i]);
            //the array is not cleaned up . so we do it ourself
            hits[i] = null;

        }
    }
    protected virtual void Oncollide(Collider2D coll)
    {
        //Debug.Log(coll.name);
        //Debug.Log(hits[i].name);
        if(this.tag == "robot_0"){
            //say something
        }

    }
}
