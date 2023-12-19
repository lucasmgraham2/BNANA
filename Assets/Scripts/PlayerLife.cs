using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private AudioSource deathSoundEffect;
    private Animator anim;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Trap"))
         {
            Die();
         }
    }

    private void Die()
    {
        itemCollector.bananas = 0;
        itemCollector.pineapples = 0;
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
        deathSoundEffect.Play();
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
