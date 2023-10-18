using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remembering : MonoBehaviour
{
    [SerializeField]
    string keyname;
    [SerializeField]
    bool enableRemembering = false;
    private static Dictionary<string, Vector3> positions = new Dictionary<string, Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        if (enableRemembering)
        {
            keyname = gameObject.name;
            if (keyname.Length > 0)
            {
                try
                {
                    // if (PlayerPrefs.HasKey(keyname))
                    if (positions[keyname] != null)
                    {
                        //transform.position = PlayerPrefsX.GetVector3(keyname);
                        transform.position = positions[keyname];
                    }
                }
                catch
                {
                    Debug.Log("No key found");
                }

                InvokeRepeating("InaSecond", 0, 1);
            }
        }
    }

   void InaSecond()
    {
        positions[keyname] = transform.position;
       // PlayerPrefsX.SetVector3(keyname, transform.position);
       // PlayerPrefs.Save();
    }
}
