﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("start");
        }
    }

}
