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

     public GameObject textBox;

     public int integer;
 
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
     text = textToWrite;
     textBox.SetActive(true);
     for (int integer = 0; integer < text.Length; integer++){
         textComponent.text = string.Concat(textComponent.text, text[integer]);
         //Wait a certain amount of time, then continue with the for loop
         yield return new WaitForSeconds(timeLapse);
     }
     if(integer < text.Length){
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
        case 6:
            StartCoroutine(BuildTextEnd(sentenceList[sentenceIdx]));
            break;
        default:
            StartCoroutine(BuildText(sentenceList[sentenceIdx]));
            break;
        }  
    }

    #endregion

}
