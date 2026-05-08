using UnityEngine;

public class optionalsaves : MonoBehaviour
{
    public static optionalsaves Instance { get; private set; }
    public static GameObject SavePoint;
    public static float SFXVolumes;
    public static float VoiceVolumes;
    public static float MusicVolumes;
    public static float MasterVolumes;
    public static bool ISFullscreens;
    public static bool CC;
    public static int SCREENResolutions;



    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        Object.DontDestroyOnLoad(this.gameObject);
    }
    public void Saves(ref PlayerSaveData data)
    {
        data.SFXVolumes = SFXVolumes;
        data.VoiceVolumes = VoiceVolumes;
        data.MusicVolumes = MusicVolumes;
        data.MasterVolumes = MasterVolumes;
        data.ISFullscreens = ISFullscreens;
        data.CC = CC;
        data.SCREENResolutions = SCREENResolutions;
    }
    
    public void loads(PlayerSaveData data)
    {
        SFXVolumes = data.SFXVolumes;
        VoiceVolumes = data.VoiceVolumes;
        MusicVolumes = data.MusicVolumes;
        MasterVolumes = data.MasterVolumes;
        ISFullscreens = data.ISFullscreens;
        CC = data.CC;
        SCREENResolutions = data.SCREENResolutions;
    }
    
}
[System.Serializable]
    public class PlayerSaveData
    {
        public float SFXVolumes;
        public float VoiceVolumes;
        public float MusicVolumes;
        public float MasterVolumes;
        public bool ISFullscreens;
        public bool CC;
        public int SCREENResolutions;
    }
    
