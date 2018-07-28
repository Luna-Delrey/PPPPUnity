﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SpriteLoader : MonoBehaviour {

    public bool root_folder_exists = false;
    public int sub_characters_found = 0;

	// Use this for initialization
	void Start () {

        string appPath = Application.dataPath + "/charactes";
        if (!Directory.Exists(appPath))
        {
            
            var folder = Directory.CreateDirectory(appPath);
        }
        else
        {
            root_folder_exists = true;
        }
        string[] charactersAvailable = Directory.GetDirectories(appPath);
        sub_characters_found = charactersAvailable.Length;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}