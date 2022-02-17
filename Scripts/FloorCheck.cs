using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour
{
   private Cat cat;

   private void Start()
   {
      cat = FindObjectOfType<Cat>();
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Floor") || other.CompareTag("Tree"))
      {
         cat.SwitchState(Cat.CatState.Walking);
      }
   }
   
   private void OnTriggerExit2D(Collider2D other)
   {  
      if (other.CompareTag("Floor") && cat.GetState() != Cat.CatState.Climbing)
      {
         cat.SwitchState(Cat.CatState.Jumping);
      }
      
      if (other.CompareTag("Tree"))
      {
         cat.SwitchState(Cat.CatState.Jumping);
      }
   }
}
