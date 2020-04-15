// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/playerControls.inputactions'

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
                    ""name"": ""Interact"",
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
                },
                {
                    ""name"": ""OpeningBook"",
                    ""type"": ""Button"",
                    ""id"": ""440c4de5-57af-45c2-92b7-c4990932599e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurningPageLeft"",
                    ""type"": ""Button"",
                    ""id"": ""77ea589b-52cc-4e94-a36f-13b458abd7cf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurningPageRight"",
                    ""type"": ""Button"",
                    ""id"": ""00adf7a7-0997-4d9a-8ba9-3b9864d02869"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""261d7cdb-2c49-4e54-9a83-d368d18ef885"",
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
                    ""action"": ""Interact"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""a747b320-6f28-4dfc-9b2b-047f6fd4d0f2"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpeningBook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e14a7ea0-8b2e-474b-86b5-c8079e4e605d"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpeningBook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af793f84-53c6-4658-8dad-ed05938c483e"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningPageLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""851c9802-d843-4d48-b358-0fc3b1ef3760"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningPageLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a45b1a9-0f2f-497c-8089-823d56e50a06"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningPageRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""257e84e0-bffe-4766-baad-749f2e23ae4b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningPageRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93e226ba-e419-48bb-b036-1166b075d85e"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b5ca6eb-9394-472a-8fac-a43dc388b7cc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
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
        m_playerControls_Interact = m_playerControls.FindAction("Interact", throwIfNotFound: true);
        m_playerControls_Shrink = m_playerControls.FindAction("Shrink", throwIfNotFound: true);
        m_playerControls_Move = m_playerControls.FindAction("Move", throwIfNotFound: true);
        m_playerControls_RotateLook = m_playerControls.FindAction("RotateLook", throwIfNotFound: true);
        m_playerControls_Pause = m_playerControls.FindAction("Pause", throwIfNotFound: true);
        m_playerControls_OpeningBook = m_playerControls.FindAction("OpeningBook", throwIfNotFound: true);
        m_playerControls_TurningPageLeft = m_playerControls.FindAction("TurningPageLeft", throwIfNotFound: true);
        m_playerControls_TurningPageRight = m_playerControls.FindAction("TurningPageRight", throwIfNotFound: true);
        m_playerControls_Inventory = m_playerControls.FindAction("Inventory", throwIfNotFound: true);
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
    private readonly InputAction m_playerControls_Interact;
    private readonly InputAction m_playerControls_Shrink;
    private readonly InputAction m_playerControls_Move;
    private readonly InputAction m_playerControls_RotateLook;
    private readonly InputAction m_playerControls_Pause;
    private readonly InputAction m_playerControls_OpeningBook;
    private readonly InputAction m_playerControls_TurningPageLeft;
    private readonly InputAction m_playerControls_TurningPageRight;
    private readonly InputAction m_playerControls_Inventory;
    public struct PlayerControlsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_playerControls_Interact;
        public InputAction @Shrink => m_Wrapper.m_playerControls_Shrink;
        public InputAction @Move => m_Wrapper.m_playerControls_Move;
        public InputAction @RotateLook => m_Wrapper.m_playerControls_RotateLook;
        public InputAction @Pause => m_Wrapper.m_playerControls_Pause;
        public InputAction @OpeningBook => m_Wrapper.m_playerControls_OpeningBook;
        public InputAction @TurningPageLeft => m_Wrapper.m_playerControls_TurningPageLeft;
        public InputAction @TurningPageRight => m_Wrapper.m_playerControls_TurningPageRight;
        public InputAction @Inventory => m_Wrapper.m_playerControls_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_playerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
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
                @OpeningBook.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpeningBook;
                @OpeningBook.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpeningBook;
                @OpeningBook.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpeningBook;
                @TurningPageLeft.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTurningPageLeft;
                @TurningPageLeft.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTurningPageLeft;
                @TurningPageLeft.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTurningPageLeft;
                @TurningPageRight.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTurningPageRight;
                @TurningPageRight.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTurningPageRight;
                @TurningPageRight.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTurningPageRight;
                @Inventory.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventory;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
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
                @OpeningBook.started += instance.OnOpeningBook;
                @OpeningBook.performed += instance.OnOpeningBook;
                @OpeningBook.canceled += instance.OnOpeningBook;
                @TurningPageLeft.started += instance.OnTurningPageLeft;
                @TurningPageLeft.performed += instance.OnTurningPageLeft;
                @TurningPageLeft.canceled += instance.OnTurningPageLeft;
                @TurningPageRight.started += instance.OnTurningPageRight;
                @TurningPageRight.performed += instance.OnTurningPageRight;
                @TurningPageRight.canceled += instance.OnTurningPageRight;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
            }
        }
    }
    public PlayerControlsActions @playerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotateLook(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnOpeningBook(InputAction.CallbackContext context);
        void OnTurningPageLeft(InputAction.CallbackContext context);
        void OnTurningPageRight(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
}
