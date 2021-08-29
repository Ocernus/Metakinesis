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
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7bcca0e0-a479-41dd-87c3-ac78095c5f66"",
                    ""expectedControlType"": ""Vector2"",
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
                    ""name"": ""Item"",
                    ""type"": ""Button"",
                    ""id"": ""fe35991f-2705-4ab6-a472-58474a8a3376"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Spell"",
                    ""type"": ""Button"",
                    ""id"": ""5d34f92c-2248-4c5c-84e3-21976be1a55e"",
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
                    ""name"": ""Sword Slash"",
                    ""type"": ""Button"",
                    ""id"": ""6aa9a7be-9b78-49c4-84b9-80047da5c588"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ffc058c5-cee6-4416-971e-5c19df5e80a2"",
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
                    ""id"": ""51339f3b-eed4-4bc4-81f7-dc31e1fcdf96"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell"",
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
                    ""action"": ""Sword Slash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interactable Control"",
            ""id"": ""3f7737db-16c8-486f-ad33-42aa675cc90e"",
            ""actions"": [
                {
                    ""name"": ""Comment"",
                    ""type"": ""Button"",
                    ""id"": ""f660e4dc-df76-4f64-9ec5-3a98c71b3062"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""b0fe33f4-8d6f-434f-9374-c1da00d55e8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option A"",
                    ""type"": ""Button"",
                    ""id"": ""80216331-357f-497d-9ad5-35e1730c59a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option B"",
                    ""type"": ""Button"",
                    ""id"": ""e0c9cf90-c176-4560-9d7d-b181821ef74a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""77d8f24d-c65e-4aff-81f4-9230d2386d2c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Comment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d279c797-6f9e-4a4f-871f-29555a6e37fe"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5248b48f-d985-4856-a1b1-170f94c57478"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1499ab9-3b6e-4b9d-915e-762e23088ec7"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option B"",
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
        m_CharacterControl_Move = m_CharacterControl.FindAction("Move", throwIfNotFound: true);
        m_CharacterControl_Look = m_CharacterControl.FindAction("Look", throwIfNotFound: true);
        m_CharacterControl_Interact = m_CharacterControl.FindAction("Interact", throwIfNotFound: true);
        m_CharacterControl_Jump = m_CharacterControl.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControl_Item = m_CharacterControl.FindAction("Item", throwIfNotFound: true);
        m_CharacterControl_Spell = m_CharacterControl.FindAction("Spell", throwIfNotFound: true);
        m_CharacterControl_ResetCamera = m_CharacterControl.FindAction("Reset Camera", throwIfNotFound: true);
        m_CharacterControl_TargetCamera = m_CharacterControl.FindAction("Target Camera", throwIfNotFound: true);
        m_CharacterControl_SwordSlash = m_CharacterControl.FindAction("Sword Slash", throwIfNotFound: true);
        // Interactable Control
        m_InteractableControl = asset.FindActionMap("Interactable Control", throwIfNotFound: true);
        m_InteractableControl_Comment = m_InteractableControl.FindAction("Comment", throwIfNotFound: true);
        m_InteractableControl_Cancel = m_InteractableControl.FindAction("Cancel", throwIfNotFound: true);
        m_InteractableControl_OptionA = m_InteractableControl.FindAction("Option A", throwIfNotFound: true);
        m_InteractableControl_OptionB = m_InteractableControl.FindAction("Option B", throwIfNotFound: true);
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
    private readonly InputAction m_CharacterControl_Move;
    private readonly InputAction m_CharacterControl_Look;
    private readonly InputAction m_CharacterControl_Interact;
    private readonly InputAction m_CharacterControl_Jump;
    private readonly InputAction m_CharacterControl_Item;
    private readonly InputAction m_CharacterControl_Spell;
    private readonly InputAction m_CharacterControl_ResetCamera;
    private readonly InputAction m_CharacterControl_TargetCamera;
    private readonly InputAction m_CharacterControl_SwordSlash;
    public struct CharacterControlActions
    {
        private @PlayerControls m_Wrapper;
        public CharacterControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CharacterControl_Move;
        public InputAction @Look => m_Wrapper.m_CharacterControl_Look;
        public InputAction @Interact => m_Wrapper.m_CharacterControl_Interact;
        public InputAction @Jump => m_Wrapper.m_CharacterControl_Jump;
        public InputAction @Item => m_Wrapper.m_CharacterControl_Item;
        public InputAction @Spell => m_Wrapper.m_CharacterControl_Spell;
        public InputAction @ResetCamera => m_Wrapper.m_CharacterControl_ResetCamera;
        public InputAction @TargetCamera => m_Wrapper.m_CharacterControl_TargetCamera;
        public InputAction @SwordSlash => m_Wrapper.m_CharacterControl_SwordSlash;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlActions instance)
        {
            if (m_Wrapper.m_CharacterControlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnLook;
                @Interact.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnInteract;
                @Jump.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnJump;
                @Item.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Item.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Item.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnItem;
                @Spell.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSpell;
                @Spell.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSpell;
                @Spell.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSpell;
                @ResetCamera.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnResetCamera;
                @TargetCamera.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @TargetCamera.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @TargetCamera.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnTargetCamera;
                @SwordSlash.started -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSwordSlash;
                @SwordSlash.performed -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSwordSlash;
                @SwordSlash.canceled -= m_Wrapper.m_CharacterControlActionsCallbackInterface.OnSwordSlash;
            }
            m_Wrapper.m_CharacterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Item.started += instance.OnItem;
                @Item.performed += instance.OnItem;
                @Item.canceled += instance.OnItem;
                @Spell.started += instance.OnSpell;
                @Spell.performed += instance.OnSpell;
                @Spell.canceled += instance.OnSpell;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
                @TargetCamera.started += instance.OnTargetCamera;
                @TargetCamera.performed += instance.OnTargetCamera;
                @TargetCamera.canceled += instance.OnTargetCamera;
                @SwordSlash.started += instance.OnSwordSlash;
                @SwordSlash.performed += instance.OnSwordSlash;
                @SwordSlash.canceled += instance.OnSwordSlash;
            }
        }
    }
    public CharacterControlActions @CharacterControl => new CharacterControlActions(this);

    // Interactable Control
    private readonly InputActionMap m_InteractableControl;
    private IInteractableControlActions m_InteractableControlActionsCallbackInterface;
    private readonly InputAction m_InteractableControl_Comment;
    private readonly InputAction m_InteractableControl_Cancel;
    private readonly InputAction m_InteractableControl_OptionA;
    private readonly InputAction m_InteractableControl_OptionB;
    public struct InteractableControlActions
    {
        private @PlayerControls m_Wrapper;
        public InteractableControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Comment => m_Wrapper.m_InteractableControl_Comment;
        public InputAction @Cancel => m_Wrapper.m_InteractableControl_Cancel;
        public InputAction @OptionA => m_Wrapper.m_InteractableControl_OptionA;
        public InputAction @OptionB => m_Wrapper.m_InteractableControl_OptionB;
        public InputActionMap Get() { return m_Wrapper.m_InteractableControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractableControlActions set) { return set.Get(); }
        public void SetCallbacks(IInteractableControlActions instance)
        {
            if (m_Wrapper.m_InteractableControlActionsCallbackInterface != null)
            {
                @Comment.started -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnComment;
                @Comment.performed -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnComment;
                @Comment.canceled -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnComment;
                @Cancel.started -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnCancel;
                @OptionA.started -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnOptionA;
                @OptionA.performed -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnOptionA;
                @OptionA.canceled -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnOptionA;
                @OptionB.started -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnOptionB;
                @OptionB.performed -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnOptionB;
                @OptionB.canceled -= m_Wrapper.m_InteractableControlActionsCallbackInterface.OnOptionB;
            }
            m_Wrapper.m_InteractableControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Comment.started += instance.OnComment;
                @Comment.performed += instance.OnComment;
                @Comment.canceled += instance.OnComment;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @OptionA.started += instance.OnOptionA;
                @OptionA.performed += instance.OnOptionA;
                @OptionA.canceled += instance.OnOptionA;
                @OptionB.started += instance.OnOptionB;
                @OptionB.performed += instance.OnOptionB;
                @OptionB.canceled += instance.OnOptionB;
            }
        }
    }
    public InteractableControlActions @InteractableControl => new InteractableControlActions(this);
    public interface ICharacterControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
        void OnSpell(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
        void OnTargetCamera(InputAction.CallbackContext context);
        void OnSwordSlash(InputAction.CallbackContext context);
    }
    public interface IInteractableControlActions
    {
        void OnComment(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnOptionA(InputAction.CallbackContext context);
        void OnOptionB(InputAction.CallbackContext context);
    }
}
