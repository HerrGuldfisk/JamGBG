// GENERATED AUTOMATICALLY FROM 'Assets/GameState/GeneralInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GeneralInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GeneralInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralInput"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""b19c634c-b1c6-45ec-8e4a-1a4225a1d1c6"",
            ""actions"": [
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""ea521264-2c50-4474-ad47-a5d051ba1af9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""adc2d529-261f-45ce-8e36-c63821eda0a7"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_Reload = m_General.FindAction("Reload", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_Reload;
    public struct GeneralActions
    {
        private @GeneralInput m_Wrapper;
        public GeneralActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Reload => m_Wrapper.m_General_Reload;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @Reload.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    public interface IGeneralActions
    {
        void OnReload(InputAction.CallbackContext context);
    }
}
