using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private Rigidbody2D rigidcat;
	private void Awake() 
	{
		rigidcat = GetComponent<Rigidbody2D>();
	}
	
    public float jump = 5; // the jump force value
    public float move = 100; // move speed (amplitude) for addforce

    public Sprite catpic; // these two sprites will be given to the sprite renderer's displayed sprite depending on the walking direction
    public Sprite catpic2;


    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero; // we are setting the velocity to 0,0,0, before pushing again the player (using addforce)
                                                             // to make sure the Cat stops exactly when we release the button

        if (Input.GetKey(KeyCode.LeftArrow)) // detecting left arrow button
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * move, ForceMode2D.Force); //adding the force (left) with an amplitude of move (the variable move)
            GetComponent<SpriteRenderer>().sprite = catpic; // giving the sprite renderer's sprite the left sprite picture
            GetComponent<SpriteRenderer>().flipX = false; // setting the sprite renderer's flipX value to false to make sure the Cat's sprite is facing left

        }
        if (Input.GetKey(KeyCode.RightArrow))//detecting right arrow button
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * move, ForceMode2D.Force); // adding the force (right) with an amplitude of move (the variable move)
            GetComponent<SpriteRenderer>().sprite = catpic2; //  giving the sprite renderer's sprite the right sprite picture
            GetComponent<SpriteRenderer>().flipX=true; // / setting the sprite renderer's flipX value to true to make sure the Cat's sprite is facing right


        }
        if (Input.GetKey(KeyCode.UpArrow)) // detecting up arrow button
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * move, ForceMode2D.Force); 
            GetComponent<SpriteRenderer>().sprite = catpic; // giving the sprite renderer's sprite the up sprite picture
            GetComponent<SpriteRenderer>().flipX = false; 

        }
  		if (Input.GetKey(KeyCode.Space)) // detecting spacebar button
        {
            rigidcat.velocity = new Vector2(rigidcat.velocity.x, jump);

        }
  
    }
}
