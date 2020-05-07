### Unity3D的Attribute

1. RuntimeInitializeOnLoadMethodAttribute

   生命周期：在lnitialization时期Start()前运行该函数

   额外属性：`RuntimeInitializeLoadType.BeforeSceneLoad | RuntimeInitializeLoadType.AfterSceneLoad`
`RuntimeInitializeLoadType.BeforeSceneLoad`:在Awake前
   
   `RuntimeInitializeLoadType.AfterSceneLoad`:在Start()前