using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_1 : ccollidable
{
    //public string[] sceneNames;

    protected override void Oncollide(Collider2D coll)
    {
        if (coll.name == "player_0")
        {
            //Gamemanager.prescene = "door_space";
            Gamemanager.instance.SaveState();
            //teleport the player
            //string sceneName = sceneNames[Random.Range(0,sceneNames.Length)];
            SceneManager.LoadScene("mainn");

        }
    }
}
