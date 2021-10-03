using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class portal_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        //Gamemanager.prescene = "tinygames";
        Gamemanager.instance.SaveState();
        SceneManager.LoadScene("mainn");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
