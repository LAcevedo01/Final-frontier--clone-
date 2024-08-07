using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public int damage;
    public float delay;
    public playerHealth Phealth;

    private bool canDamage = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && canDamage)
        {
            canDamage = false;
            Phealth.Recievedamage(damage);
            StartCoroutine(ResetCanDamage());
        }
    }

    private IEnumerator ResetCanDamage()
    {
        yield return new WaitForSeconds(delay);
        canDamage = true;
    }
}
