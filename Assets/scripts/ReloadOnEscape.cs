﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnEscape : MonoBehaviour
{
   
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

   
 
}
