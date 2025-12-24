using UnityEngine;

public class WeaponVisibility : MonoBehaviour
{
    // El arma que quieres mostrar/ocultar
    public GameObject weapon;

    // Para probar si el arma debe estar visible
    public bool isEquipped = false;

    void Update()
    {
        // Cambia la visibilidad del arma según esté equipada o no
        if (weapon != null)
        {
            weapon.SetActive(isEquipped);
        }
    }

    // Función para equipar el arma
    public void EquipWeapon()
    {
        isEquipped = true;
    }

    // Función para guardar el arma (ocultarla)
    public void UnequipWeapon()
    {
        isEquipped = false;
    }
}