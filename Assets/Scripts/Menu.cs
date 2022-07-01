// Script pour changer de scène // 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Here we are checking if the mouse button is clicked and if it is, we load our gamescene
        if (Input.GetMouseButtonUp(0))
            SceneManager.LoadScene("GameScene");
        
    }
}
