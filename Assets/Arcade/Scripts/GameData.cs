using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Clase nativa que interact�a con PlayerPrefs
//Utilizar cuando se quiera guardar informaci�n que persista entre escenas
public static class GameData
{
    public static string CurrentGameId;

    //M�todos est�ticos Set() guardan data de variables tipo int, string o float
    /* Llamar escribiendo: GameData.Set(id, value, addToValue)
     * id: nombre de la variable (sensible a may�sculas)
     * value: valor nuevo
     * addToValue: booleano que indica si el nuevo valor se suma al original(true) o lo reemplaza(false)
    */
    public static void Set(string id, int value, bool addToValue = false)
    {
        string fullId = $"{CurrentGameId}_{id}";
        PlayerPrefs.SetInt(id, addToValue? GetInt(id) + value: value);
    }
    public static void Set(string id, string value, bool addToValue = false)
    {
        string fullId = $"{CurrentGameId}_{id}";
        PlayerPrefs.SetString(id, addToValue? GetString(id) + value : value);
        }
    public static void Set(string id, float value, bool addToValue = false)
    {
        string fullId = $"{CurrentGameId}_{id}";
        PlayerPrefs.SetFloat(id, addToValue ? GetFloat(id) + value : value);
        }

    //Funciones est�ticas Get() cargan data de variables tipo int, string o float
    /* Llamar escribiendo: GameData.GetInt(id)
     * id: nombre de la variable (sensible a may�sculas)
    */
    public static int GetInt(string id)
    {
        id = $"{CurrentGameId}_{id}";
        int value = PlayerPrefs.GetInt(id);
        return value;
    }
    public static string GetString(string id)
        {
            id = $"{CurrentGameId}_{id}";
            string value = PlayerPrefs.GetString(id);
            return value;
        }
    public static float GetFloat(string id)
        {
            id = $"{CurrentGameId}_{id}";
            float value = PlayerPrefs.GetFloat(id);
            return value;
        }

    //M�todo est�tico que borra los datos de PlayerPrefs
    /*Llamar escribiendo: GameData.ResetValues(id1, id2, id3, idn...)
     * id: nombre de la variable guardada en PlayerPrefs (sensible a may�sculas)
     * Este m�todo puede llamarse con la cantidad de par�metros que se desee, s�lo deben estar separados por comas
     */
    public static void ResetValues(params string[] varsIds)
    {
        string fullId = "";

        foreach (string id in varsIds)
        {
            if (id == "Higshcore")
                continue;
            fullId = $"{CurrentGameId}_{id}";
            PlayerPrefs.DeleteKey(fullId);
        }
    }
}