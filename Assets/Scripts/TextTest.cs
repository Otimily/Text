using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTest : MonoBehaviour
{
    public Text txt1;
    public TMP_Text txt2;

    void Start()
    {
        txt1.text = "안녕하세요. 퍼스트";
        txt2.text = "안녕하세요. 세컨드";
    }
}
