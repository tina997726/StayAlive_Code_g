using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class buttontext_table : MonoBehaviour
{
    //public string end;
    public KeyCode key2;
    public Canvas CanvasGroup1;
    public GameObject talkUI;
 
    //private Vector3 post;
    //private string poststring;
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
            Debug.Log("got");
            CanvasGroup1.GetComponent<CanvasGroup>().alpha = 1;
            CanvasGroup1.GetComponent<CanvasGroup>().interactable = true;
            CanvasGroup1.GetComponent<CanvasGroup>().blocksRaycasts = true;
            talkUI.SetActive(false);
            Gamemanager.instance.SaveState();
        }


    }
}
