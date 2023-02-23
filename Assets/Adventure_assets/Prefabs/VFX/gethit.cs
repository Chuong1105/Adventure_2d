using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using UnityEngine.Events;

public class gethit : MonoBehaviour
{
    public MMFeedbacks _gethitfb;
void awake()
{   
    _gethitfb?.Initialization();
}
public void Gethitfb()
{   
    _gethitfb?.PlayFeedbacks();
}
}