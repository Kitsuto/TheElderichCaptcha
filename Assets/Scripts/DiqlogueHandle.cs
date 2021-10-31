using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiqlogueHandle : MonoBehaviour
{
    public Text textComponent;
     public string text;
     public float timeLapse;
     public string[] sentenceList;
     private int sentenceIdx = 0;

    [SerializeField] private Animator book;

     public GameObject textBox;

     public int integer;

     public Button bouton;

     public Sprite[] portraitList;

     public Image portrait;
 
     void Start()
    {
        StartCoroutine(BuildText(sentenceList[sentenceIdx]));
    }
 
    private IEnumerator BuildTextEnd(string textToWrite)
    {
     text = "";
     textBox.SetActive(true);
     textComponent.text = text;
         integer = 0;
         HideText();
         StopCoroutine(BuildTextEnd(""));
         yield return 0;
    }
    private IEnumerator BuildText(string textToWrite)
    {
        bouton.interactable = false;
     text = textToWrite;
     textBox.SetActive(true);
     for (int integer = 0; integer < text.Length; integer++){
         textComponent.text = string.Concat(textComponent.text, text[integer]);
         //Wait a certain amount of time, then continue with the for loop
         yield return new WaitForSeconds(timeLapse);
     }
     if(integer < text.Length){
         bouton.interactable = true;
         integer = 0;
         StopCoroutine(BuildText(""));

     }
    }
    private void HideText(){
        textBox.SetActive(false);
    }

    #region TextUpdaters
    public void UpdateText()
    {
    integer = 0;
    sentenceIdx++;
    textComponent.text = "";
    switch (sentenceIdx)
        {
        case 1:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildText(sentenceList[sentenceIdx]));
            break;
        case 6:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        case 10:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        case 15:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        case 21:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        case 22:
            book.SetInteger("Page", 1);
            StartCoroutine(BuildText(sentenceList[sentenceIdx]));
            break;
        case 23:
            book.SetInteger("Page", 2);
            StartCoroutine(BuildText(sentenceList[sentenceIdx]));
            break;

        case 24:
                book.SetInteger("Page", 3);
                StartCoroutine(BuildText(sentenceList[sentenceIdx]));
                break;
        case 25:
                book.SetInteger("Page", 4);
                StartCoroutine(BuildText(sentenceList[sentenceIdx]));
                break;
        case 26:
                book.SetInteger("Page", 5);
                StartCoroutine(BuildText(sentenceList[sentenceIdx]));
                break;
        case 27:
                book.SetInteger("Page", 6);
                StartCoroutine(BuildText(sentenceList[sentenceIdx]));
                break;

        case 28:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        case 33:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        default:
            portrait.sprite = portraitList[1];
            StartCoroutine(BuildText(sentenceList[sentenceIdx]));
            break;
        }  
    }

    public void RestartTextAt(int idx)
    {
        sentenceIdx = idx;
        UpdateText();
    }

    #endregion

}
