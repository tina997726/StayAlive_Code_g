using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    private void Awake()
    {
        if (days >= 80)
        {            
                Gamemanager.instance.SaveState();
                SceneManager.LoadScene("mars_in");

            
        }
        if (Gamemanager.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        Gamemanager.instance.SaveState();

        DontDestroyOnLoad(gameObject);
    }
    public void counter()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name=="mainn")
        {

        }
    }
    //Ressources
    public List<Sprite> playerSprites;
    public List<int> weaponPrices; //price for upgrade
    public List<int> xpTable;      //need how much xp to obtain the next level

    //logic(reference)
    public main player;
    //public weapon weapon...
    public FloatingTextManager floatingTextManager;
    //logic
    public string gender;
    public int age;
    public int dollars; //錢
    public int bodywater;//身體含水程度
    public int bodyfood;//滿腹程度
    public int happiness;//快樂程度
    public int intelligence;//智力
    public int nutrition;//營養
    public int muscle;//肌肉
    public double intracranial_pressure;//顱內壓
    public int days;
    //public static float player_position1x;
   // public static float player_position1y;
   // public static float player_position1z;
   // public static string prescene;
    //floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg,fontSize,color,position,motion,duration);
        
    }   

    //save state
    /*
     * INT preferedskin (gender)
     * INT ages
     * INT dollars
     * INT bodywater
     * INT bodyfood
     * INT happiness
     * INT intelligence
     * INT nutrition
     * INT muscle
     * INT intracranial_pressure
     * INT days
     * 
     */
    public void SaveState()
    {
        Debug.Log("SaveState");
        string s = "";
        s += gender + "|";
        s += age.ToString() + "|";
        s += dollars.ToString() + "|";
        s += bodywater.ToString() + "|";
        s += bodyfood.ToString() + "|";
        s += happiness.ToString() + "|";
        s += intelligence.ToString() + "|";
        s += nutrition.ToString() + "|";
        s += muscle.ToString() + "|";
        s += intracranial_pressure.ToString() + "|";
        s += days.ToString() ;
        //s += player_position1x.ToString ()+ "|";
        //s += player_position1y.ToString() + "|";
        //s += player_position1z.ToString() + "|";
       // s += prescene;

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene sm, LoadSceneMode mode)
    {
       
        if ( ! PlayerPrefs.HasKey("SaveState"))
        {
            return;
        }
        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        //change player info
        gender = data[0];
        age = int.Parse(data[1]);
        dollars = int.Parse(data[2]);
        bodywater = int.Parse(data[3]);
        bodyfood = int.Parse(data[4]);
        happiness = int.Parse(data[5]);
        intelligence = int.Parse(data[6]);
        nutrition = int.Parse(data[7]);
        muscle = int.Parse(data[8]);
        intracranial_pressure = double.Parse(data[9]);
        days = int.Parse(data[10]);
       // player_position1x = float.Parse(data[11]);
       // player_position1y = float.Parse(data[12]);
       // player_position1z = float.Parse(data[13]);
       // prescene=data[14];
        Debug.Log("LoadState");
    }
}
