using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public SkinnedMeshRenderer characterRenderer;
    public Material[] characterSkins;

    public Renderer weaponRenderer;
    public Material[] weaponSkins;

    // Cambiar skin de personaje
    public void SetCharacterSkin(int index)
    {
        if(index >= 0 && index < characterSkins.Length)
        {
            characterRenderer.material = characterSkins[index];
        }
    }

    // Cambiar skin de arma
    public void SetWeaponSkin(int index)
    {
        if(index >= 0 && index < weaponSkins.Length)
        {
            weaponRenderer.material = weaponSkins[index];
        }
    }
}