using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class talkbutton3 : MonoBehaviour
{
    //public string end;
    public KeyCode key2;
    public KeyCode key3;
    public GameObject talkUI;
    public Canvas CanvasGroup1;
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
            CanvasGroup1.GetComponent<CanvasGroup>().alpha = 1;
            CanvasGroup1.GetComponent<CanvasGroup>().interactable = true;
            CanvasGroup1.GetComponent<CanvasGroup>().blocksRaycasts = true;
            talkUI.SetActive(false);
            Gamemanager.instance.SaveState();
         }
        if (Input.GetKeyDown(key3))
        {
            CanvasGroup1.GetComponent<CanvasGroup>().alpha = 0;
            CanvasGroup1.GetComponent<CanvasGroup>().interactable = false;
            CanvasGroup1.GetComponent<CanvasGroup>().blocksRaycasts = false;
            Gamemanager.instance.SaveState();
        }

    }
}
