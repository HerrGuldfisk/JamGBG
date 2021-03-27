// GENERATED AUTOMATICALLY FROM 'Assets/Helicopter/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""eef9ad42-f54b-4ee1-af48-2dcd512b965a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a610b92b-13ba-4da7-affe-4cdb6d6bf685"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""dd8fed14-285a-4e81-ac5a-37295a6ffc9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e696e4fa-dfbf-4925-a6e2-c012b94ca4a3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7bc44f82-93ab-4e2f-adc1-bde73490c78f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c7fb8758-ea07-4cea-b8f7-7a3316de0673"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ea42f37-ee41-49e7-a55c-eb119bda1560"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be678de5-216c-44de-91eb-9dbb7273cef6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""38eb74fc-f46c-4de7-8469-b0cb8ad1ff32"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2656c5c7-acbd-4bbd-8fda-ec322ec83d98"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""de77264a-172d-4325-9c02-f98cbe9301d1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""76d38c44-6622-4515-90a2-814f2750f871"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""24735d54-9b28-4580-9f40-9aee8b7baf06"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ff2e8d64-01f1-4164-bd58-1703f585896d"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aab083c3-bcb0-46ee-ae9e-21b59643bba1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""e02c3ebc-638b-465f-ba9c-0171fd8e723c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4e9dedd4-e623-4f55-bbad-63b0ea7cf25c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""66ae8ecf-abe6-4f14-97f3-4b0e3fe7db56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""35b35fa1-dc8c-419a-807c-c731576974c4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5c0bac5c-49e7-4c32-bec8-54503d04d50f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a24c2798-f66f-4a23-b36f-a6515ba269b9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""371f72c0-e80f-48d6-9be9-2104b441e3a3"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0519b040-dae1-4274-8ec2-258206f1c97b"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""937b7df0-60b7-47ce-9e9d-0c6cac5ebe02"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c4ea1786-8639-4bdf-89f4-93283c0cb089"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6ba68991-a272-406c-8452-ed6a4838eac8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7cd1d492-ea68-43ad-a7c4-a79f32823dfe"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2552a44a-fff5-450a-a27f-f3cd39bf467f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""320dedd4-8e1f-493a-ab67-50f9989214dd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""35cc4e81-1e15-420a-9f34-546f2662e864"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player3"",
            ""id"": ""b195fcec-1f80-4a92-8732-95484175dcf9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ed461107-42bb-4456-a502-f81e76f2490f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""7d5abe5d-fa83-48ff-825e-282101c816d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""936bfe41-f965-4c7d-861c-7c69859dc005"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4a6de0fb-7237-4c74-a4fc-8b25a46a5cfa"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ca8adec9-0436-4b06-ac1b-de7ed9b91249"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1498e43b-46ed-4522-aedb-d3cade93c55c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f4a68c24-0495-4c1c-be83-54887c790dfc"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""19b41c2a-2778-434b-bd70-309a32f663e3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player4"",
            ""id"": ""aea6bb63-a5c7-4cc3-a4f0-67a857aef707"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c79edae7-be41-46fc-a2ec-2519417845a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""250bbe53-c5b7-4420-b1da-fbfb0def9acf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""07314ed7-656d-45ee-84d7-622c538df278"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""922e3a60-20f5-4d28-b250-a79bb06b5d9f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d271ef2-4b52-4ee5-9265-e37e5eab1a6c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""216feb8c-c1ba-48da-aab5-602aa669e752"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e32dac64-8f98-4097-a03c-9b63193bb4ea"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6fb346d0-479c-4892-9014-ad53ab3deacd"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        m_Player1_Action = m_Player1.FindAction("Action", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Move = m_Player2.FindAction("Move", throwIfNotFound: true);
        m_Player2_Action = m_Player2.FindAction("Action", throwIfNotFound: true);
        // Player3
        m_Player3 = asset.FindActionMap("Player3", throwIfNotFound: true);
        m_Player3_Move = m_Player3.FindAction("Move", throwIfNotFound: true);
        m_Player3_Action = m_Player3.FindAction("Action", throwIfNotFound: true);
        // Player4
        m_Player4 = asset.FindActionMap("Player4", throwIfNotFound: true);
        m_Player4_Move = m_Player4.FindAction("Move", throwIfNotFound: true);
        m_Player4_Action = m_Player4.FindAction("Action", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_Action;
    public struct Player1Actions
    {
        private @PlayerInput m_Wrapper;
        public Player1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @Action => m_Wrapper.m_Player1_Action;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Move;
    private readonly InputAction m_Player2_Action;
    public struct Player2Actions
    {
        private @PlayerInput m_Wrapper;
        public Player2Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputAction @Action => m_Wrapper.m_Player2_Action;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // Player3
    private readonly InputActionMap m_Player3;
    private IPlayer3Actions m_Player3ActionsCallbackInterface;
    private readonly InputAction m_Player3_Move;
    private readonly InputAction m_Player3_Action;
    public struct Player3Actions
    {
        private @PlayerInput m_Wrapper;
        public Player3Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player3_Move;
        public InputAction @Action => m_Wrapper.m_Player3_Action;
        public InputActionMap Get() { return m_Wrapper.m_Player3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player3Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer3Actions instance)
        {
            if (m_Wrapper.m_Player3ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_Player3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public Player3Actions @Player3 => new Player3Actions(this);

    // Player4
    private readonly InputActionMap m_Player4;
    private IPlayer4Actions m_Player4ActionsCallbackInterface;
    private readonly InputAction m_Player4_Move;
    private readonly InputAction m_Player4_Action;
    public struct Player4Actions
    {
        private @PlayerInput m_Wrapper;
        public Player4Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player4_Move;
        public InputAction @Action => m_Wrapper.m_Player4_Action;
        public InputActionMap Get() { return m_Wrapper.m_Player4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player4Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer4Actions instance)
        {
            if (m_Wrapper.m_Player4ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnMove;
                @Action.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_Player4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public Player4Actions @Player4 => new Player4Actions(this);
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IPlayer3Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IPlayer4Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
}
