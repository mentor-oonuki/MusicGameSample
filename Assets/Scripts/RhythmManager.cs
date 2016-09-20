using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class RhythmManager : SingletonMonoBehaviour<RhythmManager>
{
    private List<RhythmData> RhythmList;
    public bool isPlaying { get; private set; }

    [SerializeField]
    private string Filename;

    public enum EffectType
    {
        Non = 0,
        Movie = 1,
        Explosion = 2,
        Noise = 3
    }

    private class RhythmData
    {
        public float timer { get; set; }
        public EffectType effectType { get; set; }
    }

    private void Start()
    {
        this.RhythmList = new List<RhythmData>();
        this.RhythmList.Clear();
        isPlaying = false;
    }

    public void Play()
    {
        isPlaying = true;
    }

    public void Stop()
    {
        isPlaying = false;
        Save();
    }

    public void SetData(float time, EffectType type)
    {
        RhythmData rhythmData = new RhythmData();
        rhythmData.timer = time;
        rhythmData.effectType = type;
        RhythmList.Add(rhythmData);
        Debug.Log(time + ":" + type);
    }

    public void Save()
    {
        StreamWriter sw;
        FileInfo fi;
        fi = new FileInfo(Filename);
        sw = fi.AppendText();
        foreach(RhythmData data in RhythmList)
        {
            sw.WriteLine(data.timer + "," + data.effectType);
        }
        sw.Flush();
        sw.Close();
    }

}

