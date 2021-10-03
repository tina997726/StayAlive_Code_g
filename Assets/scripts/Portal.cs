using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : ccollidable
{
    //public string[] sceneNames;

    protected override void Oncollide(Collider2D coll)
    {
        if (coll.name == "player_0")
        {
           
            //teleport the player
            //string sceneName = sceneNames[Random.Range(0,sceneNames.Length)];
            //Gamemanager.prescene = "main";
            Gamemanager.instance.SaveState();
            SceneManager.LoadScene("door_space");

        }
    }
}
