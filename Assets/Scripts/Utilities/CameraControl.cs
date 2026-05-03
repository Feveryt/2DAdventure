using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("事件监听")]
    public VoidEventSO afterSceneLoadedEvent;

    private CinemachineConfiner2D confiner2D;
    public CinemachineImpulseSource impulseSource;
    public VoidEventSO cameraShakeEvent;

    private void Awake()
    {
        confiner2D = GetComponent<CinemachineConfiner2D>();
        
    }
    private void OnEnable()
    {
        cameraShakeEvent.OnEventRaised += OnCameraShakeEvent;
        afterSceneLoadedEvent.OnEventRaised += OnAfterSceneLoadedEvent;
    }


    private void OnDisable()
    {
        cameraShakeEvent.OnEventRaised -= OnCameraShakeEvent;
        afterSceneLoadedEvent.OnEventRaised -= OnAfterSceneLoadedEvent;
    }
    private void OnAfterSceneLoadedEvent()
    {
        GetNewCameraBounds();
    }
    private void OnCameraShakeEvent()
    {
        impulseSource.GenerateImpulse();
    }

    
    //private void Start()
    //{
    //    GetNewCameraBounds();
    //}

    private void GetNewCameraBounds()
    {
        var obj = GameObject.FindGameObjectsWithTag("Bounds");
        if (obj == null)
            return;



        //bug:第31个视频与视频代码写法不同，与视频相同会报错，无法实现场景切换时镜头效果
        confiner2D.m_BoundingShape2D = GetComponent<Collider2D>();

        confiner2D.InvalidateCache();
    }
}
