using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class ChangeAvatar : MonoBehaviour
{
    public GameObject realtimeAvatar;
    //public GameObject targetAvatar;
    public List<GameObject> avatars = new List<GameObject>();
    private RealtimeAvatarManager avatarManager;
    private GameObject avatarInstance;
    // private GameObject currentAvatar;

    void Start(){
        int selectedAvatarNumber = PlayerPrefs.GetInt("SelectedAvatar", 0);
        GameObject targetAvatar = avatars[selectedAvatarNumber];
        avatarManager = realtimeAvatar.GetComponent<RealtimeAvatarManager>();
        // avatarInstance = Instantiate(Resources.Load("DemoAvatar",typeof(GameObject))) as GameObject;
        avatarManager.localAvatarPrefab = targetAvatar;
    }
    
    // void OnMouseDown()
    // {
        // GameObject avatarInstance = Instantiate(Resources.Load("DemoAvatar",typeof(GameObject))) as GameObject;
        // avatarManager.localAvatarPrefab = avatarInstance;

        // avatarManager.localAvatarPrefab = Instantiate(Resources.Load("AvatarDemo"));
        // GameObject currentAvatar = avatarManager.localAvatarPrefab;
        // avatarManager._UnregisterAvatar(avatarManager.localAvatarPrefab.GetComponent<RealtimeAvatar>());
        // currentAvatar.SetActive(false);
        // avatarManager.DestroyAvatarIfNeeded();
        // avatarManager.CreateAvatarIfNeeded();
        // avatarManager.localAvatarPrefab = targetAvatar;
        // avatarManager.DestroyAvatarIfNeeded();
        // avatarManager.CreateAvatarIfNeeded();
        

    //}

}
