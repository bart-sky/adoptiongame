using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideCheck : MonoBehaviour
{
    private Cat cat;

    private void Start()
    {
        cat = FindObjectOfType<Cat>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tree"))
        {
            cat.SwitchState(Cat.CatState.Climbing);
        }
    }
   
    private void OnTriggerExit2D(Collider2D other)
    {  
        if (other.CompareTag("Tree") && cat.currentCatState != Cat.CatState.Walking)
        {
            cat.SwitchState(Cat.CatState.Jumping);;
        }
    }
}
