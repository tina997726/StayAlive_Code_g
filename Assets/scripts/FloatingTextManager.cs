using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextManager : MonoBehaviour
{
    public GameObject textcontainer;
    public GameObject textprefab;

    private List<Floatingtext> floatingTexts = new List<Floatingtext>();

    private void Update()
    {
        foreach (Floatingtext txt in floatingTexts)
        {
            txt.UpdateFloatingText();
        }
    }
    
    public void Show(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        Floatingtext floatingText = GetFloatingtext();

        floatingText.txt.text = msg;
        floatingText.txt.fontSize = fontSize;
        floatingText.txt.color = color;
        floatingText.go.transform.position = Camera.main.WorldToScreenPoint(position);
        //transfer world space to screen space so we can use it in the UI
        floatingText.motion = motion;
        floatingText.duration = duration;


        floatingText.Show();
    }
    
   

    private Floatingtext GetFloatingtext()
    {
        Floatingtext txt = floatingTexts.Find(t => !t.active);

        if (txt == null)
        {
            txt = new Floatingtext();
            txt.go = Instantiate(textprefab);
            txt.go.transform.SetParent(textcontainer.transform);
            txt.txt = txt.go.GetComponent<Text>();

            floatingTexts.Add(txt);
        }
        return txt;
    }
}
