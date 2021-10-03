using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkbutton_table : MonoBehaviour
{
    public GameObject Button;
    public GameObject talkUI;
    public KeyCode key;
    private int a = 0;
    public KeyCode key2;
    public Canvas CanvasGroup1;
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggerenter");
        Button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("triggerexit");
        Button.SetActive(false);
    }

    private void Update()
    {
        //KeyCode.R
        if (Input.GetKeyDown(key))
        {
            if (a == 0){ 
            if (talkUI.activeSelf == false)
            {
                talkUI.SetActive(true);
            }
            else
            {
                talkUI.SetActive(false);
            }
            }
            else
            {
                talkUI.SetActive(true);
                CanvasGroup1.GetComponent<CanvasGroup>().alpha = 0;
                CanvasGroup1.GetComponent<CanvasGroup>().interactable = false;
                CanvasGroup1.GetComponent<CanvasGroup>().blocksRaycasts = false;
                talkUI.SetActive(false);
                a = 0;
                Gamemanager.instance.SaveState();
            }
        }
        //KeyCode.R
        if (Input.GetKeyDown(key2))
        {
            a++;
            Debug.Log("got");
            CanvasGroup1.GetComponent<CanvasGroup>().alpha = 1;
            CanvasGroup1.GetComponent<CanvasGroup>().interactable = true;
            CanvasGroup1.GetComponent<CanvasGroup>().blocksRaycasts = true;
            talkUI.SetActive(false);
            Gamemanager.instance.SaveState();
        }



    }




}
