using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;
using Valve.VR.Extras;

public class CastEventToUI : MonoBehaviour
{
    SteamVR_LaserPointer laserPointer;

    private void OnEnable()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();

        laserPointer.PointerIn += OnPointerEnter;
        laserPointer.PointerOut += OnPointerExit;
        laserPointer.PointerClick += OnPointerClick;
    }

    private void OnPointerEnter(object sender, PointerEventArgs e)
    {
        IPointerEnterHandler handler = e.target.GetComponent<IPointerEnterHandler>();
        if (handler == null) return;
        handler.OnPointerEnter(new PointerEventData(EventSystem.current));
    }
     private void OnPointerExit(object sender, PointerEventArgs e)
    {
        IPointerExitHandler handler = e.target.GetComponent<IPointerExitHandler>();
        if (handler == null) return;
        handler.OnPointerExit(new PointerEventData(EventSystem.current));

    }
     private void OnPointerClick(object sender, PointerEventArgs e)
    {
        IPointerClickHandler handler = e.target.GetComponent<IPointerClickHandler>();
        if (handler == null) return;
        handler.OnPointerClick(new PointerEventData(EventSystem.current));
    }

    private void OnDisable()
    {
        laserPointer.PointerIn -= OnPointerEnter;
        laserPointer.PointerOut -= OnPointerExit;
        laserPointer.PointerClick -= OnPointerClick;
    }

}
