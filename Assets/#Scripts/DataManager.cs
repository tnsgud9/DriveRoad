using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class DataManager : MonoBehaviour 
{

    Data dataSet = new Data();
    void Awake()
    {
        Load();
    }

    void Load()
    {
       
    }

    void Save()
    {
        PlayerPrefs.SetInt("highScore", dataSet.highScore);
        PlayerPrefs.SetInt("score", dataSet.score);

        PlayerPrefs.SetInt("volume", dataSet.volume);
        PlayerPrefs.SetString("mute", dataSet.mute.ToString());
        // 로드시 
        //string value = Playerprefs.GetString("저장했던이름", "false");
        //bool isActive = System.Convert.ToBoolean(value);

        PlayerPrefs.SetInt("skinNum", dataSet.skinNum);
    }

    void Save(string saveType,int data)
    {
        object value = new object();
        value=value.GetType().GetField(saveType).GetValue(value);
        //Debug.Log(value);
        //PlayerPrefs.SetInt((string)value, data);
    }


}

class Data : DataManager
{

    //score
    public int highScore;
    public int score;
    //setting
    public int volume = 50;
    public bool mute = false;
    //userData
    public int skinNum = 0;
}

