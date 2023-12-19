using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private Text bananasText;
    [SerializeField] private Text pineapplesText;
    public static int bananas = 0;
    public static int pineapples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            Destroy(collision.gameObject);
            bananas++;
            bananasText.text = ""+bananas + "/56";
            collectSoundEffect.Play();
        }
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            Destroy(collision.gameObject);
            pineapples++;
            pineapplesText.text = ""+pineapples+ "/3";
            collectSoundEffect.Play();
        }
    }
    
}
