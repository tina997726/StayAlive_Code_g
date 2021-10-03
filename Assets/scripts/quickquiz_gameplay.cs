using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quickquiz_gameplay : MonoBehaviour
{
    public Dictionary<int, List<string>> question = new Dictionary<int, List<string>>();
    Dictionary<int, int> PickenAndAnswer = new Dictionary<int, int>(); //key=which in question, value=answer(0-3)

    public Text Question;
    public Text Score;
    public Button Quit;
    public Button[] Option = new Button[4];
    public Text[] Option_Text = new Text[4];

    public GameObject Message;
    public Text Message_Text;

    public Text day;


    int nowCorrect = 0; //range: 0-3
    int number;
    int score;
    

    // Start is called before the first frame update
    void Start()
    {
        day.text = "Day: " + Gamemanager.instance.days;
        DataInitialize();
        newGame();
    }

    public void newGame()
    {
        PickenAndAnswer = new Dictionary<int, int>();

        number = 0;
        score = 0;
        Score.text = "Score: 0/5";

        Quit.enabled = true;
        for (int i = 0; i < 4; i++)
        {
            Option[i].enabled = true;
        }
        Message.SetActive(false);

        throwQuestion();
    }

    void DataInitialize()
    {
        //convert .csv(.txt) into Array.
        //read binary file.
        TextAsset binAsset = Resources.Load("txt/questionsheet", typeof(TextAsset)) as TextAsset;
        //read every line.
        string[] lineArray = binAsset.text.Split("\r"[0]);
        //add all question into question.
        for (int i = 0; i < lineArray.Length; i++)
        {
            List<string> tempList = new List<string>();
            string[] Array = lineArray[i].Split('|');
            for (int j = 0; j < Array.Length; j++)
            {
                tempList.Add(Array[j]);
            }
            question.Add(i, tempList);
        }
    }

    void throwQuestion() //number=what question is it now
    {
        int whichQuestion; //what question in dictionary
        //pick one which is not in PickenandAnswer
        do
        {
            whichQuestion = Random.Range(1, question.Count);
        } while (PickenAndAnswer.ContainsKey(whichQuestion));

        Question.text = (number + 1) + ". " + question[whichQuestion][0];

        int[] arr = { 1, 2, 3, 4 };
        System.Random random = new System.Random();
        arr = arr.OrderBy(x => random.Next()).ToArray();

        for(int i = 0; i < 4; i++)
        {
            Option_Text[i].text = (i + 1) + ". " + question[whichQuestion][arr[i]];
            if(arr[i] == 1)
            {
                PickenAndAnswer.Add(whichQuestion, i);
                nowCorrect = i;
            }
        }
        
        
    }

    public void answerIsChosen(int which)
    {
        number += 1;
        if(which == nowCorrect) //right answer
        {
            score += 1;
            Score.text = "Score: " + score + "/5";
        }
        else
        {

        }

        if(number >= 5) //jump result message
        {
            Quit.enabled = false;
            for (int i = 0; i < 4; i++)
            {
                Option[i].enabled = false;
            }

            Message.SetActive(true);
            Gamemanager.instance.days += 1;
            Gamemanager.instance.SaveState();
            day.text = "Day: " + Gamemanager.instance.days;
            if (score >= 3) //win
            {
                Message_Text.text = "Your score: " + score + "/5\n" + "You win! A day just passed. ";
            }
            else //lose
            {
                Message_Text.text = "Your score: " + score + "/5\n" + "You lose! A day just passed. ";
            }
        }
        else
        {
            throwQuestion();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.instance.days >= 80)
        {
            SceneManager.LoadScene("mainn");
        }
    }
}
