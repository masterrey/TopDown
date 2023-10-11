using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : TopCharacter
{
    

    protected override void MyInput()
    {
        
        base.move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }


}
