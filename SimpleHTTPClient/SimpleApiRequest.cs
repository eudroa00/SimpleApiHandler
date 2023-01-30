using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Newtonsoft.Json;


public class ApiRequester : MonoBehaviour
{
    [ContextMenu("Get")]
    public async void RequestSubmiter()
    {
        var url = "http://localhost:5000/api/contracts/showAll";

        using var www = UnityWebRequest.Get(url); //Instantiate a Get Request and store it in www variable
        www.SetRequestHeader("Content-Type", "application/json");
        var webRequest = www.SendWebRequest(); //Execute the web request

        while (!webRequest.isDone)
            await Task.Yield();

        var jsonResponse = www.downloadHandler.text; //Retrieve JSON response as a string.

        if (www.result != UnityWebRequest.Result.Success)
            Debug.LogError($"Failed: {www.error}");
        else 

            try
            {
                var result = JsonConvert.DeserializeObject<List<contractData>>(jsonResponse); // JSON to c#
                Debug.Log("Success.");
            }
            catch(Exception ex)
            {
                    Debug.LogError($"Could not parse response: {jsonResponse}. {ex.Message}");
            }
    }   
}
