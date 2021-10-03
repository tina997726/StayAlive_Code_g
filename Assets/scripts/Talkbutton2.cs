using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Talkbutton2 : MonoBehaviour
{
    public string end;
    public KeyCode key2;
    private Vector3 post;
    private string poststring;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggerenter");
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("triggerexit");
       
    }

    private void Update()
    {
        //KeyCode.R
        if (Input.GetKeyDown(key2))
        {
            /*post = this.GetComponent<Transform>().position;
            // this.GetComponent<Transform>().position= new Vector3 
            //   = Gamemanager.player_position1x;
            poststring = post.ToString();
            poststring = poststring.Replace("(", "").Replace(")", "");
            string[] sstring = poststring.Split(',');
            Gamemanager.player_position1x = float.Parse(sstring[0]);
            Gamemanager.player_position1y = float.Parse(sstring[1]);
            Gamemanager.player_position1z = float.Parse(sstring[0]);
            Gamemanager.prescene = "main";*/
            Gamemanager.instance.SaveState();
            SceneManager.LoadScene(end);
           
        }

    }
}
