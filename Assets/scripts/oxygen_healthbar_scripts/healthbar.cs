using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthbar : MonoBehaviour
{
    // Start is called before the first frame update
   public Slider slider;

   public void SetMaxHealth(int shealth)
   {
    slider.maxValue = shealth;
    slider.value = shealth;
   }

   public void SetHealth(int shealth)
   {
    slider.value = shealth;
   }
}
