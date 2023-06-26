using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTextGenerator : MonoBehaviour
{

    [SerializeField][Tooltip("TMP Text Object we are changing.")] private TMP_Text textUIObject;

    [SerializeField][Tooltip("List of strings to pull from when we click the button")] 
    private List<string> randomWords = new List<string>();

    public void RandomSelectionFromStringList()
    {
        textUIObject.text = randomWords[Random.Range(0, randomWords.Count)];

    }

}
