using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CatActions : MonoBehaviour
{
    private Cat cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GetComponent<Cat>();
    }

    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Key")){
            cat.hasKey = true;
            Destroy(col.gameObject);
            FindObjectOfType<SoundManager>().PlaySoundOneShot("key");

        }

        if(col.gameObject.CompareTag("Exit")){
            if(cat.hasKey){
                FindObjectOfType<LevelManager>().NextLevel();
            }
            else
            {
                FindObjectOfType<MenuManager>().ShowNotification("The door is locked!");
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            if(!cat.isGrounded) cat.SwitchState(Cat.CatState.Climbing);
        }
    }
    /*
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Tree") )
        {

                print("CatActions collisionExit to tree - switching to jumping");

                cat.SwitchState(Cat.CatState.Walking);
            

        }
    }*/ 
}
