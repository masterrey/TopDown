using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : TopCharacter
{
    [SerializeField]
    string leveltoload;

    protected override void MyInput()
    {
        ChangeTimeLevel();
        base.move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void ChangeTimeLevel()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene(leveltoload);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            PlayerPrefs.DeleteAll();
        }
    }


}
