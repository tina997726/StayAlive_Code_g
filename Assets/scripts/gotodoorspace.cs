using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotodoorspace : MonoBehaviour
{
    float times = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        times -= Time.deltaTime;
        if (times < 0)
        {
            SceneManager.LoadScene("door_space");
        }
    }
}
