using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] AudioClip[] SFXBook;
    [SerializeField] AudioSource audioSource;

    public void TurnPage()
    {
        audioSource.clip = SFXBook[0];
        audioSource.Play();

    }

    public void OpenBook()
    {
        audioSource.clip = SFXBook[1];
        audioSource.Play();

    }

    public void CloseBook()
    {
        audioSource.clip = SFXBook[2];
        audioSource.Play();

    }

    public void SlideInBook()
    {
        audioSource.clip = SFXBook[3];
        audioSource.Play();
    }

    public void SlideOutBook()
    {
        audioSource.clip = SFXBook[4];
        audioSource.Play();
    }

    public void BookDestroyer()
    {
        Destroy(gameObject);
    }
}
