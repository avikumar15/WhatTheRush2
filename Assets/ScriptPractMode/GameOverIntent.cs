﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverIntent : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		if(Input.GetKey(KeyCode.Space))
		{
			LapComplete.lap = 0;
			SceneManager.LoadScene("StartMenu");
		}
    }
}
