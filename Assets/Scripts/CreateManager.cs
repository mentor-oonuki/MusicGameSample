using UnityEngine;
using System.Collections;

public class CreateManager : SingletonMonoBehaviour<CreateManager>
{
    private float timer;

    public enum Key
    {
        Non,
        Play,
        Stop,
        Key1,
        Key2,
        Key3
    }

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        Key key = KeyboardManager.Instance.GetKey();
        timer += Time.deltaTime;

        if (key == Key.Play && RhythmManager.Instance.isPlaying == false)
        {
            RhythmManager.Instance.Play();
            MusicManager.Instance.Play();
            timer = 0.0f;
        }

        switch (key)
        {
            case Key.Non:
                ScreenManager.Instance.SetColor(Color.clear);
                break;
            case Key.Play:
                break;
            case Key.Stop:
                RhythmManager.Instance.Stop();
                MusicManager.Instance.Stop();
                ScreenManager.Instance.SetColor(Color.clear);
                break;
            case Key.Key1:
                RhythmManager.Instance.SetData(timer, RhythmManager.EffectType.Movie);
                ScreenManager.Instance.SetColor(Color.red);
                break;
            case Key.Key2:
                RhythmManager.Instance.SetData(timer, RhythmManager.EffectType.Explosion);
                ScreenManager.Instance.SetColor(Color.blue);
                break;
            case Key.Key3:
                RhythmManager.Instance.SetData(timer, RhythmManager.EffectType.Noise);
                ScreenManager.Instance.SetColor(Color.yellow);
                break;
            default:
                break;
        }
    }

}
