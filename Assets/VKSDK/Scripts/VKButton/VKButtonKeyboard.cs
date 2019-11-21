﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VKButtonKeyboard : MonoBehaviour
{
#if UNITY_EDITOR || (!UNITY_ANDROID && !UNITY_IOS)
    public KeyCode key = KeyCode.KeypadEnter;

    public List<InputField> inputs;
    [HideInInspector]
    public VKButton vkButton;
    [HideInInspector]
    public Button button;

    public void Start()
    {
        button = GetComponent<Button>();
        vkButton = GetComponent<VKButton>();
    }

    public void OnEnable()
    {
        if (VKButtonKeyboardController.Instance != null)
            VKButtonKeyboardController.Instance.Add(this);
    }

    public void OnDisable()
    {
        if (VKButtonKeyboardController.Instance != null)
            VKButtonKeyboardController.Instance.Remove(this);
    }
#endif
}
