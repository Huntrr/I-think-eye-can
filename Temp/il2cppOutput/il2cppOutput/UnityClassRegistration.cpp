struct ClassRegistrationContext;
void InvokeRegisterStaticallyLinkedModuleClasses(ClassRegistrationContext& context)
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

}

void RegisterAllClasses()
{
	//Total: 70 classes
	//0. AssetBundle
	void RegisterClass_AssetBundle();
	RegisterClass_AssetBundle();

	//1. NamedObject
	void RegisterClass_NamedObject();
	RegisterClass_NamedObject();

	//2. EditorExtension
	void RegisterClass_EditorExtension();
	RegisterClass_EditorExtension();

	//3. QualitySettings
	void RegisterClass_QualitySettings();
	RegisterClass_QualitySettings();

	//4. GlobalGameManager
	void RegisterClass_GlobalGameManager();
	RegisterClass_GlobalGameManager();

	//5. GameManager
	void RegisterClass_GameManager();
	RegisterClass_GameManager();

	//6. MeshFilter
	void RegisterClass_MeshFilter();
	RegisterClass_MeshFilter();

	//7. Component
	void RegisterClass_Component();
	RegisterClass_Component();

	//8. Mesh
	void RegisterClass_Mesh();
	RegisterClass_Mesh();

	//9. Renderer
	void RegisterClass_Renderer();
	RegisterClass_Renderer();

	//10. Skybox
	void RegisterClass_Skybox();
	RegisterClass_Skybox();

	//11. Behaviour
	void RegisterClass_Behaviour();
	RegisterClass_Behaviour();

	//12. GUILayer
	void RegisterClass_GUILayer();
	RegisterClass_GUILayer();

	//13. Texture
	void RegisterClass_Texture();
	RegisterClass_Texture();

	//14. Texture2D
	void RegisterClass_Texture2D();
	RegisterClass_Texture2D();

	//15. RenderTexture
	void RegisterClass_RenderTexture();
	RegisterClass_RenderTexture();

	//16. NetworkView
	void RegisterClass_NetworkView();
	RegisterClass_NetworkView();

	//17. RectTransform
	void RegisterClass_RectTransform();
	RegisterClass_RectTransform();

	//18. Transform
	void RegisterClass_Transform();
	RegisterClass_Transform();

	//19. Shader
	void RegisterClass_Shader();
	RegisterClass_Shader();

	//20. TextAsset
	void RegisterClass_TextAsset();
	RegisterClass_TextAsset();

	//21. Material
	void RegisterClass_Material();
	RegisterClass_Material();

	//22. Sprite
	void RegisterClass_Sprite();
	RegisterClass_Sprite();

	//23. Camera
	void RegisterClass_Camera();
	RegisterClass_Camera();

	//24. MonoBehaviour
	void RegisterClass_MonoBehaviour();
	RegisterClass_MonoBehaviour();

	//25. GameObject
	void RegisterClass_GameObject();
	RegisterClass_GameObject();

	//26. Collider
	void RegisterClass_Collider();
	RegisterClass_Collider();

	//27. MeshCollider
	void RegisterClass_MeshCollider();
	RegisterClass_MeshCollider();

	//28. Collider2D
	void RegisterClass_Collider2D();
	RegisterClass_Collider2D();

	//29. AudioClip
	void RegisterClass_AudioClip();
	RegisterClass_AudioClip();

	//30. SampleClip
	void RegisterClass_SampleClip();
	RegisterClass_SampleClip();

	//31. AudioSource
	void RegisterClass_AudioSource();
	RegisterClass_AudioSource();

	//32. AudioBehaviour
	void RegisterClass_AudioBehaviour();
	RegisterClass_AudioBehaviour();

	//33. WebCamTexture
	void RegisterClass_WebCamTexture();
	RegisterClass_WebCamTexture();

	//34. Animator
	void RegisterClass_Animator();
	RegisterClass_Animator();

	//35. DirectorPlayer
	void RegisterClass_DirectorPlayer();
	RegisterClass_DirectorPlayer();

	//36. Font
	void RegisterClass_Font();
	RegisterClass_Font();

	//37. Canvas
	void RegisterClass_Canvas();
	RegisterClass_Canvas();

	//38. CanvasGroup
	void RegisterClass_CanvasGroup();
	RegisterClass_CanvasGroup();

	//39. CanvasRenderer
	void RegisterClass_CanvasRenderer();
	RegisterClass_CanvasRenderer();

	//40. MeshRenderer
	void RegisterClass_MeshRenderer();
	RegisterClass_MeshRenderer();

	//41. SpriteRenderer
	void RegisterClass_SpriteRenderer();
	RegisterClass_SpriteRenderer();

	//42. RuntimeAnimatorController
	void RegisterClass_RuntimeAnimatorController();
	RegisterClass_RuntimeAnimatorController();

	//43. BoxCollider
	void RegisterClass_BoxCollider();
	RegisterClass_BoxCollider();

	//44. PreloadData
	void RegisterClass_PreloadData();
	RegisterClass_PreloadData();

	//45. Cubemap
	void RegisterClass_Cubemap();
	RegisterClass_Cubemap();

	//46. Texture3D
	void RegisterClass_Texture3D();
	RegisterClass_Texture3D();

	//47. LevelGameManager
	void RegisterClass_LevelGameManager();
	RegisterClass_LevelGameManager();

	//48. TimeManager
	void RegisterClass_TimeManager();
	RegisterClass_TimeManager();

	//49. AudioManager
	void RegisterClass_AudioManager();
	RegisterClass_AudioManager();

	//50. InputManager
	void RegisterClass_InputManager();
	RegisterClass_InputManager();

	//51. Physics2DSettings
	void RegisterClass_Physics2DSettings();
	RegisterClass_Physics2DSettings();

	//52. GraphicsSettings
	void RegisterClass_GraphicsSettings();
	RegisterClass_GraphicsSettings();

	//53. PhysicsManager
	void RegisterClass_PhysicsManager();
	RegisterClass_PhysicsManager();

	//54. TagManager
	void RegisterClass_TagManager();
	RegisterClass_TagManager();

	//55. AudioListener
	void RegisterClass_AudioListener();
	RegisterClass_AudioListener();

	//56. ScriptMapper
	void RegisterClass_ScriptMapper();
	RegisterClass_ScriptMapper();

	//57. DelayedCallManager
	void RegisterClass_DelayedCallManager();
	RegisterClass_DelayedCallManager();

	//58. RenderSettings
	void RegisterClass_RenderSettings();
	RegisterClass_RenderSettings();

	//59. Light
	void RegisterClass_Light();
	RegisterClass_Light();

	//60. MonoScript
	void RegisterClass_MonoScript();
	RegisterClass_MonoScript();

	//61. MonoManager
	void RegisterClass_MonoManager();
	RegisterClass_MonoManager();

	//62. FlareLayer
	void RegisterClass_FlareLayer();
	RegisterClass_FlareLayer();

	//63. PlayerSettings
	void RegisterClass_PlayerSettings();
	RegisterClass_PlayerSettings();

	//64. BuildSettings
	void RegisterClass_BuildSettings();
	RegisterClass_BuildSettings();

	//65. ResourceManager
	void RegisterClass_ResourceManager();
	RegisterClass_ResourceManager();

	//66. NetworkManager
	void RegisterClass_NetworkManager();
	RegisterClass_NetworkManager();

	//67. MasterServerInterface
	void RegisterClass_MasterServerInterface();
	RegisterClass_MasterServerInterface();

	//68. LightmapSettings
	void RegisterClass_LightmapSettings();
	RegisterClass_LightmapSettings();

	//69. RuntimeInitializeOnLoadManager
	void RegisterClass_RuntimeInitializeOnLoadManager();
	RegisterClass_RuntimeInitializeOnLoadManager();

}
