using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Callimage : MonoBehaviour
{
    // Start is called before the first frame update
    public Button more;
    //Image image;

    void Start()
    {
       more.onClick.AddListener(delegate () { Knowledge.ChangeImage(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
