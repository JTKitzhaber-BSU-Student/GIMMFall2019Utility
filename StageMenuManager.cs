using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class StageMenuManager : MonoBehaviour
{
    public GameObject menus;
    private GameObject player;
    public Vector3 menuOffsets;
    public int menuCounter;

    public SteamVR_ActionSet squeezeActions;
    public SteamVR_Action_Boolean squeezePause;
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;

    //public Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player(Clone)");
        menuCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        menus.transform.position = new Vector3(player.transform.position.x + menuOffsets.x, player.transform.position.y + menuOffsets.y, player.transform.position.z + menuOffsets.z);
        
    }

    //----------------------------VR

    private void OnEnable()
    {
        squeezeActions.Activate();

        if (squeezePause != null)
        {
            squeezePause.AddOnChangeListener(OnTriggerPressedOrReleased, inputSource);
            //Debug.Log("StageMenuManager Awake Has Ran");
        }
        
    }

    private void OnTriggerPressedOrReleased(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState)
    {
        //Debug.Log("=====================================" + menuCounter);
        doToggle();
    }

    private void doToggle()
    {
        menuCounter++;
        if ((menuCounter % 2) == 0)
        {
            if (menus.activeInHierarchy)
            {
                menus.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                menus.SetActive(true);
            }
        }
    }   
}
