// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

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
            ""name"": ""Player"",
            ""id"": ""1bf453a1-38ff-44c7-9cf5-13f1ffec1e19"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""0eddb306-c202-4d83-b8d5-8bf820912c89"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotating"",
                    ""type"": ""Value"",
                    ""id"": ""0b9b0015-2ef2-4745-a264-15f09def851e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Value"",
                    ""id"": ""17f58b05-e4e8-45df-8895-195774210e41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""3e079fde-0c44-4002-acdf-3071cd1dec09"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""69c250fb-8677-4636-bbc8-5ff2b01cf8e0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keys"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""12d9998b-5b96-4108-87e0-9e6b61eb209d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotating"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a802ff1d-11e3-4111-bdef-f418c6e86228"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keys"",
                    ""action"": ""Rotating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f6b4d2a5-8bbb-442d-a6e2-4c7f23b7e9e7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keys"",
                    ""action"": ""Rotating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ad58f0fa-e6bd-4cb0-8d17-d0d8292870a0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keys"",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse&Keys"",
            ""bindingGroup"": ""Mouse&Keys"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Moving = m_Player.FindAction("Moving", throwIfNotFound: true);
        m_Player_Rotating = m_Player.FindAction("Rotating", throwIfNotFound: true);
        m_Player_Shooting = m_Player.FindAction("Shooting", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Moving;
    private readonly InputAction m_Player_Rotating;
    private readonly InputAction m_Player_Shooting;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_Player_Moving;
        public InputAction @Rotating => m_Wrapper.m_Player_Rotating;
        public InputAction @Shooting => m_Wrapper.m_Player_Shooting;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Moving.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoving;
                @Moving.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoving;
                @Moving.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoving;
                @Rotating.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotating;
                @Rotating.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotating;
                @Rotating.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotating;
                @Shooting.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShooting;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moving.started += instance.OnMoving;
                @Moving.performed += instance.OnMoving;
                @Moving.canceled += instance.OnMoving;
                @Rotating.started += instance.OnRotating;
                @Rotating.performed += instance.OnRotating;
                @Rotating.canceled += instance.OnRotating;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseKeysSchemeIndex = -1;
    public InputControlScheme MouseKeysScheme
    {
        get
        {
            if (m_MouseKeysSchemeIndex == -1) m_MouseKeysSchemeIndex = asset.FindControlSchemeIndex("Mouse&Keys");
            return asset.controlSchemes[m_MouseKeysSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnRotating(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
    }
}
