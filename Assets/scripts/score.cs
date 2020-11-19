using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text c;

    void Start()
    {
        c = GetComponent<Text>();
        c.text = "Score: " + GameManager.Instance.Score;
    }
}
