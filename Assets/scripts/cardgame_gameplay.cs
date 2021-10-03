using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cardgame_gameplay : MonoBehaviour
{
    int time = 0;

    int MyCard_Value;

    public Button MyCard;
    public Button NPCCard;
    public Button Big;
    public Button Small;
    public Button Quit;

    Sprite[] Cards;
    
    public GameObject Message;
    public Text Message_Text;

    public Text day;

    // Start is called before the first frame update
    void Start()
    {
        day.text = "Day: " + Gamemanager.instance.days;
        Cards = Resources.LoadAll<Sprite>("Cards");
        MyCard.enabled = false;
        NPCCard.enabled = false;
        PickBigOrSmall();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.instance.days >= 80)
        {
            SceneManager.LoadScene("mainn");
        }
    }

    //Pick paper or scissors or stone
    public void PickBigOrSmall()
    {
        NPCCard.image.sprite = Cards[0];
        MyCard_Value = Random.Range(1, 53);
        //Set MyCard.image.sprite
        MyCard.image.sprite = Cards[MyCard_Value];
        //
        Big.enabled = true;
        Small.enabled = true;
        Quit.enabled = true;
        Message.SetActive(false);
    }

    public void PickComplete(int input) //big=1, small=2
    {
        time += 1;

        Big.enabled = false;
        Small.enabled = false;
        Quit.enabled = false;

        int NPCCard_Value;
        do
        {
            NPCCard_Value = Random.Range(1, 53);
        } while (MyCard_Value == NPCCard_Value);
        //Set NPCCard.image.sprite
        NPCCard.image.sprite = Cards[NPCCard_Value];
        //

        Message.SetActive(true);
        if ((MyCard_Value > NPCCard_Value && input == 1)
            || (MyCard_Value < NPCCard_Value && input == 2)) //win
        {
            Message_Text.text = "You win!";
        }
        else //lose
        {
            Message_Text.text = "You lose!";
        }
        if (5 - time > 0)
        {
            Message_Text.text += (5 - time) + " times left.";
            Message.SetActive(true);
        }
        else
        {
            Message_Text.text += "A day just passed. ";
            Gamemanager.instance.days += 1;
            Gamemanager.instance.SaveState();
            day.text = "Day: " + Gamemanager.instance.days;
            time = 0;

            Message.SetActive(true);
        }
    }
}
