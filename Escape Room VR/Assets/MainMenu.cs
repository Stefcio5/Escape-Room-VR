﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     public void PlayGame()
        {
            Debug.Log("play");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // ustawic na scene która ma byc odpalona po przycisku graj, moze byc po nazwie a aktualny kod ustawia po prostu na kolejna
        }
    
        public void QuitGame()
        {
            Debug.Log("quit");
            Application.Quit();
        }
}
