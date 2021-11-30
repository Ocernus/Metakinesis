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
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ec9964da-8a2b-42d1-8f29-60e1ae52ac0f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
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
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ae9c9bd0-ded0-4fe4-a434-611540ced5ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Item"",
                    ""type"": ""Button"",
                    ""id"": ""fe35991f-2705-4ab6-a472-58474a8a3376"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
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
                    ""name"": ""Target Camera"",
                    ""type"": ""Button"",
                    ""id"": ""896fa234-0289-4174-bef4-f969e6e80d5c"",
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
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""ded6cb03-a634-4b86-b7c7-2ca0988a28e2"",
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
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a6c30df0-c5ae-4617-87ee-3f1fc652b6af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Heal"",
                    ""type"": ""Button"",
                    ""id"": ""84b6f580-8160-4abf-b126-5e5e7352bc76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""c85268d4-469d-4e88-aa3b-06bde35dff98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Put Away"",
                    ""type"": ""Button"",
                    ""id"": ""bb16b92b-3199-438c-902a-1c2a08038b33"",
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
                    ""id"": ""e29cf3e8-356b-4c67-a7ae-d28c61c9edf5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8020e0ec-f08f-4f38-a8cb-7acd5b32dc2a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item"",
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
                    ""id"": ""b81b0450-e7e2-4fdf-bec9-1bd643d94963"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Target Camera"",
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
                    ""id"": ""150c25e3-285e-48e3-abe4-4a510ef62e4c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
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
                    ""id"": ""23f06bf7-c29d-4013-9385-91ed10b98cc3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e646f32-3079-4fc1-8311-f2be718b5ff5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9178b30-e7eb-4022-a313-c0cf3e97e754"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03d949f2-1420-4390-b82a-c031b546adb5"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Put Away"",
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
        m_CharacterControl_Look = m_CharacterControl.FindAction("Look", throwIfNotFound: true);
        m_CharacterControl_Comment = m_CharacterControl.FindAction("Comment", throwIfNotFound: true);
        m_CharacterControl_Jump = m_CharacterControl.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControl_Item = m_CharacterControl.FindAction("Item", throwIfNotFound: true);
        m_CharacterControl_ResetCamera = m_CharacterControl.FindAction("Reset Camera", throwIfNotFound: true);
        m_CharacterControl_TargetCamera = m_CharacterControl.FindAction("Target Camera", throwIfNotFound: true);
        m_CharacterControl_PhysicalInteraction = m_CharacterControl.FindAction("Physical Interaction", throwIfNotFound: true);
        m_CharacterControl_MoveX = m_CharacterControl.FindAction("MoveX", throwIfNotFound: true);
        m_CharacterControl_MoveY = m_CharacterControl.FindAction("MoveY", throwIfNotFound: true);
        m_CharacterControl_Sprint = m_CharacterControl.FindAction("Sprint", throwIfNotFound: true);
        m_CharacterControl_Pause = m_CharacterControl.FindAction("Pause", throwIfNotFound: true);
        m_CharacterControl_Shoot = m_CharacterControl.FindAction("Shoot", throwIfNotFound: true);
        m_CharacterControl_Heal = m_CharacterControl.FindAction("Heal", throwIfNotFound: true);
        m_CharacterControl_Guard = m_CharacterControl.FindAction("Guard", throwIfNotFound: true);
        m_CharacterControl_PutAway = m_CharacterControl.FindAction("Put Away", throwIfNotFound: true);
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
    private readonly InputAction m_CharacterControl_Look;
    private readonly InputAction m_CharacterControl_Comment;
    private readonly InputAction m_CharacterControl_Jump;
    private readonly InputAction m_CharacterControl_Item;
    private readonly InputAction m_CharacterControl_ResetCamera;
    private readonly InputAction m_CharacterControl_TargetCamera;
    private readonly InputAction m_CharacterControl_PhysicalInteraction;
    private readonly InputAction m_CharacterControl_MoveX;
    private readonly InputAction m_CharacterControl_MoveY;
    private readonly InputAction m_CharacterControl_Sprint;
    private readonly InputAction m_CharacterControl_Pause;
    private readonly InputAction m_CharacterControl_Shoot;
    private readonly InputAction m_CharacterControl_Heal;
    private readonly InputAction m_CharacterControl_Guard;
    private readonly InputAction m_CharacterControl_PutAway;
    public struct CharacterControlActions
    {
        private @PlayerControls m_Wrapper;
        public CharacterControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_CharacterControl_Look;
        public InputAction @Comment => m_Wrapper.m_CharacterControl_Comment;
        public InputAction @Jump => m_Wrapper.m_CharacterControl_Jump;
        public InputAction @Item => m_Wrapper.m_CharacterControl_Item;
        public InputAction @ResetCamera => m_Wrapper.m_CharacterControl_ResetCamera;
        public InputAction @TargetCamera => m_Wrapper.m_CharacterControl_TargetCamera;
        public InputAction @PhysicalInteraction => m_Wrapper.m_CharacterControl_PhysicalInteraction;
        public InputAction @MoveX => m_Wrapper.m_CharacterControl_MoveX;
        public InputAction @MoveY => m_Wrapper.m_CharacterControl_MoveY;
        public InputAction @Sprint => m_Wrapper.m_CharacterControl_Sprint;
        public InputAction @Pause => m_Wrapper.m_CharacterControl_Pause;
        public InputAction @Shoot => m_Wrapper.m_CharacterControl_Shoot;
        public InputAction @Heal => m_Wrapper.m_CharacterControl_Heal;
        public InputAction @Guard => m_Wrapper.m_CharacterControl_Guard;
        public InputAction @PutAway => m_Wrapper.m_CharacterControl_PutAway;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlActions instance)
        {
            if (m_Wrapper.m_CharacterControlActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Comment.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Comment.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Comment.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Jump.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Item.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Item.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Item.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @ResetCamera.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @TargetCamera.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @TargetCamera.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @TargetCamera.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @PhysicalInteraction.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPhysicalInteraction;
                @PhysicalInteraction.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPhysicalInteraction;
                @PhysicalInteraction.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPhysicalInteraction;
                @MoveX.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @Sprint.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSprint;
                @Pause.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPause;
                @Shoot.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnShoot;
                @Heal.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnHeal;
                @Heal.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnHeal;
                @Heal.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnHeal;
                @Guard.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnGuard;
                @PutAway.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPutAway;
                @PutAway.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPutAway;
                @PutAway.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnPutAway;
            }
            m_Wrapper.m_CharacterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Comment.started += instance.OnComment;
                @Comment.performed += instance.OnComment;
                @Comment.canceled += instance.OnComment;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Item.started += instance.OnItem;
                @Item.performed += instance.OnItem;
                @Item.canceled += instance.OnItem;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
                @TargetCamera.started += instance.OnTargetCamera;
                @TargetCamera.performed += instance.OnTargetCamera;
                @TargetCamera.canceled += instance.OnTargetCamera;
                @PhysicalInteraction.started += instance.OnPhysicalInteraction;
                @PhysicalInteraction.performed += instance.OnPhysicalInteraction;
                @PhysicalInteraction.canceled += instance.OnPhysicalInteraction;
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Heal.started += instance.OnHeal;
                @Heal.performed += instance.OnHeal;
                @Heal.canceled += instance.OnHeal;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @PutAway.started += instance.OnPutAway;
                @PutAway.performed += instance.OnPutAway;
                @PutAway.canceled += instance.OnPutAway;
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
        void OnLook(InputAction.CallbackContext context);
        void OnComment(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
        void OnTargetCamera(InputAction.CallbackContext context);
        void OnPhysicalInteraction(InputAction.CallbackContext context);
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnHeal(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnPutAway(InputAction.CallbackContext context);
    }
    public interface IMenuControlActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
