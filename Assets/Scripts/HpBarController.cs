﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HpBarController : MonoBehaviour {

    private int total;
    private float maxWidth = 50;

    private RectTransform redBar;

    private void Start()
    {
        redBar = (RectTransform) transform.Find("RedBar");
    }

    public void SetHpTotal(int t)
    {
        total = t;
    }

    public void SetHpCurrent(int current)
    {
        redBar.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, maxWidth * current / total);
    }

}
