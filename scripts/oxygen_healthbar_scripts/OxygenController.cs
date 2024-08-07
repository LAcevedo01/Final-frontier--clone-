using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenController : MonoBehaviour
{
    public Slider oxygenSlider;
    public float startingOxygen = 100f;
    public float currentOxygen;
    public float oxygenDecreaseRate = 0.1f;
    public float timeBeforeHealthLoss = 5f;
    public int healthLossAmount = 1;
    private float timer = 0f;

    private bool isRefilling = false;
    private float refillDelay = 2.0f;

    void Start()
    {
        currentOxygen = startingOxygen;
        oxygenSlider.maxValue = startingOxygen;
        oxygenSlider.value = currentOxygen;

    }

    void Update()
    {
        if (currentOxygen > 0)
        {
            currentOxygen -= oxygenDecreaseRate * Time.deltaTime;
            oxygenSlider.value = currentOxygen;
        }
        else 
        {
            timer += Time.deltaTime;
            if (timer >= timeBeforeHealthLoss)
            {
                timer = 0f;
                // Reduce player health by 1
                playerHealth PlayerHealth = FindObjectOfType<playerHealth>();
                if (PlayerHealth != null)
                {
                    PlayerHealth.Recievedamage(healthLossAmount);
                }


            }
        }

            if (Input.GetKeyDown(KeyCode.Tab) && !isRefilling)
            {
                StartCoroutine(RefillOxygen());
            }
        if (currentOxygen > 100) { currentOxygen = 100; }
    }

 IEnumerator RefillOxygen()
        {
            
            isRefilling = true;
            currentOxygen += 25;
            Debug.Log("Oxygen refilling");
            yield return new WaitForSeconds(refillDelay);
            isRefilling = false;
        }





}

