using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScores : MonoBehaviour
{
    [SerializeField] private Text bananaText;
    [SerializeField] private Text pineappleText;
    [SerializeField] private Button button;


    public void UpdateScores()
    {
        bananaText.text = itemCollector.bananas + "/56";
        pineappleText.text = itemCollector.pineapples + "/3";
        button.gameObject.SetActive(false);
    }
}
