using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int points = 25;
    [SerializeField] AudioClip soundSFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetType() != typeof(CapsuleCollider2D))
        {
            return;
        }

        FindObjectOfType<GameSession>().AddToScore(points);
        AudioSource.PlayClipAtPoint(soundSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
