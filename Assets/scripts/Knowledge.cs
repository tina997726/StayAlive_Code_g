using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knowledge : MonoBehaviour
{
    public Image infotemp;
    //public Button moretemp;
    public KeyCode key;
    static public Image info;
    //static public Button more;
    static public List<Sprite> knpic = new List<Sprite>();
    public List<Sprite> temp = new List<Sprite>();
    static int rd;
    //static int coun;
    // Start is called before the first frame update
    void Start()
    {
        knpic = temp;
        info = infotemp;
        //more = moretemp;
        ChangeImage();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            ChangeImage();
        }
    }
    static public void ChangeImage()
    {
        rd = Random.Range(0, knpic.Count);
        info.sprite = knpic[rd];
        //more.enabled = true;
        Debug.Log("You Clicked");

    }
}
