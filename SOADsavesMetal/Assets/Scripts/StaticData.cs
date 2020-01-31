﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticData: MonoBehaviour
{
    static public string playerSelected = "";
    static public int levelSelect = 0;
    static public bool firstLoad = true;
    static public bool[] characterUnlocks = {false, false, false};
    static public bool[] shavoUnlock = {false, false};
    static public bool[] daronUnlock = {false, false};
    static public bool[] serjUnlock = {false, false, false};

    public void setPlayer(string name)
    {
        playerSelected = name;
    }

    public void setLevel(int level)
    {
        levelSelect = level;
    }

    public void printName(string name)
    {
        print(name);
    }

    public void loadLevel() //loads the selected level
    {
        {
            SceneManager.LoadScene(levelSelect);
        }
    }

    public void loadLevel(string sceneName)
    {
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void SaveGame() //saves current static data
    {
        SaveSystem.SaveGame();
    }

    public void LoadGame() //loads saved data onto static data
    {
        SaveData data = SaveSystem.LoadGame();
        firstLoad = data.firstLoad;
        characterUnlocks = data.characterUnlocks;
        shavoUnlock = data.shavoUnlock;
        daronUnlock = data.daronUnlock;
        serjUnlock = data.serjUnlock;
    }

    void Awake()
    {
        GameObject playerObject = GameObject.Find("Player"); //find an obejct in the scene named player
        if(playerObject != null)
        {
            Player playerScript = playerObject.GetComponent<Player>(); //gets Player component
            if(playerScript != null)
            {
                playerScript.currentBandMember = playerSelected; // sets player to selected player
            }
        }
    }
}