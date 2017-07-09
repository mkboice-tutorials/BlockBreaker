﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    public static MusicPlayer instance = null;

    // Use this for initialization
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            print("Duplicate music player self destructing");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            print("Creating music player");
        }
            
    }
	
    // Update is called once per frame
    void Update()
    {
		
    }
}
