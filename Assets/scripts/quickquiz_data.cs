using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickquiz_data : MonoBehaviour
{
    public static Dictionary<int, List<string>> question = new Dictionary<int, List<string>>();


    // Start is called before the first frame update
    void Start()
    {
        //convert .csv(.txt) into Array.
        //read binary file.
        TextAsset binAsset = Resources.Load("txt/questionsheet", typeof(TextAsset)) as TextAsset;
        //read every line.
        string[] lineArray = binAsset.text.Split("\r"[0]);
        //add all question into question.
        List<string> tempList = new List<string>();
        for(int i = 0; i < lineArray.Length; i++)
        {
            string[] Array = lineArray[i].Split(',');
            for(int j = 0; j < Array.Length; j++)
            {
                tempList.Add(Array[j]);
            }
            question.Add(i, tempList);
            tempList.Clear();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
