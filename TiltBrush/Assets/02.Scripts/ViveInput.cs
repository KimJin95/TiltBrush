using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    //�Է� �ҽ� ����
    [SerializeField] SteamVR_Input_Sources leftHand;
    [SerializeField] SteamVR_Input_Sources rightHand;
    [SerializeField] SteamVR_Input_Sources anyHand;

    //�׼� - Ʈ���� �׼�
    [SerializeField] SteamVR_Action_Boolean trigger;
    [SerializeField] SteamVR_Action_Boolean trackPad;
    [SerializeField] SteamVR_Action_Vector2 trackPadPos;

    Button btn;

    void Update()
    {
        if (trigger.GetStateDown(rightHand))
        {
            print("rightHand trigger");
        }
        if (trackPad.GetStateDown(anyHand))
        {
            print("trackPad Touch");
        }
        Vector2 pos = trackPadPos.GetAxis(leftHand);

    }
}
