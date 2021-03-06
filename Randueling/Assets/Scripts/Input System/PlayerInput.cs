// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input System/PlayerInput.inputactions'

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
            ""name"": ""PlayerKBM"",
            ""id"": ""cd2fb386-848a-40e3-82e1-344c84506f66"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""7bd0cba4-0e94-478d-9e33-dd85af0c4749"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WASD Movement"",
                    ""type"": ""Value"",
                    ""id"": ""50d7f48c-0365-4393-a205-da5999f72c04"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""023f869a-f697-43e8-829e-0431652b2c2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnObject"",
                    ""type"": ""Button"",
                    ""id"": ""1a613459-8ac9-44b0-859c-f99f33eec223"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Value"",
                    ""id"": ""082224f2-1a7f-427c-a66b-9c6d25bc2ba7"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuSpace"",
                    ""type"": ""Button"",
                    ""id"": ""33a38a40-a583-42c5-b451-960042314ad4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""18a91d39-e84c-49c2-8a0c-c554878b1b04"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""f1e03f60-8d74-4281-a09e-40edf99ae02f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ccaf8a9-a23c-46df-acc7-697a82f47fec"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""54eb4974-7728-4e05-9b6a-2a4127db9a50"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b9279948-c619-47c8-8212-4505c8a27341"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b39bfea7-572f-4942-9aba-fb95eafc2df7"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""461ea499-02bb-4723-8a4f-92bedea6bd7b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""889fcb0a-25a2-4a9f-bd57-3f0d52151551"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7eec6bba-eb8a-4a07-938f-d3a1b5d29068"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aa3f341f-9c16-4333-82cf-ee3433f28ce8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""325a70bb-01e0-45aa-b257-28d2697a1a60"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""0356cf38-10e1-4e06-bec5-845fa72b92d2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""49677b44-25d5-48a3-8b16-10228339b841"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""13cef8a1-c099-4eb5-b895-ba3ecf57be08"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f51d4b3f-7716-45d0-a276-030d5a41dbfe"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a84d1b66-3494-404a-b46e-8d655f2bf33d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6b7283b9-d885-4344-b75e-32cf95d86088"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d1ca501-793e-46ad-b46e-03fff22c6e77"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""278a48b2-1e6f-4a6d-a64d-0b334fe2ea55"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54eccf8e-de6f-4867-8d75-3cedcc71cffa"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""070abca8-e02b-4cf8-bbbf-a9393717171e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""472e8e80-e407-4dc0-8175-e244c4a2d87d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MenuSpace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69cc7111-4ae5-47ac-9ca2-a5cb76813c5b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""MenuSpace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerController"",
            ""id"": ""723fcef9-4483-451c-a86a-1374e3d96e7a"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""fae508f0-b723-4d4f-a5e9-eaad2717c5e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WASD Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1d0e594f-5f16-4a7e-af88-cf59ec3d988b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""e0c80406-1156-4f77-be26-1e9dc385d5c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnObject"",
                    ""type"": ""Button"",
                    ""id"": ""5e6e2ab7-4d42-4183-8ab2-5cebe2037017"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06427273-10e1-4055-9cdf-aaa9318011bf"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""74a8fcd0-7fe6-4672-b711-79a05897672a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6cabe177-0baa-4d59-b07a-05ba9f2eb82c"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3c4c915-363e-49ec-b568-b56f2c619a49"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0732101c-a5ad-4f22-9b65-ac48454985a3"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""45e35e67-c1f7-4cc9-9d9f-ba8ba825c4a1"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cd19a7fa-a968-4ae2-a97a-14e7c405d1c9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4f3b8663-87dd-4ae1-8a53-c89c22acee00"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9deea442-80d9-4625-abb0-80b21ad02160"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f3b96e6-21f8-45a6-8517-3c0a345e66f4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""746e1fe9-ce60-4246-96a3-28175963673a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""ecd10d92-858c-4eaf-b320-0665c5239b98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f62bf791-a05d-4d26-b7bb-2490f3f7cb73"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""738b11b4-1e12-4db2-b7cc-b7a20a6d4ab6"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""54fc2e68-9324-4670-b4c4-88fc591a8c83"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c42d5fcf-bd94-4e22-8470-9a609833e885"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1623059d-cfb9-4f52-b52e-7e4ab38e0412"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e1637f9-275c-4a80-b63b-51108b234ad1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e825bd53-98c4-4853-a994-9bd68f4a8dbf"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
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
        // PlayerKBM
        m_PlayerKBM = asset.FindActionMap("PlayerKBM", throwIfNotFound: true);
        m_PlayerKBM_Mouse = m_PlayerKBM.FindAction("Mouse", throwIfNotFound: true);
        m_PlayerKBM_WASDMovement = m_PlayerKBM.FindAction("WASD Movement", throwIfNotFound: true);
        m_PlayerKBM_Fire = m_PlayerKBM.FindAction("Fire", throwIfNotFound: true);
        m_PlayerKBM_SpawnObject = m_PlayerKBM.FindAction("SpawnObject", throwIfNotFound: true);
        m_PlayerKBM_StartGame = m_PlayerKBM.FindAction("StartGame", throwIfNotFound: true);
        m_PlayerKBM_MenuSpace = m_PlayerKBM.FindAction("MenuSpace", throwIfNotFound: true);
        // PlayerController
        m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
        m_PlayerController_Mouse = m_PlayerController.FindAction("Mouse", throwIfNotFound: true);
        m_PlayerController_WASDMovement = m_PlayerController.FindAction("WASD Movement", throwIfNotFound: true);
        m_PlayerController_Fire = m_PlayerController.FindAction("Fire", throwIfNotFound: true);
        m_PlayerController_SpawnObject = m_PlayerController.FindAction("SpawnObject", throwIfNotFound: true);
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

    // PlayerKBM
    private readonly InputActionMap m_PlayerKBM;
    private IPlayerKBMActions m_PlayerKBMActionsCallbackInterface;
    private readonly InputAction m_PlayerKBM_Mouse;
    private readonly InputAction m_PlayerKBM_WASDMovement;
    private readonly InputAction m_PlayerKBM_Fire;
    private readonly InputAction m_PlayerKBM_SpawnObject;
    private readonly InputAction m_PlayerKBM_StartGame;
    private readonly InputAction m_PlayerKBM_MenuSpace;
    public struct PlayerKBMActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerKBMActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_PlayerKBM_Mouse;
        public InputAction @WASDMovement => m_Wrapper.m_PlayerKBM_WASDMovement;
        public InputAction @Fire => m_Wrapper.m_PlayerKBM_Fire;
        public InputAction @SpawnObject => m_Wrapper.m_PlayerKBM_SpawnObject;
        public InputAction @StartGame => m_Wrapper.m_PlayerKBM_StartGame;
        public InputAction @MenuSpace => m_Wrapper.m_PlayerKBM_MenuSpace;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKBM; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKBMActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerKBMActions instance)
        {
            if (m_Wrapper.m_PlayerKBMActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnMouse;
                @WASDMovement.started -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnWASDMovement;
                @WASDMovement.performed -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnWASDMovement;
                @WASDMovement.canceled -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnWASDMovement;
                @Fire.started -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnFire;
                @SpawnObject.started -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnSpawnObject;
                @SpawnObject.performed -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnSpawnObject;
                @SpawnObject.canceled -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnSpawnObject;
                @StartGame.started -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnStartGame;
                @MenuSpace.started -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnMenuSpace;
                @MenuSpace.performed -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnMenuSpace;
                @MenuSpace.canceled -= m_Wrapper.m_PlayerKBMActionsCallbackInterface.OnMenuSpace;
            }
            m_Wrapper.m_PlayerKBMActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @WASDMovement.started += instance.OnWASDMovement;
                @WASDMovement.performed += instance.OnWASDMovement;
                @WASDMovement.canceled += instance.OnWASDMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @SpawnObject.started += instance.OnSpawnObject;
                @SpawnObject.performed += instance.OnSpawnObject;
                @SpawnObject.canceled += instance.OnSpawnObject;
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
                @MenuSpace.started += instance.OnMenuSpace;
                @MenuSpace.performed += instance.OnMenuSpace;
                @MenuSpace.canceled += instance.OnMenuSpace;
            }
        }
    }
    public PlayerKBMActions @PlayerKBM => new PlayerKBMActions(this);

    // PlayerController
    private readonly InputActionMap m_PlayerController;
    private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
    private readonly InputAction m_PlayerController_Mouse;
    private readonly InputAction m_PlayerController_WASDMovement;
    private readonly InputAction m_PlayerController_Fire;
    private readonly InputAction m_PlayerController_SpawnObject;
    public struct PlayerControllerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_PlayerController_Mouse;
        public InputAction @WASDMovement => m_Wrapper.m_PlayerController_WASDMovement;
        public InputAction @Fire => m_Wrapper.m_PlayerController_Fire;
        public InputAction @SpawnObject => m_Wrapper.m_PlayerController_SpawnObject;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMouse;
                @WASDMovement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnWASDMovement;
                @WASDMovement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnWASDMovement;
                @WASDMovement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnWASDMovement;
                @Fire.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @SpawnObject.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnSpawnObject;
                @SpawnObject.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnSpawnObject;
                @SpawnObject.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnSpawnObject;
            }
            m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @WASDMovement.started += instance.OnWASDMovement;
                @WASDMovement.performed += instance.OnWASDMovement;
                @WASDMovement.canceled += instance.OnWASDMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @SpawnObject.started += instance.OnSpawnObject;
                @SpawnObject.performed += instance.OnSpawnObject;
                @SpawnObject.canceled += instance.OnSpawnObject;
            }
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IPlayerKBMActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnWASDMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSpawnObject(InputAction.CallbackContext context);
        void OnStartGame(InputAction.CallbackContext context);
        void OnMenuSpace(InputAction.CallbackContext context);
    }
    public interface IPlayerControllerActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnWASDMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSpawnObject(InputAction.CallbackContext context);
    }
}
