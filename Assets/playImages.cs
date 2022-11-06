using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playImages : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private RectTransform panel;

    public void PlayNessaPorra()
    {
        LeanTween.play(panel, sprites).setLoopPingPong();
    }
}
