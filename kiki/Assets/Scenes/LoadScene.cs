﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void loadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Replay()
    {

        SceneManager.LoadScene(0);
    }
}