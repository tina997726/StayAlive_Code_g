using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class paperscissorsstone_gameplay : MonoBehaviour
{
    int time = 0;
    public Button Paper;
    public Button Scissors;
    public Button Stone;
    public Button NPC;
    public Button Quit;
    public GameObject Message;
    public Text Message_Text;

    public Sprite Paper_Sprite;
    public Sprite Scissors_Sprite;
    public Sprite Stone_Sprite;

    public Text day;


    // Start is called before the first frame update
    void Start()
    {
        day.text = "Day: " + Gamemanager.instance.days;
        NPC.enabled = false;
        PickWhichToUse();
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
    public void PickWhichToUse()
    {
        Paper.enabled = true;
        Scissors.enabled = true;
        Stone.enabled = true;
        Quit.enabled = true;
        Message.SetActive(false);
    }

    public void PickComplete(int input) //paper=1, scissors=2, stone=3
    {
        time += 1;
        Paper.enabled = false;
        Scissors.enabled = false;
        Stone.enabled = false;
        Quit.enabled = false;
        int NPCPick = Random.Range(1, 4);
        switch (NPCPick)
        {
            case 1:
                NPC.image.sprite = Paper_Sprite;
                break;
            case 2:
                NPC.image.sprite = Scissors_Sprite;
                break;
            case 3:
                NPC.image.sprite = Stone_Sprite;
                break;
        }
        
        if (input == NPCPick) //draw
        {
            Message_Text.text = "Draw! ";
        }
        else if(input > NPCPick || (input == 1 && NPCPick == 3)) //win
        {
            Message_Text.text = "You Win! ";
        }
        else //lose
        {
            Message_Text.text = "You lose! ";
        }
        if(5 - time > 0)
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
