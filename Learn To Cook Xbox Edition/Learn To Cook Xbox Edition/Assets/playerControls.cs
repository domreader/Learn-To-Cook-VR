// GENERATED AUTOMATICALLY FROM 'Assets/playerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerControls"",
    ""maps"": [
        {
            ""name"": ""playerControls"",
            ""id"": ""d1fa0f28-e8c3-4d4c-aa94-20618dbf0c87"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""c1ff5197-f968-44de-ba30-682c395801e6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shrink"",
                    ""type"": ""Button"",
                    ""id"": ""5e976d04-4ad6-47d9-a002-ed9cc5c22416"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""950a0b80-d03d-4211-bc87-6e016b56f340"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLook"",
                    ""type"": ""Button"",
                    ""id"": ""a8b5b124-a6b7-4ff9-8574-3a872a2b6d56"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""67f6661a-7766-4208-b99b-003212eedcb5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d27639cd-d767-40b6-a22d-5a3de17d7562"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c581356-48b4-447a-885f-3df49da4d7bb"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6892672e-a51c-4628-881d-4d61381cc321"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4711cfb8-e48e-4ff9-b7db-b2693865d2aa"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eb3b260-6c8b-4ae7-84f4-67c12387fc36"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6fcc9d9-e0a3-4824-871c-4a50053c6653"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ebf2f32-023c-404b-bfb0-917423c316b0"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bad4164d-65aa-4276-96af-c6c29cdc803b"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // playerControls
        m_playerControls = asset.FindActionMap("playerControls", throwIfNotFound: true);
        m_playerControls_Grow = m_playerControls.FindAction("Grow", throwIfNotFound: true);
        m_playerControls_Shrink = m_playerControls.FindAction("Shrink", throwIfNotFound: true);
        m_playerControls_Move = m_playerControls.FindAction("Move", throwIfNotFound: true);
        m_playerControls_RotateLook = m_playerControls.FindAction("RotateLook", throwIfNotFound: true);
        m_playerControls_Pause = m_playerControls.FindAction("Pause", throwIfNotFound: true);
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

    // playerControls
    private readonly InputActionMap m_playerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_playerControls_Grow;
    private readonly InputAction m_playerControls_Shrink;
    private readonly InputAction m_playerControls_Move;
    private readonly InputAction m_playerControls_RotateLook;
    private readonly InputAction m_playerControls_Pause;
    public struct PlayerControlsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_playerControls_Grow;
        public InputAction @Shrink => m_Wrapper.m_playerControls_Shrink;
        public InputAction @Move => m_Wrapper.m_playerControls_Move;
        public InputAction @RotateLook => m_Wrapper.m_playerControls_RotateLook;
        public InputAction @Pause => m_Wrapper.m_playerControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_playerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnGrow;
                @Shrink.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShrink;
                @Shrink.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShrink;
                @Shrink.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShrink;
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @RotateLook.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateLook;
                @RotateLook.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateLook;
                @RotateLook.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateLook;
                @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @Shrink.started += instance.OnShrink;
                @Shrink.performed += instance.OnShrink;
                @Shrink.canceled += instance.OnShrink;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotateLook.started += instance.OnRotateLook;
                @RotateLook.performed += instance.OnRotateLook;
                @RotateLook.canceled += instance.OnRotateLook;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerControlsActions @playerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotateLook(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
