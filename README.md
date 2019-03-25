# Unity_ObjectCountChecker

<img src="https://github.com/XJINE/Unity_ObjectCountChecker/blob/master/Screenshot.png" width="100%" height="auto" />

Simply gets some object counts in current scene.
One of the usages is to find object base memory leak.

## Import to Your Project

You can import this asset from UnityPackage.

- [ObjectCountChecker.unitypackage](https://github.com/XJINE/Unity_ObjectCountChecker/blob/master/ObjectCountChecker.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [Unity_SingletonMonoBehaviour](https://github.com/XJINE/Unity_SingletonMonoBehaviour)
- [Unity_DisableInInspectorAttribute](https://github.com/XJINE/Unity_DisableInInspectorAttribute)

## How to Use

You can access object count like ``ObjectCountChecker.Instance.ObjectCount``.
And, Following count parameters are available.

- Object (all of object)
- Texture
- AudioClip
- Mesh
- Material
- GameObject
- Component