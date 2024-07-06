using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject test;
    public void CallVisible(string input)
    {
        text.text = input;
        StartCoroutine(Visible());
    }
    IEnumerator Visible()
    {
        test.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        test.SetActive(false);
    }
}
