using UnityEngine;
using System.Collections;

public class ScreenManager : SingletonMonoBehaviour<ScreenManager> {

    [SerializeField]
    private GameObject Target;

    public void SetColor(Color color)
    {
        Target.GetComponent<Renderer>().materials[0].color = color;
    }
}
