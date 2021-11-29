// GENERATED AUTOMATICALLY FROM 'Assets/Input/Player Controls.inputactions'

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
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Character Control"",
            ""id"": ""d819ce03-2be7-4cb1-ae3e-53a2752bcbff"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""ac374dd5-a36a-4629-a711-4e4b332f6566"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""ea57b5bd-7ff0-4519-a5e8-87c7113e9801"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ec9964da-8a2b-42d1-8f29-60e1ae52ac0f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset Camera"",
                    ""type"": ""Button"",
                    ""id"": ""5166e352-e93e-46c3-9ce9-d65e01e43866"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Comment"",
                    ""type"": ""Button"",
                    ""id"": ""6a66afbb-e3ee-46c0-96af-3bd81aab29c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Physical Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""6aa9a7be-9b78-49c4-84b9-80047da5c588"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9070faa0-bb58-4171-8102-062f9d97a483"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Left Hand Change"",
                    ""type"": ""Button"",
                    ""id"": ""07477822-73a2-40bf-a8c2-21638af8afe5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Right Hand Change"",
                    ""type"": ""Button"",
                    ""id"": ""436eeba1-533b-484e-aaec-49467dfe0e31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Focus Up"",
                    ""type"": ""Button"",
                    ""id"": ""df1bf9f4-a62b-4dc3-8e40-2fb06cdfbf08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Focus Down"",
                    ""type"": ""Button"",
                    ""id"": ""a5f7e195-a368-48c8-8728-1c93913f69c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Left Hand Grip"",
                    ""type"": ""Button"",
                    ""id"": ""19fdcee7-a9db-4188-ad19-65734759ee7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Right Hand Grip"",
                    ""type"": ""Button"",
                    ""id"": ""7b6b156f-b703-45af-8ca2-a092308da18f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0356cb9a-569e-4fc6-a06d-295f921fdead"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""e65cafe5-59cf-4b15-be1b-f4988302f3ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8947a008-00db-42c2-a6a3-309edffdb780"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28602f39-76cf-4bb0-b059-ca68eb565104"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Comment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b03d1699-5d1e-4239-b93b-b1a692251c6c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Physical Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09e48003-f48e-4038-bf70-896fc877da4c"",
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
                    ""id"": ""fd16011e-d2a3-49af-98d5-c80b60091928"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Hand Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4aa4f6ba-ea63-4036-9b7d-2c1040912f95"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c43abe3-fb7b-4763-9ad7-20032ce2bd8a"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e1b6c10-0c00-4a33-af39-47c18b5ab730"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""564fe041-5b52-4c4a-ac4c-32c8c0f836d7"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Hand Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5732bc1-e551-4421-a9d6-d8c13ad78912"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b40143c-54a1-4ad1-a0e6-9ffaec2c2f1d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32bd9596-2d3f-4b07-b0a0-26a2ab82bfe7"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Hand Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0db14db0-c8b9-48da-ad7b-b402beb6fd6c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Hand Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a5448e3-68e0-41ea-83a0-74b822fa0a2b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c618d98e-b57a-4c6b-9e86-d0758844fd8e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Control"",
            ""id"": ""d3506e28-80da-4f2e-89c9-8e8a5753c675"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""10e9d730-a089-4b43-a00b-9eb14f8a8c49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7405be7-1b19-4275-a5cf-200c44e98011"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character Control
        m_CharacterControl = asset.FindActionMap("Character Control", throwIfNotFound: true);
        m_CharacterControl_MoveX = m_CharacterControl.FindAction("MoveX", throwIfNotFound: true);
        m_CharacterControl_MoveY = m_CharacterControl.FindAction("MoveY", throwIfNotFound: true);
        m_CharacterControl_Look = m_CharacterControl.FindAction("Look", throwIfNotFound: true);
        m_CharacterControl_ResetCamera = m_CharacterControl.FindAction("Reset Camera", throwIfNotFound: true);
        m_CharacterControl_Comment = m_CharacterControl.FindAction("Comment", throwIfNotFound: true);
        m_CharacterControl_PhysicalInteraction = m_CharacterControl.FindAction("Physical Interaction", throwIfNotFound: true);
        m_CharacterControl_Pause = m_CharacterControl.FindAction("Pause", throwIfNotFound: true);
        m_CharacterControl_LeftHandChange = m_CharacterControl.FindAction("Left Hand Change", throwIfNotFound: true);
        m_CharacterControl_RightHandChange = m_CharacterControl.FindAction("Right Hand Change", throwIfNotFound: true);
        m_CharacterControl_FocusUp = m_CharacterControl.FindAction("Focus Up", throwIfNotFound: true);
        m_CharacterControl_FocusDown = m_CharacterControl.FindAction("Focus Down", throwIfNotFound: true);
        m_CharacterControl_LeftHandGrip = m_CharacterControl.FindAction("Left Hand Grip", throwIfNotFound: true);
        m_CharacterControl_RightHandGrip = m_CharacterControl.FindAction("Right Hand Grip", throwIfNotFound: true);
        m_CharacterControl_Jump = m_CharacterControl.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControl_Dodge = m_CharacterControl.FindAction("Dodge", throwIfNotFound: true);
        // Menu Control
        m_MenuControl = asset.FindActionMap("Menu Control", throwIfNotFound: true);
        m_MenuControl_Start = m_MenuControl.FindAction("Start", throwIfNotFound: true);
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

    // Character Control
    private readonly InputActionMap m_CharacterControl;
    private ICharacterControlActions m_CharacterControlActionsCallbackInterface;
    private readonly InputAction m_CharacterControl_MoveX;
    private readonly InputAction m_CharacterControl_MoveY;
    private readonly InputAction m_CharacterControl_Look;
    private readonly InputAction m_CharacterControl_ResetCamera;
    private readonly InputAction m_CharacterControl_Comment;
    private readonly InputAction m_CharacterControl_PhysicalInteraction;
    private readonly InputAction m_CharacterControl_Pause;
    private readonly InputAction m_CharacterControl_LeftHandChange;
    private readonly InputAction m_CharacterControl_RightHandChange;
    private readonly InputAction m_CharacterControl_FocusUp;
    private readonly InputAction m_CharacterControl_FocusDown;
    private readonly InputAction m_CharacterControl_LeftHandGrip;
    private readonly InputAction m_CharacterControl_RightHandGrip;
    private readonly InputAction m_CharacterControl_Jump;
    private readonly InputAction m_CharacterControl_Dodge;
    public struct CharacterControlActions
    {
        private @PlayerControls m_Wrapper;
        public CharacterControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_CharacterControl_MoveX;
        public InputAction @MoveY => m_Wrapper.m_CharacterControl_MoveY;
        public InputAction @Look => m_Wrapper.m_CharacterControl_Look;
        public InputAction @ResetCamera => m_Wrapper.m_CharacterControl_ResetCamera;
        public InputAction @Comment => m_Wrapper.m_CharacterControl_Comment;
        public InputAction @PhysicalInteraction => m_Wrapper.m_CharacterControl_PhysicalInteraction;
        public InputAction @Pause => m_Wrapper.m_CharacterControl_Pause;
        public InputAction @LeftHandChange => m_Wrapper.m_CharacterControl_LeftHandChange;
        public InputAction @RightHandChange => m_Wrapper.m_CharacterControl_RightHandChange;
        public InputAction @FocusUp => m_Wrapper.m_CharacterControl_FocusUp;
        public InputAction @FocusDown => m_Wrapper.m_CharacterControl_FocusDown;
        public InputAction @LeftHandGrip => m_Wrapper.m_CharacterControl_LeftHandGrip;
        public InputAction @RightHandGrip => m_Wrapper.m_CharacterControl_RightHandGrip;
        public InputAction @Jump => m_Wrapper.m_CharacterControl_Jump;
        public InputAction @Dodge => m_Wrapper.m_CharacterControl_Dodge;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlActions instance)
        {
            if (m_Wrapper.m_CharacterControlActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @Look.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @ResetCamera.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @Comment.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Comment.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Comment.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @PhysicalInteraction.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPhysicalInteraction;
                @PhysicalInteraction.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPhysicalInteraction;
                @PhysicalInteraction.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPhysicalInteraction;
                @Pause.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPause;
                @LeftHandChange.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLeftHandChange;
                @LeftHandChange.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLeftHandChange;
                @LeftHandChange.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLeftHandChange;
                @RightHandChange.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnRightHandChange;
                @RightHandChange.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnRightHandChange;
                @RightHandChange.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnRightHandChange;
                @FocusUp.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnFocusUp;
                @FocusUp.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnFocusUp;
                @FocusUp.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnFocusUp;
                @FocusDown.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnFocusDown;
                @FocusDown.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnFocusDown;
                @FocusDown.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnFocusDown;
                @LeftHandGrip.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLeftHandGrip;
                @LeftHandGrip.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLeftHandGrip;
                @LeftHandGrip.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLeftHandGrip;
                @RightHandGrip.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnRightHandGrip;
                @RightHandGrip.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnRightHandGrip;
                @RightHandGrip.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnRightHandGrip;
                @Jump.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Dodge.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnDodge;
            }
            m_Wrapper.m_CharacterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
                @Comment.started += instance.OnComment;
                @Comment.performed += instance.OnComment;
                @Comment.canceled += instance.OnComment;
                @PhysicalInteraction.started += instance.OnPhysicalInteraction;
                @PhysicalInteraction.performed += instance.OnPhysicalInteraction;
                @PhysicalInteraction.canceled += instance.OnPhysicalInteraction;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @LeftHandChange.started += instance.OnLeftHandChange;
                @LeftHandChange.performed += instance.OnLeftHandChange;
                @LeftHandChange.canceled += instance.OnLeftHandChange;
                @RightHandChange.started += instance.OnRightHandChange;
                @RightHandChange.performed += instance.OnRightHandChange;
                @RightHandChange.canceled += instance.OnRightHandChange;
                @FocusUp.started += instance.OnFocusUp;
                @FocusUp.performed += instance.OnFocusUp;
                @FocusUp.canceled += instance.OnFocusUp;
                @FocusDown.started += instance.OnFocusDown;
                @FocusDown.performed += instance.OnFocusDown;
                @FocusDown.canceled += instance.OnFocusDown;
                @LeftHandGrip.started += instance.OnLeftHandGrip;
                @LeftHandGrip.performed += instance.OnLeftHandGrip;
                @LeftHandGrip.canceled += instance.OnLeftHandGrip;
                @RightHandGrip.started += instance.OnRightHandGrip;
                @RightHandGrip.performed += instance.OnRightHandGrip;
                @RightHandGrip.canceled += instance.OnRightHandGrip;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
            }
        }
    }
    public CharacterControlActions @CharacterControl => new CharacterControlActions(this);

    // Menu Control
    private readonly InputActionMap m_MenuControl;
    private IMenuControlActions m_MenuControlActionsCallbackInterface;
    private readonly InputAction m_MenuControl_Start;
    public struct MenuControlActions
    {
        private @PlayerControls m_Wrapper;
        public MenuControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_MenuControl_Start;
        public InputActionMap Get() { return m_Wrapper.m_MenuControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlActions instance)
        {
            if (m_Wrapper.m_MenuControlActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_MenuControlActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_MenuControlActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_MenuControlActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_MenuControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public MenuControlActions @MenuControl => new MenuControlActions(this);
    public interface ICharacterControlActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
        void OnComment(InputAction.CallbackContext context);
        void OnPhysicalInteraction(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnLeftHandChange(InputAction.CallbackContext context);
        void OnRightHandChange(InputAction.CallbackContext context);
        void OnFocusUp(InputAction.CallbackContext context);
        void OnFocusDown(InputAction.CallbackContext context);
        void OnLeftHandGrip(InputAction.CallbackContext context);
        void OnRightHandGrip(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
    }
    public interface IMenuControlActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
