﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Frame : MonoBehaviour
{
    public int order;

    [TextAreaAttribute(3, 10)]
    public string message;

    protected void Awake()
    {
        GameObject.FindObjectOfType<TutorialManager>().AddFrame(this);
    }

    public virtual bool ShouldSpawnBall()
    {
        return true;
    }

    public virtual bool ShouldShootBall()
    {
        return true;
    }

    public virtual void StartFrame() { }

    public abstract bool IsComplete();

  
}
