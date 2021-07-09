using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct Project
{
    public Sprite Thumbnail;
    public string Title;
    public string Description;
    public string Type;
    public string Company;

    public UnityEvent OnClick;
}
