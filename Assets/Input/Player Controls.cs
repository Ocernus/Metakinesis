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
                    ""name"": ""Item"",
                    ""type"": ""Button"",
                    ""id"": ""fe35991f-2705-4ab6-a472-58474a8a3376"",
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
                    ""name"": ""Attack"",
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
                },
                {
                    ""name"": ""Interact"",
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
                    ""name"": ""Evade"",
                    ""type"": ""Button"",
                    ""id"": ""ded6cb03-a634-4b86-b7c7-2ca0988a28e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Comment"",
                    ""type"": ""Button"",
                    ""id"": ""fd991d62-f023-43dd-b1c2-dbc59b312116"",
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
                    ""id"": ""b81b0450-e7e2-4fdf-bec9-1bd643d94963"",
                    ""path"": ""<Gamepad>/rightStickPress"",
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
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
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
                    ""path"": ""<Gamepad>/rightShoulder"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""28602f39-76cf-4bb0-b059-ca68eb565104"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e29cf3e8-356b-4c67-a7ae-d28c61c9edf5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
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
                    ""action"": ""Evade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36a717a0-e86c-4d80-a52e-17f5822ceed4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Comment"",
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
        },
        {
            ""name"": ""Dragon Controls"",
            ""id"": ""e1ec2fcd-e3cd-4eb3-88e6-510137ac68a1"",
            ""actions"": [
                {
                    ""name"": ""Left Wing Hold"",
                    ""type"": ""Value"",
                    ""id"": ""3e2844f6-b16e-4a1a-88db-5d665a111d50"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Wing Hold"",
                    ""type"": ""Value"",
                    ""id"": ""9d10239a-8335-4074-be83-4f61dc0f82e2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""a924822c-719f-4a12-b35e-171e5495fcc7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""7af4d178-e832-4bb5-beb7-13933e70dd9f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZMove"",
                    ""type"": ""Value"",
                    ""id"": ""ff8deeeb-5e37-4c30-8aca-f41770bd4495"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dismount"",
                    ""type"": ""Button"",
                    ""id"": ""c9b41124-e50d-43e3-a5ef-6e3c62bc5754"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""20b3f1ba-da3a-4e44-8e18-dddd738906de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d682d9b0-b15c-4cb0-8342-297813f66153"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Wing Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20309ad3-b192-408c-8660-d4f4ddb9b5ba"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Wing Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3cf5658-d8e5-425e-b11c-c63310d16652"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4da78d37-5203-4996-9fae-3cbb52693891"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d6c2943-31e7-40c7-8adf-8576b20fb96f"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f79fd507-e820-4944-996c-3469258dff40"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dismount"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""201f8d45-1860-4abd-b78d-2fb803000727"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
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
        m_CharacterControl_Item = m_CharacterControl.FindAction("Item", throwIfNotFound: true);
        m_CharacterControl_TargetCamera = m_CharacterControl.FindAction("Target Camera", throwIfNotFound: true);
        m_CharacterControl_Attack = m_CharacterControl.FindAction("Attack", throwIfNotFound: true);
        m_CharacterControl_MoveX = m_CharacterControl.FindAction("MoveX", throwIfNotFound: true);
        m_CharacterControl_MoveY = m_CharacterControl.FindAction("MoveY", throwIfNotFound: true);
        m_CharacterControl_Pause = m_CharacterControl.FindAction("Pause", throwIfNotFound: true);
        m_CharacterControl_Shoot = m_CharacterControl.FindAction("Shoot", throwIfNotFound: true);
        m_CharacterControl_Heal = m_CharacterControl.FindAction("Heal", throwIfNotFound: true);
        m_CharacterControl_Guard = m_CharacterControl.FindAction("Guard", throwIfNotFound: true);
        m_CharacterControl_PutAway = m_CharacterControl.FindAction("Put Away", throwIfNotFound: true);
        m_CharacterControl_Interact = m_CharacterControl.FindAction("Interact", throwIfNotFound: true);
        m_CharacterControl_Jump = m_CharacterControl.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControl_Evade = m_CharacterControl.FindAction("Evade", throwIfNotFound: true);
        m_CharacterControl_Comment = m_CharacterControl.FindAction("Comment", throwIfNotFound: true);
        // Menu Control
        m_MenuControl = asset.FindActionMap("Menu Control", throwIfNotFound: true);
        m_MenuControl_Start = m_MenuControl.FindAction("Start", throwIfNotFound: true);
        // Dragon Controls
        m_DragonControls = asset.FindActionMap("Dragon Controls", throwIfNotFound: true);
        m_DragonControls_LeftWingHold = m_DragonControls.FindAction("Left Wing Hold", throwIfNotFound: true);
        m_DragonControls_RightWingHold = m_DragonControls.FindAction("Right Wing Hold", throwIfNotFound: true);
        m_DragonControls_Look = m_DragonControls.FindAction("Look", throwIfNotFound: true);
        m_DragonControls_Turn = m_DragonControls.FindAction("Turn", throwIfNotFound: true);
        m_DragonControls_ZMove = m_DragonControls.FindAction("ZMove", throwIfNotFound: true);
        m_DragonControls_Dismount = m_DragonControls.FindAction("Dismount", throwIfNotFound: true);
        m_DragonControls_Boost = m_DragonControls.FindAction("Boost", throwIfNotFound: true);
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
    private readonly InputAction m_CharacterControl_Item;
    private readonly InputAction m_CharacterControl_TargetCamera;
    private readonly InputAction m_CharacterControl_Attack;
    private readonly InputAction m_CharacterControl_MoveX;
    private readonly InputAction m_CharacterControl_MoveY;
    private readonly InputAction m_CharacterControl_Pause;
    private readonly InputAction m_CharacterControl_Shoot;
    private readonly InputAction m_CharacterControl_Heal;
    private readonly InputAction m_CharacterControl_Guard;
    private readonly InputAction m_CharacterControl_PutAway;
    private readonly InputAction m_CharacterControl_Interact;
    private readonly InputAction m_CharacterControl_Jump;
    private readonly InputAction m_CharacterControl_Evade;
    private readonly InputAction m_CharacterControl_Comment;
    public struct CharacterControlActions
    {
        private @PlayerControls m_Wrapper;
        public CharacterControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_CharacterControl_Look;
        public InputAction @Item => m_Wrapper.m_CharacterControl_Item;
        public InputAction @TargetCamera => m_Wrapper.m_CharacterControl_TargetCamera;
        public InputAction @Attack => m_Wrapper.m_CharacterControl_Attack;
        public InputAction @MoveX => m_Wrapper.m_CharacterControl_MoveX;
        public InputAction @MoveY => m_Wrapper.m_CharacterControl_MoveY;
        public InputAction @Pause => m_Wrapper.m_CharacterControl_Pause;
        public InputAction @Shoot => m_Wrapper.m_CharacterControl_Shoot;
        public InputAction @Heal => m_Wrapper.m_CharacterControl_Heal;
        public InputAction @Guard => m_Wrapper.m_CharacterControl_Guard;
        public InputAction @PutAway => m_Wrapper.m_CharacterControl_PutAway;
        public InputAction @Interact => m_Wrapper.m_CharacterControl_Interact;
        public InputAction @Jump => m_Wrapper.m_CharacterControl_Jump;
        public InputAction @Evade => m_Wrapper.m_CharacterControl_Evade;
        public InputAction @Comment => m_Wrapper.m_CharacterControl_Comment;
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
                @Item.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Item.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Item.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @TargetCamera.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @TargetCamera.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @TargetCamera.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @Attack.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnAttack;
                @MoveX.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMoveY;
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
                @Interact.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnInteract;
                @Jump.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Evade.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnEvade;
                @Evade.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnEvade;
                @Evade.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnEvade;
                @Comment.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Comment.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
                @Comment.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnComment;
            }
            m_Wrapper.m_CharacterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Item.started += instance.OnItem;
                @Item.performed += instance.OnItem;
                @Item.canceled += instance.OnItem;
                @TargetCamera.started += instance.OnTargetCamera;
                @TargetCamera.performed += instance.OnTargetCamera;
                @TargetCamera.canceled += instance.OnTargetCamera;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
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
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Evade.started += instance.OnEvade;
                @Evade.performed += instance.OnEvade;
                @Evade.canceled += instance.OnEvade;
                @Comment.started += instance.OnComment;
                @Comment.performed += instance.OnComment;
                @Comment.canceled += instance.OnComment;
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

    // Dragon Controls
    private readonly InputActionMap m_DragonControls;
    private IDragonControlsActions m_DragonControlsActionsCallbackInterface;
    private readonly InputAction m_DragonControls_LeftWingHold;
    private readonly InputAction m_DragonControls_RightWingHold;
    private readonly InputAction m_DragonControls_Look;
    private readonly InputAction m_DragonControls_Turn;
    private readonly InputAction m_DragonControls_ZMove;
    private readonly InputAction m_DragonControls_Dismount;
    private readonly InputAction m_DragonControls_Boost;
    public struct DragonControlsActions
    {
        private @PlayerControls m_Wrapper;
        public DragonControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftWingHold => m_Wrapper.m_DragonControls_LeftWingHold;
        public InputAction @RightWingHold => m_Wrapper.m_DragonControls_RightWingHold;
        public InputAction @Look => m_Wrapper.m_DragonControls_Look;
        public InputAction @Turn => m_Wrapper.m_DragonControls_Turn;
        public InputAction @ZMove => m_Wrapper.m_DragonControls_ZMove;
        public InputAction @Dismount => m_Wrapper.m_DragonControls_Dismount;
        public InputAction @Boost => m_Wrapper.m_DragonControls_Boost;
        public InputActionMap Get() { return m_Wrapper.m_DragonControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DragonControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDragonControlsActions instance)
        {
            if (m_Wrapper.m_DragonControlsActionsCallbackInterface != null)
            {
                @LeftWingHold.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnLeftWingHold;
                @LeftWingHold.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnLeftWingHold;
                @LeftWingHold.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnLeftWingHold;
                @RightWingHold.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnRightWingHold;
                @RightWingHold.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnRightWingHold;
                @RightWingHold.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnRightWingHold;
                @Look.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnLook;
                @Turn.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnTurn;
                @ZMove.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnZMove;
                @ZMove.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnZMove;
                @ZMove.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnZMove;
                @Dismount.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnDismount;
                @Dismount.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnDismount;
                @Dismount.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnDismount;
                @Boost.started -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_DragonControlsActionsCallbackInterface.OnBoost;
            }
            m_Wrapper.m_DragonControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftWingHold.started += instance.OnLeftWingHold;
                @LeftWingHold.performed += instance.OnLeftWingHold;
                @LeftWingHold.canceled += instance.OnLeftWingHold;
                @RightWingHold.started += instance.OnRightWingHold;
                @RightWingHold.performed += instance.OnRightWingHold;
                @RightWingHold.canceled += instance.OnRightWingHold;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @ZMove.started += instance.OnZMove;
                @ZMove.performed += instance.OnZMove;
                @ZMove.canceled += instance.OnZMove;
                @Dismount.started += instance.OnDismount;
                @Dismount.performed += instance.OnDismount;
                @Dismount.canceled += instance.OnDismount;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
            }
        }
    }
    public DragonControlsActions @DragonControls => new DragonControlsActions(this);
    public interface ICharacterControlActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
        void OnTargetCamera(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnHeal(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnPutAway(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEvade(InputAction.CallbackContext context);
        void OnComment(InputAction.CallbackContext context);
    }
    public interface IMenuControlActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
    public interface IDragonControlsActions
    {
        void OnLeftWingHold(InputAction.CallbackContext context);
        void OnRightWingHold(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnZMove(InputAction.CallbackContext context);
        void OnDismount(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
    }
}
