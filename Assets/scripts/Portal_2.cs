using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_2 : ccollidable
{
    //public string[] sceneNames;

    protected override void Oncollide(Collider2D coll)
    {
        if (coll.name == "player_0")
        {
           // Gamemanager.prescene = "mars_in";
            Gamemanager.instance.SaveState();
            //teleport the player
            //string sceneName = sceneNames[Random.Range(0,sceneNames.Length)];
            SceneManager.LoadScene("mars_out");

        }
    }
}
