using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TopCharacter : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites;

    [SerializeField]
    private float speed=1;

    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
    protected Vector2 move;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected abstract void MyInput();
    

   void MySpriteChange()
    {
        if (spriteRenderer != null)
        {
            if (move.x > 0)
            {
            spriteRenderer.sprite = sprites[1];
            spriteRenderer.flipX = true;
        }
        else if (move.x < 0)
            {
            spriteRenderer.sprite = sprites[1];
            spriteRenderer.flipX = false;
            }
        else if (move.y > 0)
            {
            spriteRenderer.sprite = sprites[0];
        }
        else if (move.y < 0)
            {
            spriteRenderer.sprite = sprites[2];
        }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        MyInput();
        MySpriteChange();
      
        
    }
    void FixedUpdate()
    {
        rigidbody2D.velocity = move * Time.fixedDeltaTime * speed;
    }
}
