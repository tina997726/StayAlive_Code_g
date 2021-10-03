using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textadder : MonoBehaviour
{
    public string txtt;
    public string txtt2;
    public string txtt3;
    public int txtint;
    public int txtint2;
    void Start()
    {
       // txtt = GetComponent<Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
        txtint = Gamemanager.instance.days;
        for (txtint2 = 0; txtint > 7; txtint2++)
        {
            txtint -= 7;
        }
       
        txtt2 = txtint.ToString();
        txtt3 = txtint2.ToString();
        txtt ="Computer:" + "\t\n" + "Week "+ txtt3 + " Day "+txtt2 + "  I¡¦m a computer, but there¡¦s" + "\t\n" + "not much I can do for you." + "\t\n" + "Find robot 0913 for help < 3." + "\t\n" + "Wish you luck!" + "¡@¡@¡@¡@" + "--- press[E] to exit";
        this.gameObject.GetComponent<Text>().text = txtt;

    }
}
