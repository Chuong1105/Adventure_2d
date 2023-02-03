using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using UnityEngine.Events;

public class run : MonoBehaviour
{
    
    public MMFeedbacks _hitFeedback;
    public UnityEvent _gethit;
    // Start is called before the first frame update
    public void gethit()
    {
        if (_gethit != null)
        {
            _gethit.Invoke();
        }
    }

    
}
