//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/_Scripts/Core/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Human"",
            ""id"": ""92d7722e-5798-47a3-80f7-e37a50109a57"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2151dfdd-79d9-44a0-a3aa-fd347ef1ed10"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""6f50175d-25c6-4990-b650-93e060530aa1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b6c5bd56-d21b-4e9d-b8ec-a15562d95792"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c5382d50-bee7-468a-86b1-8cd58fe39b1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""cdf78856-d4d3-4445-81d3-05d79e6dffeb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a6d6663c-a604-4976-a42b-b81b92a0b902"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f2f7a427-6f5b-4b18-ad6e-d815d154fbed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""43a39334-ea15-421a-ae7e-99cfdc1fbb37"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a5028bd8-f482-4f92-8c80-9f1bc178d0b8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""19e485d0-d441-428b-9779-ff8c908f32d1"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c564a714-3b46-456d-86e0-a969bb4c5759"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd75de55-5c58-42de-a347-1194c7084dc5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77107051-d90d-4588-bc77-e5c7c0c99343"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b46b2d9e-d3fb-4152-a3be-323092570fec"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""61ce7721-8500-46ea-866f-72ea5165b2c4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a27cf67e-5002-491c-8b18-ac2ee06e26d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""d029f2d7-925d-4427-9c97-71412cfe88d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""bfad2566-cb61-4ca1-a279-8545895c74d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""cd54c5f1-4aef-4e57-8278-a3a75ecec40e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7d3c1cd2-cad2-451a-adbb-cc3f0d07083b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""79b8ba8a-ce14-479c-98e6-3c9051af5428"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2085c8f3-916f-4f95-888a-db1dc95924d0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d40eb07e-41d1-4751-ba62-4bfb922988c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""87665f34-b3fc-4ca9-a6fe-06205846ec5d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""51dbb939-19d4-46e3-b690-3763c93c0095"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d2f82c1-003e-4a2b-bfb6-db1876280be9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de0ddd8e-c89b-419c-ba99-4e7d12de4161"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""System"",
            ""id"": ""a7ede3bb-ed93-4225-bb0c-057a616f045d"",
            ""actions"": [
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""24dc9355-910b-4711-a41b-ad5d17faf80f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""921505f6-d00e-4d89-9c08-14ae36d92427"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
        }
    ]
}");
        // Human
        m_Human = asset.FindActionMap("Human", throwIfNotFound: true);
        m_Human_Movement = m_Human.FindAction("Movement", throwIfNotFound: true);
        m_Human_SwitchCharacter = m_Human.FindAction("SwitchCharacter", throwIfNotFound: true);
        m_Human_Jump = m_Human.FindAction("Jump", throwIfNotFound: true);
        m_Human_Shoot = m_Human.FindAction("Shoot", throwIfNotFound: true);
        m_Human_MousePosition = m_Human.FindAction("MousePosition", throwIfNotFound: true);
        m_Human_Interact = m_Human.FindAction("Interact", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Movement = m_Drone.FindAction("Movement", throwIfNotFound: true);
        m_Drone_SwitchCharacter = m_Drone.FindAction("SwitchCharacter", throwIfNotFound: true);
        m_Drone_Grab = m_Drone.FindAction("Grab", throwIfNotFound: true);
        m_Drone_Release = m_Drone.FindAction("Release", throwIfNotFound: true);
        // System
        m_System = asset.FindActionMap("System", throwIfNotFound: true);
        m_System_Restart = m_System.FindAction("Restart", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Human
    private readonly InputActionMap m_Human;
    private IHumanActions m_HumanActionsCallbackInterface;
    private readonly InputAction m_Human_Movement;
    private readonly InputAction m_Human_SwitchCharacter;
    private readonly InputAction m_Human_Jump;
    private readonly InputAction m_Human_Shoot;
    private readonly InputAction m_Human_MousePosition;
    private readonly InputAction m_Human_Interact;
    public struct HumanActions
    {
        private @Controls m_Wrapper;
        public HumanActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Human_Movement;
        public InputAction @SwitchCharacter => m_Wrapper.m_Human_SwitchCharacter;
        public InputAction @Jump => m_Wrapper.m_Human_Jump;
        public InputAction @Shoot => m_Wrapper.m_Human_Shoot;
        public InputAction @MousePosition => m_Wrapper.m_Human_MousePosition;
        public InputAction @Interact => m_Wrapper.m_Human_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Human; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HumanActions set) { return set.Get(); }
        public void SetCallbacks(IHumanActions instance)
        {
            if (m_Wrapper.m_HumanActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_HumanActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_HumanActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_HumanActionsCallbackInterface.OnMovement;
                @SwitchCharacter.started -= m_Wrapper.m_HumanActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.performed -= m_Wrapper.m_HumanActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.canceled -= m_Wrapper.m_HumanActionsCallbackInterface.OnSwitchCharacter;
                @Jump.started -= m_Wrapper.m_HumanActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_HumanActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_HumanActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_HumanActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_HumanActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_HumanActionsCallbackInterface.OnShoot;
                @MousePosition.started -= m_Wrapper.m_HumanActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_HumanActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_HumanActionsCallbackInterface.OnMousePosition;
                @Interact.started -= m_Wrapper.m_HumanActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_HumanActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_HumanActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_HumanActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @SwitchCharacter.started += instance.OnSwitchCharacter;
                @SwitchCharacter.performed += instance.OnSwitchCharacter;
                @SwitchCharacter.canceled += instance.OnSwitchCharacter;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public HumanActions @Human => new HumanActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_Movement;
    private readonly InputAction m_Drone_SwitchCharacter;
    private readonly InputAction m_Drone_Grab;
    private readonly InputAction m_Drone_Release;
    public struct DroneActions
    {
        private @Controls m_Wrapper;
        public DroneActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Drone_Movement;
        public InputAction @SwitchCharacter => m_Wrapper.m_Drone_SwitchCharacter;
        public InputAction @Grab => m_Wrapper.m_Drone_Grab;
        public InputAction @Release => m_Wrapper.m_Drone_Release;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @SwitchCharacter.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnSwitchCharacter;
                @Grab.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnGrab;
                @Release.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRelease;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @SwitchCharacter.started += instance.OnSwitchCharacter;
                @SwitchCharacter.performed += instance.OnSwitchCharacter;
                @SwitchCharacter.canceled += instance.OnSwitchCharacter;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // System
    private readonly InputActionMap m_System;
    private ISystemActions m_SystemActionsCallbackInterface;
    private readonly InputAction m_System_Restart;
    public struct SystemActions
    {
        private @Controls m_Wrapper;
        public SystemActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Restart => m_Wrapper.m_System_Restart;
        public InputActionMap Get() { return m_Wrapper.m_System; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SystemActions set) { return set.Get(); }
        public void SetCallbacks(ISystemActions instance)
        {
            if (m_Wrapper.m_SystemActionsCallbackInterface != null)
            {
                @Restart.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_SystemActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public SystemActions @System => new SystemActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IHumanActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSwitchCharacter(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSwitchCharacter(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
    }
    public interface ISystemActions
    {
        void OnRestart(InputAction.CallbackContext context);
    }
}
