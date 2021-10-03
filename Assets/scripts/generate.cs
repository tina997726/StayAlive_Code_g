using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    float times = 2f;

    public GameObject item;
    GameObject target = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        times -= Time.deltaTime;
        if(times < 0)
        {
            //Generate an item
            GameObject obj = (GameObject)Instantiate(item);

            obj.SetActive(true);
            float rdx = Random.Range(-6.5f, 7.4f);
            float rdy = Random.Range(-3.4f, 4.1f);
            obj.transform.position = new Vector3(rdx, rdy, 0);

            times = Random.Range(0, 10);
        }
    }
}
