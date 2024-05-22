using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class defense : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private GameObject LeftBoundary;
    [SerializeField] private GameObject RightBoundary;
    private GameObject LeftText;
    private GameObject RightText;

    void Start()
    {
        LeftText = GameObject.Find("Canvas/Text/Left");
        RightText = GameObject.Find("Canvas/Text/Right");

        LeftText.SetActive(false);
        RightText.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(eventData.pointerEnter == LeftBoundary)
        {
            RightText.SetActive(false);
            LeftText.SetActive(true);
        }
        else if(eventData.pointerEnter == RightBoundary)
        {
            LeftText.SetActive(false);
            RightText.SetActive(true);
        }
    }
}
