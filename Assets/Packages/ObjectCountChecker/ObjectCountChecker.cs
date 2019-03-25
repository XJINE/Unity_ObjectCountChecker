using UnityEngine;

public class ObjectCountChecker : SingletonMonoBehaviour<ObjectCountChecker>
{
    #region Field

    public  float updateIntervalTimeSec = 1f;
    private float previousUpdateTimeSec;
    
    [SerializeField, DisableInInspector]
    private int objectCount;
    [SerializeField, DisableInInspector]
    private int objectCountMax;
    [SerializeField, DisableInInspector]
    private int textureCount;
    [SerializeField, DisableInInspector]
    private int textureCountMax;
    [SerializeField, DisableInInspector]
    private int audioClipCount;
    [SerializeField, DisableInInspector]
    private int audioClipCountMax;
    [SerializeField, DisableInInspector]
    private int meshCount;
    [SerializeField, DisableInInspector]
    private int meshCountMax;
    [SerializeField, DisableInInspector]
    private int materialCount;
    [SerializeField, DisableInInspector]
    private int materialCountMax;
    [SerializeField, DisableInInspector]
    private int gameObjectCount;
    [SerializeField, DisableInInspector]
    private int gameObjectCountMax;
    [SerializeField, DisableInInspector]
    private int componentCount;
    [SerializeField, DisableInInspector]
    private int componentCountMax;

    #endregion Field

    #region Property

    public int ObjectCount        { get { return this.objectCount;} }
    public int ObjectCountMax     { get { return this.objectCountMax; } }
    public int TextureCount       { get { return this.textureCount;} }
    public int TextureCountMax    { get { return this.textureCountMax; } }
    public int AudioClipCount     { get { return this.audioClipCount;} }
    public int AudioClipCountMax  { get { return this.audioClipCountMax; } }
    public int MeshCount          { get { return this.meshCount;} }
    public int MeshCountMax       { get { return this.meshCountMax; } }
    public int MaterialCount      { get { return this.materialCount;} }
    public int MaterialCountMax   { get { return this.materialCountMax; } }
    public int GameObjectCount    { get { return this.gameObjectCount;} }
    public int GameObjectCountMax { get { return this.gameObjectCountMax; } }
    public int ComponentCount     { get { return this.componentCount;} }
    public int ComponentCountMax  { get { return this.componentCountMax;} }

    #endregion Property

    #region Method

    public void LateUpdate()
    {
        // NOTE:
        // Update() is called twice in sometimes, so this should use LateUpdate().

        if (Time.timeSinceLevelLoad - this.previousUpdateTimeSec < this.updateIntervalTimeSec)
        {
            return;
        }

        this.previousUpdateTimeSec = Time.timeSinceLevelLoad;

        this.objectCount        = Resources.FindObjectsOfTypeAll(typeof(UnityEngine.Object)).Length;
        this.objectCountMax     = Mathf.Max(this.ObjectCount, this.ObjectCountMax);
        this.textureCount       = Resources.FindObjectsOfTypeAll(typeof(Texture)).Length;
        this.textureCountMax    = Mathf.Max(this.TextureCount, this.TextureCountMax);
        this.audioClipCount     = Resources.FindObjectsOfTypeAll(typeof(AudioClip)).Length;
        this.audioClipCountMax  = Mathf.Max(this.AudioClipCount, this.AudioClipCountMax);
        this.meshCount          = Resources.FindObjectsOfTypeAll(typeof(Mesh)).Length;
        this.meshCountMax       = Mathf.Max(this.MeshCount, this.MeshCountMax);
        this.materialCount      = Resources.FindObjectsOfTypeAll(typeof(Material)).Length;
        this.materialCountMax   = Mathf.Max(this.MaterialCount, this.MaterialCountMax);
        this.gameObjectCount    = Resources.FindObjectsOfTypeAll(typeof(GameObject)).Length;
        this.gameObjectCountMax = Mathf.Max(this.GameObjectCount, this.GameObjectCountMax);
        this.componentCount     = Resources.FindObjectsOfTypeAll(typeof(Component)).Length;
        this.componentCountMax  = Mathf.Max(this.ComponentCount, this.ComponentCountMax);
    }

    #endregion Method
}