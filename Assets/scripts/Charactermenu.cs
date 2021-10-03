using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charactermenu : MonoBehaviour
{
    public Text moneytext, tbwtext, satietytext, happytext,intelletext,nutritext,muscletext,braintext;
    //logic
    private int currentcharacterselection = 0;
    public Image characterSelectionSprite;
    //public Image bags;
   // public RectTransform days;

    public void OnArrowClick(bool right)
    {
        if (right)
        {
            currentcharacterselection++;

            //if went to far away
            if (currentcharacterselection == Gamemanager.instance.playerSprites.Count)
            {
                currentcharacterselection = 0;
            }
            OnSelectionChanged();
        }
        else
        {
            currentcharacterselection--;

            //if went to far away
            if (currentcharacterselection <0)
            {
                currentcharacterselection =Gamemanager.instance.playerSprites.Count-1;
            }
            OnSelectionChanged();

        }
    }
    private void OnSelectionChanged()
    {
        characterSelectionSprite.sprite = Gamemanager.instance.playerSprites[currentcharacterselection];
    }

    public void OnBagClick()
    {

    }
    //update the character info
    public void Updatemenu()
    {
        moneytext.text = Gamemanager.instance.dollars.ToString();
        tbwtext.text = Gamemanager.instance.bodywater.ToString() + "/ 100 ";
        satietytext.text = Gamemanager.instance.bodyfood.ToString() + "/ 100 ";
        happytext.text = Gamemanager.instance.happiness.ToString() + "/ 100 ";
        intelletext.text = Gamemanager.instance.intelligence.ToString() + "/ 100 ";
        nutritext.text = Gamemanager.instance.nutrition.ToString() + "/ 100 ";
        muscletext.text = Gamemanager.instance.muscle.ToString() + "/ 100 ";
        braintext.text = Gamemanager.instance.intracranial_pressure.ToString();
    }

}
