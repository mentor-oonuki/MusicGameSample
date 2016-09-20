using UnityEngine;
using System.Collections;

public class KeyboardManager : SingletonMonoBehaviour<KeyboardManager>
{
	private void Start () {
	
	}
	
	public CreateManager.Key GetKey () {

        CreateManager.Key value = CreateManager.Key.Non;

        if (Input.GetKeyUp(KeyCode.Return))
        {
            value = CreateManager.Key.Play;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            value = CreateManager.Key.Stop;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            value = CreateManager.Key.Key1;
        } 
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            value = CreateManager.Key.Key2;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            value = CreateManager.Key.Key3;
        }

        return value;
    }
}
