using Assets.scripts.Objects;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SpriteLoader : MonoBehaviour {

    public bool root_folder_exists = false;
    public string[] sub_characters_found;
    public string[] sub_zips_found;
    [SerializeField]
    private VariableMaster VarMaster; 

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
        //get all uncompressed folders (dirty character mods)
        sub_characters_found = Directory.GetDirectories(appPath);
        //get all compressed character mods (clean mods)
        List<string> files = new List<string>(Directory.GetFiles(appPath, "*.*"));
        files = files.FindAll(s => s.EndsWith(".zip") || s.EndsWith(".Px4U"));
        sub_zips_found = files.ToArray();

        foreach (string filepath in sub_characters_found)
        {
            //check if an icon exists
            string[] getIcon = Directory.GetFiles(filepath + "/icon/", "*.png");
            if (getIcon.Length > 0)
            {
                //load the icon as a sprite
                Sprite Icon = new Sprite();
                Texture2D SpriteTexture = LoadTexture(getIcon[0]);
                Icon = Sprite.Create(SpriteTexture, new Rect(0, 0, SpriteTexture.width, SpriteTexture.height), new Vector2(0, 0), 100);

                //add the character with the new sprite to the game
                Character character = new Character();
                character.Icon = Icon;

                VarMaster.characters.Add(character);
            }
        }

	}

    public Texture2D LoadTexture(string FilePath)
    {

        // Load a PNG or JPG file from disk to a Texture2D
        // Returns null if load fails

        Texture2D Tex2D;
        byte[] FileData;

        if (File.Exists(FilePath))
        {
            FileData = File.ReadAllBytes(FilePath);
            Tex2D = new Texture2D(2, 2);           // Create new "empty" texture
            if (Tex2D.LoadImage(FileData))           // Load the imagedata into the texture (size is set automatically)
                return Tex2D;                 // If data = readable -> return texture
        }
        return null;                     // Return null if load failed
    }

    // Update is called once per frame
    void Update () {
		
	}
}
