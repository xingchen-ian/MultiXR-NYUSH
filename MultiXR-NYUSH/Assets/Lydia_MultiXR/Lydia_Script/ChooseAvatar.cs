using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAvatar : MonoBehaviour
{
    
    private int selectedAvatarNumber;
    
    // Function to handle avatar selection and scene transition.
    public void SelectAvatar(int avatarNumber)
    {
        selectedAvatarNumber = avatarNumber;

        // Store the selected avatarNumber in PlayerPrefs.
        PlayerPrefs.SetInt("SelectedAvatar", selectedAvatarNumber);

        
        Debug.Log(PlayerPrefs.GetInt("SelectedAvatar", 0));
    }

    public void SwitchScene(){
        // Load the next scene. Replace "NextSceneName" with the actual name of your next scene.
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
